using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTesting.Functions;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ProjectTesting.UseFunctions
{
    public class useSoTietKiem
    {

        string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        SqlConnection cnn;
        public DataTable getDataSoTietKiem()
        {
            
            //connection.open();
    
            try
            {
                cnn = new SqlConnection();
                cnn.Open();
                string sql = "SELECT * FROM SoTietKiem";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Dispose();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }
        }
    }
}
