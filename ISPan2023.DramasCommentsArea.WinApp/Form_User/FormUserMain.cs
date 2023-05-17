using ISPan2023.DramasCommentsArea.SqlDataLayer;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Comments;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Dramas;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Interfaces;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Repository;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Services;
using ISPan2023.DramasCommentsArea.WinApp.Form_User;
using ISPan2023.DramasCommentsArea.WinApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ISPan2023.DramasCommentsArea.WinApp.From_User
{
	public partial class FormUserMain : Form, IGrid
	{
		private List<DramasVM> dramaVM;
		private List<int> idList = new List<int>();
		private List<UsersWithComments> comVM;
		private int _userId;
		private int _dramaId;
		private string _searchDramaName;
		private string _sortName = string.Empty;
		private string _localPicturePath = "D:\\pictures\\";
		public FormUserMain(int userId)
		{
			InitializeComponent();
			_userId = userId;
			dataGridViewDramas.AutoGenerateColumns = false;
			dataGridViewUserComments.AutoGenerateColumns = false;
		}
		private void FormUserMain_Load(object sender, EventArgs e)
		{
			Display();
		}
		public void Display()
		{
			ShowDramaList();
			ShowRandomDramaPic();
			ShowComments();
			ShowPageUserDetails();
			ShowUserComments();
		}
		private void tabControl1_Selected(object sender, TabControlEventArgs e)
		{
			if (e.TabPage.Name == tabPageMain.Name)
			{
				txtSearchDrama.Text = string.Empty;
				_searchDramaName = string.Empty;
				Display();
			}
			else if (e.TabPage.Name == tabPageDramaDetail.Name)
			{
				if (_dramaId == 0)
				{
					MessageBox.Show("您還沒點選任何戲劇，請於首頁搜尋點選。","提醒");
					tabControl1.SelectedTab = tabPageMain;
				}
				else
				{
					txtComments.Text = string.Empty;
				}
			}
			else if(e.TabPage.Name == tabPageUser.Name)
			{
				ShowUserComments();
			}
			else if (e.TabPage.Name == tabPageLogout.Name)
			{
				this.Close();
				this.Owner.Show();
			}
		}
		#region Page首頁
		private void ShowDramaList()
		{
			IDramasRepository repo = new SqlDramasRepository();
			DramasService service = new DramasService(repo);

			dramaVM = service.Search(_searchDramaName, _sortName)
				.Select(x => x.ToViewModel())
				.ToList();

			dataGridViewDramas.DataSource = dramaVM;
		}
		private void txtSearchDrama_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter) return;

			_searchDramaName = txtSearchDrama.Text;
			ShowDramaList();
		}
		private void dataGridViewDramas_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			_dramaId = dramaVM[e.RowIndex].Id;

			tabControl1.SelectedTab = tabPageDramaDetail;
			panelDramaDetail.Visible = true;
			ShowDramaDetail();
			ShowComments();
			txtSearchDrama.Text = string.Empty;
		}
		private void ShowRandomDramaPic()
		{
			Random random = new Random(Guid.NewGuid().GetHashCode());
			List<int> listLinq = new List<int>(Enumerable.Range(0, dramaVM.Count));
			listLinq = listLinq.OrderBy(o => random.Next()).ToList<int>();

			int picNums = 8;
			
			idList.Clear();

			for (int i = 0; i < picNums; i++)
			{
				idList.Add(listLinq[i]);
			}

			List<PictureBox> pictureBoxes = new List<PictureBox>();
			foreach(Control pic in panelDramaShow.Controls)
			{
				if (pic is PictureBox)
				{
					pictureBoxes.Add((PictureBox)pic);
				}
			}
			for(int i = 0; i < picNums; i++)
			{
				PictureBox picbox = panelDramaShow.Controls[i] as PictureBox;
				picbox.Name = idList[i].ToString();
				string picPath = dramaVM[idList[i]].Path;
				picbox.ImageLocation = _localPicturePath + Path.GetFileName(picPath);
					
			}
		}
		private void pictureBox_Click(object sender, EventArgs e)
		{
			PictureBox picClicked = sender as PictureBox;
			_dramaId = dramaVM[int.Parse(picClicked.Name)].Id;

			tabControl1.SelectedTab = tabPageDramaDetail;
			panelDramaDetail.Visible = true;
			ShowDramaDetail();
			ShowComments();

		}

		#endregion

		#region Page戲劇資料和新增評論
		private void ShowDramaDetail()
			{
				IDramasRepository repo = new SqlDramasRepository();
				DramasService service = new DramasService(repo);
				DramasEditDto dto = service.Get(_dramaId);

				string dramaDetails = string.Empty;
				dramaDetails = "劇名：" + dto.Name + "\t集數：" + dto.Episode.ToString() + "\t播放平台：" + dto.Ott + "\r\n發行日：" + dto.PublishDate.GetDateTimeFormats('D')[0].ToString() + "\r\n編劇：" + dto.Writer + "\t導演：" + dto.Director + "\r\n主演：" + dto.Actors + "\r\n劇情大綱：" + dto.Description;

				pictureBoxDrama.ImageLocation = _localPicturePath + Path.GetFileName(dto.Path);

				txtDramaDetails.Text = dramaDetails;
			}
		private void ShowComments()
		{
			IDramasRepository repo = new SqlDramasRepository();
			List<DramasWithComments> comVM = repo.GetComments(_dramaId);

			dataGridViewComments.DataSource = comVM;
		}
		private void dataGridViewComments_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			//新增首欄並自動編號
			Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
				dataGridViewComments.RowHeadersWidth - 4, e.RowBounds.Height);
			TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
				   dataGridViewComments.RowHeadersDefaultCellStyle.Font,
				   rectangle,
				   dataGridViewComments.RowHeadersDefaultCellStyle.ForeColor,
				   TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
		}
		private void btnAddComments_Click(object sender, EventArgs e)
		{
			var checkedbtn = groupBoxScores.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
			if (checkedbtn == null)
			{
				MessageBox.Show("你沒有點選分數!", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			byte scores = byte.Parse(checkedbtn.Text);

			string content = txtComments.Text;
			if (content.Length < 10)
			{
				MessageBox.Show("評論內容請大於10個字!", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DialogResult result = MessageBox.Show("確定新增評論?送出後即不能修改喔!", "提醒", MessageBoxButtons.OKCancel);
			if (result == DialogResult.Cancel) { return; }

			CommentsAddDto dto = new CommentsAddDto()
			{
				Scores = scores,
				Contents = content,
				CreatedTime = DateTime.Now,
				DramaId = _dramaId,
				UserId = _userId
			};

			ICommentsRepository repo = new SqlCommentsRepository();
			CommentsService service = new CommentsService(repo);

			try
			{
				service.Create(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，因為" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			MessageBox.Show("新增成功!");

			MessageBox.Show("評論完成!", "提醒", MessageBoxButtons.OK);
			txtComments.Text = string.Empty;
			ShowComments();
			}
		#endregion

		#region Page會員資料
		private void ShowPageUserDetails()
		{
			IUsersRepository repo = new SqlUsersRepository();
			UsersService service = new UsersService(repo);
			UsersEditDto dto = service.Get(_userId);

			txtAccount.Text = dto.Account;
			txtPassword.Text = dto.Password;

			if (dto.Gender == false)
			{
				rbMan.Checked = true;
			}
			else
			{
				rbWoman.Checked = true;
			}

			dateTimePickerBD.Value = dto.Birthday;
			txtMail.Text = dto.Mail;
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			dateTimePickerBD.Enabled = true;
			txtMail.Enabled = true;
			btnEditCheck.Visible = true;
			btnEditCancel.Visible = true;
			btnEdit.Visible = false;
		}
		private void btnEditCheck_Click(object sender, EventArgs e)
		{
			UsersEditDto dto = new UsersEditDto()
			{
				Id = _userId,
				Password = txtPassword.Text,
				Birthday = dateTimePickerBD.Value,
				Mail = txtMail.Text
			};

			IUsersRepository repo = new SqlUsersRepository();
			UsersService service = new UsersService(repo);

			try
			{
				service.Update(dto);
				MessageBox.Show("更新成功!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗，原因:" + ex.Message);
				return;
			}

			dateTimePickerBD.Enabled = false;
			txtMail.Enabled = false;
			btnEdit.Visible = true;
			btnEditCheck.Visible = false;
			btnEditCancel.Visible = false;
		}
		private void btnEditCancel_Click(object sender, EventArgs e)
		{
			dateTimePickerBD.Enabled = false;
			txtMail.Enabled = false;
			btnEdit.Visible = true;
			btnEditCheck.Visible = false;
			btnEditCancel.Visible = false;
		}
		private void btnEditPassword_Click(object sender, EventArgs e)
		{
			var frm = new FormEditPassword(_userId, this.txtPassword.Text);
			frm.Owner = this;
			frm.ShowDialog();
		}
		private void ShowUserComments()
		{
			IUsersRepository repo = new SqlUsersRepository();
			comVM = repo.GetUserComments(_userId);

			dataGridViewUserComments.DataSource = comVM;
			//dataGridViewUserComments.Columns["DramaId"].Visible = false;
			dataGridViewUserComments.AutoGenerateColumns = false;
		}
		private void dataGridViewUserComments_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			//新增首欄並自動編號
			Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
				dataGridViewUserComments.RowHeadersWidth - 4, e.RowBounds.Height);
			TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
				   dataGridViewUserComments.RowHeadersDefaultCellStyle.Font,
				   rectangle,
				   dataGridViewUserComments.RowHeadersDefaultCellStyle.ForeColor,
				   TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
		}
		private void dataGridViewUserComments_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			_dramaId = comVM[e.RowIndex].DramaId;

			tabControl1.SelectedTab = tabPageDramaDetail;
			panelDramaDetail.Visible = true;
			ShowDramaDetail();

			txtComments.Text = string.Empty;
			ShowComments();
		}
		#endregion
		private void FormUserMain_FormClosing(object sender, FormClosingEventArgs e)
		{
				this.Owner.Show();
		}

		
	}
}
