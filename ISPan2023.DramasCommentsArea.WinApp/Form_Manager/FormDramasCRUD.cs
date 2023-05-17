using ISPan2023.DramasCommentsArea.SqlDataLayer;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ISPan2023.DramasCommentsArea.WinApp
{
	public partial class FormDramasCRUD : Form, IGrid
	{
		private List<DramasVM> vm;
		private string _sortName = string.Empty;
		public FormDramasCRUD()
		{
			InitializeComponent();
			dataGridViewDramas.AutoGenerateColumns = false;
		}
		public void Display()
		{
			string searchText = txtSearch.Text;

			IDramasRepository repo = new SqlDramasRepository();
			DramasService service = new DramasService(repo);

			vm = service.Search(searchText, _sortName)
				.Select(x => x.ToViewModel())
				.ToList();

			dataGridViewDramas.DataSource = vm;

		}
		private void FormDramasCRUD_Load(object sender, EventArgs e)
		{
			Display();
		}
		private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (comboBoxSort.SelectedItem.ToString())
			{
				case "編號":
					_sortName = "id";
					break;
				case "發行日期":
					_sortName = "publishDate";
					break;
				case "集數":
					_sortName = "episode";
					break;
				case "劇名":
					_sortName = "name";
					break;
			}

			Display();
		}
		private void ckbDesc_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbDesc.Checked) { SqlDB.Desc = " DESC"; }
			else { SqlDB.Desc = string.Empty; }

			Display();
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			Display();
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			var frm = new FormDramasAED(null);
			frm.Owner = this;
			this.Hide();
			frm.ShowDialog();
		}
		private void dataGridViewDramas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			int categoryId = vm[e.RowIndex].Id;

			var frm = new FormDramasAED(categoryId);
			frm.Owner = this;
			this.Hide();
			frm.ShowDialog();
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

		private void FormDramasCRUD_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Close();
			this.Owner.Show();
		}
	}
}
