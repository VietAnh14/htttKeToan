using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTTTKeToan.utils;
namespace HTTTKeToan.view
{
    public partial class FormBaoCaoNhapTon : Form
    {
        public FormBaoCaoNhapTon()
        {
            InitializeComponent();
        }


        private void initView()
        {
            monthPicker.Format = DateTimePickerFormat.Custom;
            monthPicker.CustomFormat = "MM/yyyy";
            cbKho.SelectedIndex = 0;
            var queryHH = "SELECT MAHH, TENHANGHOA FROM DANHMUC_HANGHOA";
            var dt = DbUtils.Instance.ExecuteQuery(queryHH);
            List<HangHoa> items = new List<HangHoa>();
            items.Add(new HangHoa(-1, "Tat ca hang hoa"));
            foreach(DataRow row in dt.Rows)
            {
                var item = new HangHoa();
                item.maHH = (int)row[0];
                item.tenHH = (string)row[1];
                items.Add(item);
            }
            cbHangHoa.DataSource = items;
        }

        struct HangHoa
        {
            public int maHH;
            public string tenHH;

            public HangHoa(int maHH, string tenHH)
            {
                this.maHH = maHH;
                this.tenHH = tenHH;
            }
            public override string ToString()
            {
                return tenHH;
            }
        }


        public static FormBaoCaoNhapTon newInstance()
        {
            return new FormBaoCaoNhapTon();
        }

        private void FormBaoCaoNhapTon_Load(object sender, EventArgs e)
        {
            initView();
            loadData();
        }


        private void loadData()
        {
            var loadAllQuery = "SELECT * FROM BAOCAONHAPXUATTON LEFT JOIN DANHMUC_HANGHOA ON BAOCAONHAPXUATTON.MAHH = DANHMUC_HANGHOA.MAHH";
            var dt = DbUtils.Instance.ExecuteQuery(loadAllQuery);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "THANG";
            dataGridView1.Columns[1].DataPropertyName = "MSCH";
            dataGridView1.Columns[2].DataPropertyName = "TENHANGHOA";
            dataGridView1.Columns[3].DataPropertyName = "SL_NHAP";
            dataGridView1.Columns[4].DataPropertyName = "SL_XUAT";
            dataGridView1.Columns[5].DataPropertyName = "SL_TON";
            dataGridView1.DataSource = dt;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var time = monthPicker.Value;
            var query = "SELECT * FROM BAOCAONHAPXUATTON A LEFT JOIN DANHMUC_HANGHOA B ON B.MAHH = A.MAHH";
            query += " WHERE YEAR(A.THANG) = ";
            query += time.Year;
            query += " AND MONTH(A.THANG) = ";
            query += time.Month;
            Dictionary<string, string> searchParameter = new Dictionary<string, string>();
            HangHoa hangHoa = (HangHoa)cbHangHoa.SelectedItem;
            if (hangHoa.maHH != -1)
            {
                searchParameter.Add("B.MAHH", hangHoa.maHH.ToString());
            }
            if (cbKho.SelectedIndex != 0)
            {
                searchParameter.Add("MSCH", cbKho.SelectedItem.ToString());
            }
            DataTable dt;
            if (searchParameter.Count == 0)
            {
                dt = DbUtils.Instance.ExecuteQuery(query);
            } else
            {
                foreach(var entry in searchParameter)
                {
                    query += "AND ";
                    query += entry.Key;
                    query += "='";
                    query += entry.Value + "'";
                }
            }
            dt = DbUtils.Instance.ExecuteQuery(query);
            dataGridView1.DataSource = dt;
        }

        private void btnTinhHoachToanGiaVon_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            try
            {
                HangHoa hangHoa = (HangHoa)cbHangHoa.SelectedItem;
                if (hangHoa.maHH != -1 || cbKho.SelectedItem.ToString() != cbKho.Items[0].ToString())
                {
                    string thang = monthPicker.Value.ToString("yyyy-MM-dd");
                    string msch = cbKho.SelectedItem.ToString();
                    string maHH = ((HangHoa)cbHangHoa.SelectedItem).maHH.ToString();
                    object[] parameter = { thang, msch, maHH };
                    var result = DbUtils.Instance.ExecuteNonQuery("HACHTOANGIAVON @THANG @MSCH @MAHH", parameter);
                    MessageBox.Show(this, "Hoạch toán giá vốn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        object[] parameter = { row["THANG"], row["MSCH"], row["MAHH"] };
                        var result = DbUtils.Instance.ExecuteNonQuery("HACHTOANGIAVON @THANG @MSCH @MAHH", parameter);
                    }
                    MessageBox.Show(this, "Hoạch toán giá vốn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch(Exception error)
            {
                MessageBox.Show(this, error.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
