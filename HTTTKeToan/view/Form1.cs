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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setupView();
            loadData();
        }

        private void setupView()
        {
            cbKhachHang.SelectedIndex = 0;
            cbMaCuaHang.SelectedIndex = 0;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "MAHH";
            dataGridView1.Columns[1].DataPropertyName = "SL";
            dataGridView1.Columns[2].DataPropertyName = "DVT";
            dataGridView1.Columns[3].DataPropertyName = "DONGIA";
            dataGridView1.Columns[4].DataPropertyName = "THUE_SUAT";
            dataGridView1.Columns[5].DataPropertyName = "BQGQ";
        }

        private void loadData()
        {
            const string sql = "SELECT * FROM GOC_PHIEU";
            var data = DbUtils.Instance.ExecuteQuery(sql);
            dataGridViewPSO.AutoGenerateColumns = false;
            dataGridViewPSO.Columns[0].DataPropertyName = "PSO";
            dataGridViewPSO.Columns[1].DataPropertyName = "MSCH";
            dataGridViewPSO.Columns[2].DataPropertyName = "MSKH";
            dataGridViewPSO.Columns[3].DataPropertyName = "NLAP";
            dataGridViewPSO.Columns[4].DataPropertyName = "SOHD";
            dataGridViewPSO.Columns[5].DataPropertyName = "NGPHHD";
            dataGridViewPSO.Columns[6].DataPropertyName = "NTTOAN";
            dataGridViewPSO.DataSource = data;
        }

        public static Form1 getInstance()
        {
            return new Form1();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string maKh = cbKhachHang.SelectedItem.ToString();
            string maCH = cbMaCuaHang.SelectedItem.ToString();
            string date = pickerNgLap.Value.ToString("yyyy-MM-dd");
            string query = "select * from GOC_PHIEU WHERE NLAP = '{0}' AND MSCH = '{1}' AND MSKH = '{2}'";
            query = String.Format(query, date, maCH, maKh);
            var dt = DbUtils.Instance.ExecuteQuery(query);
            dataGridViewPSO.DataSource = dt;
        }

        private void dataGridViewPSO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string pso = dataGridViewPSO.Rows[e.RowIndex].Cells[0].Value.ToString();
                var dt = DbUtils.Instance.ExecuteQuery("CHITIET_PHIEUXUAT @pso", new object[] { pso });
                dataGridView1.DataSource = dt;
            }
        }
    }
}
