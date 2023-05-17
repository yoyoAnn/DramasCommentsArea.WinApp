namespace ISPan2023.DramasCommentsArea.WinApp
{
	partial class FormDramasAED
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDramasAED));
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEpisode = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.txtWriter = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDirector = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtActors = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnUploadPic = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.ckbOtts = new System.Windows.Forms.CheckedListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "名稱：";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(72, 14);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(202, 26);
			this.txtName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(304, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "集數：";
			// 
			// txtEpisode
			// 
			this.txtEpisode.Location = new System.Drawing.Point(371, 14);
			this.txtEpisode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEpisode.Name = "txtEpisode";
			this.txtEpisode.Size = new System.Drawing.Size(112, 26);
			this.txtEpisode.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(510, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "發行日：";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(600, 14);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(182, 26);
			this.dateTimePicker1.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "編劇：";
			// 
			// txtWriter
			// 
			this.txtWriter.Location = new System.Drawing.Point(72, 51);
			this.txtWriter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtWriter.Name = "txtWriter";
			this.txtWriter.Size = new System.Drawing.Size(202, 26);
			this.txtWriter.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(304, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 19);
			this.label5.TabIndex = 0;
			this.label5.Text = "導演：";
			// 
			// txtDirector
			// 
			this.txtDirector.Location = new System.Drawing.Point(371, 51);
			this.txtDirector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDirector.Name = "txtDirector";
			this.txtDirector.Size = new System.Drawing.Size(202, 26);
			this.txtDirector.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(9, 90);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 19);
			this.label6.TabIndex = 0;
			this.label6.Text = "主演：";
			// 
			// txtActors
			// 
			this.txtActors.Location = new System.Drawing.Point(72, 88);
			this.txtActors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtActors.Name = "txtActors";
			this.txtActors.Size = new System.Drawing.Size(503, 26);
			this.txtActors.TabIndex = 6;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnUploadPic
			// 
			this.btnUploadPic.BackColor = System.Drawing.Color.PowderBlue;
			this.btnUploadPic.Location = new System.Drawing.Point(681, 53);
			this.btnUploadPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUploadPic.Name = "btnUploadPic";
			this.btnUploadPic.Size = new System.Drawing.Size(115, 37);
			this.btnUploadPic.TabIndex = 5;
			this.btnUploadPic.Text = "上傳照片";
			this.btnUploadPic.UseVisualStyleBackColor = false;
			this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(600, 94);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(272, 346);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(9, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 19);
			this.label7.TabIndex = 0;
			this.label7.Text = "大綱：";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(72, 137);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescription.Size = new System.Drawing.Size(503, 149);
			this.txtDescription.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(9, 298);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(69, 38);
			this.label9.TabIndex = 0;
			this.label9.Text = "播放\r\n平台：";
			// 
			// ckbOtts
			// 
			this.ckbOtts.BackColor = System.Drawing.Color.PowderBlue;
			this.ckbOtts.CheckOnClick = true;
			this.ckbOtts.ColumnWidth = 180;
			this.ckbOtts.FormattingEnabled = true;
			this.ckbOtts.Items.AddRange(new object[] {
            "Netflix",
            "Disney+",
            "愛奇藝",
            "friDay影音",
            "KKTV",
            "LiTV",
            "CATCHPLAY",
            "Line TV",
            "myVideo",
            "Hami Video",
            "HBO GO",
            "ELTA OTT"});
			this.ckbOtts.Location = new System.Drawing.Point(72, 296);
			this.ckbOtts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ckbOtts.MultiColumn = true;
			this.ckbOtts.Name = "ckbOtts";
			this.ckbOtts.Size = new System.Drawing.Size(503, 109);
			this.ckbOtts.TabIndex = 9;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Khaki;
			this.btnAdd.Location = new System.Drawing.Point(115, 418);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(127, 28);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "確認新增";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.PowderBlue;
			this.btnEdit.Location = new System.Drawing.Point(265, 418);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(127, 28);
			this.btnEdit.TabIndex = 10;
			this.btnEdit.Text = "修改送出";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.LightSlateGray;
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnDelete.Location = new System.Drawing.Point(419, 418);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(127, 28);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "刪除";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
			this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnReturn.Font = new System.Drawing.Font("華康中圓體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnReturn.Location = new System.Drawing.Point(814, 14);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(58, 42);
			this.btnReturn.TabIndex = 5;
			this.btnReturn.UseVisualStyleBackColor = false;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// FormDramasAED
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(896, 461);
			this.Controls.Add(this.ckbOtts);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnUploadPic);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.txtEpisode);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDirector);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtActors);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtWriter);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("華康中圓體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.Name = "FormDramasAED";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "新增戲劇資料";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDramasAED_FormClosed);
			this.Load += new System.EventHandler(this.FormDramasAED_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEpisode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtWriter;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDirector;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtActors;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnUploadPic;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckedListBox ckbOtts;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnReturn;
	}
}