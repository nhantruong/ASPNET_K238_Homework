<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EXMultiView.aspx.cs" Inherits="BaiTap.Demo.EXMultiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2 class="text-info">Demo Multiview</h2>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/Photos/Northern_lights1.jpg" Width="250px" Height="200px" />
                <br />
                <asp:LinkButton ID="LinkButtonNext" runat="server" CommandName="NextView">Next</asp:LinkButton>
                &nbsp;
                <asp:Button ID="btn2" runat="server" CommandArgument="1" CommandName="SwitchViewByIndex" 
                    CssClass="btn btn-success btn-xs" Text="2" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Image/Photos/Northern_lights2.jpg" Width="250px" Height="200px" />
                <br />
                <asp:LinkButton ID="LinkButtonPrev" runat="server" CommandName="PrevView">Preview</asp:LinkButton>
                &nbsp;
                <asp:Button ID="btn1" runat="server" CommandArgument="0" CommandName="SwitchViewByIndex" 
                    CssClass="btn btn-success btn-xs" Text="1" />
            </asp:View>
        </asp:MultiView>
        <div class="bg-danger">
            <asp:ImageButton ID="imageButton1" runat="server" ImageUrl="~/Image/Icons/prev.jpg" Height="30px" Width="30px" OnClick="imageButton1_Click" />
            &nbsp;<asp:ImageButton ID="imageButton2" runat="server" Height="30px" ImageUrl="~/Image/Icons/next.jpg" Width="30px" OnClick="imageButton2_Click" />
        </div>
    </div>
    </form>
</body>
</html>
