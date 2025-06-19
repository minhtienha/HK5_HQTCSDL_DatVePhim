namespace QuanLyRapChieuPhim.Admin
{
	partial class QuanLyThucPham
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
			this.btnSuaTP = new System.Windows.Forms.Button();
			this.btnXoaTP = new System.Windows.Forms.Button();
			this.btnThemTP = new System.Windows.Forms.Button();
			this.txtTenTP = new System.Windows.Forms.TextBox();
			this.txtGiaTP = new System.Windows.Forms.TextBox();
			this.numSoLuongTP = new System.Windows.Forms.NumericUpDown();
			this.cbMaTP1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvThucPham = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.numSoLuongTP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvThucPham)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSuaTP
			// 
			this.btnSuaTP.Location = new System.Drawing.Point(1038, 176);
			this.btnSuaTP.Name = "btnSuaTP";
			this.btnSuaTP.Size = new System.Drawing.Size(75, 43);
			this.btnSuaTP.TabIndex = 25;
			this.btnSuaTP.Text = "Sửa";
			this.btnSuaTP.UseVisualStyleBackColor = true;
			// 
			// btnXoaTP
			// 
			this.btnXoaTP.Location = new System.Drawing.Point(957, 176);
			this.btnXoaTP.Name = "btnXoaTP";
			this.btnXoaTP.Size = new System.Drawing.Size(75, 43);
			this.btnXoaTP.TabIndex = 26;
			this.btnXoaTP.Text = "Xóa";
			this.btnXoaTP.UseVisualStyleBackColor = true;
			// 
			// btnThemTP
			// 
			this.btnThemTP.Location = new System.Drawing.Point(876, 176);
			this.btnThemTP.Name = "btnThemTP";
			this.btnThemTP.Size = new System.Drawing.Size(75, 43);
			this.btnThemTP.TabIndex = 27;
			this.btnThemTP.Text = "Thêm";
			this.btnThemTP.UseVisualStyleBackColor = true;
			// 
			// txtTenTP
			// 
			this.txtTenTP.Location = new System.Drawing.Point(967, 76);
			this.txtTenTP.Name = "txtTenTP";
			this.txtTenTP.Size = new System.Drawing.Size(196, 22);
			this.txtTenTP.TabIndex = 23;
			// 
			// txtGiaTP
			// 
			this.txtGiaTP.Location = new System.Drawing.Point(967, 134);
			this.txtGiaTP.Name = "txtGiaTP";
			this.txtGiaTP.Size = new System.Drawing.Size(196, 22);
			this.txtGiaTP.TabIndex = 24;
			// 
			// numSoLuongTP
			// 
			this.numSoLuongTP.Location = new System.Drawing.Point(967, 106);
			this.numSoLuongTP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numSoLuongTP.Name = "numSoLuongTP";
			this.numSoLuongTP.Size = new System.Drawing.Size(92, 22);
			this.numSoLuongTP.TabIndex = 22;
			this.numSoLuongTP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// cbMaTP1
			// 
			this.cbMaTP1.Enabled = false;
			this.cbMaTP1.FormattingEnabled = true;
			this.cbMaTP1.Location = new System.Drawing.Point(967, 46);
			this.cbMaTP1.Name = "cbMaTP1";
			this.cbMaTP1.Size = new System.Drawing.Size(197, 24);
			this.cbMaTP1.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(872, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 22);
			this.label4.TabIndex = 19;
			this.label4.Text = "Giá";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(872, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 22);
			this.label3.TabIndex = 20;
			this.label3.Text = "Số lượng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(872, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 22);
			this.label2.TabIndex = 18;
			this.label2.Text = "Tên TP";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(872, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 22);
			this.label1.TabIndex = 17;
			this.label1.Text = "Mã TP";
			// 
			// dgvThucPham
			// 
			this.dgvThucPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvThucPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvThucPham.Location = new System.Drawing.Point(62, 46);
			this.dgvThucPham.Name = "dgvThucPham";
			this.dgvThucPham.ReadOnly = true;
			this.dgvThucPham.RowHeadersWidth = 51;
			this.dgvThucPham.RowTemplate.Height = 24;
			this.dgvThucPham.Size = new System.Drawing.Size(747, 514);
			this.dgvThucPham.TabIndex = 16;
			// 
			// QuanLyThucPham
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1194, 634);
			this.Controls.Add(this.btnSuaTP);
			this.Controls.Add(this.btnXoaTP);
			this.Controls.Add(this.btnThemTP);
			this.Controls.Add(this.txtTenTP);
			this.Controls.Add(this.txtGiaTP);
			this.Controls.Add(this.numSoLuongTP);
			this.Controls.Add(this.cbMaTP1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvThucPham);
			this.Name = "QuanLyThucPham";
			this.Text = "QuanLyThucPham";
			((System.ComponentModel.ISupportInitialize)(this.numSoLuongTP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvThucPham)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSuaTP;
		private System.Windows.Forms.Button btnXoaTP;
		private System.Windows.Forms.Button btnThemTP;
		private System.Windows.Forms.TextBox txtTenTP;
		private System.Windows.Forms.TextBox txtGiaTP;
		private System.Windows.Forms.NumericUpDown numSoLuongTP;
		private System.Windows.Forms.ComboBox cbMaTP1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvThucPham;
	}
}