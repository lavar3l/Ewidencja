
namespace Ewidencja
{
	partial class ComputerDetails
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
			this.label = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.companyComboBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.windowsKeyTextBox = new System.Windows.Forms.TextBox();
			this.diskSizeTextBox = new System.Windows.Forms.TextBox();
			this.RAMSizeTextBox = new System.Windows.Forms.TextBox();
			this.CPUTextBox = new System.Windows.Forms.TextBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.acceptButton = new System.Windows.Forms.Button();
			this.employeeComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(44, 282);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(147, 32);
			this.label.TabIndex = 38;
			this.label.Text = "Data zakupu";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.panel1.Controls.Add(this.labelTitle);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 130);
			this.panel1.TabIndex = 35;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelTitle.ForeColor = System.Drawing.Color.White;
			this.labelTitle.Location = new System.Drawing.Point(30, 30);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(499, 65);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Dodaj nowy komputer";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 169);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 32);
			this.label1.TabIndex = 49;
			this.label1.Text = "Firma";
			// 
			// companyComboBox
			// 
			this.companyComboBox.FormattingEnabled = true;
			this.companyComboBox.Location = new System.Drawing.Point(263, 166);
			this.companyComboBox.Name = "companyComboBox";
			this.companyComboBox.Size = new System.Drawing.Size(468, 40);
			this.companyComboBox.TabIndex = 48;
			this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.companyComboBox_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(44, 508);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(174, 32);
			this.label6.TabIndex = 47;
			this.label6.Text = "Klucz Windows";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 449);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 32);
			this.label5.TabIndex = 46;
			this.label5.Text = "Dysk [GB]";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 389);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(198, 32);
			this.label4.TabIndex = 45;
			this.label4.Text = "Pamięć RAM [GB]";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 335);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 32);
			this.label2.TabIndex = 44;
			this.label2.Text = "Procesor";
			// 
			// windowsKeyTextBox
			// 
			this.windowsKeyTextBox.Location = new System.Drawing.Point(263, 505);
			this.windowsKeyTextBox.Name = "windowsKeyTextBox";
			this.windowsKeyTextBox.Size = new System.Drawing.Size(468, 39);
			this.windowsKeyTextBox.TabIndex = 43;
			// 
			// diskSizeTextBox
			// 
			this.diskSizeTextBox.Location = new System.Drawing.Point(263, 446);
			this.diskSizeTextBox.Name = "diskSizeTextBox";
			this.diskSizeTextBox.Size = new System.Drawing.Size(468, 39);
			this.diskSizeTextBox.TabIndex = 42;
			// 
			// RAMSizeTextBox
			// 
			this.RAMSizeTextBox.Location = new System.Drawing.Point(263, 389);
			this.RAMSizeTextBox.Name = "RAMSizeTextBox";
			this.RAMSizeTextBox.Size = new System.Drawing.Size(468, 39);
			this.RAMSizeTextBox.TabIndex = 41;
			// 
			// CPUTextBox
			// 
			this.CPUTextBox.Location = new System.Drawing.Point(263, 335);
			this.CPUTextBox.Name = "CPUTextBox";
			this.CPUTextBox.Size = new System.Drawing.Size(468, 39);
			this.CPUTextBox.TabIndex = 40;
			// 
			// cancelButton
			// 
			this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cancelButton.BackColor = System.Drawing.Color.DarkRed;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.ForeColor = System.Drawing.Color.White;
			this.cancelButton.Location = new System.Drawing.Point(565, 586);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(201, 59);
			this.cancelButton.TabIndex = 37;
			this.cancelButton.Text = "Anuluj";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// acceptButton
			// 
			this.acceptButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.acceptButton.ForeColor = System.Drawing.Color.White;
			this.acceptButton.Location = new System.Drawing.Point(30, 586);
			this.acceptButton.Name = "acceptButton";
			this.acceptButton.Size = new System.Drawing.Size(201, 59);
			this.acceptButton.TabIndex = 36;
			this.acceptButton.Text = "Dodaj";
			this.acceptButton.UseVisualStyleBackColor = false;
			this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
			// 
			// employeeComboBox
			// 
			this.employeeComboBox.FormattingEnabled = true;
			this.employeeComboBox.Location = new System.Drawing.Point(263, 222);
			this.employeeComboBox.Name = "employeeComboBox";
			this.employeeComboBox.Size = new System.Drawing.Size(468, 40);
			this.employeeComboBox.TabIndex = 50;
			this.employeeComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeComboBox_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 230);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 32);
			this.label3.TabIndex = 51;
			this.label3.Text = "Pracownik";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.dateTimePicker.Location = new System.Drawing.Point(263, 277);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(468, 39);
			this.dateTimePicker.TabIndex = 52;
			// 
			// ComputerDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 660);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.employeeComboBox);
			this.Controls.Add(this.label);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.companyComboBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.windowsKeyTextBox);
			this.Controls.Add(this.diskSizeTextBox);
			this.Controls.Add(this.RAMSizeTextBox);
			this.Controls.Add(this.CPUTextBox);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.acceptButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "ComputerDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nowy komputer";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox companyComboBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox windowsKeyTextBox;
		private System.Windows.Forms.TextBox diskSizeTextBox;
		private System.Windows.Forms.TextBox RAMSizeTextBox;
		private System.Windows.Forms.TextBox CPUTextBox;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button acceptButton;
		private System.Windows.Forms.ComboBox employeeComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
	}
}