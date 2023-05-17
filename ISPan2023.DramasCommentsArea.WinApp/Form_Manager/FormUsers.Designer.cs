namespace ISPan2023.DramasCommentsArea.WinApp
{
	partial class FormUsers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtCommentNum = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ckbDesc = new System.Windows.Forms.CheckBox();
			this.comboBoxSort = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.btnReturn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(483, 21);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(164, 26);
			this.txtSearch.TabIndex = 3;
			this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.PowderBlue;
			this.btnSearch.Font = new System.Drawing.Font("華康中圓體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSearch.Location = new System.Drawing.Point(657, 17);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(109, 36);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "用戶搜尋";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtCommentNum
			// 
			this.txtCommentNum.Location = new System.Drawing.Point(1125, 81);
			this.txtCommentNum.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.txtCommentNum.Name = "txtCommentNum";
			this.txtCommentNum.Size = new System.Drawing.Size(164, 26);
			this.txtCommentNum.TabIndex = 3;
			this.txtCommentNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommentNum_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1028, 86);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "評論數>=";
			// 
			// ckbDesc
			// 
			this.ckbDesc.AutoSize = true;
			this.ckbDesc.Font = new System.Drawing.Font("華康中圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ckbDesc.Location = new System.Drawing.Point(328, 25);
			this.ckbDesc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.ckbDesc.Name = "ckbDesc";
			this.ckbDesc.Size = new System.Drawing.Size(58, 20);
			this.ckbDesc.TabIndex = 8;
			this.ckbDesc.Text = "遞減";
			this.ckbDesc.UseVisualStyleBackColor = true;
			this.ckbDesc.CheckedChanged += new System.EventHandler(this.ckbDesc_CheckedChanged);
			// 
			// comboBoxSort
			// 
			this.comboBoxSort.FormattingEnabled = true;
			this.comboBoxSort.Items.AddRange(new object[] {
            "編號",
            "用戶",
            "生日",
            "建立時間"});
			this.comboBoxSort.Location = new System.Drawing.Point(158, 21);
			this.comboBoxSort.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.comboBoxSort.Name = "comboBoxSort";
			this.comboBoxSort.Size = new System.Drawing.Size(151, 27);
			this.comboBoxSort.TabIndex = 7;
			this.comboBoxSort.Text = "編號";
			this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView1.Location = new System.Drawing.Point(12, 69);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(960, 480);
			this.dataGridView1.TabIndex = 6;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "id";
			this.Column1.HeaderText = "編號";
			this.Column1.Name = "Column1";
			this.Column1.Width = 74;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.DataPropertyName = "account";
			this.Column2.HeaderText = "使用者";
			this.Column2.Name = "Column2";
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "CommentsNum";
			this.Column6.HeaderText = "評論數";
			this.Column6.Name = "Column6";
			this.Column6.Width = 94;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "gender";
			this.Column3.HeaderText = "性別";
			this.Column3.Name = "Column3";
			this.Column3.Width = 74;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "birthday";
			this.Column4.HeaderText = "生日";
			this.Column4.Name = "Column4";
			this.Column4.Width = 74;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.DataPropertyName = "createdtime";
			this.Column5.HeaderText = "建立時間";
			this.Column5.Name = "Column5";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("華康中圓體", 16F);
			this.label2.Location = new System.Drawing.Point(30, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 22);
			this.label2.TabIndex = 18;
			this.label2.Text = "排序依據：";
			// 
			// btnReturn
			// 
			this.btnReturn.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
			this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnReturn.Font = new System.Drawing.Font("華康中圓體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnReturn.Location = new System.Drawing.Point(914, 15);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(58, 42);
			this.btnReturn.TabIndex = 19;
			this.btnReturn.UseVisualStyleBackColor = false;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// FormUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ckbDesc);
			this.Controls.Add(this.comboBoxSort);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCommentNum);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnSearch);
			this.Font = new System.Drawing.Font("華康中圓體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.MaximizeBox = false;
			this.Name = "FormUsers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "用戶查詢";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUsers_FormClosed);
			this.Load += new System.EventHandler(this.FormUsers_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtCommentNum;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox ckbDesc;
		private System.Windows.Forms.ComboBox comboBoxSort;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnReturn;
	}
}