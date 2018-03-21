using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting.Functions
{
   public class PhieuGui
    {
        private string _maPhieuGui;

        public string MaPhieuGui
        {
            get { return _maPhieuGui; }
            set { _maPhieuGui = value; }
        }

        private string _maSTK;
        public string MaSTK
        {
            get { return _maSTK; }
            set { _maSTK = value; }
        }

        private string _maKH;
        public string MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }

        private DateTime _thoiGianGui;
        public DateTime ThoiGianGui
        {
            get { return _thoiGianGui; }
            set { _thoiGianGui = value; }
        }

        private string _soTienGui;
        public string SoTienGui
        {
            get { return _soTienGui; }
            set { _soTienGui = value; }
        }

        public PhieuGui() { }

        public PhieuGui(string MaPhieuGui, string MaSTK, string MaKH, string ThoiGianGui, string SoTienGui)
        {
            _maPhieuGui = MaPhieuGui;
            _maSTK = MaSTK;
            _maKH = MaKH;
            _thoiGianGui = Convert.ToDateTime(ThoiGianGui);
            _soTienGui = SoTienGui;
        }
    }

  

}
