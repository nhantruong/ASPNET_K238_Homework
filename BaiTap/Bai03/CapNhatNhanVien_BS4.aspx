<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CapNhatNhanVien_BS4.aspx.cs" Inherits="BaiTap.Bai03.CapNhatNhanVien_BS4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cập nhật Nhân Viên</title>
    <%-- Mặc định sau khi Get Bootstrap --%>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/bootstrap.min.js"></script>
    <script src="../../Scripts/jquery-1.10.2.min.js"></script>
    <script src="../../Scripts/respond.js"></script>
    <link href="../Content/Site.css" rel="stylesheet" />
    <%-- Ref WEB --%>
   <%-- <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>--%>

    <%-- Download --%>
<%--<link href="../../Assets/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Assets/bootstrap.min.js"></script>
    <script src="../../Assets/jquery.min.js"></script>--%>



</head>
<body>
    <form id="ThongTinNhanVien" runat="server">
        <div>
            <div class="container">
                <h2>Nhập Thông tin Nhân viên</h2>
                <form class="form-horizontal" action="/action_page.php">
                    <div class="form-group">
                        <label class="control-label col-sm-2" for="Maso">Mã số:</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="txtMaso" runat="server" placeholder="Nhập Mã số nhân viên">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-2" for="HoTen">Họ Tên:</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="txtHoten" runat="server" placeholder="Nhập họ tên Nhân viên">
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-2" for="Ngaysinh">Ngày sinh:</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="txtNgaysinh" runat="server" placeholder="Nhập Ngày sinh Nhân viên" text="15/03/1988" />
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="control-label col-sm-2" for="NgayVaoLam">Ngày vào làm:</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="txtNgayVaoLam" runat="server" placeholder="Nhập Ngày vào bắt đầu vào làm" text="15/03/2017" />
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="control-label col-sm-2" for="HeSoLuong">Hệ số lương:</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="txtHesoluong" placeholder="Hệ số lương" text="1" runat="server"/>
                        </div>
                    </div>

                    <div class="form-group">
                        <label class="control-label col-sm-2" for="GioiTinh">Giới tính:</label>
                        <div class="col-sm-10">
                            <input type="checkbox" name="txtNam" runat="server">Nam
                        </div>
                    </div>
                    
                    <%-- Nut bam cho xuat hien Modal --%>
                    <!-- Trigger the modal with a button -->
                    <button type="button" class="btn btn-dark" id="btnXuatThongTin" data-toggle="modal" data-target="#thongTinLuong" runat="server">Xuất Thông tin lương</button>
                                        <br />
                    <!-- Modal -->
                    <div id="thongTinLuong" class="modal fade" role="dialog">
                        <div class="modal-dialog">
                            <!-- Modal content-->
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h4 class="modal-title">Thông tin luong nhân viên</h4>
                                </div>
                                <div class="modal-body">
                                    <asp:Label ID="lblThongTin" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="modal-footer">
                                    <button type="button" id="btnTiepTuc" class="btn btn-dark" data-dismiss="modal" runat="server">Tiếp Tục</button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <asp:Label ID="lblBaoLoi" runat="server" Text=""></asp:Label>
                </form>
            </div>
        </div>
    </form>
</body>
</html>
