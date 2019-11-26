<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Details.aspx.cs" Inherits="OnlineExaminationSystem.Admin_Details" %>

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
         <header class="w3-container w3-teal w3-margin-top">
  <asp:Label id="adm" runat="server" Font-Size="XX-Large"></asp:Label>
</header>
    <div class="w3-container w3-half w3-margin-top" style="margin-left:25%">
    <form id="form1" runat="server" class="w3-container w3-card-4">
        <span style="font-size:30px;cursor:pointer" onclick="show()">&#9776;Your Profile</span>
    <div id="side" class="w3-sidebar w3-bar-block w3-light-grey" style="width:50%;margin-left:-35px;">
  <div class="w3-container w3-dark-grey">
    <h4>Menu</h4>
  </div>
             <asp:Image runat="server" ImageUrl="https://www.w3schools.com/howto/img_avatar.png" style="width:30%; border-radius:50%; margin-left:30px;" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1"  runat="server" Text="ADMIN WORKSPACE" CssClass="lbl" Font-Size="XX-Large"  Font-Names="arial"></asp:Label>
            <asp:Button ID="AddFaculty" runat="server" Text="Add Faculty" class="w3-bar-item w3-button w3-red" OnClick="AddFaculty_Click"/>

            <asp:Button ID="AddStudent" runat="server" Text="Add Student" class="w3-bar-item w3-button" OnClick="AddStudent_Click"/>
            <asp:Button ID="createexam" runat="server" Text="Create An Exam" OnClick="createexam_Click" class="w3-bar-item w3-button" />
               <asp:Button ID="removefaculty" OnClick="removefaculty_Click" runat="server" Text="Remove Faculty" class="w3-bar-item w3-button" />
                    <asp:Button ID="exam" runat="server" Text="All Exams" OnClick="exam_Click" class="w3-bar-item w3-button" />
                    <asp:Button ID="result" runat="server" Text="All Results" OnClick="result_Click" class="w3-bar-item w3-button" />
                    <asp:Button ID="student" runat="server" Text="All Students" OnClick="student_Click" class="w3-bar-item w3-button" />

        <div class="w3-panel w3-blue-grey w3-display-container">
    <span onclick="hide()" class="w3-button w3-blue-grey w3-display-topright">&times;</span>
    <p>Close....</p>
  </div>
        </div>
        
        </form>
        </div>
</body>
</html>
