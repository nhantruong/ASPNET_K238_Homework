using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Homework._3._3_Phanso
{
    public partial class Pheptinhphanso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack==true)
            {
                Phanso p1 = Phanso.Parse(thPhanSo1.Text);
                Phanso p2 = Phanso.Parse(thPhanSo2.Text);
            }
        }
        protected void ibtnXoaNoiDung_Click(object sender, ImageClickEventArgs e)
        {
            thPhanSo1.Text = "";
            thPhanSo2.Text = "";
            thKetQua.Text = "";
            thPhanSo1.Focus();
        }

        protected void ibtnCong_Click(object sender, ImageClickEventArgs e)
        {
            Phanso p1 = Phanso.Parse(thPhanSo1.Text);
            Phanso p2 = Phanso.Parse(thPhanSo2.Text);
            Phanso kq = p1.Cong(p2);
            thKetQua.Text = kq.Xuat();
            lblKetqua.Text = "Kết quả Cộng:";
        }

        protected void ibtnTru_Click(object sender, ImageClickEventArgs e)
        {
            Phanso p1 = Phanso.Parse(thPhanSo1.Text);
            Phanso p2 = Phanso.Parse(thPhanSo2.Text);
            Phanso kq = p1.Tru(p2);
            thKetQua.Text = kq.Xuat();
            lblKetqua.Text = "Kết quả Trừ:";
        }

        protected void ibtnNhan_Click(object sender, ImageClickEventArgs e)
        {
            Phanso p1 = Phanso.Parse(thPhanSo1.Text);
            Phanso p2 = Phanso.Parse(thPhanSo2.Text);
            Phanso kq = p1.Nhan(p2);
            thKetQua.Text = kq.Xuat();
            lblKetqua.Text = "Kết quả Nhân:";
        }

        protected void ibtnChia_Click(object sender, ImageClickEventArgs e)
        {
            Phanso p1 = Phanso.Parse(thPhanSo1.Text);
            Phanso p2 = Phanso.Parse(thPhanSo2.Text);
            Phanso kq = p1.Chia(p2);
            thKetQua.Text = kq.Xuat();
            lblKetqua.Text = "Kết quả Chia:";
        }
    }
}