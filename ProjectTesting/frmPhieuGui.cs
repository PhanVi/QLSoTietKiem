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
    public partial class frmPhieuGui : Form
    {
        usePhieuGui usePhieugui = new usePhieuGui();
        public frmPhieuGui()
        {
            InitializeComponent();
        }


        

        private void btnThem_Click(object sender, EventArgs e)
        {
           

            //bắt đk
            if (usePhieugui.MaSTKLaNULL(txtMaSTK.Text))
            {
                MessageBox.Show("Mã Sổ tiết kiệm không được trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (usePhieugui.MaKHLaNULL(txtMaKH.Text))
            {
                MessageBox.Show("Mã khách hàng không được trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (usePhieugui.SoTienGuiLaNULL(txtSoTienGui.Text))
            {
                MessageBox.Show("số tiền gửi không được trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    
                    PhieuGui pg = new PhieuGui(txtMaPhieuGui.Text, txtMaSTK.Text, txtMaKH.Text, dateTimePicker1.Text, txtSoTienGui.Text);
                    usePhieugui.ThemPhieuGui(pg);
                    init();
                    gridPhieuGui.DataSource = usePhieugui.loadPhieuGui();
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
            txtMaPhieuGui.Text = "";
            txtMaKH.Text = "";
            txtMaSTK.Text = "";
            txtSoTienGui.Text = "";
        }

        private void frmPhieuGui_Load(object sender, EventArgs e)
        {
            //sinh ma phieugui
            SinhMaPhieuGui MaPhieugui = new SinhMaPhieuGui();
            txtMaPhieuGui.Text = MaPhieugui.SinhMaPhieuGuitu().ToString();

            gridPhieuGui.DataSource = usePhieugui.loadPhieuGui();
        }


        /// <summary>
        /// txtSoTe=ienGui khong cho nhập chữ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSoTienGui_KeyUp(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// hiển thị dữ liệu từ grid lên textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridPhieuGui_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridPhieuGui.Rows[e.RowIndex];
                txtMaPhieuGui.Text = row.Cells["MaPhieuGoi"].Value.ToString();
                txtMaSTK.Text = row.Cells["MaSTK"].Value.ToString();
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                dateTimePicker1.Text = row.Cells["ThoiGianGoiTien"].Value.ToString();
                txtSoTienGui.Text = row.Cells["SoTienGoi"].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //sinh ma phieugui
            
            init();
            SinhMaPhieuGui MaPhieugui = new SinhMaPhieuGui();
            txtMaPhieuGui.Text = MaPhieugui.SinhMaPhieuGuitu().ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuGui pg = new PhieuGui(txtMaPhieuGui.Text, txtMaSTK.Text, txtMaKH.Text, dateTimePicker1.Text, txtSoTienGui.Text);
                usePhieugui.XoaPhieuGui(pg);
                init();
                gridPhieuGui.DataSource = usePhieugui.loadPhieuGui();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
