namespace HTTTKeToan.view
{
    partial class Form1
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
            this.cbMaCuaHang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pickerNgLap = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPSO = new System.Windows.Forms.DataGridView();
            this.PSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NPHHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPSO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cửa hàng";
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
            this.cbMaCuaHang.Location = new System.Drawing.Point(126, 19);
            this.cbMaCuaHang.Name = "cbMaCuaHang";
            this.cbMaCuaHang.Size = new System.Drawing.Size(121, 21);
            this.cbMaCuaHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách hàng";
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
            this.cbKhachHang.Location = new System.Drawing.Point(382, 19);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(121, 21);
            this.cbKhachHang.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày lập";
            // 
            // pickerNgLap
            // 
            this.pickerNgLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerNgLap.Location = new System.Drawing.Point(661, 20);
            this.pickerNgLap.Name = "pickerNgLap";
            this.pickerNgLap.Size = new System.Drawing.Size(89, 20);
            this.pickerNgLap.TabIndex = 2;
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
            this.dataGridViewPSO.Location = new System.Drawing.Point(7, 76);
            this.dataGridViewPSO.Name = "dataGridViewPSO";
            this.dataGridViewPSO.Size = new System.Drawing.Size(965, 181);
            this.dataGridViewPSO.TabIndex = 3;
            this.dataGridViewPSO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPSO_CellClick);
            // 
            // PSO
            // 
            this.PSO.HeaderText = "PSO";
            this.PSO.Name = "PSO";
            // 
            // MCH
            // 
            this.MCH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MCH.HeaderText = "Mã số cửa hàng";
            this.MCH.Name = "MCH";
            this.MCH.ReadOnly = true;
            // 
            // MSKH
            // 
            this.MSKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MSKH.HeaderText = "Mã số khách hàng";
            this.MSKH.Name = "MSKH";
            this.MSKH.ReadOnly = true;
            // 
            // NgLap
            // 
            this.NgLap.HeaderText = "Ngày lập";
            this.NgLap.Name = "NgLap";
            this.NgLap.ReadOnly = true;
            // 
            // SHD
            // 
            this.SHD.HeaderText = "Số hóa đơn";
            this.SHD.Name = "SHD";
            this.SHD.ReadOnly = true;
            // 
            // NPHHD
            // 
            this.NPHHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NPHHD.HeaderText = "Ngày phát hành hóa đơn";
            this.NPHHD.Name = "NPHHD";
            this.NPHHD.ReadOnly = true;
            // 
            // NgTT
            // 
            this.NgTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgTT.HeaderText = "Ngày thanh toán";
            this.NgTT.Name = "NgTT";
            this.NgTT.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MHH,
            this.SL,
            this.DVT,
            this.DG,
            this.TX,
            this.GV});
            this.dataGridView1.Location = new System.Drawing.Point(7, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(965, 205);
            this.dataGridView1.TabIndex = 4;
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
            // GV
            // 
            this.GV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GV.HeaderText = "Gía vốn";
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(801, 17);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(77, 38);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form1
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPSO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaCuaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker pickerNgLap;
        private System.Windows.Forms.DataGridView dataGridViewPSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPHHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgTT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TX;
        private System.Windows.Forms.DataGridViewTextBoxColumn GV;
        private System.Windows.Forms.Button btnFind;
    }
}