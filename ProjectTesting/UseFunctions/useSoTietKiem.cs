using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTesting.Functions;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace ProjectTesting.UseFunctions
{
    public class useSoTietKiem
    {

        string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        SqlConnection cnn;
        public DataTable getDataSoTietKiem()
        {
          
            try
            {
                cnn = new SqlConnection(str);
                cnn.Open();
                string sql = "SELECT * FROM SoTietKiem";
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

        public Boolean MaSTKLaNULL(string MaSTK)
        {
            if (MaSTK == "")
                //MessageBox.Show("MaKH không được trống");
                return true;
            return false;
        }
        public Boolean SoTienGuiaNULL(string SoTien)
        {
            if (SoTien == "")
                //MessageBox.Show("MaKH không được trống");
                return true;
            return false;
        }

        public Boolean TienLaiaNULL(string TienLai)
        {
            if (TienLai == "")
                //MessageBox.Show("MaKH không được trống");
                return true;
            return false;
        }
    }
}
