using ProjectTesting.Functions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.UseFunctions
{
  public  class usePhieuGui
    {
        string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        SqlConnection cnn;

        public DataTable loadPhieuGui()
        {

            try
            {
                cnn = new SqlConnection(str);
                cnn.Open();
                string sql = "SELECT * FROM PhieuGoiTien";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Dispose();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;

            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }

        }


        //thêm 
        public void ThemPhieuGui(PhieuGui pg)
        {
            string sql = "insert into PhieuGoiTien values (N'" + pg.MaPhieuGui + "', N'" + pg.MaSTK + "', N'" +
                        pg.MaKH + "', '" + pg.ThoiGianGui.ToString("yyyy-MM-dd HH:mm:ss") + "', N'" + pg.SoTienGui + "') ";
            try
            {
                cnn = new SqlConnection(str);
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();               
                cmd.Dispose();
                cnn.Close();
                cnn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               // throw;
            }
        }

        //sửa
        public void XoaPhieuGui(PhieuGui pg)
        {
            string sql = "delete from PhieuGoiTien where MaPhieuGoi = N'"+pg.MaPhieuGui+"'";
            try
            {
                cnn = new SqlConnection(str);
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
                cnn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        public Boolean MaPhieuGuiNULL(string MaPhieuGui)
        {
            if (MaPhieuGui == "")
                return true;
            return false;
        }

        public Boolean MaSTKLaNULL(string MaSTK)
        {
            if (MaSTK == "")               
                return true;
            return false;
        }
        public Boolean MaKHLaNULL(string MaKH)
        {
            if (MaKH == "") 
                return true;
            return false;
        }
        public Boolean SoTienGuiLaNULL(string SoTienGui)
        {
            if (SoTienGui == "")
                return true;
            return false;
        }
    }
}
