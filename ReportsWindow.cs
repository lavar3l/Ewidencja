using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Ewidencja
{
	public partial class ReportsWindow : Form
	{
		DatabaseConnector db;
		string companyID;

		public ReportsWindow(DatabaseConnector dbConnector)
		{
			InitializeComponent();
			this.db = dbConnector;
			UpdateCompaniesComboBox();
			companyComboBox_SelectedIndexChanged(null, null); // Aktualizacja po wczytaniu listy firm
			companyComboBox.SelectedIndex = -1;
		}

		private void UpdateCompaniesComboBox()
		{
			this.db.UpdateCompaniesComboBox(companyComboBox, "Companies");
		}

		private void UpdateEmployeesComboBox(string companyID)
		{
			if(companyComboBox.SelectedIndex >= 0)
			{
				employeeComboBox.Enabled = true;
				this.db.UpdateEmployeesComboBox(employeeComboBox, "Employees", companyID);
				//employeeComboBox.Items.Add(new KeyValuePair<string, string>("All", "Wszyscy pracownicy"));
				employeeComboBox.SelectedIndex = -1;
			}
			else
			{
				employeeComboBox.Enabled = false;
				employeeComboBox.SelectedIndex = -1;
			}
		}

		private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			companyID = ((KeyValuePair<string, string>)companyComboBox.SelectedItem).Key;
			MessageBox.Show(companyID);
			UpdateEmployeesComboBox(companyID);
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			//this.db.UpdateListView(reportListView);
			GenerateReport();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			bool singleCompany = false;
			bool singleEmployee = false;
			string companyName = null;
			string employeeFullName = null;
			List<int> hideColumns = new List<int>() { 2, 3, 4 };
			if (companyComboBox.SelectedIndex >= 0)
			{
				singleCompany = true;
				hideColumns.Add(0);
				companyName = ((KeyValuePair<string, string>)companyComboBox.SelectedItem).Value;
			}
			if (employeeComboBox.SelectedIndex >= 0)
			{
				singleEmployee = true;
				hideColumns.Add(1);
				employeeFullName = ((KeyValuePair<string, string>)employeeComboBox.SelectedItem).Value;
			}
			SaveReportToPDF(singleCompany, singleEmployee, hideColumns, companyName, employeeFullName);
		}

		private void GenerateReport()
		{
			List<string> restrictions = new List<string>();

			// Wybór firmy
			if (companyComboBox.SelectedIndex >= 0) restrictions.Add($"companyID = '{((KeyValuePair<string, string>)companyComboBox.SelectedItem).Key}'");

			// Wybór pracownika
			if (employeeComboBox.SelectedIndex >= 0) restrictions.Add($"employeeID = '{((KeyValuePair<string, string>)employeeComboBox.SelectedItem).Key}'");

			// Data zakupu
			if (dateBeginCheckBox.Checked == true) restrictions.Add($"dateOfPurchase >= '{dateTimePickerBegin.Value.ToString("yyyy-MM-dd")}'");
			if (dateEndCheckBox.Checked == true) restrictions.Add($"dateOfPurchase <= '{dateTimePickerEnd.Value.ToString("yyyy-MM-dd")}'");

			// Procesor
			if (CPUTextBox.Text != String.Empty) restrictions.Add($"CPU LIKE '{CPUTextBox.Text}'");

			// Wielkość pamięci RAM
			if (RAMbeginTextBox.Text != String.Empty) restrictions.Add($"RAMsize >= '{RAMbeginTextBox.Text}'");
			if (RAMendTextBox.Text != String.Empty) restrictions.Add($"RAMsize <= '{RAMendTextBox.Text}'");

			// Wielkość dysku
			if (diskSizeBeginTextBox.Text != String.Empty) restrictions.Add($"DiskSize >= '{diskSizeBeginTextBox.Text}'");
			if (diskSizeEndTextBox.Text != String.Empty) restrictions.Add($"DiskSize <= '{diskSizeEndTextBox.Text}'");

			// Wymóg posiadania klucza Windows
			if (windowsCheckBox.Checked == true)
			{
				restrictions.Add($"windowsKey IS NOT NULL");
			}

			string sqlQuery = "SELECT * FROM ComputersView";
			if (restrictions.Count > 0) sqlQuery += " WHERE ";
			bool firstRestriction = true;
			foreach(var restriction in restrictions)
			{
				if (firstRestriction) firstRestriction = false;
				else sqlQuery += " AND ";
				sqlQuery += restriction;
			}
			
			sqlQuery += ";";
			MessageBox.Show(sqlQuery);
			this.db.GeneralSelectQuery(reportListView, sqlQuery);

			saveButton.Enabled = true;
		}

		private void SaveReportToPDF(bool singleCompany, bool singleEmployee, List<int> hideColumns, string companyName = null, string employeeFullName = null)
		{
			try
			{
				using (SaveFileDialog saveFileDialog = new SaveFileDialog())
				{
					saveFileDialog.Filter = "Plik PDF (*.pdf)|*.pdf";
					saveFileDialog.FilterIndex = 0;
					saveFileDialog.RestoreDirectory = true;

					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						// Tworzenie bazowego dokumentu
						PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write)));
						Document document = new Document(pdfDocument);

						// Przygotowanie nagłówków
						PdfFont fontHeader = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD, "Windows-1250");
						document.Add(new Paragraph("Raport ewidencji sprzętu komputerowego").SetFont(fontHeader).SetFontSize(24));

						PdfFont fontParagraph = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD, "Windows-1250");
						if (singleCompany) document.Add(new Paragraph($"Firma: {companyName}").SetFont(fontParagraph).SetFontSize(14));
						if (singleEmployee) document.Add(new Paragraph($"Odpowiedzialny pracownik: {employeeFullName}").SetFont(fontParagraph).SetFontSize(14));

						// Przygotowanie tabeli
						PdfFont fontText = PdfFontFactory.CreateFont(StandardFonts.HELVETICA, "Windows-1250");
						Table table = new Table(reportListView.Columns.Count - hideColumns.Count);
						for (int i = 0; i < reportListView.Columns.Count; i++)
						{
							if (!hideColumns.Contains(i)) table.AddHeaderCell(reportListView.Columns[i].Text).SetFont(fontText);
						}
						foreach (ListViewItem itemRow in reportListView.Items)
						{
							for (int i = 0; i < itemRow.SubItems.Count; i++)
							{
								if (!hideColumns.Contains(i)) table.AddCell(itemRow.SubItems[i].Text).SetFont(fontText);
							}
						}
						document.Add(table);

						// Zamknięcie dokumentu
						document.Close();
					}
				}
			}
			catch(Exception e)
			{
				MessageBox.Show("Zapis do pliku nie powiódł się!", "Błąd zapisu do pliku", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
