using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ProjectTesting.Functions
{
    
    public class connection
    {
       

        public static SqlConnection getConn()
        {
            string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
            SqlConnection cnn = new SqlConnection(str);
            return cnn;
        }
        //Open
        public static void open(SqlConnection cnn)
        {
            try
            {
                if (getConn().State == ConnectionState.Closed)
                    getConn().Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        //Close
        public static void close(SqlConnection cnn)
        {
            try
            {
                if (getConn().State == ConnectionState.Open)
                    getConn().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
