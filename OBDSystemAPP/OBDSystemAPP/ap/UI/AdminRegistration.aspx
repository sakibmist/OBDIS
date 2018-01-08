<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/AdminMasterForm.Master" AutoEventWireup="true" CodeBehind="AdminRegistration.aspx.cs" Inherits="OBDSystemAPP.ap.UI.AdminRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        label.error {
            color: red;
            font-size: 14px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="apMasterForm" runat="server">

    <div class="form-box" style="margin: auto;">
        <div class="header">Admin Registration | OBDIS</div>
        <div>
            <div class="body bg-gray">
                <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                <div class="form-group">
                    <label for="adminNameTextBox" class="control-label">Admin Name<i class="required">*</i></label>
                    <asp:TextBox ID="adminNameTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Full name"></asp:TextBox>

                </div>
                <div class="form-group">
                    <label for="designationTextBox" class="control-label">Designation<i class="required">*</i></label>
                    <asp:TextBox ID="designationTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Designation"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="adminImageFileUpload" class="control-label">Admin Image<i class="required">*</i></label>
                    <asp:FileUpload ID="adminImageFileUpload" runat="server" ClientIDMode="Static " CssClass="form-control" />
                </div>

                <div class="form-group">
                    <label for="adminEmailTextBox" class="control-label">E-mail<i class="required">*</i></label>
                    <asp:TextBox ID="adminEmailTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="E-mail" TextMode="Email"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="adminIdTextBox" class="control-label">Admin User Id<i class="required">*</i></label>
                    <asp:TextBox ID="adminIdTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Id Name"></asp:TextBox>

                </div>

                <div class="form-group">
                    <label for="AdminEnterPasswordTextBox" class="control-label">Enter Password<i class="required">*</i></label>
                    <asp:TextBox ID="AdminEnterPasswordTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Password" TextMode="Password"><i class="required">*</i></asp:TextBox>

                </div>
                <div class="form-group">
                    <label for="adminReEnterPasswordTextBox" class="control-label">Re-Enter Password<i class="required">*</i></label>
                    <asp:TextBox ID="adminReEnterPasswordTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>

                </div>
            </div>
            <div class="footer">
                <asp:Button ID="saveButton" runat="server" ClientIDMode="Static" Text="Sign me up" CssClass="btn bg-olive btn-block" OnClick="saveAdminInfoButton_Click" />

                <a href="IndexLogin.aspx" class="text-center"><b style="color: maroon;">I already have a membership</b></a>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content runat="server" ID="Content3" ContentPlaceHolderID="apScript">
    <script type="text/javascript">
        $(document).ready(function() {
            $("#adminLogInMasterForm").validate({
                rules: {
                    <%=adminNameTextBox.UniqueID%>: {
                         required:true ,
                         minlength:3,
                         maxlength:50
                     },
                    <%=designationTextBox.UniqueID%>: {
                         required:true ,
                         minlength:5,
                         maxlength:50
                     },
                    <%=adminImageFileUpload.UniqueID%>: {
                      
                         required: true
                         /*  extension: "jpg|jpeg|png"*/
                      
                     },
                    <%=adminEmailTextBox.UniqueID%>: {
                        required:true , 
                        email:true,
                        maxlength:60
                    }, 
                    <%=adminIdTextBox.UniqueID%>:  {
                        required: true,
                        minlength: 5,
                        maxlength: 20
                    },
                    <%=AdminEnterPasswordTextBox.UniqueID%>: {
                        required:true ,
                        minlength:8,
                        maxlength:32
                    },
                    <%=adminReEnterPasswordTextBox.UniqueID%>: {
                         required:true ,
                         minlength:8,
                         maxlength:32
                     }
                },
                messages: {

                    <%=adminNameTextBox.UniqueID%>:  {
                        required: "Name cannot be empty!",
                        minlength: "Minimum 3 Characters.",
                        maxlength:"Maximum 50 Characters."
                    },
                    <%=designationTextBox.UniqueID%>:  {
                        required: "Designation field cannot be empty!",
                        minlength: "Minimum 5 Characters.",
                        maxlength:"Maximum 50 Characters."
                    },
                    <%=adminImageFileUpload.UniqueID%>: {
                         required: "Image field cannot be empty!",
                         /*extension:"Only .jpg or .jpeg or .png"*/
                     },
                    <%=adminEmailTextBox.UniqueID%>: {
                          required:"Email field cannot be empty!", 
                          email:"Enter valid mail address.",
                          maxlength:"Maximum 60 Characters"
                      }, 
                    <%=adminIdTextBox.UniqueID%>:  {
                        required: "Admin Id cannot be empty!",
                        minlength: "Minimum 5 Characters.",
                        maxlength: "Maximum 20 Characters."
                    },

                    <%=AdminEnterPasswordTextBox.UniqueID%>:  {
                        required: "Password cannot be empty!",
                        minlength: "Minimum 8 Characters",
                        maxlength:"Maximum 32 Characters"
                    },
                    <%=adminReEnterPasswordTextBox.UniqueID%>:  {
                        required: "Re-Enter Password cannot be empty!",
                        minlength: "Minimum 8 Characters",
                        maxlength:"Maximum 32 Characters"
                    }
                }
            });
        });
    </script>
</asp:Content>

