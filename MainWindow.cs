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
	public partial class MainWindow : Form
	{
		DatabaseConnector db;

		public MainWindow(DatabaseConnector dbConnector)
		{
			InitializeComponent();
			this.db = dbConnector;
		}

		private void companiesButton_Click(object sender, EventArgs e)
		{
			CompaniesWindow form = new CompaniesWindow(db);
			form.ShowDialog();
		}

		private void employeesButton_Click(object sender, EventArgs e)
		{
			EmployeesWindow form = new EmployeesWindow(db);
			form.ShowDialog();
		}

		private void computersButton_Click(object sender, EventArgs e)
		{
			ComputersWindow form = new ComputersWindow(db);
			form.ShowDialog();
		}

		private void reportsButton_Click(object sender, EventArgs e)
		{
			ReportsWindow form = new ReportsWindow(db);
			form.ShowDialog();
		}
	}
}
