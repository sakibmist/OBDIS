<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/AdminMasterForm.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="OBDSystemAPP.ap.UI.ApLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <%--<link href="../apContent/Template/css/bootstrap-wysihtml5/bootstrap3-wysihtml5.css" rel="stylesheet" />
    <script src="../apContent/Template/js/jquery-ui-1.10.3.min.js"></script>
    <script src="../../js/Scripts/jquery-3.1.1.min.js"></script>
     <script src="../../js/jquery.validate.min.js"></script>

    <style type="text/css">
         label.error {
             color: red;
         }
    </style>
<script> 
        $(document).ready(function() {

            $("#form1").validate({
                rules: {
                    <% = adminIdTextBox.UniqueID%>: {
                        required: true,
                        rangelength: [3, 20],
                    },

                    messages: {
                        <%= adminIdTextBox%>: {
                            required: "Id is required",
                            rangelength: "Name must between{0}to{1}characters"

                        }
                    }
                }

            });
        });

    </script> --%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="apMasterForm" runat="server">
       <!-- admin login -->
        <div class="form-box" id="login-box">
            <div class="header">Admin Login</div>
          
                <div class="body bg-gray">
    
                    <div class="form-group">
                         
                         <asp:TextBox ID="adminUserIdTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Admin Id" ></asp:TextBox>
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
                    
                    <a href="AdminRegistration.aspx" class="text-center">Register a new membership</a> 
                </div>
            </div>    
<!-- end admin login -->

</asp:Content>
