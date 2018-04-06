using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai04
{
    public partial class TinhLuongNhanVien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {// Nếu là lần load đầu tiên (ko phải load lại do submit sự kiện của 1 control)
                txtSoSanPham.Text = "312";
                txtSoNgayVang.Text = "0";
            }
        }
        protected void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            // Nhận giá trị nhập
            string maso = txtMaso.Text;
            string hoten = txtHoTen.Text;
            DateTime ngaysinh =DateTime.Parse(txtNgaySinh.Text);
            DateTime ngayvaolam = DateTime.Parse(txtNgayVaoLam.Text);
            double hsl = double.Parse(txtHeSoLuong.Text);
            Phai gioitinh = chkGioiTinh.Checked ? Phai.Nam : Phai.Nữ;
            int songayvang = int.Parse(txtSoNgayVang.Text);

            // Cách 1: Bình thường
            //NhanVien nv = new NhanVien();
            if (rdbNVSX.Checked)
            {
                NhanViensx nv = new NhanViensx(maso, hoten, ngaysinh, ngayvaolam, gioitinh, songayvang, int.Parse(txtSoSanPham.Text));
                lblThongTin.Text= nv.XuatThongTin();
            }
            else if (rdbNVVP.Checked)
            {
                NhanVienvp nv = new NhanVienvp(maso, hoten, ngaysinh, ngayvaolam, hsl, gioitinh, songayvang);
                lblThongTin.Text = nv.XuatThongTin();
            }
            
            // Cách 2: Ứng dụng LateBinding
                 
            // Chuyển sang View2
			MultiView1.ActiveViewIndex = 1;
           // lblThongTin.Text = string.Format(nv.XuatThongTin("<br/>").ToString());
        }

        protected void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtMaso.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            txtNgayVaoLam.Text = "";
            txtHeSoLuong.Text = "";
            chkGioiTinh.Checked = false;
            txtSoNgayVang.Text = "0";
            txtSoSanPham.Text = "";
            rdbNVSX.Checked = true;
            txtMaso.Focus();

            MultiView1.ActiveViewIndex = 0;
        }

        protected void rdbNVVP_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}