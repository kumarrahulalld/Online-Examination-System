
<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Exam_Page.aspx.cs" Inherits="OnlineExaminationSystem.Exam_Page" %>
<asp:Content ID="admin" ContentPlaceHolderID="body" runat="server">
    <form id="exam" runat="server">
    <div style="width:100% " >
        <div style="width:70%; float:left; border:1px solid">
            <div style="width:100%">
                    <h2> Welcome User </h2>
                <hr style="border:2px solid"/>
                    <h3> Subject: </h3>
                <asp:TextBox runat="server" ID="attempted" Enabled="false" BackColor="Green" Text="Attempted" ForeColor="White"></asp:TextBox>
                <asp:TextBox runat="server" ID="left" Enabled="false" BackColor="Red" Text="Left" ForeColor="White"></asp:TextBox>
                <asp:TextBox runat="server" ID="marked" Enabled="false" BackColor="Yellow" Text="Mark" ForeColor="Red"></asp:TextBox>

            </div>
            <div style="width:100%; height:200px; background-color:aquamarine">

            </div>
            <div style="width:100%">
                 <asp:Button ID="Button11" runat="server" BackColor="Blue" ForeColor="White" Text="Prev" />
                 <asp:Button ID="Button12" runat="server" BackColor="Blue" ForeColor="White" Text="Next" />
                <asp:Button ID="Button13" runat="server" BackColor="Yellow" ForeColor="Red" Text="Mark" />
            </div>
        </div>
        <div style="width:30%; float:right; border:1px dashed; padding-left:30px" >
            <asp:Button ID="Button1" runat="server" Text="1"  CssClass="qus"/>
            <asp:Button ID="Button2" runat="server" Text="2"   CssClass="qus" />
            <asp:Button ID="Button3" runat="server" Text="3"  CssClass="qus" />
            <asp:Button ID="Button4" runat="server" Text="4"   CssClass="qus"/>
            <asp:Button ID="Button5" runat="server" Text="5"   CssClass="qus"/>
            <asp:Button ID="Button6" runat="server" Text="6"   CssClass="qus"/>
            <asp:Button ID="Button7" runat="server" Text="7"   CssClass="qus"/>
            <asp:Button ID="Button8" runat="server" Text="8"   CssClass="qus"/>
            <asp:Button ID="Button9" runat="server" Text="9"   CssClass="qus"/>
            <asp:Button ID="Button10" runat="server" Text="10"   CssClass="qus"/>
            <asp:Button ID="Button14" runat="server" Text="11"   CssClass="qus"/>
            <asp:Button ID="Button15" runat="server" Text="12"   CssClass="qus"/>
            <asp:Button ID="Button16" runat="server" Text="13"   CssClass="qus"/>
            <asp:Button ID="Button17" runat="server" Text="14"   CssClass="qus"/>
            <asp:Button ID="Button18" runat="server" Text="15"   CssClass="qus"/>
            <asp:Button ID="Button19" runat="server" Text="16"   CssClass="qus"/>
            <asp:Button ID="Button20" runat="server" Text="17"   CssClass="qus"/>
            <asp:Button ID="Button21" runat="server" Text="18"   CssClass="qus"/>
            <asp:Button ID="Button22" runat="server" Text="19"   CssClass="qus"/>
            <asp:Button ID="Button23" runat="server" Text="20"   CssClass="qus"/>
        </div>

    </div>

        </form>
  </asp:Content> 
