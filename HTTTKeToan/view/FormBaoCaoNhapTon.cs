using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            cbKho.Items.Add("- Tất cả cửa hàng -");
            cbKho.SelectedIndex = 0;
            cbHangHoa.Items.Add("- Tất cả hàng hóa -");
            cbHangHoa.SelectedIndex = 0;
        }


        public static FormBaoCaoNhapTon newInstance()
        {
            return new FormBaoCaoNhapTon();
        }

        private void FormBaoCaoNhapTon_Load(object sender, EventArgs e)
        {
            initView();
        }
    }
}
