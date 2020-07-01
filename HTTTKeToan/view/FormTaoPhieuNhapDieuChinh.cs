using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTTTKeToan.utils;

namespace HTTTKeToan.view
{
    public partial class FormTaoPhieuNhapDieuChinh : Form
    {
        private List<DanhMucHangHoa> listHangHoa = new List<DanhMucHangHoa>();
        private const string MSCH = "CH1";
        private string pso = null;
        private const string LOAI_CT = "NMHH";
        public FormTaoPhieuNhapDieuChinh()
        {
            InitializeComponent();
        }

        public static FormTaoPhieuNhapDieuChinh newInstance()
        {
            return new FormTaoPhieuNhapDieuChinh();
        }

        private void FormTaoPhieuNhapDieuChinh_Load(object sender, EventArgs e)
        {
            cbKhoNhap.SelectedIndex = 0;
            cbNhaCungCap.SelectedIndex = 0;
            const String QUERY_LOAD_DATA = "SELECT * FROM DANHMUC_HANGHOA";
            var dt = DbUtils.Instance.ExecuteQuery(QUERY_LOAD_DATA);

            foreach (DataRow row in dt.Rows)
            {
                var item = new DanhMucHangHoa();
                item.maHangHoa = (int)row[0];
                item.donViTinh = row[2].ToString();
                item.tenHangHoa = row[1].ToString();
                listHangHoa.Add(item);
            }
            dataGridView1.AutoGenerateColumns = false;
            var colMaHang = dataGridView1.Columns[0] as DataGridViewComboBoxColumn;
            colMaHang.ValueMember = "MAHH";
            colMaHang.DataSource = dt;
        }

        struct DanhMucHangHoa
        {
            public int maHangHoa;
            public string donViTinh;
            public string tenHangHoa;

            public override string ToString()
            {
                return Convert.ToString(maHangHoa);
            }
        }

        struct HangHoa
        {
            public string pso;
            public int maHH;
            public string dvt;
            public int soLuong;
            public float donGia;
            public float thueXuat;
            public float tienThue;

            public String getInsertQuery()
            {
                string query = "insert into HANG_HOA values('" + pso.ToString() + "',";
                query += maHH.ToString() + ", N'";
                query += dvt.ToString() + "',";
                query += soLuong.ToString() + ",";
                query += donGia.ToString() + ",";
                query += thueXuat.ToString() + ",";
                query += tienThue.ToString() + ")";
                Console.WriteLine(query);
                return query;
            }

            public int insert()
            {
                return DbUtils.Instance.ExecuteNonQuery(getInsertQuery());
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var cell = dataGridView1.Rows[e.RowIndex].Cells[0] as DataGridViewComboBoxCell;
                var item = listHangHoa.Find(x => x.maHangHoa == (int)cell.Value);
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = item.tenHangHoa;
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = item.donViTinh;
                dataGridView1.Invalidate();
            }
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (!insertGocPhieu())
            {
                MessageBox.Show("Insert goc phieu failed", "Error");
                return;
            }
            List<HangHoa> listItem = new List<HangHoa>();
            int index = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (index == dataGridView1.RowCount)
                    break;
                if (row.Cells[0].Value == null)
                    break;
                var item = new HangHoa();
                item.pso = pso;
                item.maHH = (int)row.Cells[0].Value;
                item.dvt = (string)row.Cells[2].Value;
                item.soLuong = Convert.ToInt32(row.Cells[3].Value);
                item.donGia = float.Parse(row.Cells[4].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                var thueXuat = float.Parse(row.Cells[5].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                thueXuat = thueXuat * 0.1f;
                item.thueXuat = thueXuat;
                item.tienThue = float.Parse(row.Cells[6].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                listItem.Add(item);
                ++index;
            }
            try
            {
                foreach (var item in listItem)
                {
                    item.insert();
                }
            }
            catch
            {
                MessageBox.Show("Insert hang hoa failed", "Error");
            }
            dataGridView1.Rows.Clear();
            MessageBox.Show("Insert success", "Info");
        }

        private bool insertGocPhieu()
        {
            GocPhieu gocPhieu = new GocPhieu();
            gocPhieu.msKh = cbNhaCungCap.Text;
            gocPhieu.msCH = cbKhoNhap.Text;
            gocPhieu.loaiCT = LOAI_CT;
            gocPhieu.ngayLap = pickerNgNhap.Value.ToString();
            gocPhieu.soHD = cbSoHD.Text;
            gocPhieu.loaiHD = cbLoaiHD.Text;
            gocPhieu.ngPHHD = pickerNgPhatHanh.Value.ToString();
            gocPhieu.nttoan = pickerNgThanhToan.Value.ToString();
            gocPhieu.quyenHD = tbQuyenHD.Text;
            gocPhieu.lyDo = tbLyDo.Text;
            pso = gocPhieu.getPSO();
            return gocPhieu.insert();
        }
    }
}
