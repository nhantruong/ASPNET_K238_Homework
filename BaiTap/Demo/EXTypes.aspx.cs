using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace BaiTap.Demo
{
    public partial class EXTypes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int n1 = 2;
            int n2;
            n2 = n1;
            n1 = 5;
            //?n2
            StringBuilder sb1 = new StringBuilder();// cú pháp NEW dùng để tạo ra 1 vùng nhớ
            StringBuilder sb2;
            sb1.Append("Hello");
            sb2 = sb1;
            sb1.Append("you");

        }
    }
}