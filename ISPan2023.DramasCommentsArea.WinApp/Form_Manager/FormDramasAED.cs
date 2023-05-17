using ISPan2023.DramasCommentsArea.SqlDataLayer;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Dramas;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Interfaces;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Repository;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Services;
using ISPan2023.DramasCommentsArea.WinApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPan2023.DramasCommentsArea.WinApp
{
	public partial class FormDramasAED : Form
	{
		private readonly int _dramaId;
		private string _path = "D:\\pictures\\";
		public FormDramasAED(int? dramaId)
		{
			InitializeComponent();
			_dramaId = dramaId.HasValue ? dramaId.Value : 0;
		}
		private void FormDramasAED_Load(object sender, EventArgs e)
		{
			if (_dramaId == 0)
			{
				btnEdit.Visible = false;
				btnDelete.Visible = false;
				return;
			}
			else
			{
				btnAdd.Visible = false;
				btnEdit.Visible = true;
				btnDelete.Visible = true;
			}

			IDramasRepository repo = new SqlDramasRepository();
			DramasService service = new DramasService(repo);

			DramasEditDto dto = service.Get(this._dramaId);
			DramasEditVM vm = dto.ToViewModel();

			txtName.Text = vm.Name;
			txtEpisode.Text = vm.Episode.ToString();
			dateTimePicker1.Value = vm.PublishDate;
			txtWriter.Text = vm.Writer;
			txtDirector.Text = vm.Director;
			txtActors.Text = vm.Actors;

			_path += vm.Path;
			pictureBox1.ImageLocation = _path;
			txtDescription.Text = vm.Description;
			//string categories;

			string[] list = vm.Ott.Split(',');
			for (int i = 0; i < list.Length; i++)
			{
				for (int j = 0; j < ckbOtts.Items.Count; j++)
				{
					if (ckbOtts.Items[j].ToString().ToLower() == list[i].ToLower())
					{
						ckbOtts.SetItemChecked(j, true);
						continue;
					}
				}
			}
		}
		private void btnUploadPic_Click(object sender, EventArgs e)
		{
			OpenLoadImgFile();
		}
		private void OpenLoadImgFile()
		{
			OpenFileDialog openPic = new OpenFileDialog();

			openPic.RestoreDirectory = true;
			openPic.InitialDirectory = @"C:\\";
			openPic.Title = "上傳封面照片";

			openPic.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";

			if (openPic.ShowDialog() == DialogResult.OK && openPic.FileName != null)
			{
				pictureBox1.ImageLocation = openPic.FileName;
				_path = Path.GetFileName(openPic.FileName);
			}
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			bool isInt = int.TryParse(txtEpisode.Text, out int episode);
			if (isInt == false)
			{
				episode = 0;
			}
			DateTime publishDate = dateTimePicker1.Value.Date;
			string writer = txtWriter.Text;
			string director = txtDirector.Text;
			string actors = txtActors.Text;

			string path;
			if (pictureBox1.ImageLocation != null) { path = _path; }
			else { path = string.Empty; }
			
			string description = txtDescription.Text;
			//string categories;
			string ott = string.Empty;
			foreach(var i in ckbOtts.CheckedItems)
			{
				ott += i.ToString() + ",";
			}
			ott = ott.TrimEnd(',');

			DramasAddVM vm = new DramasAddVM()
			{
				Name = name,
				Episode = episode,
				PublishDate = publishDate,
				Ott = ott,
				Description = description,
				Writer = writer,
				Director = director,
				Actors = actors,
				Path = path
			};

			// 針對view model 進行欄位驗證, 如果有錯誤就顯示錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			DialogResult result = MessageBox.Show("確定要新增嗎?", "提醒", MessageBoxButtons.OKCancel);
			if (result == DialogResult.Cancel) { return; }

			//將vm轉換成dto
			DramasAddDto dto = vm.ToAddDto();

			IDramasRepository repo = new SqlDramasRepository();
			DramasService service = new DramasService(repo);

			try
			{
				service.Create(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗，因為" + ex.Message, "錯誤");
				return;
			}

			//新增完成，關閉自己，並通知owner更新內容
			IGrid owner = this.Owner as IGrid;
			if (owner == null)
			{
				MessageBox.Show("你忘了做interface");
			}
			owner.Display();

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單
		}
		#region 欄位驗證
		private (bool isValid, List<ValidationResult> errors) Validate(DramasAddVM vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}
		private (bool isValid, List<ValidationResult> errors) Validate(DramasEditVM vm)
		{
			// 得知要驗證規則
			ValidationContext context = new ValidationContext(vm, null, null);

			// 用來存放錯誤的集合,因為可能有零到多個錯誤
			List<ValidationResult> errors = new List<ValidationResult>();

			// 驗證 model
			bool validateAllProperties = true; // 是否驗證所有規則,而非只驗證Required規則
			bool isValid = Validator.TryValidateObject(vm, context, errors, validateAllProperties);

			return (isValid, errors);
		}
		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Name", txtName},
				{"Episode", txtEpisode},
				{"PublishDate", dateTimePicker1},
				{"Ott", ckbOtts},
				{"Description", txtDescription},
				{"Writer", txtWriter},
				{"Director", txtDirector},
				{"Actors", txtActors},
				{"Path", pictureBox1}
			};

			this.errorProvider1.Clear();

			foreach (ValidationResult error in errors)
			{
				string propName = error.MemberNames.FirstOrDefault();
				if (propName != null && map.TryGetValue(propName, out Control ctrl))
				{
					this.errorProvider1.SetError(ctrl, error.ErrorMessage);
				}
			}
		}
		#endregion
		private void btnEdit_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			bool isInt = int.TryParse(txtEpisode.Text, out int episode);
			if (isInt == false)
			{
				episode = 0;
			}
			DateTime publishDate = dateTimePicker1.Value.Date;
			string writer = txtWriter.Text;
			string director = txtDirector.Text;
			string actors = txtActors.Text;
			string path = _path;
			string description = txtDescription.Text;
			//string categories;
			string ott = string.Empty;
			foreach (var i in ckbOtts.CheckedItems)
			{
				ott += i.ToString() + ",";
			}
			ott = ott.TrimEnd(',');

			DramasEditVM vm = new DramasEditVM()
			{
				Id = _dramaId,
				Name = name,
				Episode = episode,
				PublishDate = publishDate,
				Ott = ott,
				Description = description,
				Writer = writer,
				Director = director,
				Actors = actors,
				Path = path
			};

			// 針對view model 進行欄位驗證, 如果有錯誤就顯示錯誤訊息
			(bool isValid, List<ValidationResult> errors) validationResult = Validate(vm);

			if (validationResult.isValid == false)
			{
				this.errorProvider1.Clear();
				DisplayErrors(validationResult.errors);
				return;
			}

			DialogResult result = MessageBox.Show("確定要修改?", "提醒", MessageBoxButtons.OKCancel);
			if (result == DialogResult.Cancel) { return; }

			//將vm轉換成dto
			DramasEditDto dto = vm.ToEditDto();

			IDramasRepository repo = new SqlDramasRepository();
			DramasService service = new DramasService(repo);

			try
			{
				service.Update(dto);
			}
			catch (Exception ex)
			{
				MessageBox.Show("更新失敗，原因:" + ex.Message);
				return;
			}

			//ubdate完成，關閉自己，並通知owner更新內容
			IGrid owner = this.Owner as IGrid;
			if (owner == null)
			{
				MessageBox.Show("你忘了做interface");
			}
			owner.Display();

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			IDramasRepository repo = new SqlDramasRepository();
			DramasService service = new DramasService(repo);

			try
			{
				MessageBox.Show("確定要刪除嗎?", "提醒", MessageBoxButtons.YesNo);
				service.Delete(_dramaId);
			}
			catch (Exception ex)
			{
				return;
			}

			//Delete完成，關閉自己，並通知owner更新內容
			IGrid owner = this.Owner as IGrid;
			if (owner == null)
			{
				MessageBox.Show("你忘了做interface");
			}
			owner.Display();

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單
		}

		private void FormDramasAED_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Owner.Show();
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
