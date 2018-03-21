using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTesting.Functions;
using ProjectTesting.UseFunctions;

namespace ProjectTesting
{
    public partial class frmMoSoTietKiem : Form
    {
        useKhachHang useKH = new useKhachHang();
        useSoTietKiem useSTK = new useSoTietKiem();
        public frmMoSoTietKiem()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (useKH.MaKHLaNULL(txtMaKH.Text) )
            {
                MessageBox.Show("Mã Khách hàng không được trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (useKH.HoKHLaNULL(txtHo.Text) ==true)
            {
                MessageBox.Show("Họ Khách hàng không được trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (useKH.TenKHLaNULL(txtTen.Text) == true)
            {
                MessageBox.Show("Tên Khách hàng không được trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (useKH.SDTLaNULL(txtSDT.Text) == true)
            {
                MessageBox.Show("SDT Khách hàng không được trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (useKH.QuocTichLaNULL(txtQuocTich.Text) == true)
            {
                MessageBox.Show("Họ Khách hàng không được trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (useKH.GioiTinhLaNULL(txtGioiTinh.Text) == true)
            {
                MessageBox.Show("Giới tính Khách hàng không được trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (useSTK.MaSTKLaNULL(txtMaSTK.Text) == true)
            {
                MessageBox.Show("Mã số tiết kiệm không được trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (useSTK.SoTienGuiaNULL(txtSoTien.Text) == true)
            {
                MessageBox.Show("Mời nhập số tiền gửi ban đầu!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (useSTK.TienLaiaNULL(txtLaiSuat.Text) == true)
            {
                MessageBox.Show("Mời nhập lãi suất ban đầu!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                try
                {
                    KhachHang kh = new KhachHang(txtMaKH.Text, txtHo.Text, txtTen.Text, dtpNgaySinh.Text, txtGioiTinh.Text, txtSDT.Text, txtQuocTich.Text);
                    SoTietKiem stk = new SoTietKiem(txtMaSTK.Text, txtMaSTK.Text, txtSoTien.Text, txtLoaiTien.Text, txtLaiSuat.Text , cbKyHan.Text);
                    
                    
                   
                    useKH.ThemKH(kh, stk);

                    gridThemMoiSTK.DataSource = useSTK.getDataSoTietKiem();

                    MessageBox.Show("Đăng ký thành công!");
                    init();
                    //sinh ma kh
                    SinhMaKH MaKhachHang = new SinhMaKH();
                    txtMaKH.Text = MaKhachHang.SinhMaKHtu().ToString();

                    //sinh ma sotietkiem
                    SinhMaSTK MaSoTietKiem = new SinhMaSTK();
                    txtMaSTK.Text = MaSoTietKiem.SinhMaSTKtu().ToString();
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
            txtHo.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            txtQuocTich.Text = "";
            dtpNgaySinh.Text = "";
            txtGioiTinh.Text = "";
            txtLaiSuat.Text = "";
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

            //sinh ma kh
            SinhMaKH MaKhachHang = new SinhMaKH();
            txtMaKH.Text = MaKhachHang.SinhMaKHtu().ToString();

            //sinh ma sotietkiem
            SinhMaSTK MaSoTietKiem = new SinhMaSTK();
            txtMaSTK.Text = MaSoTietKiem.SinhMaSTKtu().ToString();

            useSoTietKiem stk = new useSoTietKiem();
            gridThemMoiSTK.DataSource = stk.getDataSoTietKiem();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
       
    }
}
