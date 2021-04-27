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
	public partial class CompanyDetails : Form
	{
		public Company companyDetails;
		string companyID = "0"; // Ma znaczenie tylko przy edycji!

		public CompanyDetails(bool addNew = true, Company initialData = null)
		{
			InitializeComponent();
			if(!addNew)
			{
				this.labelTitle.Text = "Edytuj dane firmy";
				this.Text = "Edycja danych firmy";
				acceptButton.Text = "Zapisz";
				companyID = initialData.companyID;
				nameTextBox.Text = initialData.companyName;
				NIPtextBox.Text = initialData.NIP;
				streetNameTextBox.Text = initialData.streetName;
				buildingNoTextBox.Text = initialData.buildingNo;
				postalCodeTextBox.Text = initialData.postalCode;
				cityTextBox.Text = initialData.city;
			}
		}

		private void acceptButton_Click(object sender, EventArgs e)
		{
			companyDetails = new Company(companyID, nameTextBox.Text, NIPtextBox.Text, streetNameTextBox.Text, buildingNoTextBox.Text, postalCodeTextBox.Text, cityTextBox.Text);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
