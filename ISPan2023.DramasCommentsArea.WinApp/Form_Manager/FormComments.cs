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

namespace ISPan2023.DramasCommentsArea.WinApp
{
	public partial class FormComments : Form
	{
		private List<CommentsVM> vm;
		private string _sortName = string.Empty;
		private byte _scores = 0;
		public FormComments()
		{
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
		}
		private void FormComments_Load(object sender, EventArgs e)
		{
			Display();
		}
		public void Display()
		{
			string searchText = txtSearch.Text;

			ICommentsRepository repo = new SqlCommentsRepository();
			CommentsService service = new CommentsService(repo);

			vm = service.Search(searchText, _sortName, _scores)
				.Select(x => x.ToViewModel())
				.ToList();

			dataGridView1.DataSource = vm;
		}
		private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (comboBoxSort.SelectedItem.ToString())
			{
				case "編號":
					_sortName = "id";
					break;
				case "分數":
					_sortName = "scores";
					break;
				case "劇名":
					_sortName = "name";
					break;
				case "時間":
					_sortName = "createdTime";
					break;
			}

			Display();
		}
		private void txtSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;

			btnSearch.Focus();
			btnSearch_Click(sender, e);
			txtSearch.Focus();
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
		private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			//新增首欄並自動編號
			Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
				dataGridView1.RowHeadersWidth - 10, e.RowBounds.Height);
			TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
				   dataGridView1.RowHeadersDefaultCellStyle.Font,
				   rectangle,
				   dataGridView1.RowHeadersDefaultCellStyle.ForeColor,
				   TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
		}
		#region RadioButton
		private void rb5_CheckedChanged(object sender, EventArgs e)
		{
			_scores = 5;
			Display();
		}
		private void rb4_CheckedChanged(object sender, EventArgs e)
		{
			_scores = 4;
			Display();
		}
		private void rb3_CheckedChanged(object sender, EventArgs e)
		{
			_scores = 3;
			Display();
		}
		private void rb2_CheckedChanged(object sender, EventArgs e)
		{
			_scores = 2;
			Display();
		}
		private void rb1_CheckedChanged(object sender, EventArgs e)
		{
			_scores = 1;
			Display();
		}
		private void rbAll_CheckedChanged(object sender, EventArgs e)
		{
			_scores = 0;
			Display();
		}

		#endregion
		private void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Owner.Show();
		}

		private void FormComments_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Close();
			this.Owner.Show();
		}
	}
}
