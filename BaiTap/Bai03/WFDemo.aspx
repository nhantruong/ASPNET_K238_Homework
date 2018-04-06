<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFDemo.aspx.cs" Inherits="BaiTap.Bai03.WFDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="txtMaso" runat="server" Text="K01"></asp:TextBox>
        <asp:TextBox ID="txtHoTen" runat="server" Text="Nguyễn Văn A"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtGioiTinh" runat="server" Text="Nam"></asp:TextBox>
        <asp:TextBox ID="txtHeSoLuong" runat="server" Text="1.5"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtNgayVaoLam" runat="server" Text="01/01/2015"></asp:TextBox>
        <asp:Button ID="btnGhiThongTin" runat="server" OnClick="btnGhiThongTin_Click" Text="Ghi Thông Tin" />
        <br />
        <asp:Label ID="lblThongBao" runat="server"></asp:Label>
    </form>
</body>
</html>
