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
                cnn = new SqlConnection(str);
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
                            kh.NgaySinh.ToString("yyyy-MM-dd HH:mm:ss") + "', N'"+kh.GioiTinh+"', '"+ kh.SDT +"',  N'"+kh.QuocTich+"')";
           
                string sql2 = "insert into SoTietKiem values(N'" + stk.MaSTK + "', N'" + kh.MaKH + "', '" + 
                stk.SoTien + "', '" + stk.LoaiTien + "', '"+ stk.LaiSuat + "', N'" + stk.KyHan + "')";
            try
            {
                cnn = new SqlConnection(str);
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
            
            string sql = "update KhachHang set HoKH = N'" + kh.HoKH + "', TenKH = N'" + kh.TenKH + "', SDT = '" + kh.SDT + "', NgaySinh = N'" +
                    kh.NgaySinh.ToString("yyyy-MM-dd HH:mm:ss") + "' where MaKH = '" + kh.MaKH + "'";
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

        ///kiểm tra null
        ///
        public Boolean MaKHLaNULL(string MaKH)
        {
            if (MaKH == "")
                //MessageBox.Show("MaKH không được trống");
                return true;
            return false;
        }

        public Boolean HoKHLaNULL(string HoKH)
        {
            if (HoKH == "")
                //MessageBox.Show("MaKH không được trống");
                return true;
            return false;
        }

        public Boolean TenKHLaNULL(string TenKH)
        {
            if (TenKH == "")
                //MessageBox.Show("TenKH không được trống");
                return true;
            return false;
        }
        
        public Boolean GioiTinhLaNULL(string GioiTinh)
        {
            if (GioiTinh == "")
                //MessageBox.Show("GioiTinh không được trống");
                return true;
            return false;
        }
        public Boolean SDTLaNULL(string SDT)
        {
            if (SDT == "")
                //MessageBox.Show("SDT không được trống");
                return true;
            return false;
        }
        public Boolean QuocTichLaNULL(string QuocTich)
        {
            if (QuocTich == "")
                //MessageBox.Show("QuocTich không được trống");
                return true;
            return false;
        }
    }
}

