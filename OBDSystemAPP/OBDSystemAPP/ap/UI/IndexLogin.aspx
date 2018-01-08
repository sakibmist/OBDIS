<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/AdminMasterForm.Master" AutoEventWireup="true" CodeBehind="IndexLogin.aspx.cs" Inherits="OBDSystemAPP.ap.UI.IndexLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        label.error {
            color: red;
            font-size: 14px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="apMasterForm" runat="server"> 
    <!-- admin login -->
        <div class="form-box" id="login-box">
            <div class="header">Admin Login</div>
          
                <div class="body bg-gray">
     <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                    <div class="form-group">
                         
                         <asp:TextBox ID="adminIdTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Admin Id" ></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="passwordTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Password" TextMode="Password" ></asp:TextBox>
                    </div>          
                    <div class="form-group">
                       <%-- <input type="checkbox" name="remember_me"/> Remember me--%>
                    </div>
                </div>
                <div class="footer">                     
                     <asp:Button ID="LoginButton" runat="server" ClientIDMode="Static" CssClass="btn bg-olive btn-block" Text="Sign me in" OnClick="LoginButton_Click" />   
                    
                    <!-- <p><a href="#">I forgot my password</a></p>-->
                    
                    <a href="AdminRegistration.aspx" class="text-center"><b style="color: magenta;">Register a new membership</b></a> 
                </div>
            </div>    
<!-- end admin login -->
</asp:Content>
<asp:Content runat="server" ID="Content3" ContentPlaceHolderID="apScript">
    <script type="text/javascript">
        $(document).ready(function() {
            $("#adminLogInMasterForm").validate({
                rules: {
                    <%=adminIdTextBox.UniqueID%>: {
                        required:true ,
                        minlength:5,
                        maxlength:20
                    },
                    <%=passwordTextBox.UniqueID%>: {
                        required:true ,
                        minlength:8,
                        maxlength:32
                    }
                },
                messages: {
                    <%=adminIdTextBox.UniqueID%>:  {
                        required: "Admin Id cannot be empty!",
                        minlength: "Minimum 5 Characters.",
                        maxlength:"Maximum 20 Characters."
                    },
                    <%=passwordTextBox.UniqueID%>:  {
                        required: "Password cannot be empty!",
                        minlength: "Minimum 8 Characters",
                        maxlength:"Maximum 32 Characters"
                    }
                }
            });
        });
    </script>
</asp:Content>
