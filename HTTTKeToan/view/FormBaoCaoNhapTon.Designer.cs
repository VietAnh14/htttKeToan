namespace HTTTKeToan.view
{
    partial class FormBaoCaoNhapTon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTonCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKho = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHangHoa = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnTinhHoachToanGiaVon = new System.Windows.Forms.Button();
            this.monthPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(381, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(228, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Báo cáo nhập xuất tồn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Thang,
            this.MSCH,
            this.TenHangHoa,
            this.SLNhap,
            this.SLXuat,
            this.SLTonCuoi});
            this.dataGridView1.Location = new System.Drawing.Point(15, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(957, 370);
            this.dataGridView1.TabIndex = 1;
            // 
            // Thang
            // 
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // MSCH
            // 
            this.MSCH.HeaderText = "Mã số cửa hàng";
            this.MSCH.Name = "MSCH";
            this.MSCH.ReadOnly = true;
            this.MSCH.Width = 150;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHangHoa.HeaderText = "Tên hàng";
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.ReadOnly = true;
            // 
            // SLNhap
            // 
            this.SLNhap.HeaderText = "Số lượng nhập";
            this.SLNhap.Name = "SLNhap";
            this.SLNhap.ReadOnly = true;
            this.SLNhap.Width = 120;
            // 
            // SLXuat
            // 
            this.SLXuat.HeaderText = "Số lượng xuất";
            this.SLXuat.Name = "SLXuat";
            this.SLXuat.ReadOnly = true;
            this.SLXuat.Width = 120;
            // 
            // SLTonCuoi
            // 
            this.SLTonCuoi.HeaderText = "Số lượng tồn cuối kỳ";
            this.SLTonCuoi.Name = "SLTonCuoi";
            this.SLTonCuoi.ReadOnly = true;
            this.SLTonCuoi.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kho";
            // 
            // cbKho
            // 
            this.cbKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKho.FormattingEnabled = true;
            this.cbKho.Items.AddRange(new object[] {
            "Tất cả cửa hàng",
            "KHO01",
            "KHO02",
            "KHO03",
            "KHO04",
            "KHO05",
            "KHO06"});
            this.cbKho.Location = new System.Drawing.Point(340, 49);
            this.cbKho.Name = "cbKho";
            this.cbKho.Size = new System.Drawing.Size(128, 21);
            this.cbKho.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hàng hóa";
            // 
            // cbHangHoa
            // 
            this.cbHangHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHangHoa.FormattingEnabled = true;
            this.cbHangHoa.Location = new System.Drawing.Point(632, 49);
            this.cbHangHoa.Name = "cbHangHoa";
            this.cbHangHoa.Size = new System.Drawing.Size(128, 21);
            this.cbHangHoa.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(818, 36);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(98, 34);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnTinhHoachToanGiaVon
            // 
            this.btnTinhHoachToanGiaVon.Location = new System.Drawing.Point(818, 465);
            this.btnTinhHoachToanGiaVon.Name = "btnTinhHoachToanGiaVon";
            this.btnTinhHoachToanGiaVon.Size = new System.Drawing.Size(154, 34);
            this.btnTinhHoachToanGiaVon.TabIndex = 2;
            this.btnTinhHoachToanGiaVon.Text = "Tính hoạch toán giá vốn";
            this.btnTinhHoachToanGiaVon.UseVisualStyleBackColor = true;
            this.btnTinhHoachToanGiaVon.Click += new System.EventHandler(this.btnTinhHoachToanGiaVon_Click);
            // 
            // monthPicker
            // 
            this.monthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.monthPicker.Location = new System.Drawing.Point(104, 53);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.Size = new System.Drawing.Size(110, 20);
            this.monthPicker.TabIndex = 5;
            // 
            // FormBaoCaoNhapTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.monthPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHangHoa);
            this.Controls.Add(this.cbKho);
            this.Controls.Add(this.btnTinhHoachToanGiaVon);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.title);
            this.Name = "FormBaoCaoNhapTon";
            this.Text = "FormBaoCaoNhapTon";
            this.Load += new System.EventHandler(this.FormBaoCaoNhapTon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHangHoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTinhHoachToanGiaVon;
        private System.Windows.Forms.DateTimePicker monthPicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTonCuoi;
    }
}