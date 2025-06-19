namespace QuanLyRapChieuPhim
{
    partial class DatDoAn
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
			this.lsvChiTietTP = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnDatMon = new System.Windows.Forms.Button();
			this.txtGia = new System.Windows.Forms.TextBox();
			this.numSoLuong = new System.Windows.Forms.NumericUpDown();
			this.cbMaTP = new System.Windows.Forms.ComboBox();
			this.cbMaHD = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
			this.SuspendLayout();
			// 
			// lsvChiTietTP
			// 
			this.lsvChiTietTP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lsvChiTietTP.FullRowSelect = true;
			this.lsvChiTietTP.GridLines = true;
			this.lsvChiTietTP.HideSelection = false;
			this.lsvChiTietTP.Location = new System.Drawing.Point(8, 101);
			this.lsvChiTietTP.Name = "lsvChiTietTP";
			this.lsvChiTietTP.Size = new System.Drawing.Size(503, 324);
			this.lsvChiTietTP.TabIndex = 18;
			this.lsvChiTietTP.UseCompatibleStateImageBehavior = false;
			this.lsvChiTietTP.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã HD";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã TP";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên TP";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Số lượng";
			this.columnHeader4.Width = 70;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Tổng tiền";
			this.columnHeader5.Width = 150;
			// 
			// btnDatMon
			// 
			this.btnDatMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDatMon.Location = new System.Drawing.Point(541, 225);
			this.btnDatMon.Name = "btnDatMon";
			this.btnDatMon.Size = new System.Drawing.Size(93, 38);
			this.btnDatMon.TabIndex = 17;
			this.btnDatMon.Text = "Đặt";
			this.btnDatMon.UseVisualStyleBackColor = true;
			this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
			// 
			// txtGia
			// 
			this.txtGia.Enabled = false;
			this.txtGia.Location = new System.Drawing.Point(632, 187);
			this.txtGia.Name = "txtGia";
			this.txtGia.Size = new System.Drawing.Size(196, 22);
			this.txtGia.TabIndex = 16;
			// 
			// numSoLuong
			// 
			this.numSoLuong.Location = new System.Drawing.Point(632, 159);
			this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numSoLuong.Name = "numSoLuong";
			this.numSoLuong.Size = new System.Drawing.Size(92, 22);
			this.numSoLuong.TabIndex = 15;
			this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// cbMaTP
			// 
			this.cbMaTP.FormattingEnabled = true;
			this.cbMaTP.Location = new System.Drawing.Point(632, 129);
			this.cbMaTP.Name = "cbMaTP";
			this.cbMaTP.Size = new System.Drawing.Size(197, 24);
			this.cbMaTP.TabIndex = 13;
			// 
			// cbMaHD
			// 
			this.cbMaHD.FormattingEnabled = true;
			this.cbMaHD.Location = new System.Drawing.Point(632, 99);
			this.cbMaHD.Name = "cbMaHD";
			this.cbMaHD.Size = new System.Drawing.Size(197, 24);
			this.cbMaHD.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(537, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 22);
			this.label4.TabIndex = 11;
			this.label4.Text = "Giá";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(537, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 22);
			this.label3.TabIndex = 12;
			this.label3.Text = "Số lượng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(537, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 22);
			this.label2.TabIndex = 10;
			this.label2.Text = "Mã TP";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(537, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 22);
			this.label1.TabIndex = 9;
			this.label1.Text = "Mã HD";
			// 
			// DatDoAn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 525);
			this.Controls.Add(this.lsvChiTietTP);
			this.Controls.Add(this.btnDatMon);
			this.Controls.Add(this.txtGia);
			this.Controls.Add(this.numSoLuong);
			this.Controls.Add(this.cbMaTP);
			this.Controls.Add(this.cbMaHD);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "DatDoAn";
			this.Text = "DatDoAn";
			((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.ListView lsvChiTietTP;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Button btnDatMon;
		private System.Windows.Forms.TextBox txtGia;
		private System.Windows.Forms.NumericUpDown numSoLuong;
		private System.Windows.Forms.ComboBox cbMaTP;
		private System.Windows.Forms.ComboBox cbMaHD;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}