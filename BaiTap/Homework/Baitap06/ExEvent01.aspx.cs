using BaiTap.Bai03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Homework.Baitap06
{
    public partial class ExEvent01 : System.Web.UI.Page           
    {
        private NhanVien1 nv = new NhanVien1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnThemNV_Click(object sender, EventArgs e)
        {
            //1. Tạo 1 nhân viên mới
            nv.Hoten = "Trương Tam Phong";
            nv.Maso = "NV01";
            nv.Gioitinh = Phai.Nam;
            nv.Ngaysinh = new DateTime(1981, 12, 15);
            nv.NgayVaoLam = DateTime.Today;
            //2. Khai báo sự kiện Tăng Lương
            nv.TangLuong += Nv_TangLuong;
            //3. Lưu thông tin vào Session tên ThongTinNhanVien
            Session["ThongTinNhanVien"] = nv;
        }

        private void Nv_TangLuong(string NoiDung)
        {
            throw new NotImplementedException(NoiDung);
        }

        protected void btnCapNhatHSL_Click(object sender, EventArgs e)
        {

        }
    }
}