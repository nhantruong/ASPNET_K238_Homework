using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BaiTap.Bai04.Giaiphuongtrinh
{
    public partial class PhuongtrinhBac1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                txtKetQua.Value = "";
            }
                //txtSoB.Value = "1";
                //txtSoA.Value = "1";
                btnBaiKhac.ServerClick += BtnBaiKhac_ServerClick;
                btnTinh.ServerClick += BtnTinh_ServerClick;
            
        }

        private void BtnTinh_ServerClick(object sender, EventArgs e)
        {
            //GiaiPhuongTrinh pt1 = new GiaiPhuongTrinh(double.Parse(txtSoA.Value), double.Parse(txtSoB.Value));
            GiaiPhuongTrinh pt1 = new GiaiPhuongTrinh();
            try
            {
                double So_A = double.Parse(txtSoA.Value);
                double So_B = double.Parse(txtSoB.Value);
                txtKetQua.Value = pt1.GiaiPT(So_A, So_B);
            }
            catch (FormatException ex)
            {
                txtKetQua.Value= "Sai dữ liệu đầu vào";
            }
            catch (Exception ex)
            {
                txtKetQua.Value= ex.Message.ToString();
            }
        }

            private void BtnBaiKhac_ServerClick(object sender, EventArgs e)
            {
                txtKetQua.Value = "";
                txtSoA.Value = "";
                txtSoB.Value = "";                
            }
        
    }
}