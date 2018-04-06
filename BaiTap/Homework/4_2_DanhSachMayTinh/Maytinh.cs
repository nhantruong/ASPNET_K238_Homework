using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Homework._4_2_DanhSachMayTinh
{
    public class Maytinh
    {
        #region Properties

        private string _SoHieu;
        public string SoHieu
        {
            get { return _SoHieu; }
            set { _SoHieu = value; }
        }

        private double _DonGia;
        public double DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }

        private string _HangSanXuat;
        public string HangSanXuat
        {
            get { return _HangSanXuat; }
            set { _HangSanXuat = value; }
        }

        #endregion

        #region Method

        public virtual string Tostring(string XuongDong)
        {
            string kq = "";
            XuongDong = "</br>";
            kq = string.Format(@"Số hiệu máy tính: {1}{0}Hãng sản xuất: {2}{0}Đơn giá: {3}{0}",
                                XuongDong,SoHieu,HangSanXuat,DonGia.ToString("#,##0 VND"));
            return kq;
        }
        #endregion

        #region Contructor

        public Maytinh() { }

        public Maytinh(string SoHieu, double Dongia, string HangSanXuat)
        {
            this.SoHieu = SoHieu;
            this.DonGia = Dongia;
            this.HangSanXuat = HangSanXuat;
        }
        #endregion
    }

    public class MaytinhDeBan: Maytinh
    {
        #region New Properties
        private string _CPU;
        public string CPU
        {
            get { return _CPU; }
            set { _CPU = value; }
        }

        private string _RAM;
        public string RAM
        {
            get { return _RAM; }
            set { _RAM = value; }
        }
        #endregion

        #region Constructor

        public MaytinhDeBan() { }
        public  MaytinhDeBan(string SoHieu, double Dongia, string HangSanXuat,string CPU, string RAM)
        {
            this.SoHieu = SoHieu;
            this.DonGia = Dongia;
            this.HangSanXuat = HangSanXuat;
            this.CPU = CPU;
            this.RAM = RAM;
        }

        #endregion

        #region New Method

        public override string Tostring(string XuongDong)
        {
            string kq = "";
            XuongDong = "</br>";
            kq = string.Format(@"Số hiệu máy tính: {1}{0}Hãng sản xuất: {2}{0}Đơn giá: {3}{0}Thông tin CPU: {4}{0}RAM: {5}{0}",
                                XuongDong, SoHieu, HangSanXuat, DonGia.ToString("#,##0 VND"), CPU, RAM);
            return kq;
        }
        #endregion
    }

    public class MaytinhXachTay: Maytinh
    {
        #region New Properties
        private string  _TrongLuong;

        public string  TrongLuong
        {
            get { return _TrongLuong; }
            set { _TrongLuong = value; }
        }

        private string _ThoigianPIN;

        public string ThoigianPIN
        {
            get { return _ThoigianPIN; }
            set { _ThoigianPIN = value; }
        }

        private string _KichThuocManHinh;

        public string KichThuocManHinh
        {
            get { return _KichThuocManHinh; }
            set { _KichThuocManHinh = value; }
        }
        #endregion

        #region Method
        public override string Tostring(string XuongDong)
        {
            string kq = "";
            XuongDong = "</br>";
            kq = string.Format(@"Số hiệu máy tính: {1}{0}Hãng sản xuất: {2}{0}Đơn giá: {3}{0}Trọng lượng: {4}{0}Thời gian PIN: {5}{0}Kích thước màn hình: {6}{0}",
                                XuongDong, SoHieu, HangSanXuat, DonGia.ToString("#,##0 VND"),TrongLuong,ThoigianPIN,KichThuocManHinh);
            return kq;
        }
        #endregion

        #region Constructor

        public MaytinhXachTay(){ }

        public MaytinhXachTay(string SoHieu, double Dongia, string HangSanXuat,string Trongluong, string ThoigianPIN, string KichthuocManHinh)
        {
            this.SoHieu = SoHieu;
            this.DonGia = Dongia;
            this.HangSanXuat = HangSanXuat;
            this.TrongLuong = Trongluong;
            this.ThoigianPIN = ThoigianPIN;
            this.KichThuocManHinh = KichthuocManHinh;
        }
        #endregion
    }
}