//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.SqlClient;
//using System.Configuration;
//using System.Data;

//namespace ProjectTesting.Functions
//{
    
//    public class connection
//    {
       

//        //Open
//        public static void open()
//        {
//            string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
//            SqlConnection cnn = new SqlConnection(str);
//            try
//            {
//                if(cnn.State == ConnectionState.Closed)
//                    cnn.Open();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error:" + ex.Message);
//            }
//        }
//        //Close
//        public static void close(SqlConnection cnn)
//        {

//            try
//            {
//                if(cnn.State == ConnectionState.Open)
//                    cnn.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error:" + ex.Message);
//            }
//        }
        
//    }
//}
