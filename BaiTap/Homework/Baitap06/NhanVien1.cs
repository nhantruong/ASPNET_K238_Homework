using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTap.Bai03
{
    #region Buổi 5


    // khai báo ngoài Class NV để tất cả các nơi khác đểu truy cập dc

    //enum là kiểu dữ liệu liệt kê
    public class NhanVien1
    {
        #region Delegate

        //tạo delegate
        public delegate void XulySuKien(string NoiDung);

        //Tạo Event
        public event XulySuKien TangLuong;

        private double _Hesoluong = 1;
        public double Hesoluong
        {
            get { return _Hesoluong; }
            set
            {
                if (value < 1) throw new Exception("Hệ số lương phải >= 1");
                else
                {
                    bool hslTang = true;
                    if (value <= _Hesoluong) hslTang = false;
                    _Hesoluong = value;

                    if (hslTang && TangLuong != null)
                    {
                        string noiDung = string.Format("Chúc mừng bạn {0} được tăng lương", Hoten);
                        TangLuong(noiDung);
                    }
                }     
            }
        }

        #endregion


        #region Full Properties
        //Từ khóa propfull  - TAB tạo ra full properties
        //private string _Maso;   //tên field, dùng để chứa dữ liệu của đối tương đó
        //                        // private dùng để khóa tên Field để không truy xuất ra ngoài được.
        //public string Maso //Thuộc tính
        //{
        //    get { return _Maso; }
        //    set { _Maso = value; }
        //}

        //private string _Hoten;

        //public string Hoten
        //{
        //    get { return _Hoten; }
        //    set { _Hoten = value; }
        //}

        private DateTime _Ngaysinh;

        public DateTime Ngaysinh
        {
            get { return _Ngaysinh; }
            set { _Ngaysinh = value; }
        }

        private DateTime _NgayVaoLam;

        public DateTime NgayVaoLam
        {
            get { return _NgayVaoLam; }
            set { _NgayVaoLam = value; }
        }

        //private double _Hesoluong = 1; //Kiểu số thực Mặc định của C#, kiểu Double > float
        //                               //=1 là gán giá trị mặc định của đối tượng khi khởi tạo một đối tượng.
        //public double Hesoluong
        //{
        //    get { return _Hesoluong; }
        //    set
        //    {
        //        //Kiểm tra tính hợp lệ của giá trị trước khi Lưu vào Field
        //        if (value < 1) throw new Exception("Hệ số lương phải >= 1"); // gặp lỗi sẽ bỏ qua, do đó ko cần Else
        //                                                                     //throw new Exception dùng để tạo ra 1 Exception ghi nhận lỗi do dữ liệu
        //        _Hesoluong = value;
        //    }
        //}

        #endregion
        #region Read-Only Properties or Write-Only properties
        /// <summary>
        /// Thâm niên được tính từ năm hiện nay đến thời điểm vào làm, theo năm
        /// Giá trị trả về là kiểu INT
        /// </summary>
        public int ThamNien //Chỉ có duy nhất phương thức GET
        {
            get
            {
                int ketqua = 0;
                int namHienHanh = DateTime.Today.Year;
                int namVaoLam = _NgayVaoLam.Year;//Lấy dữ liệu trực tiếp từ Field trong Class
                ketqua = namHienHanh - namVaoLam;
                return ketqua;
            }
        }

        #endregion
        #region Auto-Implement Properties
        //Thuộc tính không can thiệp giá trị vào ra
        public string Maso { get; set; } //Thuộc tính mới, Field sẽ do máy tự động tạo ra.
        public string Hoten { get; set; }
        public Phai Gioitinh { get; set; }

        #endregion
        #region Static properties

        private static double _LuongCoBan = 5000000;//Dùng Full-properties, Phương thước và Field cũng phải Static

        public static double LuongCoBan
        {
            get { return _LuongCoBan; }
            set { _LuongCoBan = value; }
        }

        #endregion

        #region Method - Phương thức xử lý tính toán
        public double TinhLuong()
        {
            double kq = 0;
            kq = _Hesoluong * _LuongCoBan;
            return kq;
        }

        public double TinhThuong()
        {
            double kq = 0;
            kq = ThamNien * 500000;
            return kq;
        }
        /// <summary>
        /// Nếu xuất ra lable thì ko cần nhập
        /// Nếu xuất ra Textbox thì nhập /t/n
        /// </summary>
        /// <param name="Xuongdong"></param>
        /// <returns></returns>
        public string XuatThongTin(string Xuongdong)

        {
            Xuongdong = "<br/>";
            string kq = "";
            double luong = TinhLuong();
            double thuong = TinhThuong();
            double tong = luong + thuong;
            kq = string.Format("Nhân viên: {1}-{2}{0}Tiền Thưởng: {3}{0}Tiền Lương: {4}{0}Tổng cộng: {5}{0}",
                Xuongdong, Maso, Hoten, thuong.ToString("#,##0VND"), luong.ToString("#,##0VND"), tong.ToString("#,##0VND"));
            return kq;
        }

        #endregion

        #endregion

        #region Buổi 6- Constructors - Phương thức khởi tạo
        /// <summary>
        /// Khởi tạo đối tượng Nhân viên có tham số (Mã số, Họ tên, ngày sinh...)
        /// </summary>
        /// <param name="Maso"></param>
        /// <param name="HoTen"></param>
        /// <param name="Ngaysinh"></param>
        public NhanVien1(string Maso, string HoTen, DateTime Ngaysinh, DateTime NgayVaoLam, double HeSoLuong, Phai GioiTinh)
        {
            this.Maso = Maso;
            this.Hoten = Hoten;
            this.Ngaysinh = Ngaysinh;
            this.NgayVaoLam = NgayVaoLam;
            this.Hesoluong = Hesoluong;
            this.Gioitinh = Gioitinh;
        }
        // Constructor không tham số đầu vào, nhưng có thông tin khởi tạo mặc định
        /// <summary>
        /// KHởi tạo đối tượng Nhân viên không tham số
        /// </summary>
        public NhanVien1()
        {
            _NgayVaoLam = DateTime.Today; //Gán thông tin khởi tạo mặc định
        }
        #endregion



    }

}