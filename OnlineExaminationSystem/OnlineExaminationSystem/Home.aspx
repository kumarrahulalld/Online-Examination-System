<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineExaminationSystem.Home" %>
<asp:Content ID="home" ContentPlaceHolderID="body" runat="server">
    <form id="login" runat="server">
    <div class="row" id="tmFeatures">
          <div class="col-lg-4">
            <div class=" tm-feature-box">            
            </div>
          </div>
          <div class="col-lg-4">
            <div class=" tm-feature-box">
                <h3 class="tm-feature-name">Login Here</h3>
                <div class="tm-feature-icon-container">
                    <i class="fas fa-3x fa-arrow-circle-down"></i>
                    
                </div>
                <asp:Label ID="error" runat="server"></asp:Label>
                <label>Username</label>
                    <asp:TextBox ID="username" runat="server" CssClass="form-control form-control-lg txt" ForeColor="Black"></asp:TextBox>
                <label>Password</label>
                    <asp:TextBox ID="password" TextMode="Password" runat="server" CssClass="form-control form-control-lg txt" ForeColor="Black"></asp:TextBox>
                <asp:Button ID="submit" runat="server" Text="Login" CssClass="btn btn-success btn-lg px-5 btn" OnClick="submit_Click"/>
                <asp:LinkButton ID="forgot" runat="server" CssClass="btn btn-danger"  href="#" style="font-size:smaller;">Forgot password ?</asp:LinkButton>
            </div>
          </div>
          <div class="col-lg-4">
            <div class=" tm-feature-box">                
            </div>
          </div>
        
        
        </div>
    </form>
        
</asp:Content>