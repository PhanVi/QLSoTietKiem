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
   public  class SinhMaSTK
    {
        public string SinhMaSTKtu()
        {
            string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
            SqlConnection cnn;
            string strMaSTK = "";
            try
            {
                cnn = new SqlConnection(str);
                cnn.Open();
                string sql = "select count(*) from SoTietKiem";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                int count = (int)cmd.ExecuteScalar();
                count++;
                strMaSTK = "STK" + count.ToString();
                cmd.Dispose();
                cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return strMaSTK;
        }
    }
}
