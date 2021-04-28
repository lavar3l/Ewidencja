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
	public partial class EmployeeDetails : Form
	{
		private DatabaseConnector db;
		public Employee employeeDetails;
		string employeeID = "0"; // Ma znaczenie tylko przy edycji!
		string companyID = "0"; // Ma znaczenie tylko przy nowym rekordzie!

		public EmployeeDetails(DatabaseConnector db, bool addNew = true, Employee initialData = null, string initialCompanyName = null)
		{
			InitializeComponent();
			this.db = db;
			if (!addNew)
			{
				this.labelTitle.Text = "Edytuj dane pracownika";
				this.Text = "Edycja danych pracownika";
				acceptButton.Text = "Zapisz";
				companyComboBox.Enabled = false;
				companyComboBox.Text = initialCompanyName;
				companyID = initialData.companyID;
				employeeID = initialData.employeeID;
				nameTextBox.Text = initialData.employeeName;
				surnameTextBox.Text = initialData.employeeSurname;
				positionTextBox.Text = initialData.position;
				phoneTextBox.Text = initialData.phone;
				emailTextBox.Text = initialData.email;
			}
			else
			{
				UpdateCompaniesComboBox();
				companyComboBox_SelectedIndexChanged(null, null); // Aktualizacja po wczytaniu listy firm
			}
		}

		private void UpdateCompaniesComboBox()
		{
			this.db.UpdateCompaniesComboBox(companyComboBox, "Companies");
		}

		private void acceptButton_Click(object sender, EventArgs e)
		{
			employeeDetails = new Employee(employeeID, companyID, nameTextBox.Text, surnameTextBox.Text, positionTextBox.Text, phoneTextBox.Text, emailTextBox.Text);
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
			companyID = ((KeyValuePair<string, string>)companyComboBox.SelectedItem).Key;
			MessageBox.Show(companyID);
		}
	}
}
