<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BaiTap.Demo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Module 1 - Thực hành</title>
    <link href="../Content/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <h2>Trang chủ</h2>
            <ol>
                <li>
                    <asp:HyperLink ID="hplChao" runat="server" NavigateUrl="~/Demo/EX01Chao.aspx" Target="_blank">Chào</asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="hplW3school" runat="server" NavigateUrl="https://www.w3schools.com/html/html_lists.asp">W3School</asp:HyperLink>
                </li>
                <li>
                    <asp:HyperLink ID="hplTheThao" runat="server" ImageHeight="100px" ImageUrl="~/Image/thethao.jpg" ImageWidth="200px" NavigateUrl="https://thethao.vnexpress.net/tin-tuc/giai-ngoai-hang-anh/salah-ghi-bon-ban-liverpool-thoi-lua-vao-gay-man-utd-3724319.html" ToolTip="Salah ghi bốn bàn, Liverpool 'thổi lửa vào gáy' Man Utd">Thể Thao</asp:HyperLink>

                </li>
                <li>
                    <asp:HyperLink ID="hplKhachHang" runat="server">Khách hàng</asp:HyperLink>
                </li>
            </ol>


        </div>
    </form>
</body>
</html>
