using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiTap.Homework._3._3_Phanso;

namespace BaiTap.Homework._3._4_Phanso_Nangcao
{
    public partial class Phanso_NangCao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack==true)
            {
                Phanso ps1 = Phanso.Parse(thPhanSo1.Text);
                Phanso ps2 = Phanso.Parse(thPhanSo2.Text);
            }
        }

        protected void ibtnCong_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
            Phanso ps1 = Phanso.Parse(thPhanSo1.Text);
            Phanso ps2 = Phanso.Parse(thPhanSo2.Text);
            Phanso kq = new Phanso();
            kq = ps1 + ps2;
            thNhanKetQua.Text = kq.Xuat();
            }
            catch (FormatException)
            {
                thNhanKetQua.Text = "Bạn cần nhập phân số vào Hộp thoại";
            }
        }

        protected void ibtnTru_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                Phanso ps1 = Phanso.Parse(thPhanSo1.Text);
                Phanso ps2 = Phanso.Parse(thPhanSo2.Text);
                Phanso kq = new Phanso();
                kq = ps1 - ps2;
                thNhanKetQua.Text = kq.Xuat();
            }
            catch (FormatException)
            {
                thNhanKetQua.Text = "Bạn cần nhập phân số vào Hộp thoại";
            }
        }

        protected void ibtnSoSanh_Click(object sender, ImageClickEventArgs e)
        {
            bool sosanh = false;
            Phanso ps1 = Phanso.Parse(thPhanSo1.Text);
            Phanso ps2 = Phanso.Parse(thPhanSo2.Text);
            if (ps1 == ps2)
            {
                sosanh = true;
            }
            if (sosanh)
            {
                thNhanKetQua.Text = "Hai phân số BẰNG nhau";
            }
            else
            {
                thNhanKetQua.Text = "Hai phân số KHÔNG BẰNG nhau";
            }
        }

        protected void ibtnXoaNoiDung_Click(object sender, ImageClickEventArgs e)
        {
            thNhanKetQua.Text = "";
            thPhanSo1.Text = "";
            thPhanSo2.Text = "";
            thPhanSo1.Focus();
        }
    }
}