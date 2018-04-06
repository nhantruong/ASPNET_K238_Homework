<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Phanso_NangCao.aspx.cs" Inherits="BaiTap.Homework._3._4_Phanso_Nangcao.Phanso_NangCao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>So sánh phân số</title>
    <link href="../../Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-ContentGreen text-center">
            <h2 class="">Phép tính trên phân số (Nâng cao)</h2>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Phân số 1: " Width="15%" cssclass="text-left"></asp:Label>
                <asp:TextBox ID="thPhanSo1" runat="server" Width="80%" placeHolder="Nhập phân số 1 có dạng A/B"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Phân số 2: " Width="15%" cssclass="text-left"></asp:Label>
                <asp:TextBox ID="thPhanSo2" runat="server" Width="80%" placeHolder="Nhập phân số 2 có dạng A/B"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblKetQua" runat="server" Text="Kết quả: " Width="15%" cssclass="text-left"></asp:Label>
                <asp:TextBox ID="thNhanKetQua" runat="server" placeholder="Kết quả" BackColor="#B3B3FF" ReadOnly="true" Width="80%"></asp:TextBox>
            </div>
            <div class="form-group text-right">
                <asp:ImageButton ID="ibtnCong" runat="server" Height="30px" Width="30px" ImageUrl="~/Content/Icons/math_plus_blue-jelly.png" OnClick="ibtnCong_Click"  />
                <asp:ImageButton ID="ibtnTru" runat="server" Height="30px" Width="30px" ImageUrl="~/Content/Icons/math_minus_blue-jelly.png" OnClick="ibtnTru_Click"  />
                <asp:ImageButton ID="ibtnSoSanh" runat="server" Height="30px" Width="30px" ImageUrl="~/Content/Icons/question-mark-icon_32.png" OnClick="ibtnSoSanh_Click"  />
                <asp:ImageButton ID="ibtnXoaNoiDung" runat="server" height="30px" Width="30px" ImageUrl="~/Content/Icons/undo-arrow_blue.png" OnClick="ibtnXoaNoiDung_Click" />
                </div>
        </div>
    </form>
</body>
</html>
