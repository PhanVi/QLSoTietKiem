using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting.Functions
{
   public class PhieuRut
    {
        private string _maPhieuRut;

        public string MaPhieuRut
        {
            get { return _maPhieuRut; }
            set { _maPhieuRut = value; }
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

        private DateTime _thoiGianRut;
        public DateTime ThoiGianRut
        {
            get { return _thoiGianRut; }
            set { _thoiGianRut = value; }
        }

        private string _soTienRut;
        public string SoTienRut
        {
            get { return _soTienRut; }
            set { _soTienRut = value; }
        }

        public PhieuRut() { }
        public PhieuRut(string MaPhieuRut, string MaSTK, string MaKH, string ThoiGianRut, string SoTienRut)
        {
            _maPhieuRut = MaPhieuRut;
            _maSTK = MaSTK;
            _maKH = MaKH;
            _thoiGianRut = Convert.ToDateTime(ThoiGianRut);
            _soTienRut = SoTienRut;
        }
    }
}
