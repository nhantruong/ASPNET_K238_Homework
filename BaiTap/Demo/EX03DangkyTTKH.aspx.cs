using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class EX03DangkyTTKH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangky_Click(object sender, EventArgs e)
        {
            //C#
            string noidung = "Xin chào " + txtHoten.Text + "! </br>Thông tin của bạn đã được ghi nhận.";
            lblThongBao.Text = noidung;
        }
    }
}