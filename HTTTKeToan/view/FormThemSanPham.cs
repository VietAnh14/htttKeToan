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
    public partial class FormThemSanPham : Form
    {
        public FormThemSanPham()
        {
            InitializeComponent();
        }

        public static FormThemSanPham newInstance()
        {
            return new FormThemSanPham();
        }
    }
}
