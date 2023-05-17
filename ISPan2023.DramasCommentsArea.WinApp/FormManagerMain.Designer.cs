namespace ISPan2023.DramasCommentsArea.WinApp
{
	partial class FormManagerMain
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
			this.btnDramas = new System.Windows.Forms.Button();
			this.btnComments = new System.Windows.Forms.Button();
			this.btnUsers = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnDramas
			// 
			this.btnDramas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnDramas.Location = new System.Drawing.Point(110, 47);
			this.btnDramas.Name = "btnDramas";
			this.btnDramas.Size = new System.Drawing.Size(133, 41);
			this.btnDramas.TabIndex = 0;
			this.btnDramas.Text = "戲劇資料管理";
			this.btnDramas.UseVisualStyleBackColor = true;
			this.btnDramas.Click += new System.EventHandler(this.btnDramas_Click);
			// 
			// btnComments
			// 
			this.btnComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnComments.Location = new System.Drawing.Point(110, 112);
			this.btnComments.Name = "btnComments";
			this.btnComments.Size = new System.Drawing.Size(133, 41);
			this.btnComments.TabIndex = 0;
			this.btnComments.Text = "評論查詢";
			this.btnComments.UseVisualStyleBackColor = true;
			// 
			// btnUsers
			// 
			this.btnUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnUsers.Location = new System.Drawing.Point(110, 182);
			this.btnUsers.Name = "btnUsers";
			this.btnUsers.Size = new System.Drawing.Size(133, 41);
			this.btnUsers.TabIndex = 0;
			this.btnUsers.Text = "使用者查詢";
			this.btnUsers.UseVisualStyleBackColor = true;
			// 
			// FormManagerMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 291);
			this.Controls.Add(this.btnUsers);
			this.Controls.Add(this.btnComments);
			this.Controls.Add(this.btnDramas);
			this.Font = new System.Drawing.Font("源石黑體 R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "FormManagerMain";
			this.Text = "FormManagerMain";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnDramas;
		private System.Windows.Forms.Button btnComments;
		private System.Windows.Forms.Button btnUsers;
	}
}