<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddExam.aspx.cs" Inherits="OnlineExaminationSystem.AddExam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>

</head>
<body>
     <header class="w3-container w3-teal">
  <h1>Add Exams</h1>
</header>
    <div class="w3-container w3-half w3-margin-top" style="margin-left:25%">

    <form id="form1" runat="server">
                <div class="form-group" style="font-size:medium">
                    <p>
                        <asp:Label ID="error" runat="server" ForeColor="Red"></asp:Label>
                    </p>
                <p>
                                    <asp:Label ID="Label1" runat="server" Text="Test Id" CssClass=""></asp:Label>
            <asp:TextBox ID="test_id" runat="server" class="w3-input" required="true" MaxLength="5"></asp:TextBox>
      </p>  
        
                    <p>
                                    <asp:Label ID="Label3" runat="server" Text="Total Questions" CssClass=""></asp:Label>
            <asp:TextBox ID="totalques" runat="server" TextMode="Number" MaxLength="3" class="w3-input" required="true"></asp:TextBox>
      </p>
                    <p>
                                    <asp:Label ID="Label4" runat="server" Text="Mark For Correct Answer" CssClass=""></asp:Label>
            <asp:TextBox ID="correctmark" runat="server" class="w3-input" TextMode="Number" required="true" MaxLength="1"></asp:TextBox>
      </p>
                    <p>
                                    <asp:Label ID="Label5" runat="server" Text="Mark For Wrong Answer" CssClass=""></asp:Label>
            <asp:TextBox ID="wrongmark" runat="server" class="w3-input" TextMode="Number"  required="true"></asp:TextBox>
                   </p>  
                                <p>
                                    <asp:Label ID="Label2" runat="server" Text="Total Marks" CssClass=""></asp:Label>
            <asp:TextBox ID="totalmarks" runat="server" class="w3-input" TextMode="Number" required="true"></asp:TextBox>
      </p>
                                               <p>
                                    <asp:Label ID="Label7" runat="server" Text="Test Duration In Seconds" CssClass=""></asp:Label>
            <asp:TextBox ID="td" runat="server" class="w3-input" TextMode="Number" required="true"></asp:TextBox>
      </p>
                                               <p>
                                    <asp:Label ID="Label8" runat="server" Text="Passing Marks" CssClass=""></asp:Label>
            <asp:TextBox ID="pm" runat="server" class="w3-input" TextMode="Number" required="true"></asp:TextBox>
      </p>
                    <p>
                                    <asp:Label ID="Label6" runat="server" Text="Date Of Exam" CssClass=""></asp:Label>
            <asp:TextBox ID="date" runat="server" TextMode="Date" class="w3-input" required="true"></asp:TextBox>
      </p>
      <p>
            <asp:DropDownList ID="course" runat="server" class="w3-input" required="true">
                <asp:ListItem value="none" Selected="True" Text="Select Course" ></asp:ListItem>
                <asp:ListItem value="mca" Text="MCA"></asp:ListItem>
                    <asp:ListItem value="bca" Text="BCA"></asp:ListItem>
                        <asp:ListItem value="pgdca" Text="PGDCA"></asp:ListItem>
            </asp:DropDownList>
       </p>
                         <p>
            <asp:DropDownList ID="semester" runat="server" class="w3-input" required="true">
                <asp:ListItem value="none" Selected="True" Text="Select Semester" ></asp:ListItem>
                <asp:ListItem value="1" Text="I"></asp:ListItem>
                    <asp:ListItem value="2" Text="II"></asp:ListItem>
                        <asp:ListItem value="3" Text="III"></asp:ListItem>
                                        <asp:ListItem value="4" Text="IV"></asp:ListItem>

                                        <asp:ListItem value="5" Text="V"></asp:ListItem>

                                        <asp:ListItem value="6" Text="VI"></asp:ListItem>

            </asp:DropDownList>
       </p>
                    <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="false" />
                   <p> <asp:Button ID="exam" runat="server" Text="Create Exam"  class="w3-button w3-section w3-teal w3-ripple" OnClick="exam_Click"  /></p>
                    </div>
    </form>
        </div>
</body>
</html>
