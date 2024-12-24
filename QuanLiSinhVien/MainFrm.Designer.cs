namespace QuanLiSinhVien
{
    partial class MainFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtSoTiet = new System.Windows.Forms.TextBox();
            this.comboMaMH = new System.Windows.Forms.ComboBox();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.btnTimMHTheoND = new System.Windows.Forms.Button();
            this.btnTimMHtheoma = new System.Windows.Forms.Button();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.dtgvMH = new System.Windows.Forms.DataGridView();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXemDSSV = new System.Windows.Forms.Button();
            this.btnXemDSSVTheoKhoa = new System.Windows.Forms.Button();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.btnXemDiemtheomon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma MH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten MH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Tiết:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn Mã môn học cần tìm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(715, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 45);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tìm kiếm thông tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(731, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhập từ khóa";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Location = new System.Drawing.Point(147, 66);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(245, 34);
            this.txtMaMH.TabIndex = 6;
            this.txtMaMH.TextChanged += new System.EventHandler(this.txtMaMH_TextChanged);
            // 
            // txtTenMH
            // 
            this.txtTenMH.Enabled = false;
            this.txtTenMH.Location = new System.Drawing.Point(147, 131);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(245, 34);
            this.txtTenMH.TabIndex = 7;
            this.txtTenMH.TextChanged += new System.EventHandler(this.txtTenMH_TextChanged);
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.Enabled = false;
            this.txtSoTiet.Location = new System.Drawing.Point(147, 206);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.Size = new System.Drawing.Size(245, 34);
            this.txtSoTiet.TabIndex = 8;
            // 
            // comboMaMH
            // 
            this.comboMaMH.FormattingEnabled = true;
            this.comboMaMH.Location = new System.Drawing.Point(439, 109);
            this.comboMaMH.Name = "comboMaMH";
            this.comboMaMH.Size = new System.Drawing.Size(223, 36);
            this.comboMaMH.TabIndex = 9;
            this.comboMaMH.Click += new System.EventHandler(this.comboMaMH_Click);
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(878, 111);
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(153, 34);
            this.txtNoidung.TabIndex = 10;
            // 
            // btnTimMHTheoND
            // 
            this.btnTimMHTheoND.Location = new System.Drawing.Point(898, 180);
            this.btnTimMHTheoND.Name = "btnTimMHTheoND";
            this.btnTimMHTheoND.Size = new System.Drawing.Size(133, 39);
            this.btnTimMHTheoND.TabIndex = 11;
            this.btnTimMHTheoND.Text = "Tìm kiếm";
            this.btnTimMHTheoND.UseVisualStyleBackColor = true;
            this.btnTimMHTheoND.Click += new System.EventHandler(this.btnTimMHTheoND_Click);
            // 
            // btnTimMHtheoma
            // 
            this.btnTimMHtheoma.Location = new System.Drawing.Point(509, 194);
            this.btnTimMHtheoma.Name = "btnTimMHtheoma";
            this.btnTimMHtheoma.Size = new System.Drawing.Size(113, 43);
            this.btnTimMHtheoma.TabIndex = 12;
            this.btnTimMHtheoma.Text = "Tìm kiếm";
            this.btnTimMHtheoma.UseVisualStyleBackColor = true;
            this.btnTimMHtheoma.Click += new System.EventHandler(this.btnTimMHtheoma_Click);
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.Location = new System.Drawing.Point(54, 260);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(179, 37);
            this.btnHienThiTatCa.TabIndex = 13;
            this.btnHienThiTatCa.Text = "Hiển thị tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = true;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // dtgvMH
            // 
            this.dtgvMH.AllowUserToAddRows = false;
            this.dtgvMH.AllowUserToDeleteRows = false;
            this.dtgvMH.AllowUserToOrderColumns = true;
            this.dtgvMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMH.Location = new System.Drawing.Point(40, 303);
            this.dtgvMH.Name = "dtgvMH";
            this.dtgvMH.ReadOnly = true;
            this.dtgvMH.RowHeadersWidth = 51;
            this.dtgvMH.RowTemplate.Height = 24;
            this.dtgvMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMH.Size = new System.Drawing.Size(1136, 199);
            this.dtgvMH.TabIndex = 14;
            this.dtgvMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMH_CellContentClick);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(40, 510);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(85, 35);
            this.btnThemMoi.TabIndex = 15;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Location = new System.Drawing.Point(147, 512);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 35);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(238, 512);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(331, 514);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 35);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXemDSSV
            // 
            this.btnXemDSSV.Location = new System.Drawing.Point(429, 513);
            this.btnXemDSSV.Name = "btnXemDSSV";
            this.btnXemDSSV.Size = new System.Drawing.Size(182, 40);
            this.btnXemDSSV.TabIndex = 19;
            this.btnXemDSSV.Text = "Xem DS Sinh Viên";
            this.btnXemDSSV.UseVisualStyleBackColor = true;
            // 
            // btnXemDSSVTheoKhoa
            // 
            this.btnXemDSSVTheoKhoa.Location = new System.Drawing.Point(630, 507);
            this.btnXemDSSVTheoKhoa.Name = "btnXemDSSVTheoKhoa";
            this.btnXemDSSVTheoKhoa.Size = new System.Drawing.Size(208, 44);
            this.btnXemDSSVTheoKhoa.TabIndex = 20;
            this.btnXemDSSVTheoKhoa.Text = "Xem DSSV Theo khoa";
            this.btnXemDSSVTheoKhoa.UseVisualStyleBackColor = true;
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Location = new System.Drawing.Point(844, 509);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(110, 43);
            this.btnXemDiem.TabIndex = 21;
            this.btnXemDiem.Text = "Xem điểm";
            this.btnXemDiem.UseVisualStyleBackColor = true;
            // 
            // btnXemDiemtheomon
            // 
            this.btnXemDiemtheomon.Location = new System.Drawing.Point(974, 509);
            this.btnXemDiemtheomon.Name = "btnXemDiemtheomon";
            this.btnXemDiemtheomon.Size = new System.Drawing.Size(202, 44);
            this.btnXemDiemtheomon.TabIndex = 22;
            this.btnXemDiemtheomon.Text = "Xem điểm theo môn";
            this.btnXemDiemtheomon.UseVisualStyleBackColor = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 622);
            this.Controls.Add(this.btnXemDiemtheomon);
            this.Controls.Add(this.btnXemDiem);
            this.Controls.Add(this.btnXemDSSVTheoKhoa);
            this.Controls.Add(this.btnXemDSSV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.dtgvMH);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.btnTimMHtheoma);
            this.Controls.Add(this.btnTimMHTheoND);
            this.Controls.Add(this.txtNoidung);
            this.Controls.Add(this.comboMaMH);
            this.Controls.Add(this.txtSoTiet);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtSoTiet;
        private System.Windows.Forms.ComboBox comboMaMH;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.Button btnTimMHTheoND;
        private System.Windows.Forms.Button btnTimMHtheoma;
        private System.Windows.Forms.Button btnHienThiTatCa;
        private System.Windows.Forms.DataGridView dtgvMH;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXemDSSV;
        private System.Windows.Forms.Button btnXemDSSVTheoKhoa;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Button btnXemDiemtheomon;
    }
}