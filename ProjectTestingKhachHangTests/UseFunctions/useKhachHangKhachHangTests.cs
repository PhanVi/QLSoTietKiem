using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectTesting.Functions;
using ProjectTesting.UseFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting.UseFunctions.KhachHangTests
{
    [TestClass()]
    public class useKhachHangKhachHangTests
    {
        public string MaKH;
        public string hoKH;
        public string tenKH;
        public string NgaySinh;
        public string GioiTinh;
        public string sdt;
        public string QuocTich;
        
        

        [TestMethod()]
        public void MaKHLaNULLKhachHangTests()
        {
            KhachHang kh = new KhachHang("", "Phan", "Vũ", "2018-03-19 00:00:00.000", "Nam", "00000000", "VietNam");
            Assert.IsNull(MaKH);
        }

        [TestMethod()]
        public void HoKHLaNULLKhachHangTests()
        {
            KhachHang kh = new KhachHang("KH04", "", "Vũ", "2018-03-19 00:00:00.000", "Nam", "00000000", "VietNam");
            Assert.IsNull(hoKH);
        }

        [TestMethod()]
        public void TenKHLaNULLKhachHangTests()
        {
            KhachHang kh = new KhachHang("KH03", "Phan", "", "2018-03-19 00:00:00.000", "Nam", "00000000", "VietNam");
            Assert.IsNull(tenKH);
        }

        [TestMethod()]
        public void GioiTinhLaNULLKhachHangTests()
        {
            KhachHang kh = new KhachHang("KH02", "Phan", "Vũ", "2018-03-19 00:00:00.000", "", "00000000", "VietNam");
            Assert.IsNull(GioiTinh);
        }

        [TestMethod()]
        public void SDTLaNULLKhachHangTests()
        {
            KhachHang kh = new KhachHang("KH03", "Phan", "Vũ", "2018-03-19 00:00:00.000", "Nam", "", "VietNam");
            Assert.IsNull(sdt);
        }

        [TestMethod()]
        public void QuocTichLaNULLKhachHangTests()
        {
            KhachHang kh = new KhachHang("KH01", "Phan", "Vũ", "2018-03-19 00:00:00.000", "Nam", "00000000", "");
            Assert.IsNull(MaKH);
        }
    }
}