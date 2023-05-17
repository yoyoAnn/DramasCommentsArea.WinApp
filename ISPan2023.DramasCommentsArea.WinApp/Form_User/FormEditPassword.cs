using ISPan2023.DramasCommentsArea.SqlDataLayer;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Interfaces;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Repository;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPan2023.DramasCommentsArea.WinApp.Form_User
{
	public partial class FormEditPassword : Form
	{
		private int _userId;
		private string _password;
		public FormEditPassword(int userId, string password)
		{
			InitializeComponent();
			_userId = userId;
			_password = password;
		}

		private void btnEditPswCheck_Click(object sender, EventArgs e)
		{
			if(txtPassword.Text == _password)
			{
				lblErrorMessage.Visible = true;
				lblErrorMessage.Text = "不能和上次密碼相同!";
				return;
			}

			UsersEditDto dto = new UsersEditDto()
			{
				Id = _userId,
				Password = txtPassword.Text
			};

			IUsersRepository repo = new SqlUsersRepository();
			UsersService service = new UsersService(repo);

			try
			{
				service.UpdatePassword(dto);
				MessageBox.Show("密碼修改完成!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("修改失敗，原因:" + ex.Message);
				return;
			}

			IGrid owner = this.Owner as IGrid;
			if (owner == null)
			{
				MessageBox.Show("你忘了做interface");
			}
			owner.Display();
			this.DialogResult = DialogResult.OK;
		}
		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;

			btnEditPswCheck.Focus();
			btnEditPswCheck_Click(sender, e);
			txtPassword.Focus();
		}
	}
}
