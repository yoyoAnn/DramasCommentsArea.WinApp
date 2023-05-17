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
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dataGridViewDramas = new System.Windows.Forms.DataGridView();
			this.comboBoxSort = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewDramas)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(36, 25);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(137, 44);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "新增戲劇資料";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(635, 24);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(70, 44);
			this.btnSearch.TabIndex = 0;
			this.btnSearch.Text = "搜尋";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(517, 32);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(100, 29);
			this.txtSearch.TabIndex = 1;
			// 
			// dataGridViewDramas
			// 
			this.dataGridViewDramas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewDramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewDramas.Location = new System.Drawing.Point(36, 122);
			this.dataGridViewDramas.Name = "dataGridViewDramas";
			this.dataGridViewDramas.RowTemplate.Height = 24;
			this.dataGridViewDramas.Size = new System.Drawing.Size(669, 449);
			this.dataGridViewDramas.TabIndex = 2;
			this.dataGridViewDramas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDramas_CellClick);
			// 
			// comboBoxSort
			// 
			this.comboBoxSort.FormattingEnabled = true;
			this.comboBoxSort.Location = new System.Drawing.Point(351, 31);
			this.comboBoxSort.Name = "comboBoxSort";
			this.comboBoxSort.Size = new System.Drawing.Size(121, 30);
			this.comboBoxSort.TabIndex = 3;
			// 
			// FormDramasCRUD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(741, 612);
			this.Controls.Add(this.comboBoxSort);
			this.Controls.Add(this.dataGridViewDramas);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnAdd);
			this.Font = new System.Drawing.Font("源石黑體 R", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "FormDramasCRUD";
			this.Text = "戲劇管理頁面";
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
	}
}