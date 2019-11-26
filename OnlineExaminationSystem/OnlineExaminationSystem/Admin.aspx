<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="OnlineExaminationSystem.Admin" %>
<asp:Content ID="admin" ContentPlaceHolderID="body" runat="server">
    <form id="admin_log" runat="server">
    <div class="row" id="tmFeatures">
          <div class="col-lg-4">
            <div class=" tm-feature-box">            
            </div>
          </div>
          <div class="col-lg-4">
            <div class=" tm-feature-box">
                <h3 class="tm-feature-name">Admin Login Here</h3>
                <div class="tm-feature-icon-container">
                    <i class="fas fa-3x fa-arrow-circle-down"></i>
                    
                </div>
                <label>Admin name</label>
                    <asp:TextBox ID="username" runat="server" CssClass="form-control form-control-lg txt" ForeColor="Black"></asp:TextBox>
                <label>Password</label>
                    <asp:TextBox ID="password" TextMode="Password" runat="server" CssClass="form-control form-control-lg txt" ForeColor="Black"></asp:TextBox>
                <asp:Button ID="submit" runat="server" Text="Login" CssClass="btn btn-success float-left" OnClick="submit_Click"/>
                                <asp:Button ID="forgot" runat="server" Text="Forgot Password" CssClass="btn btn-danger float-right custom-control-inline" OnClick="submit_Click"/>

            </div>
          </div>
          <div class="col-lg-4">
            <div class=" tm-feature-box">                
            </div>
          </div>
        
        
        </div>
    </form>

    </asp:Content>
