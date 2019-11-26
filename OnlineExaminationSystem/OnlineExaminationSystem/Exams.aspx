<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exams.aspx.cs" Inherits="OnlineExaminationSystem.Exams" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>

</head>
<body>
     <header class="w3-container w3-teal">
  <h1>Available Exams</h1>
</header>
    <div class="w3-container w3-half w3-margin-top" style="margin-left:25%">

    <form id="form1" runat="server">
                <div class="form-group" style="font-size:medium">
                    <p>
                        <asp:Label ID="error" runat="server"></asp:Label>
                    </p>

          <p>
            <asp:DropDownList ID="course" runat="server" class="w3-input" required="true">
                <asp:ListItem value="none" Selected="True" Text="Select An Exam" ></asp:ListItem>
              
            </asp:DropDownList>
       </p>
                     <p> <asp:Button ID="reg" runat="server" Text="Start Exam" OnClick="reg_Click"  class="w3-button w3-section w3-teal w3-ripple"  /></p>
                    </div>
    </form>
        </div>
</body>
</html>
