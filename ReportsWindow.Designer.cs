
namespace Ewidencja
{
	partial class ReportsWindow
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
			this.saveButton = new System.Windows.Forms.Button();
			this.windowsKeyColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.diskSizeColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.RAMSizeColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.CPUColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.generateButton = new System.Windows.Forms.Button();
			this.dateOfPurchaseColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.companyIDComputerColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.computerIDColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.employeeFullNameComputerColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.companyNameComputerColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.reportListView = new System.Windows.Forms.ListView();
			this.employeeIDComputerColumnHeader = new System.Windows.Forms.ColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.employeeComboBox = new System.Windows.Forms.ComboBox();
			this.companyComboBox = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.windowsCheckBox = new System.Windows.Forms.CheckBox();
			this.diskSizeEndTextBox = new System.Windows.Forms.TextBox();
			this.RAMendTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.diskSizeBeginTextBox = new System.Windows.Forms.TextBox();
			this.RAMbeginTextBox = new System.Windows.Forms.TextBox();
			this.CPUTextBox = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dateEndCheckBox = new System.Windows.Forms.CheckBox();
			this.dateBeginCheckBox = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.saveButton.Enabled = false;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.Location = new System.Drawing.Point(30, 1040);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(486, 59);
			this.saveButton.TabIndex = 15;
			this.saveButton.Text = "Zapisz raport do pliku";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// windowsKeyColumnHeader
			// 
			this.windowsKeyColumnHeader.Text = "Klucz produktu systemu Windows";
			this.windowsKeyColumnHeader.Width = 400;
			// 
			// diskSizeColumnHeader
			// 
			this.diskSizeColumnHeader.Text = "Rozmiar dysku [GB]";
			this.diskSizeColumnHeader.Width = 220;
			// 
			// RAMSizeColumnHeader
			// 
			this.RAMSizeColumnHeader.Text = "Pamięć RAM [GB]";
			this.RAMSizeColumnHeader.Width = 200;
			// 
			// CPUColumnHeader
			// 
			this.CPUColumnHeader.Text = "Procesor";
			this.CPUColumnHeader.Width = 120;
			// 
			// generateButton
			// 
			this.generateButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.generateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.generateButton.ForeColor = System.Drawing.Color.White;
			this.generateButton.Location = new System.Drawing.Point(30, 958);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(486, 59);
			this.generateButton.TabIndex = 14;
			this.generateButton.Text = "Generuj raport";
			this.generateButton.UseVisualStyleBackColor = false;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// dateOfPurchaseColumnHeader
			// 
			this.dateOfPurchaseColumnHeader.Text = "Data zakupu";
			this.dateOfPurchaseColumnHeader.Width = 180;
			// 
			// companyIDComputerColumnHeader
			// 
			this.companyIDComputerColumnHeader.Text = "ID firmy";
			this.companyIDComputerColumnHeader.Width = 0;
			// 
			// computerIDColumnHeader
			// 
			this.computerIDColumnHeader.Text = "ID komputera";
			this.computerIDColumnHeader.Width = 0;
			// 
			// employeeFullNameComputerColumnHeader
			// 
			this.employeeFullNameComputerColumnHeader.Text = "Pracownik";
			this.employeeFullNameComputerColumnHeader.Width = 200;
			// 
			// companyNameComputerColumnHeader
			// 
			this.companyNameComputerColumnHeader.Text = "Nazwa firmy";
			this.companyNameComputerColumnHeader.Width = 200;
			// 
			// reportListView
			// 
			this.reportListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.reportListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.reportListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
			this.reportListView.FullRowSelect = true;
			this.reportListView.HideSelection = false;
			this.reportListView.HoverSelection = true;
			this.reportListView.Location = new System.Drawing.Point(557, 166);
			this.reportListView.MultiSelect = false;
			this.reportListView.Name = "reportListView";
			this.reportListView.Size = new System.Drawing.Size(984, 933);
			this.reportListView.TabIndex = 17;
			this.reportListView.UseCompatibleStateImageBehavior = false;
			this.reportListView.View = System.Windows.Forms.View.Details;
			// 
			// employeeIDComputerColumnHeader
			// 
			this.employeeIDComputerColumnHeader.Text = "ID pracownika";
			this.employeeIDComputerColumnHeader.Width = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(30, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(476, 65);
			this.label1.TabIndex = 0;
			this.label1.Text = "Generowanie raportu";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1574, 130);
			this.panel1.TabIndex = 13;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.employeeComboBox);
			this.groupBox1.Controls.Add(this.companyComboBox);
			this.groupBox1.Location = new System.Drawing.Point(30, 166);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(486, 200);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Właściciel";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 32);
			this.label3.TabIndex = 52;
			this.label3.Text = "Pracownik";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 32);
			this.label2.TabIndex = 50;
			this.label2.Text = "Firma";
			// 
			// employeeComboBox
			// 
			this.employeeComboBox.Enabled = false;
			this.employeeComboBox.FormattingEnabled = true;
			this.employeeComboBox.Location = new System.Drawing.Point(164, 125);
			this.employeeComboBox.Name = "employeeComboBox";
			this.employeeComboBox.Size = new System.Drawing.Size(297, 40);
			this.employeeComboBox.TabIndex = 51;
			// 
			// companyComboBox
			// 
			this.companyComboBox.FormattingEnabled = true;
			this.companyComboBox.Location = new System.Drawing.Point(164, 56);
			this.companyComboBox.Name = "companyComboBox";
			this.companyComboBox.Size = new System.Drawing.Size(297, 40);
			this.companyComboBox.TabIndex = 49;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.windowsCheckBox);
			this.groupBox2.Controls.Add(this.diskSizeEndTextBox);
			this.groupBox2.Controls.Add(this.RAMendTextBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.diskSizeBeginTextBox);
			this.groupBox2.Controls.Add(this.RAMbeginTextBox);
			this.groupBox2.Controls.Add(this.CPUTextBox);
			this.groupBox2.Location = new System.Drawing.Point(30, 613);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(486, 304);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Parametry";
			// 
			// windowsCheckBox
			// 
			this.windowsCheckBox.AutoSize = true;
			this.windowsCheckBox.Location = new System.Drawing.Point(32, 231);
			this.windowsCheckBox.Name = "windowsCheckBox";
			this.windowsCheckBox.Size = new System.Drawing.Size(442, 36);
			this.windowsCheckBox.TabIndex = 58;
			this.windowsCheckBox.Text = "Wymagany klucz licencyjny Windows";
			this.windowsCheckBox.UseVisualStyleBackColor = true;
			// 
			// diskSizeEndTextBox
			// 
			this.diskSizeEndTextBox.Location = new System.Drawing.Point(323, 170);
			this.diskSizeEndTextBox.Name = "diskSizeEndTextBox";
			this.diskSizeEndTextBox.Size = new System.Drawing.Size(145, 39);
			this.diskSizeEndTextBox.TabIndex = 57;
			// 
			// RAMendTextBox
			// 
			this.RAMendTextBox.Location = new System.Drawing.Point(323, 113);
			this.RAMendTextBox.Name = "RAMendTextBox";
			this.RAMendTextBox.Size = new System.Drawing.Size(145, 39);
			this.RAMendTextBox.TabIndex = 56;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 32);
			this.label5.TabIndex = 54;
			this.label5.Text = "Dysk [GB]";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 32);
			this.label4.TabIndex = 53;
			this.label4.Text = "RAM [GB]";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(25, 60);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 32);
			this.label7.TabIndex = 52;
			this.label7.Text = "Procesor";
			// 
			// diskSizeBeginTextBox
			// 
			this.diskSizeBeginTextBox.Location = new System.Drawing.Point(157, 170);
			this.diskSizeBeginTextBox.Name = "diskSizeBeginTextBox";
			this.diskSizeBeginTextBox.Size = new System.Drawing.Size(145, 39);
			this.diskSizeBeginTextBox.TabIndex = 50;
			// 
			// RAMbeginTextBox
			// 
			this.RAMbeginTextBox.Location = new System.Drawing.Point(157, 113);
			this.RAMbeginTextBox.Name = "RAMbeginTextBox";
			this.RAMbeginTextBox.Size = new System.Drawing.Size(145, 39);
			this.RAMbeginTextBox.TabIndex = 49;
			// 
			// CPUTextBox
			// 
			this.CPUTextBox.Location = new System.Drawing.Point(157, 57);
			this.CPUTextBox.Name = "CPUTextBox";
			this.CPUTextBox.Size = new System.Drawing.Size(311, 39);
			this.CPUTextBox.TabIndex = 48;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dateEndCheckBox);
			this.groupBox3.Controls.Add(this.dateBeginCheckBox);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.dateTimePickerEnd);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.dateTimePickerBegin);
			this.groupBox3.Location = new System.Drawing.Point(30, 399);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(486, 177);
			this.groupBox3.TabIndex = 21;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Data zakupu";
			// 
			// dateEndCheckBox
			// 
			this.dateEndCheckBox.AutoSize = true;
			this.dateEndCheckBox.Location = new System.Drawing.Point(440, 117);
			this.dateEndCheckBox.Name = "dateEndCheckBox";
			this.dateEndCheckBox.Size = new System.Drawing.Size(28, 27);
			this.dateEndCheckBox.TabIndex = 59;
			this.dateEndCheckBox.UseVisualStyleBackColor = true;
			// 
			// dateBeginCheckBox
			// 
			this.dateBeginCheckBox.AutoSize = true;
			this.dateBeginCheckBox.Location = new System.Drawing.Point(440, 59);
			this.dateBeginCheckBox.Name = "dateBeginCheckBox";
			this.dateBeginCheckBox.Size = new System.Drawing.Size(28, 27);
			this.dateBeginCheckBox.TabIndex = 58;
			this.dateBeginCheckBox.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(25, 113);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(164, 32);
			this.label8.TabIndex = 57;
			this.label8.Text = "Data końcowa";
			// 
			// dateTimePickerEnd
			// 
			this.dateTimePickerEnd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerEnd.Location = new System.Drawing.Point(226, 108);
			this.dateTimePickerEnd.Name = "dateTimePickerEnd";
			this.dateTimePickerEnd.Size = new System.Drawing.Size(198, 39);
			this.dateTimePickerEnd.TabIndex = 56;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(25, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(195, 32);
			this.label6.TabIndex = 55;
			this.label6.Text = "Data początkowa";
			// 
			// dateTimePickerBegin
			// 
			this.dateTimePickerBegin.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.dateTimePickerBegin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerBegin.Location = new System.Drawing.Point(226, 50);
			this.dateTimePickerBegin.Name = "dateTimePickerBegin";
			this.dateTimePickerBegin.Size = new System.Drawing.Size(198, 39);
			this.dateTimePickerBegin.TabIndex = 53;
			// 
			// ReportsWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1574, 1129);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.generateButton);
			this.Controls.Add(this.reportListView);
			this.Controls.Add(this.panel1);
			this.Name = "ReportsWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Raporty";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.ColumnHeader windowsKeyColumnHeader;
		private System.Windows.Forms.ColumnHeader diskSizeColumnHeader;
		private System.Windows.Forms.ColumnHeader RAMSizeColumnHeader;
		private System.Windows.Forms.ColumnHeader CPUColumnHeader;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.ColumnHeader dateOfPurchaseColumnHeader;
		private System.Windows.Forms.ColumnHeader companyIDComputerColumnHeader;
		private System.Windows.Forms.ColumnHeader computerIDColumnHeader;
		private System.Windows.Forms.ColumnHeader employeeFullNameComputerColumnHeader;
		private System.Windows.Forms.ColumnHeader companyNameComputerColumnHeader;
		private System.Windows.Forms.ListView reportListView;
		private System.Windows.Forms.ColumnHeader employeeIDComputerColumnHeader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox companyComboBox;
		private System.Windows.Forms.ComboBox employeeComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox windowsCheckBox;
		private System.Windows.Forms.TextBox diskSizeEndTextBox;
		private System.Windows.Forms.TextBox RAMendTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox diskSizeBeginTextBox;
		private System.Windows.Forms.TextBox RAMbeginTextBox;
		private System.Windows.Forms.TextBox CPUTextBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
		private System.Windows.Forms.CheckBox dateEndCheckBox;
		private System.Windows.Forms.CheckBox dateBeginCheckBox;
	}
}