using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaiTap.Homework._3_5ThongTinNhanVien;

namespace BaiTap.Homework._4_ThuaKe_DaHinh
{
    public class _40NhanVien
    {
        
        #region Properties
        //Mã số
        private string _Maso;
        public string Maso
        {
            get { return _Maso; }
            set { _Maso = value; }
        }

        //Họ tên
        private string _Hoten;
        public string Hoten
        {
            get { return _Hoten; }
            set { _Hoten = value; }
        }

        //Giới tính
        private Phai _GioiTinh = Phai.Nam;
        public Phai GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        //Ngày sinh
        private DateTime _NgaySinh;
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        //Ngày vào làm
        private DateTime _NgayVaoLam;
        public DateTime NgayVaoLam
        {
            get { return _NgayVaoLam; }
            set { _NgayVaoLam = value; }
        }

        //Hệ số lương
        private double _HesoLuong = 1;
        public double HesoLuong
        {
            get { return _HesoLuong; }
            set
            {
                if (value < 1) throw new Exception("Hệ số lương phải >=1");
                _HesoLuong = value;
            }
        }

        //Lương cơ bản
        private static double _LuongCoBan = 1000000;
        public static double LuongCoBan
        {
            get { return _LuongCoBan; }
            set { _LuongCoBan = value; }
        }


        //Read-Only Tính thâm niên
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


        //Số ngày vắng
        private int _SoNgayVang;
        public int SoNgayVang
        {
            get { return _SoNgayVang; }
            set { _SoNgayVang = value; }
        }


        //Định mức vắng
        private static int _DinhMucVang=3;
        public static int DinhMucVang
        {
            get { return _DinhMucVang; }
            set { _DinhMucVang = value; }
        }
        

        #endregion

        #region Method
        /// <summary>
        /// Tính lương Nhân viên
        /// Lương = Lương cơ bản * Hệ số lương
        /// </summary>
        /// <returns></returns>
        public virtual double TinhLuong()
        {
            double luong = 0;
            luong = LuongCoBan * HesoLuong;
            return luong;
        }

        /// <summary>
        /// Tính thưởng = Thâm nien * 500000
        /// </summary>
        /// <returns></returns>
        public virtual double TinhThuong()
        {
            double thuong;
            thuong = ThamNien * 500000;
            return thuong;
        }

        /// <summary>
        /// Xuất thông tin Nhân viên ra ngoài
        /// Cần nhập thêm tham số:
        /// Nếu xuất ra Textbox thì nhập NhanVien.XuatThongTin("\t\r")
        /// Nếu xuất ra Lable thì nhập NhanVien.XuatThongTin()
        /// </summary>
        /// <param name="Xuongdong"></param>
        /// <returns></returns>
        public virtual string XuatThongTin(string Xuongdong)
        {
            string kq = "";
            Xuongdong = "</br>";
            double thuong = TinhThuong();
            double luong = TinhLuong();
            double tongCong = luong + thuong;
            kq = string.Format("MSNV: {1}{0}Tên Nhân viên: {2}{0}Giới tính: {3}{0}Hệ số lương: {4}{0}Ngày vào làm: {9}{0}Thâm niên công tác: {5} năm{0} Lương: {6}{0}Thưởng: {7}{0}Tổng cộng: {8}{0}"
                , Xuongdong, Maso, Hoten, GioiTinh, HesoLuong, ThamNien, luong.ToString("#,##0 VND"), thuong.ToString("#,##0 VND"), tongCong.ToString("#,##0 VND"), NgayVaoLam.ToString("dd/MM/yyyy"));
            return kq;
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Khởi tạo đối tượng Nhân viên không tham số
        /// </summary>
        public _40NhanVien() { }

        /// <summary>
        /// Khởi tạo Nhân viên có các tham số
        /// </summary>
        /// <param name="Maso"></param>
        /// <param name="Hoten"></param>
        /// <param name="Ngaysinh"></param>
        /// <param name="NgayVaoLam"></param>
        /// <param name="gioitinh"></param>
        /// <param name="HesoLuong"></param>
        /// <param name="SoNgayVang"></param>
        public _40NhanVien(string Maso, string Hoten, DateTime Ngaysinh, DateTime NgayVaoLam, Phai gioitinh, int HesoLuong, int SoNgayVang)
        {
            this.Maso = Maso;
            this.Hoten = Hoten;
            this.NgaySinh = Ngaysinh;
            this.NgayVaoLam = NgayVaoLam;
            this.GioiTinh = gioitinh;
            this.HesoLuong = HesoLuong;
            this.SoNgayVang = SoNgayVang;
        }

        #endregion
    }
}