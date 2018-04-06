<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuanLyMayTinh.aspx.cs" Inherits="BaiTap.Homework._4_2_DanhSachMayTinh.QuanLyMayTinh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quản lý Máy tính</title>
    <link href="../../Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Nhập thông tin máy tính</h3>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Số hiệu" CssClass="col-left control-label" Width="30%"></asp:Label>
                <asp:TextBox ID="txtSoHieu" runat="server" CssClass="form-control" Width="65%"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Đơn giá" CssClass="col-left control-label" Width="30%"></asp:Label>
                <asp:TextBox ID="txtDonGia" runat="server" CssClass="form-control" Width="65%"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Hãng Sản Xuất" CssClass="col-left control-label" Width="30%"></asp:Label>
                <asp:TextBox ID="txtHangSanXuat" runat="server" CssClass="form-control" Width="65%"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Loại Máy tính" CssClass="col-left control-label" Width="30%"></asp:Label>
                <div class="control-checkbox">
                    <asp:RadioButton ID="rbtnMaytinhDeBan" GroupName="LoaiMayTinh" runat="server" Text=" Máy tính để bàn" Checked="True" OnCheckedChanged="rbtnMaytinhDeBan_CheckedChanged" />
                    &nbsp;&nbsp;&nbsp;&nbsp;                        
                      <asp:RadioButton ID="rbtnMayTinhXachTay" GroupName="LoaiMayTinh" runat="server" Text=" Máy tính xách tay" OnCheckedChanged="rbtnMayTinhXachTay_CheckedChanged" />
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="lbl1" runat="server" Text="Trọng Lượng" CssClass="col-left control-label" Width="30%"></asp:Label>
                <asp:TextBox ID="txt1" runat="server" CssClass="form-control" Width="65%"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lbl2" runat="server" Text="Thời gian pin" CssClass="col-left control-label" Width="30%"></asp:Label>
                <asp:TextBox ID="txt2" runat="server" CssClass="form-control" Width="65%"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblKichThuocManHinh" runat="server" Text="Kích thước màn hình" CssClass="col-left control-label" Width="30%"></asp:Label>
                <asp:TextBox ID="txtKichThuocManHinh" runat="server" CssClass="form-control" Width="65%"></asp:TextBox>
            </div>
            <div class="text-left">
                <asp:Button ID="btnLuuThongTin" runat="server" Text="Lưu Thông tin" />
            </div>


            <div class="col-left">
                <h3 class="text-left">Danh sách máy tính</h3>
                <asp:Label ID="tblDanhSachMT" runat="server" Text=""></asp:Label>
            </div>

        </div>
    </form>
</body>
</html>
