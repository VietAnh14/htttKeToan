namespace HTTTKeToan.view
{
    partial class Form3
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
            this.btnFind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NgTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NPHHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewPSO = new System.Windows.Forms.DataGridView();
            this.pickerNgLap = new System.Windows.Forms.DateTimePicker();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.cbMaCuaHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPSO)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(804, 21);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(77, 38);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MHH,
            this.SL,
            this.DVT,
            this.DG,
            this.TX});
            this.dataGridView1.Location = new System.Drawing.Point(10, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(965, 205);
            this.dataGridView1.TabIndex = 13;
            // 
            // NgTT
            // 
            this.NgTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgTT.HeaderText = "Ngày thanh toán";
            this.NgTT.Name = "NgTT";
            this.NgTT.ReadOnly = true;
            // 
            // NPHHD
            // 
            this.NPHHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NPHHD.HeaderText = "Ngày phát hành hóa đơn";
            this.NPHHD.Name = "NPHHD";
            this.NPHHD.ReadOnly = true;
            // 
            // SHD
            // 
            this.SHD.HeaderText = "Số hóa đơn";
            this.SHD.Name = "SHD";
            this.SHD.ReadOnly = true;
            // 
            // NgLap
            // 
            this.NgLap.HeaderText = "Ngày lập";
            this.NgLap.Name = "NgLap";
            this.NgLap.ReadOnly = true;
            // 
            // MSKH
            // 
            this.MSKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MSKH.HeaderText = "Mã số khách hàng";
            this.MSKH.Name = "MSKH";
            this.MSKH.ReadOnly = true;
            // 
            // MCH
            // 
            this.MCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MCH.HeaderText = "Mã số cửa hàng";
            this.MCH.Name = "MCH";
            this.MCH.ReadOnly = true;
            // 
            // PSO
            // 
            this.PSO.HeaderText = "PSO";
            this.PSO.Name = "PSO";
            // 
            // dataGridViewPSO
            // 
            this.dataGridViewPSO.AllowUserToAddRows = false;
            this.dataGridViewPSO.AllowUserToDeleteRows = false;
            this.dataGridViewPSO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPSO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PSO,
            this.MCH,
            this.MSKH,
            this.NgLap,
            this.SHD,
            this.NPHHD,
            this.NgTT});
            this.dataGridViewPSO.Location = new System.Drawing.Point(10, 80);
            this.dataGridViewPSO.Name = "dataGridViewPSO";
            this.dataGridViewPSO.Size = new System.Drawing.Size(965, 181);
            this.dataGridViewPSO.TabIndex = 12;
            this.dataGridViewPSO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPSO_CellClick);
            // 
            // pickerNgLap
            // 
            this.pickerNgLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerNgLap.Location = new System.Drawing.Point(664, 24);
            this.pickerNgLap.Name = "pickerNgLap";
            this.pickerNgLap.Size = new System.Drawing.Size(89, 20);
            this.pickerNgLap.TabIndex = 11;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Items.AddRange(new object[] {
            "KH01",
            "KH02",
            "KH03",
            "KH04",
            "KH05"});
            this.cbKhachHang.Location = new System.Drawing.Point(385, 23);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(121, 21);
            this.cbKhachHang.TabIndex = 9;
            // 
            // cbMaCuaHang
            // 
            this.cbMaCuaHang.FormattingEnabled = true;
            this.cbMaCuaHang.Items.AddRange(new object[] {
            "KHO01",
            "KHO02",
            "KHO03",
            "KHO04",
            "KHO05",
            "KHO06"});
            this.cbMaCuaHang.Location = new System.Drawing.Point(129, 23);
            this.cbMaCuaHang.Name = "cbMaCuaHang";
            this.cbMaCuaHang.Size = new System.Drawing.Size(121, 21);
            this.cbMaCuaHang.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(594, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cửa hàng";
            // 
            // MHH
            // 
            this.MHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MHH.HeaderText = "Mã hàng hóa";
            this.MHH.Name = "MHH";
            this.MHH.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            // 
            // DG
            // 
            this.DG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DG.HeaderText = "Đơn giá";
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            // 
            // TX
            // 
            this.TX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TX.HeaderText = "Thuế xuất";
            this.TX.Name = "TX";
            this.TX.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewPSO);
            this.Controls.Add(this.pickerNgLap);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.cbMaCuaHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPSO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPHHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSO;
        private System.Windows.Forms.DataGridView dataGridViewPSO;
        private System.Windows.Forms.DateTimePicker pickerNgLap;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.ComboBox cbMaCuaHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TX;
    }
}