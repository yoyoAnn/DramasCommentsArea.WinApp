using ISPan2023.DramasCommentsArea.SqlDataLayer;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Interfaces;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Repository;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Services;
using ISPan2023.DramasCommentsArea.WinApp.ViewModels;
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
	public partial class FormUsers : Form
	{
		private List<UsersVM> vm;
		private string _searchText = string.Empty;
		private string _sortName = string.Empty;
		private int _commentsNum = 0;
		public FormUsers()
		{
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
		}
		public void Display()
		{
			_searchText = txtSearch.Text;
			_commentsNum = int.TryParse(txtCommentNum.Text, out int num) ? num : 0;

			IUsersRepository repo = new SqlUsersRepository();
			UsersService service = new UsersService(repo);

			vm = service.Search(_commentsNum, _searchText, _sortName)
				.Select(x => x.ToViewModel())
				.ToList();

			dataGridView1.DataSource = vm;

		}
		private void FormUsers_Load(object sender, EventArgs e)
		{
			Display();
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			Display();
		}
		private void ckbDesc_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbDesc.Checked) { SqlDB.Desc = " DESC"; }
			else { SqlDB.Desc = string.Empty; }

			Display();
		}

		private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (comboBoxSort.SelectedItem.ToString())
			{
				case "編號":
					_sortName = "id";
					break;
				case "使用者帳號":
					_sortName = "account";
					break;
				case "生日":
					_sortName = "birthday";
					break;
				case "時間":
					_sortName = "createdTime";
					break;
			}
			Display();
		}
		private void txtCommentNum_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;

			btnSearch.Focus();
			btnSearch_Click(sender, e);
			txtCommentNum.Focus();
		}
		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;

			btnSearch.Focus();
			btnSearch_Click(sender, e);
			txtSearch.Focus();
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Owner.Show();
		}

		private void FormUsers_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Close();
			this.Owner.Show();
		}
	}
}
