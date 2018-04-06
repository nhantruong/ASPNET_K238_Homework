using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class EXMultiView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void imageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //Chuyển sang view 1
            MultiView1.ActiveViewIndex = 0;//Cách 1
            //MultiView1.SetActiveView(View1);//Cách 2: truyền thứ tự view
        }

        protected void imageButton2_Click(object sender, ImageClickEventArgs e)
        {
            //Chuyển sang View 2
            MultiView1.ActiveViewIndex = 1;
            //MultiView1.SetActiveView(View2);
        }
    }
}