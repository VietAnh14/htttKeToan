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
    public partial class FormPhieuXuatDieuChinh : Form
    {
        public FormPhieuXuatDieuChinh()
        {
            InitializeComponent();
        }

        public static FormPhieuXuatDieuChinh newInstance()
        {
            return new FormPhieuXuatDieuChinh();
        }

        private void FormPhieuXuatDieuChinh_Load(object sender, EventArgs e)
        {
            ViewUtils.setDefaulCbText(cbChonKhachHang, "Chọn khách hàng");
            ViewUtils.setDefaulCbText(cbKhoXuat, "Chọn kho xuất");

        }
    }
}
