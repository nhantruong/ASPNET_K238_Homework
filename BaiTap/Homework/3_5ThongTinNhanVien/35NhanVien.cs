using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Homework._3_5ThongTinNhanVien
{
    public  enum Phai { Nữ, Nam}
    public class _35NhanVien
    {
        #region Properties
        private string _Maso;

        public string Maso
        {
            get { return _Maso; }
            set { _Maso = value; }
        }

        private string _Hoten;

        public string Hoten
        {
            get { return _Hoten; }
            set { _Hoten = value; }
        }

        private Phai _GioiTinh=Phai.Nam;

        public Phai GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        private DateTime _NgaySinh;

        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        private DateTime _NgayVaoLam;

        public DateTime NgayVaoLam
        {
            get { return _NgayVaoLam; }
            set { _NgayVaoLam = value; }
        }

        private double _HesoLuong =1;
    
        public  double HesoLuong
        {
            get { return _HesoLuong; }
            set
            {
                if (value < 1) throw new Exception("Hệ số lương phải >=1");
                _HesoLuong = value;
            }
        }

        private double _LuongCoBan=1000000;

        public double LuongCoBan
        {
            get { return _LuongCoBan; }
            set { _LuongCoBan = value; }
        }

        private int _ThamNien;

        public int ThamNien
        {
            get
            {
                int namHienHanh = DateTime.Today.Year;
                int namVaolam = _NgayVaoLam.Year;
                _ThamNien = namHienHanh - namVaolam;
                return _ThamNien;
            }            
        }


        #endregion
        #region Method
        /// <summary>
        /// Tính lương Nhân viên
        /// Lương = Lương cơ bản * Hệ số lương
        /// </summary>
        /// <returns></returns>
        public  double TinhLuong()
        {
            double luong = 0;
            luong = LuongCoBan * HesoLuong;
            return luong;
        }

        /// <summary>
        /// Tính thưởng = Thâm nien * 500000
        /// </summary>
        /// <returns></returns>
         public double TinhThuong()
        {
            double thuong;
            thuong = ThamNien * 500000;
            return thuong;
        }

        public string XuatThongTin(string Xuongdong)
        {
            string kq = "";
            Xuongdong = "</br>";
            double thuong = TinhThuong();
            double luong = TinhLuong();
            double tongCong = luong + thuong;
            kq = string.Format("MSNV: {1}{0}Tên Nhân viên: {2}{0}Giới tính: {3}{0}Hệ số lương: {4}{0}Ngày vào làm: {9}{0}Thâm niên công tác: {5} năm{0} Lương: {6}{0}Thưởng: {7}{0}Tổng cộng: {8}{0}"
                , Xuongdong, Maso, Hoten,GioiTinh,HesoLuong,ThamNien, luong.ToString("#,##0 VND"),thuong.ToString("#,##0 VND"), tongCong.ToString("#,##0 VND"),NgayVaoLam.ToString("dd/MM/yyyy"));
            return kq;
        }

        #endregion


        #region Constructor
        /// <summary>
        /// Khởi tạo đối tượng Nhân viên không tham số
        /// </summary>
        public _35NhanVien() { }

        /// <summary>
        /// Khởi tạo Nhân viên có các tham số
        /// </summary>
        /// <param name="Maso"></param>
        /// <param name="Hoten"></param>
        /// <param name="Ngaysinh"></param>
        /// <param name="NgayVaoLam"></param>
        /// <param name="gioitinh"></param>
        /// <param name="HesoLuong"></param>
        public _35NhanVien(string Maso, string Hoten,DateTime Ngaysinh, DateTime NgayVaoLam, Phai gioitinh, int HesoLuong)
        {
            this.Maso = Maso;
            this.Hoten = Hoten;
            this._NgaySinh = Ngaysinh;
            this.NgayVaoLam = NgayVaoLam;
            this.GioiTinh = gioitinh;
            this.HesoLuong = HesoLuong;
        }

        #endregion
    }
}