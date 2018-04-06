<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KhachHang.aspx.cs" Inherits="BaiTap.Bai02.KhachHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>2.3 - Khách hàng</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid ">
            <h2 class="page-header text-primary text-center">Đăng ký - Thông tin khách hàng</h2>
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="col-sm-3 control-label">Tên đăng nhập</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="txtTenDangNhap" runat="server" CssClass="form-control" placeholder="Nhập tên Đăng Nhập"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Mật khẩu</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Họ và tên</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control" placeholder="Nhập Họ tên"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Email</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Nhập Email" TextMode="Email"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">Địa chỉ</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="txtDiaChi" runat="server" CssClass="form-control" placeholder="Nhập địa chỉ" Rows="5" TextMode="MultiLine"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-3 control-label">Giới tính</label>
                    <div class="col-sm-9">
                        <asp:RadioButton ID="rbtnNam" runat="server" Text="Nam" GroupName="Group_GioiTinh" Style="text-align: left" Checked="True" />
                        &nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="rbtnNu" runat="server" Text="Nữ" GroupName="Group_GioiTinh" />
                    </div>
                </div>

                <div class="form-group">
                    <label class="col-sm-3 control-label">ngày sinh</label>
                    <div class="col-sm-9">
                        <asp:DropDownList ID="DropDownList_Date" runat="server"></asp:DropDownList>
                        <asp:DropDownList ID="DropDownList_Month" runat="server">
                            <asp:ListItem Value="1">Tháng Giêng</asp:ListItem>
                            <asp:ListItem Value="2">Tháng 2</asp:ListItem>

                        </asp:DropDownList>
                        <asp:DropDownList ID="DropDownList_Year" runat="server"></asp:DropDownList>
                    </div>
                </div>


                <div class="form-group">
                    <label class="col-sm-3 control-label">Sở thích</label>
                    <div class="col-sm-9">
                        <asp:Panel ID="panelSoThich" runat="server">
                            <asp:CheckBox ID="CheckBox1" runat="server" Text="Xem phim" />
                            <asp:CheckBox ID="CheckBox2" runat="server" Text="Du lịch" />
                            <asp:CheckBox ID="CheckBox3" runat="server" Text="Đọc sách" />
                            <asp:CheckBox ID="CheckBox4" runat="server" Text="Nghe nhạc" />
                            <asp:CheckBox ID="CheckBox5" runat="server" Text="Chơi game" />
                            <asp:CheckBox ID="CheckBox6" runat="server" Text="Lập trình" />
                            <asp:CheckBox ID="CheckBox7" runat="server" Text="Tán dóc" />
                            <asp:CheckBox ID="CheckBox8" runat="server" Text="Nghiên cứu" />
                        </asp:Panel>
                    </div>
                </div>




                <div class="form-group">
                    <div class="col-sm-offset-3 col-sm-9">
                        <asp:Button ID="btnDangKy" runat="server" Text="Đăng ký" CssClass="btn btn-success" OnClick="btnDangKy_Click" />

                    </div>
                </div>
                <div>
                    <asp:Label ID="lblThongTin" runat="server" Text="" CssClass="text-success"></asp:Label>
                    &nbsp;<br />
                    <asp:Label ID="lblBaoLoi" runat="server" CssClass="text-danger" ViewStateMode="Disabled"></asp:Label>
                </div>
            </div>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
