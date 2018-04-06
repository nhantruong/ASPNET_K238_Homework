using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai03
{
    public partial class CapNhatNhanVien_BS4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnXuatThongTin.ServerClick += BtnXuatThongTin_ServerClick;
            btnTiepTuc.ServerClick += BtnTiepTuc_ServerClick;
        }

        private void BtnTiepTuc_ServerClick(object sender, EventArgs e)
        {
            
        }

        private void BtnXuatThongTin_ServerClick(object sender, EventArgs e)
        {
            try
            { 
            NhanVien nv1 = new NhanVien();
            nv1.Maso = txtMaso.Value;
            nv1.Hoten = txtHoten.Value;
            nv1.Ngaysinh = DateTime.Parse(txtNgaysinh.Value);
            nv1.NgayVaoLam = DateTime.Parse(txtNgayVaoLam.Value);
            double hsl;
            if (double.TryParse(txtHesoluong.Value, out hsl) == false) throw new Exception("Hệ số lương phải nhập số >=1");//Kiểm tra số liệu nhập vào của Textbox Hệ số lương.
            nv1.Hesoluong = hsl;
            double tl = nv1.TinhLuong();
            double tt = nv1.TinhThuong();
            int tn = nv1.ThamNien;

            
            lblThongTin.Text = string.Format("-Mã số NV: {1}{0}-Họ tên NV: {2}{0}-Giới tính: {3}{0}-Hệ số lương: {4}{0}-Thâm niên: {5} năm{0}-Tiền lương: {6}{0} Tiền thưởng: {7}{0}",
                                            "<br/>", nv1.Maso, nv1.Hoten, nv1.Gioitinh, hsl, tn, tl.ToString("#,##0.#"), tt.ToString("#,##0"));

            }
            catch (FormatException ex)
            {
                lblBaoLoi.Text = "Kiểu dữ liệu nhập vào ko đúng";
            }
            catch (Exception ex)
            {
                lblBaoLoi.Text = ex.Message;
            }
        }
    }
}