using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ewidencja
{
	public class DatabaseConnector
	{
        public string ConnectionString;
        public DataSet dataSet;

        public DatabaseConnector()
		{
            InitializeConnection();
            //ConnectData();
		}

        public void UpdateListView(ListView listView, string dbTableName)
        {
            try
            {
                listView.Items.Clear();
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    SqlCommand command = new SqlCommand($"SELECT * FROM {dbTableName};", connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            List<string> cells = new List<string>();
                            for(int column = 0; column < reader.FieldCount; column++)
							{
                                cells.Add(reader[column].ToString());
							}
                            listView.Items.Add(new ListViewItem(cells.ToArray()));
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Połączenie z bazą danych nie powiodło się.", "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.ToString());
            }
        }

        public void UpdateCompaniesComboBox(ComboBox comboBox, string dbTableName)
        {
            try
            {
                comboBox.Items.Clear();
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {

                    SqlCommand command = new SqlCommand($"SELECT companyID, companyName FROM {dbTableName};", connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    List<Object> items = new List<Object>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if(reader[1] != String.Empty) items.Add(new {Text = reader[1], Value = reader[0]});
                        }
                    }
                    comboBox.DataSource = items;
                    comboBox.DisplayMember = "Text";
                    comboBox.ValueMember = "Value";
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Połączenie z bazą danych nie powiodło się.", "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.ToString());
            }
        }

        public void AddItem(string table, object item)
		{
            string fields = "";
            bool firstField = true;
            foreach (PropertyInfo property in item.GetType().GetProperties())
            {
                if ((item is Company && property.Name != "companyID") ||
                    (item is Employee && property.Name != "employeeID") ||
                    (item is Computer && property.Name != "computerID"))
				{
                    if (firstField) firstField = false;
                    else fields += ", ";
                    var value = property.GetValue(item, null);
                    if (value == null) fields += "null";
                    else fields += "'" + value.ToString() + "'";
                }
            }
            string sqlQuery = $"INSERT INTO {table} VALUES ({fields});";
            GeneralNonSelectQuery(sqlQuery);
        }

        public void UpdateItem(string table, object item)
        {
            string fields = "";
            bool firstField = true;

            string idColumnName = String.Empty, itemID = String.Empty;
            if (item is Company) idColumnName = "companyID";
            if (item is Employee) idColumnName = "employeeID";
            if (item is Computer) idColumnName = "computerID";

            foreach (PropertyInfo property in item.GetType().GetProperties())
            {
                if ((item is Company && property.Name != "companyID") ||
                    (item is Employee && property.Name != "employeeID") ||
                    (item is Computer && property.Name != "computerID"))
                {
                    if (firstField) firstField = false;
                    else fields += ", ";
                    var value = property.GetValue(item, null);
                    if (value == null) fields += $"{property.Name} = null";
                    else fields += $"{property.Name} = '{value.ToString()}'";
                }
                else itemID = property.GetValue(item, null).ToString();
            }

            string sqlQuery = $"UPDATE {table} SET {fields} WHERE {idColumnName} = '{itemID}'";
            MessageBox.Show(sqlQuery);
            GeneralNonSelectQuery(sqlQuery);
        }

        public void DeleteItem(string table, string id, string idColumn)
		{
            GeneralNonSelectQuery($"DELETE FROM {table} WHERE {idColumn} = {id}");
		}

        public void GeneralNonSelectQuery(string sqlQuery)
		{
            try
            {
                MessageBox.Show(sqlQuery);
                using (SqlConnection connection = new SqlConnection(this.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Połączenie z bazą danych nie powiodło się.", "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.ToString());
            }
        }

		private void InitializeConnection()
		{
            try
            {
                string tmpConnectionString = GetConnectionStringFromAppSettings();

                using (SqlConnection connection = new SqlConnection(tmpConnectionString))
                {
                    connection.Open();
                    ConnectionString = tmpConnectionString;
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Połączenie z bazą danych nie powiodło się.", "Błąd połączenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.ToString());
            }
        }

        private void ConnectData()
        {
			try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    this.dataSet = new DataSet("Inventory");

                    connection.Open();
                    MessageBox.Show("The SqlConnection is open.");

                    SqlDataAdapter companiesAdapter = new SqlDataAdapter();
                    companiesAdapter.TableMappings.Add("Table", "Companies");
                    SqlCommand companiesCommand = new SqlCommand("SELECT * FROM dbo.Companies;", connection);
                   // companiesCommand.CommandType = CommandType.Text;
                    companiesAdapter.SelectCommand = companiesCommand;
                    companiesAdapter.Fill(dataSet);


                    SqlDataAdapter employeesAdapter = new SqlDataAdapter();
                    employeesAdapter.TableMappings.Add("Table", "Employees");
                    SqlCommand employeesCommand = new SqlCommand("SELECT * FROM dbo.Employees;", connection);
                    employeesAdapter.SelectCommand = employeesCommand;
                    employeesAdapter.Fill(dataSet);

                    SqlDataAdapter computersAdapter = new SqlDataAdapter();
                    computersAdapter.TableMappings.Add("Table", "Computers");
                    SqlCommand computersCommand = new SqlCommand("SELECT * FROM dbo.Computers;", connection);
                    computersAdapter.SelectCommand = computersCommand;
                    computersAdapter.Fill(dataSet);

                    // Zamykanie połączenia do bazy danych
                    connection.Close();

                    // Tworzenie relacji pomiędzy danymi
                    CreateTableRelations();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Pobranie danych z bazy nie powiodło się.", "Błąd bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(e.ToString());
            }
        }

        private void CreateTableRelations()
		{
            // Relacja Companies <-- Employees
            DataColumn parentColumnCE = dataSet.Tables["Companies"].Columns["companyID"];
            DataColumn childColumnCE = dataSet.Tables["Employees"].Columns["companyID"];
            DataRelation relationCE = new System.Data.DataRelation("CompanyEmployee", parentColumnCE, childColumnCE);
            dataSet.Relations.Add(relationCE);

            // Relacja Companies <-- Computers
            DataColumn parentColumnCC = dataSet.Tables["Companies"].Columns["companyID"];
            DataColumn childColumnCC = dataSet.Tables["Computers"].Columns["companyID"];
            DataRelation relationCC = new System.Data.DataRelation("CompanyComputer", parentColumnCC, childColumnCC);
            dataSet.Relations.Add(relationCC);

            // Relacja Employees <-- Computers
            DataColumn parentColumnEC = dataSet.Tables["Employees"].Columns["employeeID"];
            DataColumn childColumnEC = dataSet.Tables["Computers"].Columns["employeeID"];
            DataRelation relationEC = new System.Data.DataRelation("EmployeeComputer", parentColumnEC, childColumnEC);
            dataSet.Relations.Add(relationEC);
        }

        private string GetConnectionStringFromAppSettings()
		{
			return ConfigurationManager.ConnectionStrings["InventoryDB"].ConnectionString;
		}
	}
}
