using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Bai03
{
    public partial class WFDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //1-Khai báo một biến đối tượng kiểu Nhân viên
            NhanVien nv1;
            //2-Khởi tạo biến đối tương nv1 kiểu Nhân viên
            nv1 = new NhanVien();//Hệ thống tự tạo 1 biến ko có tham số
                                 //Tạo đối tượng xong mới gán thuộc tính cho đối tượng dc
            //3- Gán giá trị cho các thuộc tính dữ liệu của biến (biểu tượng Cờ lê)
            //Gán (set) giá trị cho biến
            nv1.Maso = "A01";
            nv1.Gioitinh = Phai.Nam;
            //Đọc (Get) giá trị của đối tượng
            string m1 = nv1.Maso;

            //Buổi 6

            DateTime ns = new DateTime(1986, 1, 25);
            DateTime nvl = DateTime.Parse("01/60/2012");
            NhanVien nv2 = new NhanVien("A02","Trần văn B",ns,nvl,1.5,Phai.Nam);

            NhanVien nv3;


        }

        protected void btnGhiThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                //Khai báo và khởi tạo biến đối tượng kiểu NhanVien

                //NhanVien nv = new NhanVien(); //Bị lỗi do không có tham số khởi tạo
                NhanVien nv = new NhanVien();
                nv.Maso = txtMaso.Text;
                double hsl;
                if (double.TryParse(txtHeSoLuong.Text, out hsl) == false) throw new Exception("Hệ số lương phải nhập số >=1");//Kiểm tra số liệu nhập vào của Textbox Hệ số lương.
                nv.Hesoluong = hsl;
                nv.NgayVaoLam = DateTime.Parse(txtNgayVaoLam.Text);
                int tn = nv.ThamNien;
                nv.Hoten = txtHoTen.Text;
                //nv.Gioitinh = (enum)txtGioiTinh.Text;
                //if (int.TryParse(txtGioiTinh.Text,out gt) == false) throw new Exception("Nhập Giới tính sai");
                double tl = nv.TinhLuong();
                lblThongBao.Text = string.Format("-Mã số NV: {1}{0}-Họ tên NV: {2}{0}-Giới tính: {3}{0}-Hệ số lương: {4}{0}-Thâm niên: {5} năm{0}-Tiền lương trung bình hàng tháng: {6}{0}", "<br/>", nv.Maso,nv.Hoten,nv.Gioitinh, hsl, tn, tl.ToString("#,##0.#"));
            }
                catch (FormatException ex)
            {
                lblThongBao.Text = "Kiểu dữ liệu nhập vào ko đúng";
            }
            catch (Exception ex)
            {
                lblThongBao.Text = ex.Message;
            }
        }
    }
}