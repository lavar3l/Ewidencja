
namespace Ewidencja
{
	partial class EmployeesWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.refreshButton = new System.Windows.Forms.Button();
			this.employeesListView = new System.Windows.Forms.ListView();
			this.employeeIDColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.companyIDEmployeeColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.surnameColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.positionColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.phoneColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.emailColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.deleteButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.companyNameColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(30, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(265, 65);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pracownicy";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1574, 130);
			this.panel1.TabIndex = 1;
			// 
			// refreshButton
			// 
			this.refreshButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshButton.ForeColor = System.Drawing.Color.White;
			this.refreshButton.Location = new System.Drawing.Point(1340, 1058);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(201, 59);
			this.refreshButton.TabIndex = 11;
			this.refreshButton.Text = "Odśwież";
			this.refreshButton.UseVisualStyleBackColor = false;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// employeesListView
			// 
			this.employeesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.employeesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.employeesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.companyNameColumnHeader,
            this.employeeIDColumnHeader,
            this.companyIDEmployeeColumnHeader,
            this.nameColumnHeader,
            this.surnameColumnHeader,
            this.positionColumnHeader,
            this.phoneColumnHeader,
            this.emailColumnHeader});
			this.employeesListView.FullRowSelect = true;
			this.employeesListView.HideSelection = false;
			this.employeesListView.HoverSelection = true;
			this.employeesListView.Location = new System.Drawing.Point(30, 160);
			this.employeesListView.MultiSelect = false;
			this.employeesListView.Name = "employeesListView";
			this.employeesListView.Size = new System.Drawing.Size(1511, 881);
			this.employeesListView.TabIndex = 10;
			this.employeesListView.UseCompatibleStateImageBehavior = false;
			this.employeesListView.View = System.Windows.Forms.View.Details;
			this.employeesListView.SelectedIndexChanged += new System.EventHandler(this.employeesListView_SelectedIndexChanged);
			// 
			// employeeIDColumnHeader
			// 
			this.employeeIDColumnHeader.Text = "ID pracownika";
			this.employeeIDColumnHeader.Width = 180;
			// 
			// companyIDEmployeeColumnHeader
			// 
			this.companyIDEmployeeColumnHeader.Text = "ID Firmy";
			this.companyIDEmployeeColumnHeader.Width = 150;
			// 
			// nameColumnHeader
			// 
			this.nameColumnHeader.Text = "Imię";
			this.nameColumnHeader.Width = 200;
			// 
			// surnameColumnHeader
			// 
			this.surnameColumnHeader.Text = "Nazwisko";
			this.surnameColumnHeader.Width = 200;
			// 
			// positionColumnHeader
			// 
			this.positionColumnHeader.Text = "Stanowisko";
			this.positionColumnHeader.Width = 260;
			// 
			// phoneColumnHeader
			// 
			this.phoneColumnHeader.Text = "Numer telefonu";
			this.phoneColumnHeader.Width = 200;
			// 
			// emailColumnHeader
			// 
			this.emailColumnHeader.Text = "Adres e-mail";
			this.emailColumnHeader.Width = 300;
			// 
			// deleteButton
			// 
			this.deleteButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.deleteButton.BackColor = System.Drawing.Color.DarkRed;
			this.deleteButton.Enabled = false;
			this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteButton.ForeColor = System.Drawing.Color.White;
			this.deleteButton.Location = new System.Drawing.Point(464, 1058);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(201, 59);
			this.deleteButton.TabIndex = 9;
			this.deleteButton.Text = "Usuń";
			this.deleteButton.UseVisualStyleBackColor = false;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// editButton
			// 
			this.editButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.editButton.Enabled = false;
			this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.editButton.ForeColor = System.Drawing.Color.White;
			this.editButton.Location = new System.Drawing.Point(248, 1058);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(201, 59);
			this.editButton.TabIndex = 8;
			this.editButton.Text = "Edytuj";
			this.editButton.UseVisualStyleBackColor = false;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// addButton
			// 
			this.addButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addButton.ForeColor = System.Drawing.Color.White;
			this.addButton.Location = new System.Drawing.Point(30, 1058);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(201, 59);
			this.addButton.TabIndex = 7;
			this.addButton.Text = "Dodaj";
			this.addButton.UseVisualStyleBackColor = false;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// companyNameColumnHeader
			// 
			this.companyNameColumnHeader.Text = "Nazwa firmy";
			this.companyNameColumnHeader.Width = 300;
			// 
			// EmployeesWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1574, 1129);
			this.Controls.Add(this.refreshButton);
			this.Controls.Add(this.employeesListView);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.panel1);
			this.Name = "EmployeesWindow";
			this.Text = "Pracownicy";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.ListView employeesListView;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.ColumnHeader employeeIDColumnHeader;
		private System.Windows.Forms.ColumnHeader companyIDEmployeeColumnHeader;
		private System.Windows.Forms.ColumnHeader nameColumnHeader;
		private System.Windows.Forms.ColumnHeader surnameColumnHeader;
		private System.Windows.Forms.ColumnHeader positionColumnHeader;
		private System.Windows.Forms.ColumnHeader phoneColumnHeader;
		private System.Windows.Forms.ColumnHeader emailColumnHeader;
		private System.Windows.Forms.ColumnHeader companyNameColumnHeader;
	}
}