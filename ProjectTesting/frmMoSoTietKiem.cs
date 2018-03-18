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
                string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
                cnn = new SqlConnection(str);

                cnn.Open();

                string sql = "insert into KhachHang values (N'" + txtMaKH.Text + "', N'" + txtHo.Text + "', N'" + txtTen.Text + "', '" +
                            dtpNgaySinh.Value.ToString("yyyy-MM-dd HH:mm:ss") + "', '";
                if (radNam.Checked)
                    sql += radNam.Text + "', N'" + txtSDT.Text + "', N'" + txtQuocTich.Text + "')";
                else
                    sql += radNu.Text + "', N'" + txtSDT.Text + "', N'" + txtQuocTich.Text + "')";
                string sql2 = "insert into SoTietKiem values(N'" + txtMaSTK.Text + "', N'" + txtMaKH.Text + "', '" + String.Format("{0:0,0}", txtSoTien.Text) + "', '" + txtLoaiTien.Text + "', '";
                sql2 += Convert.ToDouble(txLaiSuat.Text) + "', N'" + cbKyHan.SelectedItem.ToString() + "')";
                SqlCommand cmd = new SqlCommand(sql, cnn);
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
