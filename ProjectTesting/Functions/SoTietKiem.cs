using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting.Functions
{
   public  class SoTietKiem
    {
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

        private string _soTien;

        public string SoTien
        {
            get { return _soTien; }
            set { _soTien = value; }
        }
        private string _loaiTien;

        public string LoaiTien
        {
            get { return _loaiTien; }
            set { _loaiTien = value; }
        }
        private string _laiSuat;

        public string LaiSuat
        {
            get { return _laiSuat; }
            set { _laiSuat = value; }
        }
        private string _kyHan;

        public string KyHan
        {
            get { return _kyHan; }
            set { _kyHan = value; }
        }

        public SoTietKiem(){}

        public SoTietKiem(string MaSTK, string MaKH, string SoTien, string LoaiTien, string LaiSuat, string KyHan)
        {
            _maSTK = MaSTK;
            _maKH = MaKH;
            _soTien = SoTien;
            _loaiTien = LoaiTien;
            _laiSuat = LaiSuat;
            _kyHan = KyHan;
        }

    }
}
