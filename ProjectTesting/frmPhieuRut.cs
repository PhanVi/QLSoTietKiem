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
    public partial class frmPhieuRut : Form
    {
        SqlConnection cnn;
        usePhieuRut useRut = new usePhieuRut();
        public frmPhieuRut()
        {
            InitializeComponent();
        }

        private void loadPhieuRut()
        {
            try
            {
                string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
                cnn = new SqlConnection(str);

                cnn.Open();
                string sql = "select * from PhieuRutTien ";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Dispose();
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridPhieuRut.DataSource = table;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void init()
        {
            txtMaPhieuRut.Text = "";
            txtMaKH.Text = "";
            txtMaSTK.Text = "";
            txtSoTienRut.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //bắt đk
                if (useRut.MaSTKLaNULL(txtMaSTK.Text))
                {
                    MessageBox.Show("Mã Sổ tiết kiệm không được trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (useRut.MaKHLaNULL(txtMaKH.Text))
                {
                    MessageBox.Show("Mã khách hàng không được trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (useRut.SoTienRutLaNULL(txtSoTienRut.Text))
                {
                    MessageBox.Show("số tiền gửi không được trống!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {

                        PhieuRut pr = new PhieuRut(txtMaPhieuRut.Text, txtMaSTK.Text, txtMaKH.Text, dateTimePicker1.Text, txtSoTienRut.Text);
                        useRut.ThemPhieuRut(pr);
                        init();
                        gridPhieuRut.DataSource = useRut.loadPhieuRut();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        //throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            init();
            SinhPhieuRut MaPhieuRut = new SinhPhieuRut();
            txtMaPhieuRut.Text = MaPhieuRut.SinhMaPhieuRuttu().ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuRut pg = new PhieuRut(txtMaPhieuRut.Text, txtMaSTK.Text, txtMaKH.Text, dateTimePicker1.Text, txtSoTienRut.Text);
                useRut.XoaPhieuRut(pg);
                init();
                gridPhieuRut.DataSource = useRut.loadPhieuRut();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void gridPhieuRut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridPhieuRut.Rows[e.RowIndex];
                txtMaPhieuRut.Text = row.Cells["MaPhieuRut"].Value.ToString();
                txtMaSTK.Text = row.Cells["MaSTK"].Value.ToString();
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                dateTimePicker1.Text = row.Cells["ThoiGianRutTien"].Value.ToString();
                txtSoTienRut.Text = row.Cells["SoTienRut"].Value.ToString();
            }
        }

        private void frmPhieuRut_Load(object sender, EventArgs e)
        {
            SinhPhieuRut MaPhieuRut = new SinhPhieuRut();
            txtMaPhieuRut.Text = MaPhieuRut.SinhMaPhieuRuttu().ToString();

            gridPhieuRut.DataSource = useRut.loadPhieuRut();
        }
    }
}
