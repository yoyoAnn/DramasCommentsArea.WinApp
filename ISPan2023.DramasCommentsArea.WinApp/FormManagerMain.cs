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
			frm.ShowDialog();
		}
	}
}
