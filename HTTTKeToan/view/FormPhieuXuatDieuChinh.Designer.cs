namespace HTTTKeToan.view
{
    partial class FormPhieuXuatDieuChinh
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbChonKhachHang = new System.Windows.Forms.ComboBox();
            this.cbKhoXuat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSoHD = new System.Windows.Forms.TextBox();
            this.tbLoaiHD = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHangHoa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThueXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.pickerNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.pickerNgThanhToan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.pickerNgPHHD = new System.Windows.Forms.DateTimePicker();
            this.quyenHD = new System.Windows.Forms.Label();
            this.tbQuyenHD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLyDo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(371, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(261, 25);
            this.title.TabIndex = 1;
            this.title.Text = "Tạo phiếu xuất điều chỉnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kho xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày xuất";
            // 
            // cbChonKhachHang
            // 
            this.cbChonKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChonKhachHang.FormattingEnabled = true;
            this.cbChonKhachHang.Items.AddRange(new object[] {
            "KH01",
            "KH02",
            "KH03",
            "KH04",
            "KH05"});
            this.cbChonKhachHang.Location = new System.Drawing.Point(160, 48);
            this.cbChonKhachHang.Name = "cbChonKhachHang";
            this.cbChonKhachHang.Size = new System.Drawing.Size(140, 21);
            this.cbChonKhachHang.TabIndex = 3;
            // 
            // cbKhoXuat
            // 
            this.cbKhoXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoXuat.FormattingEnabled = true;
            this.cbKhoXuat.Items.AddRange(new object[] {
            "KHO01",
            "KHO02",
            "KHO03",
            "KHO04",
            "KHO05",
            "KHO06"});
            this.cbKhoXuat.Location = new System.Drawing.Point(160, 86);
            this.cbKhoXuat.Name = "cbKhoXuat";
            this.cbKhoXuat.Size = new System.Drawing.Size(140, 21);
            this.cbKhoXuat.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Loại hóa đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ngày thanh toán";
            // 
            // tbSoHD
            // 
            this.tbSoHD.Location = new System.Drawing.Point(468, 51);
            this.tbSoHD.Name = "tbSoHD";
            this.tbSoHD.Size = new System.Drawing.Size(144, 20);
            this.tbSoHD.TabIndex = 4;
            // 
            // tbLoaiHD
            // 
            this.tbLoaiHD.Location = new System.Drawing.Point(468, 88);
            this.tbLoaiHD.Name = "tbLoaiHD";
            this.tbLoaiHD.Size = new System.Drawing.Size(144, 20);
            this.tbLoaiHD.TabIndex = 4;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(960, 289);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // MaHangHoa
            // 
            this.MaHangHoa.DataPropertyName = "MaHH";
            this.MaHangHoa.HeaderText = "Mã hàng hóa";
            this.MaHangHoa.Name = "MaHangHoa";
            this.MaHangHoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaHangHoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHangHoa.DataPropertyName = "TENHANGHOA";
            this.TenHangHoa.HeaderText = "Tên hàng hóa";
            this.TenHangHoa.Name = "TenHangHoa";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DVT";
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
            this.ThueXuat.HeaderText = "Thuế xuất";
            this.ThueXuat.Name = "ThueXuat";
            // 
            // TienThue
            // 
            this.TienThue.HeaderText = "Tiền thuế";
            this.TienThue.Name = "TienThue";
            this.TienThue.Width = 150;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(804, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Lưu phiếu xuất";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pickerNgayXuat
            // 
            this.pickerNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerNgayXuat.Location = new System.Drawing.Point(160, 124);
            this.pickerNgayXuat.Name = "pickerNgayXuat";
            this.pickerNgayXuat.Size = new System.Drawing.Size(140, 20);
            this.pickerNgayXuat.TabIndex = 7;
            // 
            // pickerNgThanhToan
            // 
            this.pickerNgThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerNgThanhToan.Location = new System.Drawing.Point(468, 120);
            this.pickerNgThanhToan.Name = "pickerNgThanhToan";
            this.pickerNgThanhToan.Size = new System.Drawing.Size(140, 20);
            this.pickerNgThanhToan.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(633, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày phát hành hóa đơn";
            // 
            // pickerNgPHHD
            // 
            this.pickerNgPHHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerNgPHHD.Location = new System.Drawing.Point(804, 49);
            this.pickerNgPHHD.Name = "pickerNgPHHD";
            this.pickerNgPHHD.Size = new System.Drawing.Size(140, 20);
            this.pickerNgPHHD.TabIndex = 7;
            // 
            // quyenHD
            // 
            this.quyenHD.AutoSize = true;
            this.quyenHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quyenHD.Location = new System.Drawing.Point(633, 86);
            this.quyenHD.Name = "quyenHD";
            this.quyenHD.Size = new System.Drawing.Size(106, 17);
            this.quyenHD.TabIndex = 2;
            this.quyenHD.Text = "Quyển hóa đơn";
            // 
            // tbQuyenHD
            // 
            this.tbQuyenHD.Location = new System.Drawing.Point(800, 83);
            this.tbQuyenHD.Name = "tbQuyenHD";
            this.tbQuyenHD.Size = new System.Drawing.Size(144, 20);
            this.tbQuyenHD.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(633, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Lý do";
            // 
            // tbLyDo
            // 
            this.tbLyDo.Location = new System.Drawing.Point(698, 108);
            this.tbLyDo.Name = "tbLyDo";
            this.tbLyDo.Size = new System.Drawing.Size(246, 48);
            this.tbLyDo.TabIndex = 8;
            this.tbLyDo.Text = "";
            // 
            // FormPhieuXuatDieuChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.tbLyDo);
            this.Controls.Add(this.pickerNgPHHD);
            this.Controls.Add(this.pickerNgThanhToan);
            this.Controls.Add(this.pickerNgayXuat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbLoaiHD);
            this.Controls.Add(this.tbQuyenHD);
            this.Controls.Add(this.tbSoHD);
            this.Controls.Add(this.cbKhoXuat);
            this.Controls.Add(this.cbChonKhachHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quyenHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "FormPhieuXuatDieuChinh";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPhieuXuatDieuChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbChonKhachHang;
        private System.Windows.Forms.ComboBox cbKhoXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSoHD;
        private System.Windows.Forms.TextBox tbLoaiHD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker pickerNgayXuat;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThueXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienThue;
        private System.Windows.Forms.DateTimePicker pickerNgThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker pickerNgPHHD;
        private System.Windows.Forms.Label quyenHD;
        private System.Windows.Forms.TextBox tbQuyenHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox tbLyDo;
    }
}