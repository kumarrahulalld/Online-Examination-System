<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="OnlineExaminationSystem.Test" %>

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
    
    <center><div class="jumbotron jumbotron-fluid">
  <div class="container">
      <form id="form1" runat="server">
                                  <asp:Label ID="error" runat="server"></asp:Label>
          <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label2" runat="server" Text="Time Left : "></asp:Label>
            <asp:Timer ID="Timer1" runat="server">
            </asp:Timer>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Label ID="Label1" runat="server" Text="60"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
                    <asp:Label ID="ques" runat="server" Text="Question" Font-Size="XX-Large" CssClass="text-success"></asp:Label>
<br /><asp:RadioButton ID="Op1" OnCheckedChanged="Op1_CheckedChanged" GroupName="op"  runat="server" />
      <br />    <asp:RadioButton ID="Op2" OnCheckedChanged="Op2_CheckedChanged" GroupName="op" runat="server" />
          <br /><asp:RadioButton ID="Op3" OnCheckedChanged="Op3_CheckedChanged" GroupName="op" runat="server" />
          <br /><asp:RadioButton ID="Op4" OnCheckedChanged="Op4_CheckedChanged" GroupName="op" runat="server" />
          <br /><p><asp:Button ID="Next" runat="server"  Text="Next" class="w3-button w3-section w3-orange w3-ripple" style="float:right" OnClick="Next_Click"></asp:Button>
<asp:Button ID="Previous" runat="server"  Text="Previous" CssClass="w3-button w3-section w3-green w3-ripple" style="float:left" OnClick="Previous_Click"></asp:Button>
              <asp:Button ID="Skip" runat="server"  Text="Skip Question" CssClass="w3-button w3-section w3-red w3-ripple" OnClick="Skip_Click"></asp:Button>
                </p>
<br /><br /><br /><p>
              <asp:Button ID="Button2" runat="server"  Text="Submit Exam" class="w3-button w3-section w3-teal w3-ripple" OnClick="Button2_Click"></asp:Button>

</p>
    </form>
  </div>

    
        
   
    </div>
    </center>
</body>
</html>
