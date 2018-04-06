using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Homework.TinhKhoangCach
{
    public partial class TinhKhoangCachHaiDiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTinh_Click(object sender, EventArgs e)
        {
            Diem A = new Diem();
            Diem B = new Diem();
            A = Diem.Parse(txtDiemA.Text);
            B = Diem.Parse(txtDiemB.Text);
            txtKetQua.Text = KhoangCach(A, B).ToString();            
        }

        private static double KhoangCach(Diem A, Diem B)
        {
            double kq = 0;
            double deltaX = (B.X - A.X);
            double deltaY = (B.Y - A.Y);
            kq = Math.Sqrt((deltaX*deltaX) + (deltaY*deltaY));
            return kq;
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            txtDiemA.Text = "";
            txtDiemB.Text = "";
            txtKetQua.Text = "";
            txtDiemA.Focus();
        }
    }
}