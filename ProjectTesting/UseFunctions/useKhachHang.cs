using ProjectTesting.Functions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting.UseFunctions
{
    public class useKhachHang
    {
        public void ThemKH(KhachHang kh, SoTietKiem stk)
        {
            SqlConnection cnn = connection.getConn();
            connection.open(cnn);
            string sql = "insert into KhachHang values (N'" + kh.MaKH + "', N'" + kh.HoKH + "', N'" + kh.TenKH + "', '" +
                            kh.NgaySinh + "', N'"+kh.GioiTinh+"'";
           
            string sql2 = "insert into SoTietKiem values(N'" + stk.MaSTK + "', N'" + stk.MaKH + "', '" + String.Format("{0:0,0}", stk.SoTien) + "', '" + stk.LoaiTien + "', '";
            sql2 += Convert.ToDouble(stk.LaiSuat) + "', N'" + stk.KyHan + "')";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(sql2, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

            }
            catch (Exception)
            {
                connection.close(cnn);
                cnn.Dispose();
            }
        }
    }
}
