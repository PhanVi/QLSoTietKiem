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
    public class useKhachHang
    {

        string str = ConfigurationManager.ConnectionStrings["str"].ConnectionString;
        SqlConnection cnn;
        /// <summary>
        /// load du lieu khach hang
        /// </summary>
        /// <returns></returns>
        public DataTable loadKH()
        {
            
            try
            {
                cnn = new SqlConnection();
                cnn.Open();
                string sql = "SELECT * FROM KhachHang";
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

        /// <summary>
        /// them khach hang
        /// </summary>
        /// <param name="kh"></param>
        /// <param name="stk"></param>
        public void ThemKH(KhachHang kh, SoTietKiem stk)
        {
            
                string sql = "insert into KhachHang values (N'" + kh.MaKH + "', N'" + kh.HoKH + "', N'" + kh.TenKH + "', '" +
                            kh.NgaySinh + "', N'"+kh.GioiTinh+"', N'"+kh.QuocTich+"'";
           
                string sql2 = "insert into SoTietKiem values(N'" + stk.MaSTK + "', N'" + kh.MaKH + "', '" + 
                stk.SoTien + "', '" + stk.LoaiTien + "', '"+ stk.LaiSuat + "', N'" + stk.KyHan + "')";
            try
            {
                cnn = new SqlConnection();
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(sql2, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
                cnn.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }


        public void SuaKH(KhachHang kh)
        {

           
            try
            {
                cnn = new SqlConnection();
                cnn.Open();
                string sql = "update KhachHang set HoKH = N'" + kh.HoKH + "', TenKH = N'" + kh.TenKH + "', SDT = '" + kh.SDT + "', NgaySinh = N'" +
                    kh.NgaySinh + "' where MaKH = '" + kh.MaKH + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.Dispose();
                DataTable table = new DataTable();
                adapter.Fill(table);

                cnn.Close
                    ();
                cnn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }
    }
}
