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
using ProjectTesting.UseFunctions;

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
            if (txtMaKH.Text == "" || txtMaSTK.Text == "" || txtHo.Text == "" || txtTen.Text == "" || txtSoTien.Text =="")
            {
                MessageBox.Show("Mời nhập đủ thông tin !","Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    KhachHang kh = new KhachHang(txtMaKH.Text, txtHo.Text, txtTen.Text, dtpNgaySinh.Text, txtGioiTinh.Text, txtSDT.Text, txtQuocTich.Text);
                    SoTietKiem stk = new SoTietKiem(txtMaSTK.Text, txtMaSTK.Text, txtSoTien.Text, txtLoaiTien.Text, txtLaiSuat.Text , cbKyHan.Text);
                    useKhachHang useKH = new useKhachHang();
                    
                    useSoTietKiem useSTK = new useSoTietKiem();
                    useKH.ThemKH(kh, stk);

                    gridThemMoiSTK.DataSource = useSTK.getDataSoTietKiem();

                    MessageBox.Show("Đăng ký thành công!");
                    init();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }

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
            txtGioiTinh.Text = "";
            txtMaSTK.Text = "";
            txtLaiSuat.Text = "";
            txtLoaiTien.Text = "";
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

        private void frmMoSoTietKiem_Load(object sender, EventArgs e)
        {

            useSoTietKiem stk = new useSoTietKiem();            
            gridThemMoiSTK.DataSource = stk.getDataSoTietKiem();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }




        ///// <summary>
        ///// sinh ma Khach hang
        ///// </summary>
        ///// <returns></returns>
        //string SinhMaKH()
        //{
        //    SqlConnection cnn = connection.getConn();
        //    connection.open(cnn);
        //    string strMaKH = "";
        //    try
        //    {
        //        string sql = "select count(*) from KhachHang";
        //        SqlCommand cmd = new SqlCommand(sql, cnn);
        //        int count = (int)cmd.ExecuteScalar();
        //        init();
        //        count++;
        //        strMaKH = "KH" + count.ToString();
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    connection.close(cnn);
        //    cnn.Dispose();
        //    return strMaKH;
        //}

        ///// <summary>
        ///// sinh ma so tiet kiem
        ///// </summary>
        ///// <returns></returns>
        //string SinhMaSTK()
        //{
        //    SqlConnection cnn = connection.getConn();
        //    connection.open(cnn);
        //    string strMaSTK = "";
        //    try
        //    {
        //        string sql = "select count(*) from SoTietKiem";
        //        SqlCommand cmd = new SqlCommand(sql, cnn);
        //        int count = (int)cmd.ExecuteScalar();
        //        count++;
        //        strMaSTK = "STK" + count.ToString();
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.close(cnn);
        //        cnn.Dispose();
        //    }
        //    return strMaSTK;
        //}
    }
}
