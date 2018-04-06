<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NhapDiemHocSinhLop1.aspx.cs" Inherits="BaiTap.Homework.Baitap05.NhapDiemHocSinhLop1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nhập điểm cho học sinh lớp 1</title>
    <link href="../../Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-Content">
            <h3>Nhập điểm - học sinh lớp Một</h3>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Lớp " CssClass="form-lable col-left text-right" Style="padding-right: 10px" Width="25%"></asp:Label>
                <asp:DropDownList ID="dropdownlistLop" runat="server" CssClass="form-control col-right text-left" Width="74%"></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Mã số " CssClass="form-lable col-left text-right" Style="padding-right: 10px" Width="25%"></asp:Label>
                <asp:TextBox ID="txtMaSo" runat="server" CssClass="form-control text-left col-right" Width="74%"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Họ tên " CssClass="form-lable col-left text-right" Style="padding-right: 10px" Width="25%"></asp:Label>
                <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control text-left col-right" Width="74%"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Toán " CssClass="form-lable col-left text-right" Style="padding-right: 10px" Width="25%"></asp:Label>
                <asp:TextBox ID="txtToan" runat="server" CssClass="form-control text-left col-right" Width="74%"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Tiếng Việt " CssClass="form-lable col-left text-right" Style="padding-right: 10px" Width="25%"></asp:Label>
                <asp:TextBox ID="txtTiengViet" runat="server" CssClass="form-control text-left col-right" Width="74%"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Tập Viết " CssClass="form-lable col-left text-right" Style="padding-right: 10px" Width="25%"></asp:Label>
                <asp:TextBox ID="txtTapViet" runat="server" CssClass="form-control text-left col-right" Width="74%"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Điểm Trung Bình " CssClass="form-lable col-left text-right" Style="padding-right: 10px;" Width="25%" Enabled="false"></asp:Label>
                <asp:TextBox ID="txtDiemTrungBinh" runat="server" CssClass="form-control text-left col-right" Width="74%" BackColor="#9bc3e5"></asp:TextBox>
            </div>
                        <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="Kết quả học tập " CssClass="form-lable col-left text-right" Style="padding-right: 10px;" Width="25%" Enabled="false"></asp:Label>
                <asp:TextBox ID="txtKQHT" runat="server" CssClass="form-control text-left col-right" Width="74%" BackColor="#9bc3e5"></asp:TextBox>
            </div>
                                    <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="Xếp loại khen thưởng " CssClass="form-lable col-left text-right" Style="padding-right: 10px;" Width="25%" Enabled="false"></asp:Label>
                <asp:TextBox ID="txtXeploaiKhenThuong" runat="server" CssClass="form-control text-left col-right" Width="74%" BackColor="#9bc3e5"></asp:TextBox>
            </div>
            <div class="text-right">
                <asp:Button ID="btnThucHien" runat="server" Text="Thực hiện" OnClick="btnThucHien_Click" />
                <asp:Button ID="btnTiep" runat="server" Text="Tiếp" OnClick="btnTiep_Click" />
            </div>


        </div>
    </form>
</body>
</html>
