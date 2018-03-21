using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.UseFunctions
{
    public class SinhPhieuRut
    {
        public string SinhMaPhieuRuttu()
        {
            string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
            SqlConnection cnn;
            string strMaPhieuRut = "";
            try
            {
                cnn = new SqlConnection(str);
                cnn.Open();
                string sql = "select count(*) from PhieuGoiTien";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                int count = (int)cmd.ExecuteScalar();
                count++;
                strMaPhieuRut = "MPR" + count.ToString();
                cmd.Dispose();
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return strMaPhieuRut;
        }
    }
}
