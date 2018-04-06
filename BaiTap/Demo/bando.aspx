<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bando.aspx.cs" Inherits="BaiTap.Demo.bando" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Ban do Nga ba Nguyen Kim</h2>
        <p>
            <asp:LinkButton ID="lbtnDiachi1" runat="server" OnClick="XulyLoadbanDo_Click">Ngã ba Nguyễn Kim</asp:LinkButton>
        </p>
        <p>
            <asp:LinkButton ID="lbtnDiaChi2" runat="server" OnClick="XulyLoadbanDo_Click">Ngã 7 dân chủ</asp:LinkButton>
        </p>
        <asp:Literal ID="ltrBanDo" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
