<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TinhKhoangCachHaiDiem.aspx.cs" Inherits="BaiTap.Homework.TinhKhoangCach.TinhKhoangCachHaiDiem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính khoảng cách giữa 2 điểm</title>
    <link href="../../Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="text-left">
        <div class="main-Content">
            <h2>Tính khoảng cách giữa 2 điểm AB</h2>
            <div class="form-group">
                <asp:Label ID="lblDiemA" runat="server" CssClass="col-left control-label">Tọa độ điểm A</asp:Label>
                <div class="col-right">
                <asp:TextBox ID="txtDiemA" runat="server" CssClass="col-right text-left" placeholder="Nhập tọa độ điểm A, dạng A(X;Y)"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lblDiemB" runat="server" CssClass="col-left control-label">Tọa độ điểm B</asp:Label>
                <div class =" col-right">
                    <asp:TextBox ID="txtDiemB" runat="server" CssClass="col-right" placeholder="Nhập tọa độ B, dạng B(X;Y)"></asp:TextBox>
                </div>
            </div>
                        <div class="form-group">
                <asp:Label ID="Label1" runat="server" CssClass="col-left control-label">Kết quả</asp:Label>
                <div class =" col-right">
                    <asp:TextBox ID="txtKetQua" runat="server" CssClass="col-right"></asp:TextBox>
                </div>
            </div>
            <br />
            <p class="text-left" style="padding: 20px 0px; border-top: 1px solid #c9c4c4">
                <asp:Button ID="btnTinh" runat="server" Text=" Tính Khoảng cách AB " OnClick="btnTinh_Click" />
                <asp:Button ID="btnXoa" runat="server" Text=" Xóa nội dung " OnClick="btnXoa_Click" />
            </p>
        </div>
    </form>
</body>
</html>
