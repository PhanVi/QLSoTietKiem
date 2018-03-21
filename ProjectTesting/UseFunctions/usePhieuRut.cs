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
    public class usePhieuRut
    {
        string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        SqlConnection cnn;

        public DataTable loadPhieuRut()
        {

            try
            {
                cnn = new SqlConnection(str);
                cnn.Open();
                string sql = "SELECT * FROM PhieuRutTien";
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

        //thêm rut
        //thêm 
        public void ThemPhieuRut(PhieuRut pr)
        {
            string sql = "insert into PhieuRutTien values (N'" + pr.MaPhieuRut + "', N'" + pr.MaSTK + "', N'" +
                        pr.MaKH + "', '" + pr.ThoiGianRut.ToString("yyyy-MM-dd HH:mm:ss") + "', N'" + pr.SoTienRut + "') ";
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

        //xoa rut
        public void XoaPhieuRut(PhieuRut pr)
        {
            string sql = "delete from PhieuRutTien where MaPhieuRut = N'" + pr.MaPhieuRut + "'";
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


        public Boolean MaPhieuRutNULL(string MaPhieuRut)
        {
            if (MaPhieuRut == "")
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
        public Boolean SoTienRutLaNULL(string SoTienRut)
        {
            if (SoTienRut == "")
                return true;
            return false;
        }
    }
}
