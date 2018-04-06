using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class EX06HTMLServerControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            buttonDangNhap.ServerClick += buttonDangNhap_serverClick;

        }

        private void buttonDangNhap_serverClick(object sender, EventArgs e)
        {
            if (inputEmail.Value.Trim() =="hv@gmail.com" && inputPassword.Value.Trim() == "123")
            {
                divThongbao.InnerHtml = "Đăng nhập thành công"; //gán nội dung vào thông báo
                divThongbao.Attributes.Add("class", "text-success text-center"); // Tùy biến cách hiển thị của thông báo thông qua cách gán Attributt (thay đổi trong thẻ DIV)
            }
            else
            {
                divThongbao.InnerHtml = "Đăng nhập thất bại"; 
                divThongbao.Attributes.Add("class", "text-danger  text-center");
            }
        }
    }
}