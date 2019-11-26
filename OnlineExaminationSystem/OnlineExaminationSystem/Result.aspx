<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="OnlineExaminationSystem.Result" %>

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
  <h1>Your Exam Results.</h1>
</header>
    <div class="w3-container w3-half w3-margin-top" style="margin-left:25%">
        <form id="form1" runat="server">
        <div class="w3-table-all">
            <asp:Table ID="Table1" runat="server" CellPadding="5"

GridLines="horizontal" HorizontalAlign="Center">

   <asp:TableRow>

   <asp:TableCell>Total Marks</asp:TableCell>

   <asp:TableCell ID="tq">2</asp:TableCell>

   </asp:TableRow>

   <asp:TableRow>

   <asp:TableCell>Attempted Questions</asp:TableCell>

   <asp:TableCell ID="aq">4</asp:TableCell>

   </asp:TableRow>
                 <asp:TableRow>

   <asp:TableCell>Left Questions</asp:TableCell>

   <asp:TableCell ID="lq">4</asp:TableCell>

   </asp:TableRow>
                 <asp:TableRow>

   <asp:TableCell>Correct Answered Questions</asp:TableCell>

   <asp:TableCell ID="cam">4</asp:TableCell>

   </asp:TableRow>
                 <asp:TableRow>

   <asp:TableCell>Wrong Answered Questions</asp:TableCell>

   <asp:TableCell ID="wam">4</asp:TableCell>

   </asp:TableRow>
                 <asp:TableRow>

   <asp:TableCell>Obtained Marks</asp:TableCell>

   <asp:TableCell ID="om">4</asp:TableCell>

   </asp:TableRow>
                                 <asp:TableRow>

   <asp:TableCell>Passing Marks</asp:TableCell>

   <asp:TableCell ID="ps">4</asp:TableCell>

   </asp:TableRow>
                                              <asp:TableRow>

   <asp:TableCell>Result</asp:TableCell>

   <asp:TableCell ID="rs">4</asp:TableCell>

   </asp:TableRow>

</asp:Table>
        </div>    
        </form>
        </div>
</body>
</html>
