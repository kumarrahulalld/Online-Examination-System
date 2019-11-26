<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="OnlineExaminationSystem.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
    <title></title>
    
</head>
<body>
   
    <div class="w3-container w3-full w3-margin-top w3-centered" style="margin-left:auto;width:80%;margin-left:10%;">
    <form id="form1" runat="server" class="w3-container w3-card-4">            
          <header class="w3-container w3-teal">
  <h1>Add Student</h1>
</header>
        
                <p>
                    <asp:Label ID="course" runat="server" Text="Select A Course."></asp:Label>
                                        <asp:DropDownList ID="courses" CssClass="w3-input" runat="server" DataValueField="CourseId" DataTextField="CourseName" OnSelectedIndexChanged="courses_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></p>
                                      <p> <asp:Label ID="sem" runat="server" Text="Select A Semester"> </asp:Label><asp:DropDownList ID="semester" CssClass="w3-input" runat="server"  DataTextField="SemName"></asp:DropDownList></p>
                                         <p><asp:FileUpload ID="FileUpload1" runat="server" ToolTip="Select Only Excel File" />   </p>     
                                     <p><asp:Button ID="upload" runat="server" Text="Upload" class="w3-button w3-section w3-teal w3-ripple" onclick="upload_Click" />  </p>
    <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
        </div>
        
</body>
</html>
