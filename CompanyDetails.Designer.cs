
namespace Ewidencja
{
	partial class CompanyDetails
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
			this.labelTitle = new System.Windows.Forms.Label();
			this.acceptButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.NIPtextBox = new System.Windows.Forms.TextBox();
			this.streetNameTextBox = new System.Windows.Forms.TextBox();
			this.buildingNoTextBox = new System.Windows.Forms.TextBox();
			this.postalCodeTextBox = new System.Windows.Forms.TextBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.panel1.Controls.Add(this.labelTitle);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 130);
			this.panel1.TabIndex = 1;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.labelTitle.ForeColor = System.Drawing.Color.White;
			this.labelTitle.Location = new System.Drawing.Point(30, 30);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(404, 65);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Dodaj nową firmę";
			// 
			// acceptButton
			// 
			this.acceptButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.acceptButton.ForeColor = System.Drawing.Color.White;
			this.acceptButton.Location = new System.Drawing.Point(30, 571);
			this.acceptButton.Name = "acceptButton";
			this.acceptButton.Size = new System.Drawing.Size(201, 59);
			this.acceptButton.TabIndex = 3;
			this.acceptButton.Text = "Dodaj";
			this.acceptButton.UseVisualStyleBackColor = false;
			this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cancelButton.BackColor = System.Drawing.Color.DarkRed;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.ForeColor = System.Drawing.Color.White;
			this.cancelButton.Location = new System.Drawing.Point(565, 571);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(201, 59);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "Anuluj";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(44, 162);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(84, 32);
			this.label.TabIndex = 6;
			this.label.Text = "Nazwa";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(223, 159);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(508, 39);
			this.nameTextBox.TabIndex = 7;
			// 
			// NIPtextBox
			// 
			this.NIPtextBox.Location = new System.Drawing.Point(223, 216);
			this.NIPtextBox.Name = "NIPtextBox";
			this.NIPtextBox.Size = new System.Drawing.Size(508, 39);
			this.NIPtextBox.TabIndex = 8;
			// 
			// streetNameTextBox
			// 
			this.streetNameTextBox.Location = new System.Drawing.Point(223, 311);
			this.streetNameTextBox.Name = "streetNameTextBox";
			this.streetNameTextBox.Size = new System.Drawing.Size(508, 39);
			this.streetNameTextBox.TabIndex = 9;
			// 
			// buildingNoTextBox
			// 
			this.buildingNoTextBox.Location = new System.Drawing.Point(223, 366);
			this.buildingNoTextBox.Name = "buildingNoTextBox";
			this.buildingNoTextBox.Size = new System.Drawing.Size(508, 39);
			this.buildingNoTextBox.TabIndex = 10;
			// 
			// postalCodeTextBox
			// 
			this.postalCodeTextBox.Location = new System.Drawing.Point(223, 423);
			this.postalCodeTextBox.Name = "postalCodeTextBox";
			this.postalCodeTextBox.Size = new System.Drawing.Size(508, 39);
			this.postalCodeTextBox.TabIndex = 11;
			// 
			// cityTextBox
			// 
			this.cityTextBox.Location = new System.Drawing.Point(223, 482);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(508, 39);
			this.cityTextBox.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 219);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 32);
			this.label2.TabIndex = 13;
			this.label2.Text = "NIP";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 314);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 32);
			this.label3.TabIndex = 14;
			this.label3.Text = "Ulica";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 366);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(141, 32);
			this.label4.TabIndex = 15;
			this.label4.Text = "Nr budynku";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 426);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(163, 32);
			this.label5.TabIndex = 16;
			this.label5.Text = "Kod pocztowy";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(44, 485);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(148, 32);
			this.label6.TabIndex = 17;
			this.label6.Text = "Miejscowość";
			// 
			// CompanyDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 660);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(this.postalCodeTextBox);
			this.Controls.Add(this.buildingNoTextBox);
			this.Controls.Add(this.streetNameTextBox);
			this.Controls.Add(this.NIPtextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.acceptButton);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "CompanyDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nowa firma";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Button acceptButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox NIPtextBox;
		private System.Windows.Forms.TextBox streetNameTextBox;
		private System.Windows.Forms.TextBox buildingNoTextBox;
		private System.Windows.Forms.TextBox postalCodeTextBox;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}