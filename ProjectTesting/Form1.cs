using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
   

        private void menuThongTinKH_Click_1(object sender, EventArgs e)
        {
            frmKhachHang formKH = new frmKhachHang();
            formKH.ShowDialog();
        }

        private void menuMoSoTietKiem_Click(object sender, EventArgs e)
        {
            frmMoSoTietKiem formMo = new frmMoSoTietKiem();
            formMo.ShowDialog();
        }

        private void menuPhieuRut_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chưa làm");
            frmPhieuRut formRut = new frmPhieuRut();
            formRut.ShowDialog();

        }

        private void menuPhieuGui_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chưa làm");
            frmPhieuGui formGui = new frmPhieuGui();
            formGui.ShowDialog();
        }

        private void menuThongKe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Càngchưa làm");
        }

        private void menuThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
