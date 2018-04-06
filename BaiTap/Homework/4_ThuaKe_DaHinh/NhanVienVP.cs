using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaiTap.Homework._3_5ThongTinNhanVien;

namespace BaiTap.Homework._4_ThuaKe_DaHinh
{
    public class NhanVienVP:_40NhanVien
    {
        #region New Properties
        //Đơn giá phạt, 100k/1 ngày
        private static double _DonGiaPhat=100000;
        public static double DonGiaPhat
        {
            get { return _DonGiaPhat; }
            set { _DonGiaPhat = value; }
        }


        #endregion

        #region New - Method
        //Tính tiền phạt
        /// <summary>
        /// Tính tiền phạt do Vắng Vượt định mức
        /// </summary>
        /// <returns></returns>
        public double Tinhphat()
        {
            double kq = 0;
            if (SoNgayVang> DinhMucVang)
            {
                kq = (SoNgayVang - DinhMucVang) * DonGiaPhat;
            }
            return kq;
        }

        //Tính thưởng
        /// <summary>
        /// Tính tiền thưởng cho NVVP
        /// </summary>
        /// <returns></returns>
        public override double TinhThuong()
        {
            double kq=0;
            kq = LuongCoBan * HesoLuong * 0.1;
            return kq;
        }

        //Tính lương
        /// <summary>
        /// Tính lương cho NVVP
        /// </summary>
        /// <returns></returns>
        public override double TinhLuong()
        {
            return base.TinhLuong() + TinhThuong() - Tinhphat();
        }

        /// <summary>
        /// Method Xuất thông tin cho NVVP
        /// </summary>
        /// <param name="Xuongdong"></param>
        /// <returns></returns>
        public override string XuatThongTin(string Xuongdong)
        {
            string kq = "";
            Xuongdong = "<\br>";
            double thuclanh = TinhLuong() + TinhThuong() - Tinhphat();
            return kq = string.Format(@"Mã số: {1}{0}Tên Nhân viên: {2}{0}Loại nhân viên: {3}{0}Tiền Thưởng: {4}{0}Tiền Phạt do nghỉ quá định mức {5}{0}Tiền lương {6}{0}Thực lãnh: {7}{0}"
                                        ,Xuongdong,Maso,Hoten,"Văn phòng",TinhThuong().ToString("#,##0 VND"),Tinhphat().ToString("#,##0 VND"),TinhLuong().ToString("#,##0 VND"),thuclanh.ToString("#,##0 VND"));
        }

        #endregion

        #region Constructor NVVP

        public NhanVienVP() {}

        public NhanVienVP(string Maso, string Hoten, DateTime Ngaysinh, DateTime NgayVaoLam, Phai gioitinh, int HesoLuong, int SoNgayVang)
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

    public class NhanVienSX: _40NhanVien
    {
        #region New Properties
        //Số lượng sản phẩm
        private int _SoluongSanPham;
        public int SoluongSanPham
        {
            get { return _SoluongSanPham; }
            set { _SoluongSanPham = value; }
        }

        //Định mức sản phẩm
        private static int _DinhMucSanPham=312;
        public static int DinhMucSanPham
        {
            get { return _DinhMucSanPham; }
            set { _DinhMucSanPham = value; }
        }

        //Đơn giá sản phẩm
        private static double _DonGiaSanPham = 10000;
        public static double DonGiaSanPham
        {
            get { return _DonGiaSanPham; }
            set { _DonGiaSanPham = value; }
        }

        //Định mức vắng
        private static int _DinhMucVang;

        public static int DinhMucVang
        {
            get { return _DinhMucVang; }
            set { _DinhMucVang = value; }
        }

        #endregion

        #region New Contructor NVSX

        public NhanVienSX() { }

        public NhanVienSX(string Maso, string Hoten, DateTime Ngaysinh, DateTime NgayVaoLam, Phai gioitinh, int SoNgayVang, int soluongsanpham)
        {
            this.Maso = Maso;
            this.Hoten = Hoten;
            this.NgaySinh = Ngaysinh;
            this.NgayVaoLam = NgayVaoLam;
            this.GioiTinh = gioitinh;
            this.SoNgayVang = SoNgayVang;
            this.SoluongSanPham = soluongsanpham;
            DinhMucVang = _40NhanVien.DinhMucVang + 2;
        }
        #endregion

        #region New Method

        public override double TinhThuong()
        {
            return base.TinhThuong();   
        }

        public override double TinhLuong()
        {
            return (SoluongSanPham * DonGiaSanPham) + TinhThuong();
        }


        public override string XuatThongTin(string Xuongdong)
        {
            string kq = "";
            Xuongdong = "<\br>";
            double thuclanh = TinhLuong() + TinhThuong();
            return kq = string.Format(@"Mã số: {1}{0}Tên Nhân viên: {2}{0}Loại nhân viên: {3}{0}Tiền Thưởng: {4}{0}Tiền lương {5}{0}Thực lãnh: {6}{0}"
                                        , Xuongdong, Maso, Hoten, "Văn phòng", TinhThuong().ToString("#,##0 VND"), TinhLuong().ToString("#,##0 VND"), thuclanh.ToString("#,##0 VND"));
        }

        #endregion

    }
}