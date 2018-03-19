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
    public partial class frmPhieuGui : Form
    {
        SqlConnection cnn;
        public frmPhieuGui()
        {
            InitializeComponent();
        }


        private void LoadPhieuGui()
        {
            try
            {
                string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
                cnn = new SqlConnection(str);

                cnn.Open();
                string sql = "select * from PhieuGoiTien ";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Dispose();
                DataTable table = new DataTable();
                adapter.Fill(table);
                gridPhieuGui.DataSource = table;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
                cnn = new SqlConnection(str);

                cnn.Open();

                string sql = "insert into PhieuGoiTien values (N'"+txtMaPhieuGui.Text+"', N'"+txtMaSTK.Text+"', N'"+
                    txtMaKH.Text+"', '"+dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") +"', N'"+txtSoTienGui.Text+"') ";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                init();
                LoadPhieuGui();

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
            txtMaPhieuGui.Text = "";
            txtMaKH.Text = "";
            txtMaSTK.Text = "";
            txtSoTienGui.Text = "";
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            init();
        }
    }
}
