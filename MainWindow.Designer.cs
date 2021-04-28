
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.acceptButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
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
			this.panel1.Size = new System.Drawing.Size(1349, 130);
			this.panel1.TabIndex = 1;
			// 
			// acceptButton
			// 
			this.acceptButton.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.acceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.acceptButton.ForeColor = System.Drawing.Color.White;
			this.acceptButton.Location = new System.Drawing.Point(30, 166);
			this.acceptButton.Name = "acceptButton";
			this.acceptButton.Size = new System.Drawing.Size(201, 59);
			this.acceptButton.TabIndex = 20;
			this.acceptButton.Text = "Firmy";
			this.acceptButton.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(159)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(30, 244);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(201, 59);
			this.button1.TabIndex = 21;
			this.button1.Text = "Komputery";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1349, 767);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.acceptButton);
			this.Controls.Add(this.panel1);
			this.Name = "MainWindow";
			this.Text = "MainWindow";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button acceptButton;
		private System.Windows.Forms.Button button1;
	}
}