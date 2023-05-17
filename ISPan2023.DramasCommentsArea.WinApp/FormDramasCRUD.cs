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
	public partial class FormDramasCRUD : Form, IGrid
	{
		private List<DramasVM> vm;
		public FormDramasCRUD()
		{
			InitializeComponent();
		}
		public void Display()
		{
			string searchText = txtSearch.Text;

			IDramasRepository repo = new SqlDramasRepository();
			DramasService service = new DramasService(repo);

			//List<CategoryDto> data = service.Search(name, id);

			vm = service.Search(searchText)
				.Select(x => x.ToViewModel())
				.ToList();

			dataGridViewDramas.DataSource = vm;

		}
		private void FormDramasCRUD_Load(object sender, EventArgs e)
		{
			Display();
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			Display();
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			var frm = new FormDramasAdd();
			frm.Owner = this;
			frm.ShowDialog();
		}

		private void dataGridViewDramas_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
