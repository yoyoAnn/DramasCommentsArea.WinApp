namespace ISPan2023.DramasCommentsArea.WinApp
{
	partial class FormComments
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComments));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ckbDesc = new System.Windows.Forms.CheckBox();
			this.comboBoxSort = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbAll = new System.Windows.Forms.RadioButton();
			this.rb1 = new System.Windows.Forms.RadioButton();
			this.rb2 = new System.Windows.Forms.RadioButton();
			this.rb3 = new System.Windows.Forms.RadioButton();
			this.rb4 = new System.Windows.Forms.RadioButton();
			this.rb5 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.btnReturn = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ckbDesc
			// 
			this.ckbDesc.AutoSize = true;
			this.ckbDesc.Font = new System.Drawing.Font("華康中圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ckbDesc.Location = new System.Drawing.Point(256, 25);
			this.ckbDesc.Margin = new System.Windows.Forms.Padding(5);
			this.ckbDesc.Name = "ckbDesc";
			this.ckbDesc.Size = new System.Drawing.Size(58, 20);
			this.ckbDesc.TabIndex = 15;
			this.ckbDesc.Text = "遞減";
			this.ckbDesc.UseVisualStyleBackColor = true;
			this.ckbDesc.CheckedChanged += new System.EventHandler(this.ckbDesc_CheckedChanged);
			// 
			// comboBoxSort
			// 
			this.comboBoxSort.FormattingEnabled = true;
			this.comboBoxSort.Items.AddRange(new object[] {
            "編號",
            "分數",
            "劇名",
            "評論時間"});
			this.comboBoxSort.Location = new System.Drawing.Point(132, 20);
			this.comboBoxSort.Margin = new System.Windows.Forms.Padding(5);
			this.comboBoxSort.Name = "comboBoxSort";
			this.comboBoxSort.Size = new System.Drawing.Size(114, 27);
			this.comboBoxSort.TabIndex = 14;
			this.comboBoxSort.Text = "編號";
			this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
			this.dataGridView1.Location = new System.Drawing.Point(10, 59);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(960, 488);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(329, 21);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(130, 26);
			this.txtSearch.TabIndex = 11;
			this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.PowderBlue;
			this.btnSearch.Font = new System.Drawing.Font("華康中圓體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSearch.Location = new System.Drawing.Point(469, 17);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(101, 32);
			this.btnSearch.TabIndex = 9;
			this.btnSearch.Text = "劇名搜尋";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbAll);
			this.groupBox1.Controls.Add(this.rb1);
			this.groupBox1.Controls.Add(this.rb2);
			this.groupBox1.Controls.Add(this.rb3);
			this.groupBox1.Controls.Add(this.rb4);
			this.groupBox1.Controls.Add(this.rb5);
			this.groupBox1.Font = new System.Drawing.Font("華康中圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox1.Location = new System.Drawing.Point(601, 3);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox1.Size = new System.Drawing.Size(274, 51);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "分數篩選";
			// 
			// rbAll
			// 
			this.rbAll.AutoSize = true;
			this.rbAll.Location = new System.Drawing.Point(223, 23);
			this.rbAll.Margin = new System.Windows.Forms.Padding(5);
			this.rbAll.Name = "rbAll";
			this.rbAll.Size = new System.Drawing.Size(49, 20);
			this.rbAll.TabIndex = 0;
			this.rbAll.TabStop = true;
			this.rbAll.Text = "All";
			this.rbAll.UseVisualStyleBackColor = true;
			this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
			// 
			// rb1
			// 
			this.rb1.AutoSize = true;
			this.rb1.Location = new System.Drawing.Point(180, 23);
			this.rb1.Margin = new System.Windows.Forms.Padding(5);
			this.rb1.Name = "rb1";
			this.rb1.Size = new System.Drawing.Size(33, 20);
			this.rb1.TabIndex = 0;
			this.rb1.TabStop = true;
			this.rb1.Text = "1";
			this.rb1.UseVisualStyleBackColor = true;
			this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
			// 
			// rb2
			// 
			this.rb2.AutoSize = true;
			this.rb2.Location = new System.Drawing.Point(137, 23);
			this.rb2.Margin = new System.Windows.Forms.Padding(5);
			this.rb2.Name = "rb2";
			this.rb2.Size = new System.Drawing.Size(33, 20);
			this.rb2.TabIndex = 0;
			this.rb2.TabStop = true;
			this.rb2.Text = "2";
			this.rb2.UseVisualStyleBackColor = true;
			this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
			// 
			// rb3
			// 
			this.rb3.AutoSize = true;
			this.rb3.Location = new System.Drawing.Point(96, 23);
			this.rb3.Margin = new System.Windows.Forms.Padding(5);
			this.rb3.Name = "rb3";
			this.rb3.Size = new System.Drawing.Size(33, 20);
			this.rb3.TabIndex = 0;
			this.rb3.TabStop = true;
			this.rb3.Text = "3";
			this.rb3.UseVisualStyleBackColor = true;
			this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
			// 
			// rb4
			// 
			this.rb4.AutoSize = true;
			this.rb4.Location = new System.Drawing.Point(53, 23);
			this.rb4.Margin = new System.Windows.Forms.Padding(5);
			this.rb4.Name = "rb4";
			this.rb4.Size = new System.Drawing.Size(33, 20);
			this.rb4.TabIndex = 0;
			this.rb4.TabStop = true;
			this.rb4.Text = "4";
			this.rb4.UseVisualStyleBackColor = true;
			this.rb4.CheckedChanged += new System.EventHandler(this.rb4_CheckedChanged);
			// 
			// rb5
			// 
			this.rb5.AutoSize = true;
			this.rb5.Location = new System.Drawing.Point(10, 23);
			this.rb5.Margin = new System.Windows.Forms.Padding(5);
			this.rb5.Name = "rb5";
			this.rb5.Size = new System.Drawing.Size(33, 20);
			this.rb5.TabIndex = 0;
			this.rb5.TabStop = true;
			this.rb5.Text = "5";
			this.rb5.UseVisualStyleBackColor = true;
			this.rb5.CheckedChanged += new System.EventHandler(this.rb5_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("華康中圓體", 16F);
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 22);
			this.label1.TabIndex = 17;
			this.label1.Text = "排序依據：";
			// 
			// btnReturn
			// 
			this.btnReturn.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
			this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnReturn.Font = new System.Drawing.Font("華康中圓體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnReturn.Location = new System.Drawing.Point(912, 12);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(58, 42);
			this.btnReturn.TabIndex = 5;
			this.btnReturn.UseVisualStyleBackColor = false;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "dramaName";
			this.Column1.HeaderText = "劇名";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 74;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.Column2.DataPropertyName = "scores";
			this.Column2.HeaderText = "分數";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 74;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.DataPropertyName = "contents";
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Column3.DefaultCellStyle = dataGridViewCellStyle6;
			this.Column3.HeaderText = "評論內容";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "createdTime";
			this.Column4.HeaderText = "評論時間";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 114;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "UserAccount";
			this.Column6.HeaderText = "評論者";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 94;
			// 
			// FormComments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ckbDesc);
			this.Controls.Add(this.comboBoxSort);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnSearch);
			this.Font = new System.Drawing.Font("華康中圓體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.Name = "FormComments";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "評論查詢";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormComments_FormClosed);
			this.Load += new System.EventHandler(this.FormComments_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox ckbDesc;
		private System.Windows.Forms.ComboBox comboBoxSort;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rb1;
		private System.Windows.Forms.RadioButton rb2;
		private System.Windows.Forms.RadioButton rb3;
		private System.Windows.Forms.RadioButton rb4;
		private System.Windows.Forms.RadioButton rb5;
		private System.Windows.Forms.RadioButton rbAll;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
	}
}