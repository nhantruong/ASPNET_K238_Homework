using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Homework._4_2_DanhSachMayTinh
{
    public partial class QuanLyMayTinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rbtnMaytinhDeBan_CheckedChanged(object sender, EventArgs e)
        {
            txt1.ID = "txtCPU";
            lbl1.Text = "CPU";
            txt2.ID = "txtRAM";
            lbl2.Text = "RAM";
            txtKichThuocManHinh.Visible = false;
            lblKichThuocManHinh.Visible = false;
        }

        protected void rbtnMayTinhXachTay_CheckedChanged(object sender, EventArgs e)
        {
            txt1.ID = "txtTrongLuong";
            lbl1.Text = "Trọng Lượng";
            txt2.ID = "txtThoiGianPin";
            lbl2.Text = "Thời gian Pin";
            txtKichThuocManHinh.Visible = true;
            lblKichThuocManHinh.Visible = true;
        }
    }
}