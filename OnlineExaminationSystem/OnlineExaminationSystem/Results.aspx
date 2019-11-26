<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="OnlineExaminationSystem.Results" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
        <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
    <title></title>
</head>
<body>
     <header class="w3-container w3-teal">
  <h1>Your Previous Exam Results.</h1>
</header>
    <div class="w3-container w3-half w3-margin-top" style="margin-left:18%">
    <form id="form1" runat="server">
        <div class="w3-table-all">
            <asp:GridView ID="res" runat="server"></asp:GridView>
        </div>
    </form>
        </div>
</body>
</html>
