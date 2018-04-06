using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class bando : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        //protected void lbtnDiachi1_Click(object sender, EventArgs e)
        //{
        //    string diachi1 = "<iframe src='https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3919.6249454309395!2d106.6600763202025!3d10.763361138669309!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752ee92d7f1737%3A0xc13b7a5b646f48a!2zTmfDoyBiYSBOZ3V54buFbiBLaW0!5e0!3m2!1sen!2s!4v1521344111292' width='400' height='300' frameborder='0' style='border:0' allowfullscreen></iframe>";
        //    ltrBanDo.Text = diachi1;
        //}

        //protected void lbtnDiaChi2_Click(object sender, EventArgs e)
        //{
        //    string diachi2 = "<iframe src='https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3919.6249454309395!2d106.6600763202025!3d10.763361138669309!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752ee92d7f1737%3A0xc13b7a5b646f48a!2zTmfDoyBiYSBOZ3V54buFbiBLaW0!5e0!3m2!1sen!2s!4v1521344111292' width='400' height='300' frameborder='0' style='border:0' allowfullscreen></iframe>";
        //    ltrBanDo.Text = diachi2;
        //}

        protected void XulyLoadbanDo_Click(object sender, EventArgs e)
        {
            LinkButton lbtn = (LinkButton)sender; //Ép kiểu dữ liệu của Sender thành Link Button
                switch (lbtn.ID)
	            {
                    case "lbtnDiachi1":
                        ltrBanDo.Text = "<iframe src='https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3919.6249454309395!2d106.6600763202025!3d10.763361138669309!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752ee92d7f1737%3A0xc13b7a5b646f48a!2zTmfDoyBiYSBOZ3V54buFbiBLaW0!5e0!3m2!1sen!2s!4v1521344111292' width='400' height='300' frameborder='0' style='border:0' allowfullscreen></iframe>";
                        break;
                    case "lbtnDiaChi2":
                        ltrBanDo.Text = "<iframe src='https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d62905.31489257686!2d105.8077749!3d9.8013756!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31a05f23f51a7a71%3A0x3ee1e426e38fa80a!2zVHguIE5nw6MgQuG6o3ksIEjhuq11IEdpYW5nLCBWaeG7h3QgTmFt!5e0!3m2!1svi!2s!4v1521345337991' width='400' height='300' frameborder='0' style='border:0' allowfullscreen></iframe>";
                        break;
	            };
        }
    }
}