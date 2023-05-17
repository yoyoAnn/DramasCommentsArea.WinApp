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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDramas
			// 
			this.btnDramas.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDramas.BackColor = System.Drawing.Color.MediumAquamarine;
			this.btnDramas.Location = new System.Drawing.Point(66, 71);
			this.btnDramas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDramas.Name = "btnDramas";
			this.btnDramas.Size = new System.Drawing.Size(244, 78);
			this.btnDramas.TabIndex = 0;
			this.btnDramas.Text = "戲劇資料管理";
			this.btnDramas.UseVisualStyleBackColor = false;
			this.btnDramas.Click += new System.EventHandler(this.btnDramas_Click);
			// 
			// btnComments
			// 
			this.btnComments.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnComments.BackColor = System.Drawing.Color.PowderBlue;
			this.btnComments.Location = new System.Drawing.Point(66, 166);
			this.btnComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnComments.Name = "btnComments";
			this.btnComments.Size = new System.Drawing.Size(119, 40);
			this.btnComments.TabIndex = 1;
			this.btnComments.Text = "評論查詢";
			this.btnComments.UseVisualStyleBackColor = false;
			this.btnComments.Click += new System.EventHandler(this.btnComments_Click);
			// 
			// btnUsers
			// 
			this.btnUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnUsers.BackColor = System.Drawing.Color.PowderBlue;
			this.btnUsers.Location = new System.Drawing.Point(191, 166);
			this.btnUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUsers.Name = "btnUsers";
			this.btnUsers.Size = new System.Drawing.Size(119, 40);
			this.btnUsers.TabIndex = 2;
			this.btnUsers.Text = "用戶查詢";
			this.btnUsers.UseVisualStyleBackColor = false;
			this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(384, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 登出ToolStripMenuItem
			// 
			this.登出ToolStripMenuItem.Font = new System.Drawing.Font("華康中圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
			this.登出ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.登出ToolStripMenuItem.Text = "登出";
			this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
			// 
			// FormManagerMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.btnUsers);
			this.Controls.Add(this.btnComments);
			this.Controls.Add(this.btnDramas);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("華康中圓體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "FormManagerMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "管理者頁面";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormManagerMain_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDramas;
		private System.Windows.Forms.Button btnComments;
		private System.Windows.Forms.Button btnUsers;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
	}
}