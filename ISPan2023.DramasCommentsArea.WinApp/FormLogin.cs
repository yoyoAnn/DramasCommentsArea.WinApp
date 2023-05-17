using ISPan2023.DramasCommentsArea.SqlDataLayer.Interfaces;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Repository;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Services;
using ISPan2023.DramasCommentsArea.WinApp.From_User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPan2023.DramasCommentsArea.WinApp
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			IUsersRepository repo = new SqlUsersRepository();
			UsersService service = new UsersService(repo);

			if (string.IsNullOrEmpty(txtAccount.Text)&&string.IsNullOrEmpty(txtPassword.Text))
			{
				MessageBox.Show("帳號密碼不能空白!","提醒");
				return;
			}
			else if (string.IsNullOrEmpty(txtAccount.Text))
			{
				MessageBox.Show("帳號不能空白!", "提醒");
				return;
			}
			else if (string.IsNullOrEmpty(txtPassword.Text))
			{
				MessageBox.Show("密碼不能空白!", "提醒");
				return;
			}

			try
			{
				int validationResult = service.IsValid(txtAccount.Text, txtPassword.Text);
				if (validationResult == 0)
				{
					MessageBox.Show("帳號或密碼有誤，請再試一次", "提醒");
					return;
				}

				if(validationResult == 1)
				{
					var frm = new FormManagerMain();
					frm.Owner = this;

					this.Hide();
					frm.ShowDialog();
				}
				else
				{
					var frm = new FormUserMain(validationResult);
					frm.Owner = this;

					this.Hide();
					frm.ShowDialog();
				}
				txtAccount.Text = string.Empty;
				txtPassword.Text = string.Empty;

				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}
		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;

			btnLogin.Focus();
			btnLogin_Click(sender, e);
			txtPassword.Focus();
		}

		private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtAccount_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;

			btnLogin.Focus();
			btnLogin_Click(sender, e);
			txtPassword.Focus();
		}
	}
}
