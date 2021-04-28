
namespace Ewidencja
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.companiesButton = new System.Windows.Forms.Button();
			this.computersButton = new System.Windows.Forms.Button();
			this.employeesButton = new System.Windows.Forms.Button();
			this.reportsButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(30, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(768, 65);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ewidencja sprzętu komputerowego";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(995, 130);
			this.panel1.TabIndex = 1;
			// 
			// companiesButton
			// 
			this.companiesButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.companiesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.companiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.companiesButton.ForeColor = System.Drawing.Color.White;
			this.companiesButton.Location = new System.Drawing.Point(440, 153);
			this.companiesButton.Name = "companiesButton";
			this.companiesButton.Size = new System.Drawing.Size(520, 59);
			this.companiesButton.TabIndex = 20;
			this.companiesButton.Text = "Firmy";
			this.companiesButton.UseVisualStyleBackColor = false;
			this.companiesButton.Click += new System.EventHandler(this.companiesButton_Click);
			// 
			// computersButton
			// 
			this.computersButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.computersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.computersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.computersButton.ForeColor = System.Drawing.Color.White;
			this.computersButton.Location = new System.Drawing.Point(440, 331);
			this.computersButton.Name = "computersButton";
			this.computersButton.Size = new System.Drawing.Size(520, 59);
			this.computersButton.TabIndex = 21;
			this.computersButton.Text = "Komputery";
			this.computersButton.UseVisualStyleBackColor = false;
			this.computersButton.Click += new System.EventHandler(this.computersButton_Click);
			// 
			// employeesButton
			// 
			this.employeesButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.employeesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.employeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.employeesButton.ForeColor = System.Drawing.Color.White;
			this.employeesButton.Location = new System.Drawing.Point(440, 243);
			this.employeesButton.Name = "employeesButton";
			this.employeesButton.Size = new System.Drawing.Size(520, 59);
			this.employeesButton.TabIndex = 22;
			this.employeesButton.Text = "Pracownicy";
			this.employeesButton.UseVisualStyleBackColor = false;
			this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
			// 
			// reportsButton
			// 
			this.reportsButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.reportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.reportsButton.ForeColor = System.Drawing.Color.White;
			this.reportsButton.Location = new System.Drawing.Point(440, 425);
			this.reportsButton.Name = "reportsButton";
			this.reportsButton.Size = new System.Drawing.Size(520, 59);
			this.reportsButton.TabIndex = 23;
			this.reportsButton.Text = "Raporty";
			this.reportsButton.UseVisualStyleBackColor = false;
			this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 136);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(385, 364);
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(995, 525);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.reportsButton);
			this.Controls.Add(this.employeesButton);
			this.Controls.Add(this.computersButton);
			this.Controls.Add(this.companiesButton);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.Text = "Ewidencja sprzętu komputerowego";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button companiesButton;
		private System.Windows.Forms.Button computersButton;
		private System.Windows.Forms.Button employeesButton;
		private System.Windows.Forms.Button reportsButton;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}