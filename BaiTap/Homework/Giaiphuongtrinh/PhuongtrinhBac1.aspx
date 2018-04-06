<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhuongtrinhBac1.aspx.cs" Inherits="BaiTap.Bai04.Giaiphuongtrinh.PhuongtrinhBac1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GiaiPhuongTrinhBac1</title>
    <link href="../../Content/Site.css" rel="stylesheet" />
    <style>
        .frame{
            width:500px auto;
            height:200px auto;
            margin-bottom:25%;
            margin-top:25%;
            margin-left:25%;
            margin-right:25%;
        }
        .textcolor{
            color:#ff6a00;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="text-center frame">
        <div>
            <h2>Giải phương trình bậc 1 - Ax + B = 0</h2>
            <div class="form-group text-left">
                <label>Nhập số A:</label>
                <input class="form-control" id="txtSoA" placeholder="Nhập số A" runat="server">
            </div>
            <div class="form-group text-left">
                <label>Nhập số B:</label>
                <input class="form-control" id="txtSoB" placeholder="Nhập số B"  runat="server">
            </div>
            <div class="form-group text-left">
                <label>Kết Quả:</label>
                <input class="form-control" id="txtKetQua" placeholder="Kết quả" runat="server" enableviewstate="False">
            </div>
            <div class="text-right">
                <button id="btnTinh" runat="server" type="submit" class="btn btn-success">Giải Phương Trình</button>
                <button id="btnBaiKhac" runat="server" type="submit" class="btn btn-success">Bài Khác</button>
            </div>
        </div>
    </form>
</body>
</html>
