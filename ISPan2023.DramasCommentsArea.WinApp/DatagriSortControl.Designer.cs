namespace ISPan2023.DramasCommentsArea.WinApp
{
	partial class DatagriSortControl
	{
		/// <summary> 
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 元件設計工具產生的程式碼

		/// <summary> 
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.comboBoxSort = new System.Windows.Forms.ComboBox();
			this.ckbDesc = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(25, 52);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(750, 400);
			this.dataGridView1.TabIndex = 0;
			// 
			// comboBoxSort
			// 
			this.comboBoxSort.FormattingEnabled = true;
			this.comboBoxSort.Location = new System.Drawing.Point(111, 20);
			this.comboBoxSort.Name = "comboBoxSort";
			this.comboBoxSort.Size = new System.Drawing.Size(121, 20);
			this.comboBoxSort.TabIndex = 1;
			// 
			// ckbDesc
			// 
			this.ckbDesc.AutoSize = true;
			this.ckbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbDesc.Location = new System.Drawing.Point(49, 19);
			this.ckbDesc.Name = "ckbDesc";
			this.ckbDesc.Size = new System.Drawing.Size(56, 20);
			this.ckbDesc.TabIndex = 5;
			this.ckbDesc.Text = "遞減";
			this.ckbDesc.UseVisualStyleBackColor = true;
			// 
			// DatagriSortControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ckbDesc);
			this.Controls.Add(this.comboBoxSort);
			this.Controls.Add(this.dataGridView1);
			this.Name = "DatagriSortControl";
			this.Size = new System.Drawing.Size(800, 476);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBoxSort;
		private System.Windows.Forms.CheckBox ckbDesc;
	}
}
