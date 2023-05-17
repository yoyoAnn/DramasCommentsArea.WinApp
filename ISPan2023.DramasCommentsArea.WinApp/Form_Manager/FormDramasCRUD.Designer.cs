namespace ISPan2023.DramasCommentsArea.WinApp
{
	partial class FormDramasCRUD
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDramasCRUD));
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dataGridViewDramas = new System.Windows.Forms.DataGridView();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.comboBoxSort = new System.Windows.Forms.ComboBox();
			this.ckbDesc = new System.Windows.Forms.CheckBox();
			this.btnReturn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDramas)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Khaki;
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAdd.Location = new System.Drawing.Point(12, 9);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(114, 53);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "新增";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.PowderBlue;
			this.btnSearch.Font = new System.Drawing.Font("華康中圓體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSearch.Location = new System.Drawing.Point(657, 17);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(114, 35);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "劇名搜尋";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(553, 23);
			this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(101, 26);
			this.txtSearch.TabIndex = 3;
			this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
			// 
			// dataGridViewDramas
			// 
			this.dataGridViewDramas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewDramas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewDramas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewDramas.BackgroundColor = System.Drawing.Color.PaleTurquoise;
			this.dataGridViewDramas.ColumnHeadersHeight = 40;
			this.dataGridViewDramas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			this.dataGridViewDramas.Location = new System.Drawing.Point(12, 71);
			this.dataGridViewDramas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridViewDramas.Name = "dataGridViewDramas";
			this.dataGridViewDramas.ReadOnly = true;
			this.dataGridViewDramas.RowHeadersVisible = false;
			this.dataGridViewDramas.RowTemplate.Height = 24;
			this.dataGridViewDramas.Size = new System.Drawing.Size(960, 480);
			this.dataGridViewDramas.TabIndex = 2;
			this.dataGridViewDramas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDramas_CellClick);
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Column7.DataPropertyName = "id";
			this.Column7.HeaderText = "編號";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 74;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
			this.Column1.DataPropertyName = "name";
			this.Column1.HeaderText = "劇名";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 21;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.Column2.DataPropertyName = "episode";
			this.Column2.HeaderText = "集數";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 74;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
			this.Column3.DataPropertyName = "publishDate";
			this.Column3.HeaderText = "發行日";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 21;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.DataPropertyName = "actors";
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
			this.Column4.HeaderText = "演員";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column5.DataPropertyName = "writer";
			this.Column5.HeaderText = "編劇";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 74;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
			this.Column6.DataPropertyName = "director";
			this.Column6.HeaderText = "導演";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 21;
			// 
			// comboBoxSort
			// 
			this.comboBoxSort.FormattingEnabled = true;
			this.comboBoxSort.Items.AddRange(new object[] {
            "編號",
            "發行日期",
            "集數",
            "劇名"});
			this.comboBoxSort.Location = new System.Drawing.Point(333, 23);
			this.comboBoxSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboBoxSort.Name = "comboBoxSort";
			this.comboBoxSort.Size = new System.Drawing.Size(130, 27);
			this.comboBoxSort.TabIndex = 1;
			this.comboBoxSort.Text = "編號";
			this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
			// 
			// ckbDesc
			// 
			this.ckbDesc.AutoSize = true;
			this.ckbDesc.Font = new System.Drawing.Font("華康中圓體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ckbDesc.Location = new System.Drawing.Point(469, 29);
			this.ckbDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ckbDesc.Name = "ckbDesc";
			this.ckbDesc.Size = new System.Drawing.Size(58, 20);
			this.ckbDesc.TabIndex = 2;
			this.ckbDesc.Text = "遞減";
			this.ckbDesc.UseVisualStyleBackColor = true;
			this.ckbDesc.CheckedChanged += new System.EventHandler(this.ckbDesc_CheckedChanged);
			// 
			// btnReturn
			// 
			this.btnReturn.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
			this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnReturn.Font = new System.Drawing.Font("華康中圓體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnReturn.Location = new System.Drawing.Point(914, 14);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(58, 42);
			this.btnReturn.TabIndex = 5;
			this.btnReturn.UseVisualStyleBackColor = false;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("華康中圓體", 16F);
			this.label1.Location = new System.Drawing.Point(212, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 22);
			this.label1.TabIndex = 6;
			this.label1.Text = "排序依據：";
			// 
			// FormDramasCRUD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ckbDesc);
			this.Controls.Add(this.comboBoxSort);
			this.Controls.Add(this.dataGridViewDramas);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnAdd);
			this.Font = new System.Drawing.Font("華康中圓體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.Name = "FormDramasCRUD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "戲劇資料管理頁面";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDramasCRUD_FormClosed);
			this.Load += new System.EventHandler(this.FormDramasCRUD_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDramas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.DataGridView dataGridViewDramas;
		private System.Windows.Forms.ComboBox comboBoxSort;
		private System.Windows.Forms.CheckBox ckbDesc;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
	}
}