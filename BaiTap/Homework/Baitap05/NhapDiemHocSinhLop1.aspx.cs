using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiTap.Homework.Baitap05
{
    public partial class NhapDiemHocSinhLop1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AddItem();
            }

        }

        protected void btnTiep_Click(object sender, EventArgs e)
        {
            txtMaSo.Text = txtHoTen.Text = txtToan.Text = txtTiengViet.Text = txtTapViet.Text = txtDiemTrungBinh.Text = txtKQHT.Text = txtXeploaiKhenThuong.Text = "";
                        dropdownlistLop.Focus();
        }

        protected void btnThucHien_Click(object sender, EventArgs e)
        {
            string maSo, hoTen, lop = "";
            double toan, tiengViet, tapViet = 0;
            maSo = txtMaSo.Text;
            hoTen = txtHoTen.Text;            
            toan = double.Parse(txtToan.Text);
            tiengViet = double.Parse(txtTiengViet.Text);
            tapViet = double.Parse(txtTapViet.Text);
            HocSinhLop1 hs = new HocSinhLop1();
            hs.Lop = dropdownlistLop.Text;
            hs.maSo = maSo;
            hs.Hoten = hoTen;
            hs.Toan = toan;
            hs.TiengViet = tiengViet;
            hs.TapViet = tapViet;
            txtDiemTrungBinh.Text = string.Format(hs.DiemTrungBinh().ToString());
            txtKQHT.Text = string.Format(hs.KetQuaHocTap().ToString());
            txtXeploaiKhenThuong.Text = string.Format(hs.XepLoaiKhenThuong().ToString());
        }

        private void AddItem()
        {
            dropdownlistLop.Items.Add(new ListItem("Chọn lớp", "lop"));//Nhớ chọn giá trị sao cho không parse ra được
                for (int i = 1; i <= 10; i++)
                {
                    dropdownlistLop.Items.Add(new ListItem("1-A" + i, i.ToString()));
                }


        }
    }
}