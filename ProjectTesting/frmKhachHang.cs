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
    public partial class frmKhachHang : Form
    {
        SqlConnection cnn;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void LoadKH()
        {
            try
            {
                string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
                cnn = new SqlConnection(str);

                cnn.Open();
                string sql = "select * from KhachHang ";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Dispose();
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridKhachHang.DataSource = table;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {

            LoadKH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
                cnn = new SqlConnection(str);

                cnn.Open();
                string sql = "update KhachHang set HoKH = N'" + txtHo.Text + "', TenKH = N'" + txtTen.Text + "', SDT = '"+txtSDT.Text+"', NgaySinh = N'"+ 
                    dtpNgaySinh.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' where MaKH = '"+txtMaKH.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Dispose();
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridKhachHang.DataSource = table;
                LoadKH();
                MessageBox.Show("Cập nhật thành công!");
                cnn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //throw;
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
                cnn = new SqlConnection(str);

                cnn.Open();
                string sql = "delete from KhachHang where MaKH = N'"+txtMaKH.Text+"' ";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Dispose();
                string sql2 = "delete from SoTietKiem where MaKH = N'" + txtMaKH.Text + "' ";
                cmd = new SqlCommand(sql2, cnn);
                adapter = new SqlDataAdapter(cmd);
                cmd.Dispose();
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridKhachHang.DataSource = table;
                LoadKH();
                MessageBox.Show("Xóa thành công!");
                cnn.Close();
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
