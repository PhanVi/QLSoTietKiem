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
using ProjectTesting.UseFunctions;
using ProjectTesting.Functions;

namespace ProjectTesting
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
       
        private void frmKhachHang_Load(object sender, EventArgs e)
        {

            useKhachHang kh = new useKhachHang();
            gridKhachHang.DataSource = kh.loadKH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
                try
                {
                    KhachHang kh = new KhachHang(txtMaKH.Text, txtHo.Text, txtTen.Text, dtpNgaySinh.Text, txtGioiTinh.Text, txtSDT.Text, txtQuocTich.Text);
                    useKhachHang suaKH = new useKhachHang();
                    suaKH.SuaKH(kh);
                    gridKhachHang.DataSource = suaKH.loadKH();
                    MessageBox.Show("Sửa thành công!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    //throw;
                }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            gridKhachHang.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < gridKhachHang.RowCount - 1; i++)
                {
                    gridKhachHang.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < gridKhachHang.RowCount - 1; i++)
                {
                    if (gridKhachHang.Rows[i].Cells["MaKH"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || gridKhachHang.Rows[i].Cells["HoKH"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || gridKhachHang.Rows[i].Cells["TenKH"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                    {
                        gridKhachHang.Rows[i].Visible = true;
                    }
                    else
                    {
                        gridKhachHang.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void gridKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtHo.Text = row.Cells["HoKH"].Value.ToString();
                txtTen.Text = row.Cells["TenKH"].Value.ToString();
                dtpNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtQuocTich.Text = row.Cells["QuocTich"].Value.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHo.Text = "";
            txtGioiTinh.Text = "";
            txtTimKiem.Text = "";
            txtSDT.Text = "";
            txtQuocTich.Text = "";
            dtpNgaySinh.Text = "";
        }
    }
}
