namespace ISPan2023.DramasCommentsArea.WinApp
{
	partial class FormDramasAdd
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
			this.lblIsUpload = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.ckbCategories = new System.Windows.Forms.CheckedListBox();
			this.label9 = new System.Windows.Forms.Label();
			this.ckbOtts = new System.Windows.Forms.CheckedListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "名稱：";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(76, 12);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 29);
			this.txtName.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(214, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 22);
			this.label2.TabIndex = 0;
			this.label2.Text = "集數：";
			// 
			// txtEpisode
			// 
			this.txtEpisode.Location = new System.Drawing.Point(278, 12);
			this.txtEpisode.Name = "txtEpisode";
			this.txtEpisode.Size = new System.Drawing.Size(44, 29);
			this.txtEpisode.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(349, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 22);
			this.label3.TabIndex = 0;
			this.label3.Text = "發行日：";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(429, 11);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
			this.dateTimePicker1.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 22);
			this.label4.TabIndex = 0;
			this.label4.Text = "編劇：";
			// 
			// txtWriter
			// 
			this.txtWriter.Location = new System.Drawing.Point(76, 59);
			this.txtWriter.Name = "txtWriter";
			this.txtWriter.Size = new System.Drawing.Size(100, 29);
			this.txtWriter.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(214, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 22);
			this.label5.TabIndex = 0;
			this.label5.Text = "導演：";
			// 
			// txtDirector
			// 
			this.txtDirector.Location = new System.Drawing.Point(278, 56);
			this.txtDirector.Name = "txtDirector";
			this.txtDirector.Size = new System.Drawing.Size(100, 29);
			this.txtDirector.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 110);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 22);
			this.label6.TabIndex = 0;
			this.label6.Text = "主演：";
			// 
			// txtActors
			// 
			this.txtActors.Location = new System.Drawing.Point(76, 106);
			this.txtActors.Name = "txtActors";
			this.txtActors.Size = new System.Drawing.Size(275, 29);
			this.txtActors.TabIndex = 6;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnUploadPic
			// 
			this.btnUploadPic.Location = new System.Drawing.Point(489, 60);
			this.btnUploadPic.Name = "btnUploadPic";
			this.btnUploadPic.Size = new System.Drawing.Size(140, 36);
			this.btnUploadPic.TabIndex = 5;
			this.btnUploadPic.Text = "上傳封面照片";
			this.btnUploadPic.UseVisualStyleBackColor = true;
			this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(669, 11);
			this.pictureBox1.MaximumSize = new System.Drawing.Size(220, 260);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(220, 260);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// lblIsUpload
			// 
			this.lblIsUpload.AutoSize = true;
			this.lblIsUpload.Location = new System.Drawing.Point(516, 113);
			this.lblIsUpload.Name = "lblIsUpload";
			this.lblIsUpload.Size = new System.Drawing.Size(113, 22);
			this.lblIsUpload.TabIndex = 5;
			this.lblIsUpload.Text = "lblIsUpload";
			this.lblIsUpload.Visible = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 166);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 22);
			this.label7.TabIndex = 0;
			this.label7.Text = "大綱：";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(76, 163);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescription.Size = new System.Drawing.Size(510, 115);
			this.txtDescription.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 305);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 22);
			this.label8.TabIndex = 0;
			this.label8.Text = "類別：";
			// 
			// ckbCategories
			// 
			this.ckbCategories.ColumnWidth = 150;
			this.ckbCategories.FormattingEnabled = true;
			this.ckbCategories.Location = new System.Drawing.Point(76, 305);
			this.ckbCategories.MultiColumn = true;
			this.ckbCategories.Name = "ckbCategories";
			this.ckbCategories.Size = new System.Drawing.Size(748, 76);
			this.ckbCategories.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 424);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 44);
			this.label9.TabIndex = 0;
			this.label9.Text = "OTT\r\n平台：";
			// 
			// ckbOtts
			// 
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
			this.ckbOtts.Location = new System.Drawing.Point(76, 408);
			this.ckbOtts.MultiColumn = true;
			this.ckbOtts.Name = "ckbOtts";
			this.ckbOtts.Size = new System.Drawing.Size(748, 76);
			this.ckbOtts.TabIndex = 9;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(211, 502);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(140, 36);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "新增";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// FormDramasAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(919, 553);
			this.Controls.Add(this.ckbOtts);
			this.Controls.Add(this.ckbCategories);
			this.Controls.Add(this.lblIsUpload);
			this.Controls.Add(this.pictureBox1);
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
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtWriter);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("源石黑體 R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "FormDramasAdd";
			this.Text = "新增戲劇資料";
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
		private System.Windows.Forms.Label lblIsUpload;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckedListBox ckbCategories;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckedListBox ckbOtts;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}