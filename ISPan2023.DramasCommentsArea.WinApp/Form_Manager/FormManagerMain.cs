using ISPan2023.DramasCommentsArea.SqlDataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPan2023.DramasCommentsArea.WinApp
{
	public partial class FormManagerMain : Form
	{
		public FormManagerMain()
		{
			InitializeComponent();
		}
		private void btnDramas_Click(object sender, EventArgs e)
		{
			var frm = new FormDramasCRUD();
			frm.Owner = this;
			this.Hide();
			frm.ShowDialog();
		}
		private void btnComments_Click(object sender, EventArgs e)
		{
			var frm = new FormComments();
			frm.Owner = this;
			this.Hide();
			frm.ShowDialog();
		}
		private void btnUsers_Click(object sender, EventArgs e)
		{
			var frm = new FormUsers();
			frm.Owner = this;
			this.Hide();
			frm.ShowDialog();
		}

		private void FormManagerMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Owner.Show();
		}
	}
}
