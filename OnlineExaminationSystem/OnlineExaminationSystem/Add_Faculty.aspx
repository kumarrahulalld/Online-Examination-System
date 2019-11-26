<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Faculty.aspx.cs" Inherits="OnlineExaminationSystem.Add_Faculty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
    <title></title>
</head>
<body>
     <div class="w3-container w3-full w3-margin-top w3-centered" style="width:80%;margin-left:10%;">
    <form id="form" runat="server" class="w3-container w3-card-4">            
          <header class="w3-container w3-teal">
  <h1>Add Faculty</h1>
</header>
        <p>
                      <asp:Label ID="error" runat="server" CssClass="form-control label-danger" Text=""></asp:Label>

          <asp:Label ID="Label1" runat="server" CssClass="form-control label-primary" Text="NAME OF THE FACULTY:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="w3-input" required="true"></asp:TextBox>
         <asp:Label ID="Label2" runat="server" CssClass="form-control label-primary" Text="CLASS OF THE FACULTY:"></asp:Label>
        <asp:DropDownList ID="classs" runat="server" OnSelectedIndexChanged="classs_SelectedIndexChanged" CssClass="w3-input">
            <asp:ListItem Text="MCA" Value="mca"></asp:ListItem>
            <asp:ListItem Text="BCA" Value="bca"></asp:ListItem>
        </asp:DropDownList>
         <asp:Label ID="Label3" runat="server" CssClass="form-control label-primary" Visible="false" Text="SEMESTER OF THE FACULTY:"></asp:Label>
        <asp:DropDownList ID="sem" runat="server" OnSelectedIndexChanged="sem_SelectedIndexChanged" CssClass="w3-input">
            <asp:ListItem Text="I" Value="1"></asp:ListItem>
            <asp:ListItem Text="II" Value="2"></asp:ListItem>
            <asp:ListItem Text="III" Value="3"></asp:ListItem>
            <asp:ListItem Text="IV" Value="4"></asp:ListItem>
            <asp:ListItem Text="V" Value="5"></asp:ListItem>
            <asp:ListItem Text="VI" Value="6"></asp:ListItem>
        </asp:DropDownList>
         <asp:Label ID="Label4" runat="server" CssClass="form-control label-primary" Visible="false" Text="SUBJECT OF THE FACULTY:"></asp:Label>
        <asp:DropDownList ID="sub" runat="server" CssClass="w3-input">
            <asp:ListItem Text="JAVA" Value="java"></asp:ListItem>
            <asp:ListItem Text="C++" Value="c++"></asp:ListItem>
            <asp:ListItem Text="C" Value="c"></asp:ListItem>
            <asp:ListItem Text="Data Structures" Value="ds"></asp:ListItem>
            <asp:ListItem Text="Database" Value="dbms"></asp:ListItem>
            <asp:ListItem Text="Operating System" Value="os"></asp:ListItem>
        </asp:DropDownList>
         <asp:Label ID="Label5" runat="server" CssClass="form-control label-primary" Text="EMAIL OF THE FACULTY:"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" CssClass="w3-input" TextMode="Email" required="true"></asp:TextBox>
         <asp:Label ID="Label6" runat="server" Text="PASSWORD OF THE FACULTY:" CssClass="form-control label-primary"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" CssClass="w3-input" TextMode="Password" required="true" MaxLength="8"></asp:TextBox>
            <asp:Button ID="add" OnClick="add_Click" runat="server" Text="Add Faculty" class="w3-button w3-section w3-teal w3-ripple"/>
        </p>
</form>
        </div>
</body>
</html>
