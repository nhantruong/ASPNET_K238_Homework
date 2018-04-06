<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EX04Table.aspx.cs" Inherits="BaiTap.Demo.EX04Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            border: 1px solid #008000;
            margin:100px auto;/*Cách top 100px*/
        }
        .auto-style2 {
            height: 23px;
        }
        .canh-giua{text-align:center;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td colspan="2" class="auto-style2" style="font-family: Arial; font-size: larger; font-weight: bold; font-style: normal; font-variant: normal; text-transform: uppercase; background-color: #FFFFFF; background-image: none; border: thin solid #000000; overflow: auto; position: inherit; text-align: center;">Tính Tổng 2 số nguyên</td>
            </tr>
            <tr>
                <td style="width:30%">Số A&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtSoA" runat="server" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Số B&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtSoB" runat="server" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Kết Quả&nbsp;</td>
                <td>
                    <asp:TextBox ID="txtKetQua" runat="server" ReadOnly="True" Width="98%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="tbnTinh" runat="server" OnClick="tbnTinh_Click" Text="Tính" />
                    <asp:Button ID="tbnTiepTuc" runat="server" OnClick="tbnTiepTuc_Click" Text="Tiếp tục" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="font-family: Arial; font-size: larger; font-weight: bold; color: #FF0000";>
                    <asp:Label ID="lblBaoloi" runat="server" CssClass="canh-giua"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
