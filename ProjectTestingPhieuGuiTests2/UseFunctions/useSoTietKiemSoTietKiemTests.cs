using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectTesting.Functions;
using ProjectTesting.UseFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting.UseFunctions.SoTietKiemTests
{
    [TestClass()]
    public class useSoTietKiemSoTietKiemTests
    {
        public string MaSTK;
        public string MaKH;
        public string SoTien;
        public string LoaiTien;
        public string LaiXuat;
        public string KyHan;
        

        [TestMethod()]
        public void SoTienGuiaNULLSoTietKiemTests()
        {
            SoTietKiem stk = new SoTietKiem("STK05","KH02", "", "VND", "2.3", "1 tháng" );
            Assert.IsNull(SoTien);
        }
        public void MaSTKNULLSoTietKiemTests()
        {
            SoTietKiem stk = new SoTietKiem("", "KH02", "8000000", "VND", "2.3", "1 tháng");
            Assert.IsNull(MaSTK);
        }
        public void MaKHNULLSoTietKiemTests()
        {
            SoTietKiem stk = new SoTietKiem("STK05", "", "8000000", "VND", "2.3", "1 tháng");
            Assert.IsNull(MaKH);
        }
        public void LaiXuatNULLSoTietKiemTests()
        {
            SoTietKiem stk = new SoTietKiem("STK05", "KH02", "8000000", "VND", "", "1 tháng");
            Assert.IsNull(LaiXuat);
        }

    }
}
