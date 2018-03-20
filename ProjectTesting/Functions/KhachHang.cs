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
    public class KhachHang
    {
        private string _maKH;

        public string MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }

        private string _hoKH;

        public string HoKH
        {
            get { return _hoKH; }
            set { _hoKH = value; }
        }

        private string _tenKH;

        public string TenKH
        {
            get { return _tenKH; }
            set { _tenKH = value; }
        }
        private DateTime _ngaySinh;

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }


        private string _gioiTinh;

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        private string _sdt;

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

       
       
        private string _quocTich;

        public string QuocTich
        {
            get { return _quocTich; }
            set { _quocTich = value; }
        }

        public KhachHang() { }

        public KhachHang(string MaKH, string hoKH, string tenKH, string NgaySinh, string GioiTinh, string sdt, string QuocTich)
        {
            _maKH = MaKH;
            _hoKH = hoKH;
            _tenKH = tenKH;
            _gioiTinh = GioiTinh;
            _sdt = sdt;
            _quocTich = QuocTich;
        }
    }
}

