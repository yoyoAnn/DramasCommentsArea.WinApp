namespace ISPan2023.DramasCommentsArea.WinApp.Form_User
{
	partial class FormEditPassword
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
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnEditPswCheck = new System.Windows.Forms.Button();
			this.lblErrorMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 18F);
			this.txtPassword.Location = new System.Drawing.Point(126, 23);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(237, 39);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("華康中圓體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(14, 33);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 21);
			this.label4.TabIndex = 2;
			this.label4.Text = "新密碼：";
			// 
			// btnEditPswCheck
			// 
			this.btnEditPswCheck.BackColor = System.Drawing.Color.Yellow;
			this.btnEditPswCheck.Font = new System.Drawing.Font("微軟正黑體", 16F);
			this.btnEditPswCheck.Location = new System.Drawing.Point(136, 129);
			this.btnEditPswCheck.Margin = new System.Windows.Forms.Padding(5);
			this.btnEditPswCheck.Name = "btnEditPswCheck";
			this.btnEditPswCheck.Size = new System.Drawing.Size(125, 51);
			this.btnEditPswCheck.TabIndex = 21;
			this.btnEditPswCheck.Text = "確認送出";
			this.btnEditPswCheck.UseVisualStyleBackColor = false;
			this.btnEditPswCheck.Click += new System.EventHandler(this.btnEditPswCheck_Click);
			// 
			// lblErrorMessage
			// 
			this.lblErrorMessage.AutoSize = true;
			this.lblErrorMessage.Font = new System.Drawing.Font("華康中圓體", 10F);
			this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
			this.lblErrorMessage.Location = new System.Drawing.Point(123, 79);
			this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblErrorMessage.Name = "lblErrorMessage";
			this.lblErrorMessage.Size = new System.Drawing.Size(91, 14);
			this.lblErrorMessage.TabIndex = 22;
			this.lblErrorMessage.Text = "ErrorMessage";
			this.lblErrorMessage.Visible = false;
			// 
			// FormEditPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightYellow;
			this.ClientSize = new System.Drawing.Size(399, 206);
			this.Controls.Add(this.lblErrorMessage);
			this.Controls.Add(this.btnEditPswCheck);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label4);
			this.Font = new System.Drawing.Font("華康中圓體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.Name = "FormEditPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "修改密碼";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnEditPswCheck;
		private System.Windows.Forms.Label lblErrorMessage;
	}
}