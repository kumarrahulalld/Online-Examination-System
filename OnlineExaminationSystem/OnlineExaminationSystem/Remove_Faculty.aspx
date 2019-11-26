
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Remove_Faculty.aspx.cs" Inherits="OnlineExaminationSystem.Remove_Faculty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
    <title></title>
</head>
<body>
<div class="w3-container w3-full w3-margin-top w3-centered" style="margin-left:auto;width:80%;margin-left:10%;">
    <form id="form" runat="server" class="w3-container w3-card-4">            
          <header class="w3-container w3-teal">
  <h1>Remove Faculty</h1>
</header>
        <p>
                      <asp:Label ID="error" runat="server" CssClass="form-control label-danger" Text=""></asp:Label>
            <br/>
          <asp:Label ID="Label1" runat="server" CssClass="form-control label-primary" Text="Please Select A Faculty."></asp:Label>
        <asp:DropDownList ID="fac" runat="server" CssClass="w3-input"></asp:DropDownList>
            <asp:Button ID="rem" runat="server" Text="Remove Faculty" OnClick="rem_Click" class="w3-button w3-section w3-teal w3-ripple"/>
        </p>
</form>
        </div>
</body>
</html>
