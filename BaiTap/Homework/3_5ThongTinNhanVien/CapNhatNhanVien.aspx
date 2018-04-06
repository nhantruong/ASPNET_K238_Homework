<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CapNhatNhanVien.aspx.cs" Inherits="BaiTap.Homework._3_5ThongTinNhanVien.CapNhatNhanVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cập nhật thông tin nhân viên</title>
    <link href="../../Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-ContentGreen" style="height:350px; width:600px">
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <%-- View 1 - Nhập thông tin --%>
                <asp:View ID="thView1" runat="server">
                    <h2>Nhập thông tin nhân viên</h2>
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Mã số NV: " Width="20%" CssClass="control-lable col-left text-right" Font-Bold="True"></asp:Label>
                        <div class="col-right">
                            <asp:TextBox ID="thMaso" runat="server" placeholder="Nhập Mã số Nhân viên" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group  col-left">
                        <asp:Label ID="Label2" runat="server" Text="Họ tên: " Width="20%" CssClass="control-lable col-left text-right" Font-Bold="True"></asp:Label>
                        <div class="col-right">
                            <asp:TextBox ID="thHoten" runat="server" placeholder="Nhập Họ và Tên Nhân viên" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group  col-left">
                        <asp:Label ID="Label3" runat="server" Text="Ngày sinh: " Width="20%" CssClass="control-lable col-left text-right" Font-Bold="True"></asp:Label>
                        <div class="col-right">
                            <asp:TextBox ID="thNgaySinh" runat="server" placeholder="Nhập Ngày tháng năm sinh" CssClass="form-control"></asp:TextBox>
                            <asp:ImageButton ID="ImageButton1" runat="server" width="20px" Height="20px" ImageUrl="~/Content/Icons/Calendar icon.jpg" />
                            <asp:Calendar ID="thLichNgayVaoLam" runat="server" Visible ="false"></asp:Calendar>
                        </div>
                        
                    </div>
                    <div class="form-group  col-left">
                        <asp:Label ID="Label4" runat="server" Text="Ngày vào làm: " Width="20%" CssClass="control-lable col-left text-right" Font-Bold="True"></asp:Label>
                        <div class="col-right">
                            <asp:TextBox ID="thNgayVaoLam" runat="server" placeholder="Nhập Ngày bắt đầu vào cty làm việc" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group  col-left">
                        <asp:Label ID="Label5" runat="server" Text="Hệ số lương: " Width="20%" CssClass="control-lable col-left text-right" Font-Bold="True"></asp:Label>
                        <div class="col-right">
                            <asp:TextBox ID="thHesoLuong" runat="server" placeholder="Nhập hệ số lương" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group  col-left">
                        <asp:Label ID="Label6" runat="server" Text="Giới tính: " Width="20%" CssClass="col-left text-right" Font-Bold="True"></asp:Label>
                        <div class="col-right">
                            <asp:CheckBox ID="thGioiTinh" runat="server" Text="Nam" Checked="True" CssClass="text-right" />
                        </div>

                        <div class="text-right" style="padding-right:30px">
                            <asp:Button ID="thXuatThongTin" runat="server" Text="Xuất thông tin lương" CssClass="control-button col-left" OnClick="thXuatThongTin_Click"/>
                        </div>
                    </div>
                </asp:View>
                <%-- View 2 - Xuất Thông tin Nhân viên --%>
                <asp:View ID="thView2" runat="server">
                        <h2>Thông tin nhân viên</h2>
                        <div class="form-group">
                            <asp:Label ID="thThongBao" runat="server" Text="Label" CssClass="form-lable text-left"></asp:Label>

                            <p class="text-right">
                                <asp:Button ID="thTiepTuc" runat="server" Text="Tiếp tục" Width="100px" OnClick="thTiepTuc_Click" CssClass="col-left" />
                            </p>
                        </div>
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
