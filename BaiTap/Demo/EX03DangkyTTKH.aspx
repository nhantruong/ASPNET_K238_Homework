<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EX03DangkyTTKH.aspx.cs" Inherits="BaiTap.Demo.EX03DangkyTTKH" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Thông tin Đăng ký khách hàng</h2>
        <hr style="color:greenyellow"/>
        <asp:Label ID="lblHoten" runat="server" Text="Họ tên khách hàng" ForeColor="#0033CC"></asp:Label>
        <asp:TextBox ID="txtHoten" runat="server"></asp:TextBox>
        <asp:Button ID="btnDangky" runat="server" OnClick="btnDangky_Click" Text="Đăng ký" />
        <br />
        <asp:Label ID="lblThongBao" runat="server"></asp:Label>
    </form>
</body>
</html>
