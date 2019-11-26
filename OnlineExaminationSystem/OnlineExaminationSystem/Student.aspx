<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="OnlineExaminationSystem.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>

    <title></title>
    <script>
        function hide() {
            document.getElementById("side").style.display = 'none';
        }
        function show() {
            document.getElementById("side").style.display='contents';
        }
    </script>
</head>
<body>
    
     <header class="w3-container w3-teal">
  <h1>Update Password Detials Here</h1>
</header>
    <div class="w3-container w3-half w3-margin-top" style="margin-left:25%">

    <form id="form1" runat="server" class="w3-container w3-card-4">
         <span style="font-size:30px;cursor:pointer" onclick="show()">&#9776;Your Profile</span>
    <div id="side" class="w3-sidebar w3-bar-block w3-light-grey" style="width:50%">
  <div class="w3-container w3-dark-grey">
    <h4>Menu</h4>
  </div>

  <img src="img_snowtops.jpg" alt="Snow" style="width:80%; border-radius:50%; height: 60%;" />
  <asp:Button ID="CP" runat="server" Text="Change Password" class="w3-bar-item w3-button w3-red"></asp:Button>
  <asp:Button ID="Exam" runat="server" Text="Exams" class="w3-bar-item w3-button" OnClick="Exam_Click"></asp:Button>
  <asp:Button ID="resultt" runat="server" class="w3-bar-item w3-button" Text="Results" OnClick="resultt_Click"></asp:Button>
          <asp:Button ID="logout" runat="server" Text="LogOut" class="w3-bar-item w3-button"></asp:Button>


  <div class="w3-panel w3-blue-grey w3-display-container">
    <span onclick="hide()" class="w3-button w3-blue-grey w3-display-topright">&times;</span>
    <p>Close....</p>
  </div>

</div>
        <div class="form-group" style="font-size:medium;">
    



<br />
            <p>
                <asp:Label ID="error" runat="server" ForeColor="Red"></asp:Label>
            </p>
            <p>
                                    <asp:Label ID="Label1" runat="server" Text="Old Password" CssClass=""></asp:Label>
            <asp:TextBox ID="oldpass" runat="server" TextMode="Password" MaxLength="8" class="w3-input" ></asp:TextBox>
      </p>
         <p>
                                    <asp:Label ID="passl" runat="server" Text="New Password" CssClass=""></asp:Label>
            <asp:TextBox ID="newpass" runat="server" TextMode="Password" MaxLength="8" class="w3-input" ></asp:TextBox>
      </p><p>
                                    <asp:Label ID="cpassl" runat="server" Text="Confirm New Password" CssClass=""></asp:Label>
            <asp:TextBox ID="newcpass" runat="server" TextMode="Password" MaxLength="8" class="w3-input" ></asp:TextBox>
          </p>
           <p> <asp:Button ID="update" OnClick="update_Click" runat="server" Text="Update Password"  class="w3-button w3-section w3-teal w3-ripple"  /></p>

            </div>
            

        
       
          
            




       
    </form>
        </div>
    <div id="resshow" class="w3-table" runat="server">
        <asp:DataGrid ID="result" runat="server" ></asp:DataGrid>

    </div>
</body>
</html>
