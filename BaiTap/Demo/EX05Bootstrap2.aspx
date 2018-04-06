<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EX05Bootstrap2.aspx.cs" Inherits="BaiTap.Demo.EX05Bootstrap2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bootstrap 4 Example</title>
     <meta charset="utf-8">
     <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <script src="../Scripts/popper.min.js"></script>
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
<div class="container">
  <h2>List Group With Badges</h2>
  <ul class="list-group">
    <li class="list-group-item">New <span class="badge">12</span></li>
    <li class="list-group-item">Deleted <span class="badge">5</span></li>
    <li class="list-group-item">Warnings <span class="badge">3</span></li>
  </ul>
</div>
    </form>
</body>
</html>
