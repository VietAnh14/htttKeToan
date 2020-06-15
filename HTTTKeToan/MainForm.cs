using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTTTKeToan.view;

namespace HTTTKeToan
{
    public partial class MainForm : Form
    {
        protected Form currentForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            currentForm = FormBaoCaoNhapTon.newInstance();
            currentForm.TopLevel = false;
            panelContainer.Controls.Add(currentForm);
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            currentForm.Show();
        }

        private void báoCáoNhậpXuấtTồnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadFormInPanel(FormBaoCaoNhapTon.newInstance());
        }

        private void loadFormInPanel(Form form)
        {
            if (form.GetType() != currentForm.GetType()) {
                currentForm.Close();
                panelContainer.Controls.Clear();
                currentForm = form;
                form.TopLevel = false;
                panelContainer.Controls.Add(form);
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
        }

        private void tạoPhiếuNhậpĐiềuChỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadFormInPanel(FormTaoPhieuNhapDieuChinh.newInstance());
        }

        private void tạoPhiếuXuấtĐiềuChỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadFormInPanel(FormPhieuXuatDieuChinh.newInstance());
        }

        private void quảnLýPhiếuXuấtBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadFormInPanel(Form1.getInstance());
        }
    }
}
