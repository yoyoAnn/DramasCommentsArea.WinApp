namespace ISPan2023.DramasCommentsArea.WinApp
{
	partial class test
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.urGender1 = new ISPan2023.DramasCommentsArea.WinApp.urGender();
			this.waTextBox2 = new ISPan2023.DramasCommentsArea.WinApp.WATextBox();
			this.waTextBox1 = new ISPan2023.DramasCommentsArea.WinApp.WATextBox();
			this.waCheckBox1 = new ISPan2023.DramasCommentsArea.WinApp.WACheckBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(159, 154);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(143, 193);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "label1";
			// 
			// urGender1
			// 
			this.urGender1.Location = new System.Drawing.Point(254, 75);
			this.urGender1.Name = "urGender1";
			this.urGender1.Size = new System.Drawing.Size(66, 68);
			this.urGender1.TabIndex = 3;
			// 
			// waTextBox2
			// 
			this.waTextBox2.Location = new System.Drawing.Point(136, 61);
			this.waTextBox2.Name = "waTextBox2";
			this.waTextBox2.Size = new System.Drawing.Size(100, 22);
			this.waTextBox2.TabIndex = 1;
			// 
			// waTextBox1
			// 
			this.waTextBox1.Location = new System.Drawing.Point(136, 24);
			this.waTextBox1.Name = "waTextBox1";
			this.waTextBox1.Size = new System.Drawing.Size(100, 22);
			this.waTextBox1.TabIndex = 0;
			// 
			// waCheckBox1
			// 
			this.waCheckBox1.AutoSize = true;
			this.waCheckBox1.Location = new System.Drawing.Point(136, 102);
			this.waCheckBox1.Name = "waCheckBox1";
			this.waCheckBox1.Size = new System.Drawing.Size(93, 16);
			this.waCheckBox1.TabIndex = 2;
			this.waCheckBox1.Text = "waCheckBox1";
			this.waCheckBox1.UseVisualStyleBackColor = true;
			// 
			// test
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.urGender1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.waTextBox2);
			this.Controls.Add(this.waTextBox1);
			this.Controls.Add(this.waCheckBox1);
			this.Name = "test";
			this.Text = "test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private WACheckBox waCheckBox1;
		private WATextBox waTextBox1;
		private WATextBox waTextBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private urGender urGender1;
	}
}