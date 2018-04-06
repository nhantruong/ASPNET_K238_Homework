<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pheptinhphanso.aspx.cs" Inherits="BaiTap.Homework._3._3_Phanso.Pheptinhphanso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Phép tính phân số</title>
    <link href="../../Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-ContentGreen col-left">
            <h2>Phép tính trên phân số</h2>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Phân số 1:" Width="25%" ></asp:Label>
                <asp:TextBox ID="thPhanSo1" runat="server" placeholder="Nhập phân số 1, dạng A/B" Width="250px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Phân số 2:" Width="25%" ></asp:Label>
                <asp:TextBox ID="thPhanSo2" runat="server" placeholder="Nhập phân số 2, dạng A/B" Width="250px"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblKetqua" runat="server" Text="Kết Quả:" Width="25%"></asp:Label>
                <asp:TextBox ID="thKetQua" runat="server"  placeholder="Kết quả" Width="250px" BackColor="#CCFF99"></asp:TextBox>
            </div>
            <div>
                <p class="col-right text-right">
                    <asp:ImageButton ID="ibtnCong" runat="server" ImageUrl="~/Content/Icons/math_plus_red.png" OnClick="ibtnCong_Click" />
                    <asp:ImageButton ID="ibtnTru" runat="server" ImageUrl="~/Content/Icons/math_minus_red.png" OnClick="ibtnTru_Click" />
                    <asp:ImageButton ID="ibtnNhan" runat="server" ImageUrl="~/Content/Icons/math_multiply_red.png" OnClick="ibtnNhan_Click" />
                    <asp:ImageButton ID="ibtnChia" runat="server" ImageUrl="~/Content/Icons/math_divide_red.png" OnClick="ibtnChia_Click" />
                    <asp:ImageButton ID="ibtnXoaNoiDung" runat="server" ImageUrl="~/Content/Icons/math_clear_red.png" OnClick="ibtnXoaNoiDung_Click" />
                </p>

            </div>
        </div>
    </form>
</body>
</html>
