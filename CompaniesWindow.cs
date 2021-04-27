using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ewidencja
{
	public partial class CompaniesWindow : Form
	{
		DatabaseConnector db;

		public CompaniesWindow(DatabaseConnector dbConnector)
		{
			this.db = dbConnector;
			InitializeComponent();
			companiesListView.Columns[0].Width = 0;
			UpdateFormList();
		}

		private void UpdateFormList()
		{
			this.db.UpdateListView(companiesListView, "Companies");
		}

		private void refreshButton_Click(object sender, EventArgs e)
		{
			UpdateFormList();
		}

		private void companiesListView_ItemChecked(object sender, ItemCheckedEventArgs e)
		{

		}

		private void companiesListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(this.companiesListView.SelectedItems.Count > 0)
			{
				this.deleteButton.Enabled = true;
				this.editButton.Enabled = true;
			}
			else
			{
				this.deleteButton.Enabled = false;
				this.editButton.Enabled = false;
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			var SelectedItem = this.companiesListView.SelectedItems[0];
			DialogResult result = MessageBox.Show($"Czy napewno chcesz usunąć firmę {SelectedItem.SubItems[1].Text}?", "Usuwanie firmy", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if(result == DialogResult.Yes)
			{
				db.DeleteItem("Companies", SelectedItem.SubItems[0].Text, "companyID");
			}
			UpdateFormList();
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			var SelectedItem = this.companiesListView.SelectedItems[0];
			CompanyDetails form = new CompanyDetails(false, new Company(SelectedItem.SubItems[0].Text, SelectedItem.SubItems[1].Text, SelectedItem.SubItems[2].Text, SelectedItem.SubItems[3].Text, SelectedItem.SubItems[4].Text, SelectedItem.SubItems[5].Text, SelectedItem.SubItems[6].Text));
			form.ShowDialog();
			if(form.DialogResult == DialogResult.OK)
			{
				Company companyDetails = form.companyDetails;
				db.UpdateItem("Companies", companyDetails);
			}
			UpdateFormList();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			CompanyDetails form = new CompanyDetails(true);
			form.ShowDialog();
			if (form.DialogResult == DialogResult.OK)
			{
				Company companyDetails = form.companyDetails;
				db.AddItem("Companies", companyDetails);
			}
			UpdateFormList();
		}
	}
}
