
namespace Ewidencja
{
	partial class ComputersWindow
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.computersListView = new System.Windows.Forms.ListView();
			this.computerIDColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.companyIDComputerColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.employeeIDComputerColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.dateOfPurchaseColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.CPUColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.RAMSizeColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.diskSizeColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.windowsKeyColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.deleteButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.refreshButton = new System.Windows.Forms.Button();
			this.companyNameComputerColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.employeeFullNameComputerColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1574, 130);
			this.panel1.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(30, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 65);
			this.label1.TabIndex = 0;
			this.label1.Text = "Komputery";
			// 
			// computersListView
			// 
			this.computersListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.computersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.computersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.companyNameComputerColumnHeader,
            this.employeeFullNameComputerColumnHeader,
            this.computerIDColumnHeader,
            this.companyIDComputerColumnHeader,
            this.employeeIDComputerColumnHeader,
            this.dateOfPurchaseColumnHeader,
            this.CPUColumnHeader,
            this.RAMSizeColumnHeader,
            this.diskSizeColumnHeader,
            this.windowsKeyColumnHeader});
			this.computersListView.FullRowSelect = true;
			this.computersListView.HideSelection = false;
			this.computersListView.HoverSelection = true;
			this.computersListView.Location = new System.Drawing.Point(30, 160);
			this.computersListView.MultiSelect = false;
			this.computersListView.Name = "computersListView";
			this.computersListView.Size = new System.Drawing.Size(1511, 881);
			this.computersListView.TabIndex = 11;
			this.computersListView.UseCompatibleStateImageBehavior = false;
			this.computersListView.View = System.Windows.Forms.View.Details;
			this.computersListView.SelectedIndexChanged += new System.EventHandler(this.computersListView_SelectedIndexChanged);
			// 
			// computerIDColumnHeader
			// 
			this.computerIDColumnHeader.Text = "ID komputera";
			this.computerIDColumnHeader.Width = 0;
			// 
			// companyIDComputerColumnHeader
			// 
			this.companyIDComputerColumnHeader.Text = "ID firmy";
			this.companyIDComputerColumnHeader.Width = 0;
			// 
			// employeeIDComputerColumnHeader
			// 
			this.employeeIDComputerColumnHeader.Text = "ID pracownika";
			this.employeeIDComputerColumnHeader.Width = 0;
			// 
			// dateOfPurchaseColumnHeader
			// 
			this.dateOfPurchaseColumnHeader.Text = "Data zakupu";
			this.dateOfPurchaseColumnHeader.Width = 180;
			// 
			// CPUColumnHeader
			// 
			this.CPUColumnHeader.Text = "Procesor";
			this.CPUColumnHeader.Width = 120;
			// 
			// RAMSizeColumnHeader
			// 
			this.RAMSizeColumnHeader.Text = "Pamięć RAM [GB]";
			this.RAMSizeColumnHeader.Width = 200;
			// 
			// diskSizeColumnHeader
			// 
			this.diskSizeColumnHeader.Text = "Rozmiar dysku [GB]";
			this.diskSizeColumnHeader.Width = 220;
			// 
			// windowsKeyColumnHeader
			// 
			this.windowsKeyColumnHeader.Text = "Klucz produktu systemu Windows";
			this.windowsKeyColumnHeader.Width = 400;
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
			this.deleteButton.TabIndex = 10;
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
			this.editButton.TabIndex = 9;
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
			this.addButton.TabIndex = 8;
			this.addButton.Text = "Dodaj";
			this.addButton.UseVisualStyleBackColor = false;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
			this.refreshButton.TabIndex = 12;
			this.refreshButton.Text = "Odśwież";
			this.refreshButton.UseVisualStyleBackColor = false;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// companyNameComputerColumnHeader
			// 
			this.companyNameComputerColumnHeader.Text = "Nazwa firmy";
			this.companyNameComputerColumnHeader.Width = 200;
			// 
			// employeeFullNameComputerColumnHeader
			// 
			this.employeeFullNameComputerColumnHeader.Text = "Pracownik";
			this.employeeFullNameComputerColumnHeader.Width = 200;
			// 
			// ComputersWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1574, 1129);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.computersListView);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.refreshButton);
			this.Name = "ComputersWindow";
			this.Text = "Komputery";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView computersListView;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.ColumnHeader computerIDColumnHeader;
		private System.Windows.Forms.ColumnHeader companyIDComputerColumnHeader;
		private System.Windows.Forms.ColumnHeader employeeIDComputerColumnHeader;
		private System.Windows.Forms.ColumnHeader dateOfPurchaseColumnHeader;
		private System.Windows.Forms.ColumnHeader CPUColumnHeader;
		private System.Windows.Forms.ColumnHeader RAMSizeColumnHeader;
		private System.Windows.Forms.ColumnHeader diskSizeColumnHeader;
		private System.Windows.Forms.ColumnHeader windowsKeyColumnHeader;
		private System.Windows.Forms.ColumnHeader companyNameComputerColumnHeader;
		private System.Windows.Forms.ColumnHeader employeeFullNameComputerColumnHeader;
	}
}