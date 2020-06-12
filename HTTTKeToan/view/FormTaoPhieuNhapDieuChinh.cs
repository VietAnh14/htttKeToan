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
    public partial class FormTaoPhieuNhapDieuChinh : Form
    {
        public FormTaoPhieuNhapDieuChinh()
        {
            InitializeComponent();
        }

        public static FormTaoPhieuNhapDieuChinh newInstance()
        {
            return new FormTaoPhieuNhapDieuChinh();
        }
    }
}
