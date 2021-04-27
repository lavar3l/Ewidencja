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
	public partial class ComputerDetails : Form
	{
		private DatabaseConnector db;
		public Computer computerDetails;
		string computerID = "0"; // Ma znaczenie tylko przy edycji!
		string employeeID = "0"; // Ma znaczenie tylko przy edycji!
		string companyID = "0"; // Ma znaczenie tylko przy nowym rekordzie!

		public ComputerDetails(DatabaseConnector db, bool addNew = true, Computer initialData = null)
		{
			InitializeComponent();
			this.db = db;
			if (!addNew)
			{
				this.labelTitle.Text = "Edytuj dane komputera";
				this.Text = "Edycja danych komputera";
				acceptButton.Text = "Zapisz";
				companyComboBox.Enabled = false;
				companyComboBox.Text = $"Firma o ID = {initialData.companyID}";
				employeeComboBox.Enabled = false;
				employeeComboBox.Text = $"Pracownik o ID = {initialData.employeeID}";
				computerID = initialData.computerID;
				companyID = initialData.companyID;
				employeeID = initialData.employeeID;
				dateTimePicker.Value = DateTime.Parse(initialData.dateOfPurchase);
				CPUTextBox.Text = initialData.CPU;
				RAMSizeTextBox.Text = initialData.ramSize;
				diskSizeTextBox.Text = initialData.diskSize;
				windowsKeyTextBox.Text = initialData.windowsKey;
			}
			else
			{
				UpdateCompaniesComboBox();
				companyComboBox_SelectedIndexChanged(null, null); // Aktualizacja po wczytaniu listy firm
				employeeComboBox_SelectedIndexChanged(null, null);
			}
		}

		private void UpdateCompaniesComboBox()
		{
			this.db.UpdateCompaniesComboBox(companyComboBox, "Companies");
		}

		private void UpdateEmployeesComboBox(string companyID)
		{
			this.db.UpdateEmployeesComboBox(employeeComboBox, "Employees", companyID);
		}

		private void acceptButton_Click(object sender, EventArgs e)
		{
			computerDetails = new Computer(computerID, companyID, employeeID, dateTimePicker.Value.ToString("yyyy-MM-dd"), CPUTextBox.Text, RAMSizeTextBox.Text, diskSizeTextBox.Text, windowsKeyTextBox.Text);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			companyID = companyComboBox.SelectedValue.ToString();
			MessageBox.Show(companyID);
			if(Int32.TryParse(companyID, out _)) UpdateEmployeesComboBox(companyID);
		}

		private void employeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			employeeID = employeeComboBox.SelectedValue.ToString();
			MessageBox.Show("Employee selected: " + employeeID.ToString());
		}
	}
}
