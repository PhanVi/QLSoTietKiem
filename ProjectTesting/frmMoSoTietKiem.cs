using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ProjectTesting.Functions;

namespace ProjectTesting
{
    public partial class frmMoSoTietKiem : Form
    {
        public frmMoSoTietKiem()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {

                KhachHang kh = new KhachHang(txtMaKH.Text, txtHo.Text, txtTen.Text, dtpNgaySinh.Text, txtGioiTinh.Text, txtSDT.Text, txtQuocTich.Text);
                MessageBox.Show("Đăng ký thành công!");
                init();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            
        }

        private void init()
        {
            txtMaKH.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtQuocTich.Text = "";
            dtpNgaySinh.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            init();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }           
        }
    }
}
