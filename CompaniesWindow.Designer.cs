
namespace Ewidencja
{
	partial class CompaniesWindow
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
			this.addButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.companiesListView = new System.Windows.Forms.ListView();
			this.companyIDColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.companyNameColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.NIPColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.streetNameColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.buildingNoColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.postalCodeColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.cityColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.refreshButton = new System.Windows.Forms.Button();
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
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(30, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 65);
			this.label1.TabIndex = 0;
			this.label1.Text = "Firmy";
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
			this.addButton.TabIndex = 2;
			this.addButton.Text = "Dodaj";
			this.addButton.UseVisualStyleBackColor = false;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
			this.editButton.TabIndex = 3;
			this.editButton.Text = "Edytuj";
			this.editButton.UseVisualStyleBackColor = false;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
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
			this.deleteButton.TabIndex = 4;
			this.deleteButton.Text = "Usuń";
			this.deleteButton.UseVisualStyleBackColor = false;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// companiesListView
			// 
			this.companiesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.companiesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.companiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.companyIDColumnHeader,
            this.companyNameColumnHeader,
            this.NIPColumnHeader,
            this.streetNameColumnHeader,
            this.buildingNoColumnHeader,
            this.postalCodeColumnHeader,
            this.cityColumnHeader});
			this.companiesListView.FullRowSelect = true;
			this.companiesListView.HideSelection = false;
			this.companiesListView.HoverSelection = true;
			this.companiesListView.Location = new System.Drawing.Point(30, 160);
			this.companiesListView.MultiSelect = false;
			this.companiesListView.Name = "companiesListView";
			this.companiesListView.Size = new System.Drawing.Size(1511, 881);
			this.companiesListView.TabIndex = 5;
			this.companiesListView.UseCompatibleStateImageBehavior = false;
			this.companiesListView.View = System.Windows.Forms.View.Details;
			this.companiesListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.companiesListView_ItemChecked);
			this.companiesListView.SelectedIndexChanged += new System.EventHandler(this.companiesListView_SelectedIndexChanged);
			// 
			// companyIDColumnHeader
			// 
			this.companyIDColumnHeader.Text = "ID firmy";
			this.companyIDColumnHeader.Width = 120;
			// 
			// companyNameColumnHeader
			// 
			this.companyNameColumnHeader.Text = "Nazwa firmy";
			this.companyNameColumnHeader.Width = 400;
			// 
			// NIPColumnHeader
			// 
			this.NIPColumnHeader.Text = "Numer NIP";
			this.NIPColumnHeader.Width = 160;
			// 
			// streetNameColumnHeader
			// 
			this.streetNameColumnHeader.Text = "Ulica";
			this.streetNameColumnHeader.Width = 200;
			// 
			// buildingNoColumnHeader
			// 
			this.buildingNoColumnHeader.Text = "Nr budynku";
			this.buildingNoColumnHeader.Width = 160;
			// 
			// postalCodeColumnHeader
			// 
			this.postalCodeColumnHeader.Text = "Kod pocztowy";
			this.postalCodeColumnHeader.Width = 200;
			// 
			// cityColumnHeader
			// 
			this.cityColumnHeader.Text = "Miejscowość";
			this.cityColumnHeader.Width = 240;
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
			this.refreshButton.TabIndex = 6;
			this.refreshButton.Text = "Odśwież";
			this.refreshButton.UseVisualStyleBackColor = false;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// CompaniesWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1574, 1129);
			this.Controls.Add(this.refreshButton);
			this.Controls.Add(this.companiesListView);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.panel1);
			this.Name = "CompaniesWindow";
			this.Text = "Firmy";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.ListView companiesListView;
		private System.Windows.Forms.ColumnHeader companyIDColumnHeader;
		private System.Windows.Forms.ColumnHeader noteColumnHeader;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.ColumnHeader companyNameColumnHeader;
		private System.Windows.Forms.ColumnHeader NIPColumnHeader;
		private System.Windows.Forms.ColumnHeader streetNameColumnHeader;
		private System.Windows.Forms.ColumnHeader buildingNoColumnHeader;
		private System.Windows.Forms.ColumnHeader postalCodeColumnHeader;
		private System.Windows.Forms.ColumnHeader cityColumnHeader;
	}
}