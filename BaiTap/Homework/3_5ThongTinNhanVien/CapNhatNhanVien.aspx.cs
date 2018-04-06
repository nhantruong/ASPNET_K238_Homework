using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Homework._3_5ThongTinNhanVien
{
    public partial class CapNhatNhanVien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack)
            //{
            //DateTime Ngaysinh, ngayvaolam;
            //Ngaysinh = new DateTime(2015, 10, 12);
            //ngayvaolam = DateTime.Today;
            //thNgaySinh.Text = Ngaysinh.ToString();
            //thNgayVaoLam.Text = ngayvaolam.ToString();
            //}

        }

        protected void thXuatThongTin_Click(object sender, EventArgs e)
        {
            _35NhanVien nv = new _35NhanVien();
            string maso = thMaso.Text;
            string hoten = thHoten.Text;
            DateTime ngaysinh = DateTime.Parse(thNgaySinh.Text);
            DateTime ngayvaolam = DateTime.Parse(thNgayVaoLam.Text);
            double hesoluong = double.Parse(thHesoLuong.Text);
            if (thGioiTinh.Checked)
            {
                nv.GioiTinh = Phai.Nam;
            }
            else
            {
                nv.GioiTinh = Phai.Nữ;
            }
            nv.Maso = maso;
            nv.Hoten = hoten;
            nv.HesoLuong = hesoluong;
            nv.NgaySinh = ngaysinh;
            nv.NgayVaoLam = ngayvaolam;

            thThongBao.Text = nv.XuatThongTin("\t\r");

            MultiView1.ActiveViewIndex = 1;
        }

        protected void thTiepTuc_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
            thMaso.Text = "";
            thHoten.Text = "";
            thHesoLuong.Text = "";
            thNgaySinh.Text = "";
            thNgayVaoLam.Text = "";
            thMaso.Focus();
        }
    }
}