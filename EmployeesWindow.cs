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
	public partial class EmployeesWindow : Form
	{
		DatabaseConnector db;

		public EmployeesWindow(DatabaseConnector dbConnector)
		{
			this.db = dbConnector;
			InitializeComponent();
			employeesListView.Columns[0].Width = 0;
			UpdateFormList();
		}

		private void UpdateFormList()
		{
			this.db.UpdateListView(employeesListView, "Employees");
		}

		private void refreshButton_Click(object sender, EventArgs e)
		{
			UpdateFormList();
		}

		private void employeesListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.employeesListView.SelectedItems.Count > 0)
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
			var SelectedItem = this.employeesListView.SelectedItems[0];
			DialogResult result = MessageBox.Show($"Czy napewno chcesz usunąć pracownika {SelectedItem.SubItems[2].Text} {SelectedItem.SubItems[3].Text}?", "Usuwanie pracownika", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				db.DeleteItem("Employees", SelectedItem.SubItems[0].Text, "employeeID");
			}
			UpdateFormList();
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			var SelectedItem = this.employeesListView.SelectedItems[0];
			EmployeeDetails form = new EmployeeDetails(db, false, new Employee(SelectedItem.SubItems[0].Text, SelectedItem.SubItems[1].Text, SelectedItem.SubItems[2].Text, SelectedItem.SubItems[3].Text, SelectedItem.SubItems[4].Text, SelectedItem.SubItems[5].Text, SelectedItem.SubItems[6].Text));
			form.ShowDialog();
			if (form.DialogResult == DialogResult.OK)
			{
				Employee employeeDetails = form.employeeDetails;
				db.UpdateItem("Employees", employeeDetails);
			}
			UpdateFormList();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			EmployeeDetails form = new EmployeeDetails(db, true);
			form.ShowDialog();
			if (form.DialogResult == DialogResult.OK)
			{
				Employee employeeDetails = form.employeeDetails;
				db.AddItem("Employees", employeeDetails);
			}
			UpdateFormList();
		}
	}
}
