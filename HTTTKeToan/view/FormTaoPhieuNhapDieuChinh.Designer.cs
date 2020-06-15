namespace HTTTKeToan.view
{
    partial class FormTaoPhieuNhapDieuChinh
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
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKhoNhap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSoHD = new System.Windows.Forms.TextBox();
            this.cbLoaiHD = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLuuPhieuNhap = new System.Windows.Forms.Button();
            this.pickerNgNhap = new System.Windows.Forms.DateTimePicker();
            this.pickerNgThanhToan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pickerNgPhatHanh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tbQuyenHD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLyDo = new System.Windows.Forms.RichTextBox();
            this.MaHangHoa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThueXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(360, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(268, 25);
            this.title.TabIndex = 1;
            this.title.Text = "Tạo phiếu nhập điều chỉnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhà cung cấp";
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Items.AddRange(new object[] {
            "NCC1",
            "NCC2",
            "NCC3",
            "NCC4",
            "NCC5",
            "NCC6"});
            this.cbNhaCungCap.Location = new System.Drawing.Point(217, 43);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(121, 21);
            this.cbNhaCungCap.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kho Nhập";
            // 
            // cbKhoNhap
            // 
            this.cbKhoNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoNhap.FormattingEnabled = true;
            this.cbKhoNhap.Items.AddRange(new object[] {
            "KHO01",
            "KHO02",
            "KHO03",
            "KHO04",
            "KHO05",
            "KHO06"});
            this.cbKhoNhap.Location = new System.Drawing.Point(217, 81);
            this.cbKhoNhap.Name = "cbKhoNhap";
            this.cbKhoNhap.Size = new System.Drawing.Size(121, 21);
            this.cbKhoNhap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Loại hóa đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày thanh toán";
            // 
            // cbSoHD
            // 
            this.cbSoHD.Location = new System.Drawing.Point(483, 43);
            this.cbSoHD.Name = "cbSoHD";
            this.cbSoHD.Size = new System.Drawing.Size(118, 20);
            this.cbSoHD.TabIndex = 4;
            // 
            // cbLoaiHD
            // 
            this.cbLoaiHD.Location = new System.Drawing.Point(483, 81);
            this.cbLoaiHD.Name = "cbLoaiHD";
            this.cbLoaiHD.Size = new System.Drawing.Size(118, 20);
            this.cbLoaiHD.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHangHoa,
            this.TenHangHoa,
            this.DonViTinh,
            this.SoLuong,
            this.DonGia,
            this.ThueXuat,
            this.TienThue});
            this.dataGridView1.Location = new System.Drawing.Point(12, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 295);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // btnLuuPhieuNhap
            // 
            this.btnLuuPhieuNhap.Location = new System.Drawing.Point(840, 469);
            this.btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            this.btnLuuPhieuNhap.Size = new System.Drawing.Size(132, 30);
            this.btnLuuPhieuNhap.TabIndex = 5;
            this.btnLuuPhieuNhap.Text = "Lưu phiếu nhập";
            this.btnLuuPhieuNhap.UseVisualStyleBackColor = true;
            this.btnLuuPhieuNhap.Click += new System.EventHandler(this.btnLuuPhieuNhap_Click);
            // 
            // pickerNgNhap
            // 
            this.pickerNgNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerNgNhap.Location = new System.Drawing.Point(217, 118);
            this.pickerNgNhap.Name = "pickerNgNhap";
            this.pickerNgNhap.Size = new System.Drawing.Size(121, 20);
            this.pickerNgNhap.TabIndex = 7;
            // 
            // pickerNgThanhToan
            // 
            this.pickerNgThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerNgThanhToan.Location = new System.Drawing.Point(480, 118);
            this.pickerNgThanhToan.Name = "pickerNgThanhToan";
            this.pickerNgThanhToan.Size = new System.Drawing.Size(121, 20);
            this.pickerNgThanhToan.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(632, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày phát hành hóa đơn";
            // 
            // pickerNgPhatHanh
            // 
            this.pickerNgPhatHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerNgPhatHanh.Location = new System.Drawing.Point(814, 43);
            this.pickerNgPhatHanh.Name = "pickerNgPhatHanh";
            this.pickerNgPhatHanh.Size = new System.Drawing.Size(112, 20);
            this.pickerNgPhatHanh.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(632, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Quyển hóa đơn";
            // 
            // tbQuyenHD
            // 
            this.tbQuyenHD.Location = new System.Drawing.Point(808, 80);
            this.tbQuyenHD.Name = "tbQuyenHD";
            this.tbQuyenHD.Size = new System.Drawing.Size(118, 20);
            this.tbQuyenHD.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(632, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Lý do";
            // 
            // tbLyDo
            // 
            this.tbLyDo.Location = new System.Drawing.Point(710, 106);
            this.tbLyDo.Name = "tbLyDo";
            this.tbLyDo.Size = new System.Drawing.Size(216, 56);
            this.tbLyDo.TabIndex = 8;
            this.tbLyDo.Text = "";
            // 
            // MaHangHoa
            // 
            this.MaHangHoa.HeaderText = "Mã hàng hóa";
            this.MaHangHoa.Name = "MaHangHoa";
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHangHoa.HeaderText = "Tên hàng hóa";
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // ThueXuat
            // 
            this.ThueXuat.HeaderText = "Thuế xuất (%)";
            this.ThueXuat.Name = "ThueXuat";
            // 
            // TienThue
            // 
            this.TienThue.HeaderText = "Tiền thuế";
            this.TienThue.Name = "TienThue";
            // 
            // FormTaoPhieuNhapDieuChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.tbLyDo);
            this.Controls.Add(this.pickerNgPhatHanh);
            this.Controls.Add(this.pickerNgThanhToan);
            this.Controls.Add(this.pickerNgNhap);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLuuPhieuNhap);
            this.Controls.Add(this.tbQuyenHD);
            this.Controls.Add(this.cbLoaiHD);
            this.Controls.Add(this.cbSoHD);
            this.Controls.Add(this.cbKhoNhap);
            this.Controls.Add(this.cbNhaCungCap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "FormTaoPhieuNhapDieuChinh";
            this.Text = "FormTaoPhieuNhapDieuChinh";
            this.Load += new System.EventHandler(this.FormTaoPhieuNhapDieuChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKhoNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cbSoHD;
        private System.Windows.Forms.TextBox cbLoaiHD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLuuPhieuNhap;
        private System.Windows.Forms.DateTimePicker pickerNgNhap;
        private System.Windows.Forms.DateTimePicker pickerNgThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker pickerNgPhatHanh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbQuyenHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox tbLyDo;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThueXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienThue;
    }
}