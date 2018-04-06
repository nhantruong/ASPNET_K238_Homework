using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai04
{
    public partial class WFDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            DateTime ns = new DateTime(1986, 1, 25);
            DateTime nvl = DateTime.Parse("03/25/2018");
            NhanVienvp nv1 = new NhanVienvp("VP01", "Tran van B", ns, nvl,2, Phai.Nam, 5);
            lblThongBao.Text = nv1.XuatThongTin();
            txtThongTin.Text = nv1.XuatThongTin("\r\n");//Ký hiệu Xuống dòng của Textbox
        }
    }
}