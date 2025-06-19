namespace QuanLyRapChieuPhim
{
    partial class QuanLySuatChieu
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
			this.dtpThoiGianKT = new System.Windows.Forms.DateTimePicker();
			this.dtpThoiGianBD = new System.Windows.Forms.DateTimePicker();
			this.dtpNgayChieu = new System.Windows.Forms.DateTimePicker();
			this.btnThemSuatChieu = new System.Windows.Forms.Button();
			this.cboMaPhim = new System.Windows.Forms.ComboBox();
			this.cboMaPhong = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewSuatChieu = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuatChieu)).BeginInit();
			this.SuspendLayout();
			// 
			// dtpThoiGianKT
			// 
			this.dtpThoiGianKT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpThoiGianKT.Location = new System.Drawing.Point(1095, 188);
			this.dtpThoiGianKT.Name = "dtpThoiGianKT";
			this.dtpThoiGianKT.Size = new System.Drawing.Size(227, 22);
			this.dtpThoiGianKT.TabIndex = 26;
			// 
			// dtpThoiGianBD
			// 
			this.dtpThoiGianBD.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpThoiGianBD.Location = new System.Drawing.Point(1095, 160);
			this.dtpThoiGianBD.Name = "dtpThoiGianBD";
			this.dtpThoiGianBD.Size = new System.Drawing.Size(227, 22);
			this.dtpThoiGianBD.TabIndex = 27;
			// 
			// dtpNgayChieu
			// 
			this.dtpNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNgayChieu.Location = new System.Drawing.Point(1095, 132);
			this.dtpNgayChieu.Name = "dtpNgayChieu";
			this.dtpNgayChieu.Size = new System.Drawing.Size(227, 22);
			this.dtpNgayChieu.TabIndex = 28;
			// 
			// btnThemSuatChieu
			// 
			this.btnThemSuatChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThemSuatChieu.Location = new System.Drawing.Point(963, 231);
			this.btnThemSuatChieu.Name = "btnThemSuatChieu";
			this.btnThemSuatChieu.Size = new System.Drawing.Size(122, 38);
			this.btnThemSuatChieu.TabIndex = 25;
			this.btnThemSuatChieu.Text = "Thêm";
			this.btnThemSuatChieu.UseVisualStyleBackColor = true;
			// 
			// cboMaPhim
			// 
			this.cboMaPhim.FormattingEnabled = true;
			this.cboMaPhim.Location = new System.Drawing.Point(1094, 102);
			this.cboMaPhim.Name = "cboMaPhim";
			this.cboMaPhim.Size = new System.Drawing.Size(228, 24);
			this.cboMaPhim.TabIndex = 23;
			// 
			// cboMaPhong
			// 
			this.cboMaPhong.FormattingEnabled = true;
			this.cboMaPhong.Location = new System.Drawing.Point(1094, 72);
			this.cboMaPhong.Name = "cboMaPhong";
			this.cboMaPhong.Size = new System.Drawing.Size(228, 24);
			this.cboMaPhong.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(959, 188);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(126, 22);
			this.label5.TabIndex = 21;
			this.label5.Text = "Thời gian KT";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(959, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 22);
			this.label4.TabIndex = 19;
			this.label4.Text = "Thời gian BD";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(959, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 22);
			this.label3.TabIndex = 22;
			this.label3.Text = "Ngày chiếu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(959, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 22);
			this.label2.TabIndex = 20;
			this.label2.Text = "Tên phim";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(959, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 22);
			this.label1.TabIndex = 18;
			this.label1.Text = "Mã phòng";
			// 
			// dataGridViewSuatChieu
			// 
			this.dataGridViewSuatChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewSuatChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSuatChieu.Location = new System.Drawing.Point(31, 72);
			this.dataGridViewSuatChieu.Name = "dataGridViewSuatChieu";
			this.dataGridViewSuatChieu.ReadOnly = true;
			this.dataGridViewSuatChieu.RowHeadersWidth = 51;
			this.dataGridViewSuatChieu.RowTemplate.Height = 24;
			this.dataGridViewSuatChieu.Size = new System.Drawing.Size(880, 532);
			this.dataGridViewSuatChieu.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(519, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(276, 37);
			this.label6.TabIndex = 87;
			this.label6.Text = "Quản lý suất chiếu";
			// 
			// QuanLySuatChieu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1357, 685);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dtpThoiGianKT);
			this.Controls.Add(this.dtpThoiGianBD);
			this.Controls.Add(this.dtpNgayChieu);
			this.Controls.Add(this.btnThemSuatChieu);
			this.Controls.Add(this.cboMaPhim);
			this.Controls.Add(this.cboMaPhong);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewSuatChieu);
			this.Name = "QuanLySuatChieu";
			this.Text = "QuanLySuatChieu";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuatChieu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.DateTimePicker dtpThoiGianKT;
		private System.Windows.Forms.DateTimePicker dtpThoiGianBD;
		private System.Windows.Forms.DateTimePicker dtpNgayChieu;
		private System.Windows.Forms.Button btnThemSuatChieu;
		private System.Windows.Forms.ComboBox cboMaPhim;
		private System.Windows.Forms.ComboBox cboMaPhong;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewSuatChieu;
		private System.Windows.Forms.Label label6;
	}
}