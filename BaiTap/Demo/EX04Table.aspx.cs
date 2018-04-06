using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Demo
{
    public partial class EX04Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tbnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                txtKetQua.Text = (float.Parse(txtSoA.Text) + float.Parse(txtSoB.Text)).ToString();

            }
            catch (FormatException ex)
            {

                lblBaoloi.Text = "Cần nhập vào con số ";
            }
            catch (Exception ex)
            {
                lblBaoloi.Text = ex.Message;
            }
        }

        protected void tbnTiepTuc_Click(object sender, EventArgs e)
        {
            txtSoB.Text = txtSoA.Text = txtKetQua.Text =lblBaoloi.Text= "";
            txtSoA.Focus();
        }
    }
}