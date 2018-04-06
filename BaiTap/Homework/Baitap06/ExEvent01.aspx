<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExEvent01.aspx.cs" Inherits="BaiTap.Homework.Baitap06.ExEvent01" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cập nhật thông tin về Hệ số lương</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Thêm nhân viên"></asp:Label>
            <asp:Button ID="btnThemNV" runat="server" Text="Thêm nhân viên" OnClick="btnThemNV_Click" />
           </div>
        <div>
            <asp:TextBox ID="txtHSL" runat="server"></asp:TextBox>
            <asp:Button ID="btnCapNhatHSL" runat="server" Text="Cập nhật Hệ số lương" OnClick="btnCapNhatHSL_Click" />
        </div>
    </form>
</body>
</html>
