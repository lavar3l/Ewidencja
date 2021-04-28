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
	public partial class ComputersWindow : Form
	{
		DatabaseConnector db;

		public ComputersWindow(DatabaseConnector dbConnector)
		{
			this.db = dbConnector;
			InitializeComponent();
			computersListView.Columns[2].Width = 0;
			computersListView.Columns[3].Width = 0;
			UpdateFormList();
		}

		private void UpdateFormList()
		{
			this.db.UpdateListView(computersListView, "ComputersView");
		}

		private void refreshButton_Click(object sender, EventArgs e)
		{
			UpdateFormList();
		}

		private void computersListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.computersListView.SelectedItems.Count > 0)
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
			var SelectedItem = this.computersListView.SelectedItems[0];
			DialogResult result = MessageBox.Show($"Czy napewno chcesz usunąć wybrany komputer?", "Usuwanie komputera", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				db.DeleteItem("Computers", SelectedItem.SubItems[2].Text, "computerID");
			}
			UpdateFormList();
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			var SelectedItem = this.computersListView.SelectedItems[0];
			ComputerDetails form = new ComputerDetails(db, false, new Computer(SelectedItem.SubItems[2].Text, SelectedItem.SubItems[3].Text, SelectedItem.SubItems[4].Text, SelectedItem.SubItems[5].Text, SelectedItem.SubItems[6].Text, SelectedItem.SubItems[7].Text, SelectedItem.SubItems[8].Text, SelectedItem.SubItems[9].Text), SelectedItem.SubItems[0].Text, SelectedItem.SubItems[1].Text);
			MessageBox.Show($"!#! {SelectedItem.SubItems[4].Text}, {SelectedItem.SubItems[1].Text}");
			form.ShowDialog();
			if (form.DialogResult == DialogResult.OK)
			{
				Computer computerDetails = form.computerDetails;
				db.UpdateItem("Computers", computerDetails);
			}
			UpdateFormList();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			ComputerDetails form = new ComputerDetails(db, true);
			form.ShowDialog();
			if (form.DialogResult == DialogResult.OK)
			{
				Computer computerDetails = form.computerDetails;
				db.AddItem("Computers", computerDetails);
			}
			UpdateFormList();
		}
	}
}
