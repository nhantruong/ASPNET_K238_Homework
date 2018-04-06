<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFDemo.aspx.cs" Inherits="BaiTap.Bai04.WFDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblThongBao" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnXuatThongTin" runat="server" Text="Xuất Thông tin" OnClick="btnXuatThongTin_Click" />
            <br />
        </div>
        <asp:TextBox ID="txtThongTin" runat="server" Rows="4" TextMode="MultiLine" Width="300px"></asp:TextBox>
    </form>
</body>
</html>
