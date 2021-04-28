using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
		}

	}
}
