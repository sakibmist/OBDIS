<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Index.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OBDSystemAPP.UI.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        label.error {
            color: red;
            font-size: 14px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainBodyMaster" runat="server">
    <div class="col-md-offset-4 col-md-4">
        <div class="row" id="login_display">
            <div class="form-horizontal">
                <div class="panel panel-success">
                    <div class="panel-heading"><span class="glyphicon glyphicon-user"></span>Donor Login</div>
                    <div class="panel-body">
                          <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                        <!--DonorId input field-->
                        <div class="form-group">
                            <label for="donorIdTextBox" class="col-sm-3 control-label">Donor ID</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="donorIdTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Donor ID"></asp:TextBox>

                            </div>
                        </div> 
                        <!--Password input field-->
                        <div class="form-group">
                            <label for="pwd" class="col-sm-3 control-label">Password</label>
                            <div class="col-sm-9">
                                <asp:TextBox ID="passwordTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>

                            </div>
                        </div>
                        <!--Checkbox input field-->
                       <%-- <div class="form-group">
                            <div class="col-sm-offset-4 col-sm-5">
                                <div class="checkbox">
                                    $1$ <label><input type="checkbox">Keep me login!</label>#1#
                                </div>
                            </div>
                        </div>--%>
                    </div>
                    <div class="panel-footer">
                        <div class="row">
                            <div class="col-md-offset-4 col-md-8">
                                <asp:Button ID="loginButton" runat="server" Text="Login" ClientIDMode="Static" CssClass="btn btn-success" OnClick="loginButton_Click" />
                                <a href="DonorRegistrationForm.aspx" class="btn btn-sm btn-info">Sign up for donation</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content runat="server" ID="Content3" ContentPlaceHolderID="script">
    <script>
        $(document).ready(function() {
            $("#UserSideForm").validate({
                rules: {
                    <%=donorIdTextBox.UniqueID%>: {
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
                    <%=donorIdTextBox.UniqueID%>:  {
                         required: "Donor Id cannot be empty!",
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
