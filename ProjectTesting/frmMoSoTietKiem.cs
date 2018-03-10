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

namespace ProjectTesting
{
    public partial class frmMoSoTietKiem : Form
    {
        SqlConnection cnn;
        public frmMoSoTietKiem()
        {
            InitializeComponent();
        }

       

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            
            try
            {
                cnn = new SqlConnection();
                cnn.ConnectionString = "Data Source = .\\SQLEXPRESS;  Initial Catalog = QLSoTietKiem; Integrated Security = True;";
                string sql = "insert into KhachHang values (N'" + txtMaKH.Text + "', N'" + txtHo.Text + "', N'" + txtTen.Text + "', '" + dtpNgaySinh.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + txtGioiTinh.Text + "', N'" + txtEmail.Text + "', '" + txtSDT.Text + "', N'" + txtQuocTich.Text + "')";
                string sql2 = "insert into SoTietKiem values(N'" + txtMaSTK.Text + "', N'" + txtMaKH.Text + "', '" + txtSoTien.Text + "', '" + txtLoaiTien.Text + "', '" + txLaiXuat.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cnn.Open();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(sql2, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng ký thành công!");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            
        }

        
       
    }
}
