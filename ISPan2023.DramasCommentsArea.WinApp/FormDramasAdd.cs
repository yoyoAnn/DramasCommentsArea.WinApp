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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPan2023.DramasCommentsArea.WinApp
{
	public partial class FormDramasAdd : Form
	{
		private string _path;
		public FormDramasAdd()
		{
			InitializeComponent();
		}

		private void btnUploadPic_Click(object sender, EventArgs e)
		{
			string path = OpenLoadImgFile();
			if (path != null)
			{
				lblIsUpload.Visible = true;
				lblIsUpload.Text = "上傳完成!";
				pictureBox1.ImageLocation = path;
				_path = path;
			}
		}
		private string OpenLoadImgFile()
		{
			OpenFileDialog openPic = new OpenFileDialog();

			openPic.RestoreDirectory = true;
			openPic.InitialDirectory = @".\Picture";
			openPic.Title = "上傳封面照片";

			openPic.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";

			if (openPic.ShowDialog() == DialogResult.OK && openPic.FileName != null)
			{
				return openPic.FileName;
			}
			else
			{
				return null;
			}
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			bool isInt = int.TryParse(txtEpisode.Text, out int episode);
			if (isInt == false)
			{
				MessageBox.Show("集數必須輸入整數");
				return;
			}
			DateTime publishDate = dateTimePicker1.Value.Date;
			string writer = txtWriter.Text;
			string director = txtDirector.Text;
			string actors = txtActors.Text;
			string path = _path;
			string description = txtDescription.Text;
			string categories;
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

			//將vm轉換成dto
			DramasAddDto dto = vm.ToAddDto();

			IDramasRepository repo = new SqlDramasRepository();
			DramasService service = new DramasService(repo);

			service.Create(dto);

			//新增完成，關閉自己，並通知owner更新內容
			//IGrid owner = (IGrid)this.Owner;
			IGrid owner = this.Owner as IGrid;
			if (owner == null)
			{
				MessageBox.Show("你忘了做interface");
			}
			owner.Display();

			this.DialogResult = DialogResult.OK;//寫這個，會自動關閉本表單
		}
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
		private void DisplayErrors(List<ValidationResult> errors)
		{
			// 大小寫不同仍視為相同的key
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"名稱", txtName},
				{"集數", txtEpisode},
				{"發行日", dateTimePicker1},
				{"OTT平台", ckbOtts},
				{"大綱", txtDescription},
				{"編劇", txtWriter},
				{"導演", txtDirector},
				{"演員", txtActors},
				{"封面", pictureBox1}
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
	}
}
