using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace BaiTap.Bai02
{
    public partial class KhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //Nếu là lần Load đầu tiên
            {
                TaoDanhsachNgay();
                TaodanhsachNam();
                TaodanhsachThang();
            }
        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            string ngaySinh = string.Format("{0}/{1}/{2}", DropDownList_Date.SelectedValue, DropDownList_Month.SelectedValue, DropDownList_Year.SelectedValue);

            DateTime Ngay_sinh;
            if (!DateTime.TryParse(ngaySinh, out Ngay_sinh))
            {
                lblBaoLoi.Text = "ngày sinh không hợp lệ";
                return;// Thoát ra không cần kiểm tra các đối tượng còn lại
            }


            //Các cách làm về giới tính
            //string gioitinh = rbtnNam.Checked==true ? "Nam":"Nữ";
            //string gioitinh=rbtnNam.Checked?rbtnNam.Text:rbtnNu.Text;
            string gioitinh = "Nam";
            if (!rbtnNam.Checked) gioitinh = "Nữ";

            //Cach 1:lấy sở thích
            //string sothich = "";
            //foreach (Control check in panelSoThich.Controls)
            //{
            //    if (check.GetType().Name=="Checkbox")
            //    {
            //        CheckBox chk = (CheckBox)check;
            //        if (chk.Checked) sothich += string.Format("{0},", chk.Text);
            //    }

            //}
            //sothich = sothich.TrimEnd(',');

            //Cách 2 So thich
            string sothich = "";
            StringBuilder sb = new StringBuilder();//Nhớ khai báo using System.Text
            foreach (Control check in panelSoThich.Controls)
            {
                if (check.GetType().Name == "CheckBox")// Lưu ý tên của Control phải chính xác tuyệt đối
                {
                    CheckBox chk = (CheckBox)check;
                    if (chk.Checked) sb.AppendFormat("{0},", chk.Text);
                }

            }
            sothich = sb.ToString().TrimEnd(',');

            string noidung = string.Format("Tên đăng nhập: {1}{0} Mật Khẩu: {2}{0} Giới tính: {3}{0} Ngày sinh {4}{0} Email: {5}{0} Địa chỉ liên hệ: {6}{0} Sở thích : {7}","<br/>", txtTenDangNhap.Text, txtPassword.Text, gioitinh, ngaySinh,txtEmail.Text, txtDiaChi.Text, sothich);
            lblThongTin.Text = noidung;
            }



        private void TaoDanhsachNgay()
        {
            DropDownList_Date.Items.Add(new ListItem("Chọn ngày", "ngay"));//Nhớ chọn giá trị sao cho không parse ra được
            for (int i= 1 ; i<= 31; i++)
            {
                string ngayStr = i.ToString("00");
                DropDownList_Date.Items.Add(ngayStr);
            }
        }
        private void TaodanhsachNam()
        {
            int Namhienhanh = DateTime.Today.Year;
            DropDownList_Year.Items.Add(new ListItem("Chọn Năm", "nam"));//Nhớ chọn giá trị sao cho không parse ra được
            for (int i = Namhienhanh; i >= 1970; i--)
            {
                string NamStr = i.ToString();
                DropDownList_Year.Items.Add(NamStr);
            }

        }
        private void TaodanhsachThang()
        {
            //Chèn thêm 1 dòng Item vào vị trí đầu tiên của List Tháng
            DropDownList_Month.Items.Insert(0, new ListItem("Chọn Tháng", "Thang"));//Nhớ chọn giá trị sao cho không parse ra được
            ListItem it = new ListItem("Thang 3", "3");
            DropDownList_Month.Items.Add(it);
            for (int i = 4; i <=12; i++)
            {
                DropDownList_Month.Items.Add(new ListItem("Tháng " + i, i.ToString()));
            }
        }
    }
}