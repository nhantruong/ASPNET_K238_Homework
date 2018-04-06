using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Homework.Baitap05
{
    public class HocSinhLop1:IHocSinh
    {
        #region Propperties

        private string _maSo;
        public string maSo
        {
            get { return _maSo; }
            set { _maSo = value; }
        }

        private string _Hoten;

        public string Hoten
        {
            get { return _Hoten; }
            set { _Hoten = value; }
        }
        private string _Lop;

        public string Lop
        {
            get { return _Lop; }
            set { _Lop = value; }
        }

        #region New Properties

        private double _Toan;
        public double Toan
        {
            get { return _Toan; }
            set
            {
                if (value < 0 || value > 10) throw new Exception("Điểm phải >=0 và <10");
                _Toan = value;
            }
        }

        private double _TiengViet;
        public double TiengViet
        {
            get { return _TiengViet; }
            set
            {
                if (value < 0 || value > 10) throw new Exception("Điểm phải >=0 và <10");
                _TiengViet = value;
            }
        }
        private double _TapViet;
        public double TapViet
        {
            get { return _TapViet; }
            set
            {
                if (value < 0 || value > 10) throw new Exception("Điểm phải >=0 và <10");
                _TapViet = value;
            }
        }

        #endregion


        #endregion

        #region Method

        public double DiemTrungBinh()
        {
            double kq = 0;
            kq = (Toan * 2 + TiengViet + TapViet) / 4;
            return kq;
        }

        public string KetQuaHocTap()
        {
            string kq = "";
            if (DiemTrungBinh() >= 5)
            {
                kq = "Được lên lớp";
            }
            else
            {
                kq = "Ở lại lớp";
            }
            return kq;
        }

        public  string XepLoaiKhenThuong()
        {
            string kq = "";
            if (DiemTrungBinh() >=8)
            {
                kq = "Tặng 2 bông hoa hồng";
            }
            else if (DiemTrungBinh() <8 && DiemTrungBinh() >=5)
            {
                kq = "Tặng 1 bông hoa hồng";
            }
            else
            {
                kq = "Không có bông hoa hồng";
            }
            return kq;
        }



        #endregion

        #region Constructor
        /// <summary>
        /// Khởi tạo Class Học sinh lớp 1, không tham số
        /// </summary>
        public HocSinhLop1() { }

        /// <summary>
        /// Khởi tạo Class Học sinh lớp 1, chứa tham số cơ bản
        /// </summary>
        /// <param name="Maso"></param>
        /// <param name="Hoten"></param>
        /// <param name="Lop"></param>
        public HocSinhLop1(string Maso, string Hoten,string Lop)
        {
            this.maSo = Maso;
            this.Hoten = Hoten;
            this.Lop = Lop;
        }
        #endregion
    }
}