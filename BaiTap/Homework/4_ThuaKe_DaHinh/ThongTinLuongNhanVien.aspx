<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThongTinLuongNhanVien.aspx.cs" Inherits="BaiTap.Homework._4_ThuaKe_DaHinh.ThongTinLuongNhanVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thông tin Lương Nhân viên Công ty Z</title>
    <link href="../../Content/bootstrap.css" rel="stylesheet" />
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../../Scripts/popper-utils.min.js"></script>
    <script src="../../Scripts/bootstrap.js"></script>
    <script src="../../Scripts/jquery-ui.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <h2>Thông tin Nhân viên</h2>
                    <div class="form-group">
                        <label class="control-label col-sm-2">Mã số NV: </label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="thMaso" placeholder="Nhập Mã số NV" name="Maso" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-2">Họ tên NV: </label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="thHoten" placeholder="Nhập Họ tên NV" name="Hoten" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-2">Ngày sinh: </label>
                        <div class="col-sm-10">
                            <%-- Date picker --%>
                            <div class="container">
                                <div class="row">
                                    <div class='col-sm-6'>
                                        <div class="form-group">
                                            <div class='input-group date' id='thNgaySinh'>
                                                <input type='text' class="form-control" placeholder="Chọn Ngày sinh" />
                                                <span class="input-group-addon">
                                                    <span class="glyphicon glyphicon-calendar"></span>
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                    <script type="text/javascript">
                                        $(function () {
                                            $('#thNgaySinh')..data("DateTimePicker").FUNCTION(){
                                                locale: 'vn'
                                            });
                                        });
                                    </script>
                                </div>
                            </div>
                            <div class="container">
                                <div class="row">
                                    <div class='col-sm-6'>
                                        <div class="form-group">
                                            <div class='input-group date' id='datetimepicker1'>
                                                <input type='text' class="form-control" />
                                                <span class="input-group-addon">
                                                    <span class="glyphicon glyphicon-calendar"></span>
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                    <script type="text/javascript">
                                        $(function () {
                                            $('#datetimepicker1').data("DateTimePicker").FUNCTION();
                                        });
                                    </script>
                                </div>
                            </div>
                            <%-- End Date picker --%>
                            <%--  dạng 2--%>
                            <div style="overflow: hidden;">
                                <div class="form-group">
                                    <div class="row">
                                        <div class="col-md-8">
                                            <div id="datetimepicker12"></div>
                                        </div>
                                    </div>
                                </div>
                                <script type="text/javascript">
                                    $(function () {
                                        $('#datetimepicker12').datetimepicker({
                                            inline: true,
                                            sideBySide: true
                                        });
                                    });
                                </script>
                            </div>
                            <%-- End Dạng 2 --%>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="control-label col-sm-2">Ngày vào làm: </label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="thNgayVaoLam" placeholder="Chọn Ngày vào làm" name="Ngayvaolam" />
                        </div>
                    </div>


                </asp:View>
                <asp:View ID="View2" runat="server">
                </asp:View>

            </asp:MultiView>
        </div>
    </form>
</body>
</html>
