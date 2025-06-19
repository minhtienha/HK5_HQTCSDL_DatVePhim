namespace QuanLyRapChieuPhim.NhanVienBanVe
{
    partial class DsVeDaDat
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaVe,
            this.MaSC,
            this.NgayChieu,
            this.TenPhim,
            this.ThoiGian,
            this.TenGhe,
            this.GiaGhe});
            this.dataGridView1.Location = new System.Drawing.Point(34, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1340, 466);
            this.dataGridView1.TabIndex = 2;
            // 
            // MaHD
            // 
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.Name = "MaHD";
            // 
            // MaVe
            // 
            this.MaVe.HeaderText = "Mã vé";
            this.MaVe.Name = "MaVe";
            // 
            // MaSC
            // 
            this.MaSC.HeaderText = "Mã SC";
            this.MaSC.Name = "MaSC";
            // 
            // NgayChieu
            // 
            this.NgayChieu.HeaderText = "Ngày chiếu";
            this.NgayChieu.Name = "NgayChieu";
            // 
            // TenPhim
            // 
            this.TenPhim.HeaderText = "Tên phim";
            this.TenPhim.Name = "TenPhim";
            // 
            // ThoiGian
            // 
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.Name = "ThoiGian";
            // 
            // TenGhe
            // 
            this.TenGhe.HeaderText = "Tên ghế";
            this.TenGhe.Name = "TenGhe";
            // 
            // GiaGhe
            // 
            this.GiaGhe.HeaderText = "Giá ghế";
            this.GiaGhe.Name = "GiaGhe";
            // 
            // DsVeDaDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 584);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DsVeDaDat";
            this.Text = "DsVeDaDat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DsVeDaDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaGhe;
    }
}