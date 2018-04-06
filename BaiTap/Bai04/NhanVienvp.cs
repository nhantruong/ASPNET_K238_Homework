using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai04
{
    public class NhanVienvp:NhanVien
    {
        private static double _DonGiaPhat=100000;

        public static double DonGiaPhat //Đơn giá phạt
        {
            get { return _DonGiaPhat; }
            set { _DonGiaPhat = value; }
        }

        public double TinhPhat() // Tính tiền phạt
        {
            double kq = 0;
            if (_SoNgayVang>=_DinhMucVang)
            {
                kq = (_SoNgayVang - _DinhMucVang) * _DonGiaPhat; // Lấy Field _DongiaPhat
            }
            return kq;
        }

        #region Constructor cho NVVP
        public NhanVienvp() : base() { } // Kế thừa Constructor của Class cha

        public NhanVienvp(string Maso, string HoTen, DateTime Ngaysinh, DateTime NgayVaoLam, double HeSoLuong, Phai GioiTinh)
            : base(Maso,HoTen,Ngaysinh,NgayVaoLam,HeSoLuong,GioiTinh){}

        public NhanVienvp(string Maso, string HoTen, DateTime Ngaysinh, DateTime NgayVaoLam, double HeSoLuong, Phai GioiTinh, int SoNgayVang)
            : base(Maso, HoTen, Ngaysinh, NgayVaoLam, HeSoLuong,GioiTinh, SoNgayVang){}
        #endregion


        public override double TinhThuong()
        {
            double kq = 0;
            //Cách 1:
            //kq = LuongCoBan * Hesoluong * 0.1;// thưởng 10% so với lương
                                              // không quan tâm đến cách tính của Class cha
            //Cách 2:
            kq = base.TinhLuong() * 0.1;//Lấy kết quả tính toán của Class cha * 0.1
            return kq;
        }

        public override double TinhLuong()
        {
            double kq = 0;
            kq= base.TinhLuong()+this.TinhThuong()+this.TinhPhat();
            return kq;
            
        }
        public override string XuatThongTin(string XuongDong="<br/>")
        {
            string kq = "";
            string thuong = this.TinhThuong().ToString("#,##0VND");
            string phat = this.TinhPhat().ToString("#,##0VND");
            string luongnv = base.TinhLuong().ToString("#,##0VND");
            string thuclanh = this.TinhLuong().ToString("#,##0VND");

            kq = string.Format(@"Nhân viên: {1} - Họ Tên: {2}{0}Loại Nhân viên: Văn phòng{0}Tiền Thưởng: {3}{0}Tiền lương: {4}{0}Tiền Phạt {5}{0}Thực lãnh: {6}"                
                , XuongDong, Maso,Hoten,thuong,luongnv,phat,thuclanh);
            return kq;
        }
    }
}