<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="bloodInfo.aspx.cs" Inherits="OBDSystemAPP.ap.UI.bloodInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"> 
    <script src="../../Scripts/jquery-3.2.1.js"></script>
    <script src="../../Scripts/jquery.validate.js"></script>
    <script src="../../Scripts/jquery.validate.min.js"></script>
    <style type="text/css">
        label.error {
            color: red;
        }
    </style>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#divisionNameTextBox").keypress(function () { //SAME KAJ EK JAYGAY HOY EK JAYGAY HOY NA???
                $("#InfoMessageLabel").hide();
            });
        });
    </script>
         <%--  $("#DashBoardMasterForm").validate(function() {
                rules: {
                    bloodGroupNameTextBox: {
                        required:true, minLength:2
                    }
                }
                messages: {
                    bloodGroupNameTextBox: {
                            required: "Please enter a username",
                            minlength: "Your username must consist of at least 2 characters"
                    } 

                }

            });
            $("#commentForm").validate();

		 validate signup form on keyup and submit
		$("#signupForm").validate({
			rules: {
				firstname: "required",
				lastname: "required",
				username: {
					required: true,
					minlength: 2
				},
				password: {
					required: true,
					minlength: 5
				},
				confirm_password: {
					required: true,
					minlength: 5,
					equalTo: "#password"
				},
				email: {
					required: true,
					email: true
				},
				topic: {
					required: "#newsletter:checked",
					minlength: 2
				},
				agree: "required"
			},
			messages: {
				firstname: "Please enter your firstname",
				lastname: "Please enter your lastname",
				username: {
					required: "Please enter a username",
					minlength: "Your username must consist of at least 2 characters"
				},
				password: {
					required: "Please provide a password",
					minlength: "Your password must be at least 5 characters long"
				},
				confirm_password: {
					required: "Please provide a password",
					minlength: "Your password must be at least 5 characters long",
					equalTo: "Please enter the same password as above"
				},
				email: "Please enter a valid email address",
				agree: "Please accept our policy",
				topic: "Please select at least 2 topics"
			}
		});        <style>
	#commentForm {
		width: 500px;
	}
	#commentForm label {
		width: 250px;
	}
	#commentForm label.error, #commentForm input.submit {
		margin-left: 253px;
	}
	#signupForm {
		width: 670px;
	}
	#signupForm label.error {
		margin-left: 10px;
		width: auto;
		display: inline;
	}
	#newsletter_topics label.error {
		display: none;
		margin-left: 103px;
	}
	</style>
        });
    </script> --%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">
    <div class="col-md-offset-2 col-md-8">
        <div class="panel panel-primary">
            <div class="panel-heading "><span class="glyphicon glyphicon-paperclip"></span>Add Blood Group Name</div>
            <div class="panel-body">
                <div class="col-md-12">
                    <div class="form-horizontal">
                        <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                        <div class="form-group">
                            <label for="bloodGroupNameTextBox" class="col-sm-4 control-label">Blood Group:<i class="required">*</i></label>
                            <div class="col-sm-8">
                                <asp:TextBox Id="bloodGroupNameTextBox"   runat="server" CssClass="form-control" ClientIDMode="Static" Placeholder="Blood Group Name"></asp:TextBox>
                            </div>
                        </div> 
                        <div class="form-group">
                            <div class="col-sm-4"></div>
                            <div class="col-sm-8"> 
                                    <asp:Button ID="bloodGroupSaveButton" runat="server" Text="Save" ClientIDMode="Static" CssClass="btn btn-success col-sm-5" OnClick="bloodGroupSaveButton_Click" style="left: 0px; top: 1px" />
                              
                                <div class="col-sm-2"></div>
                                <asp:Button  runat="server" ID="resetButton" ClientIDMode="Static" Text="Reset" CssClass="btn btn-info col-sm-5" OnClick="resetButton_Click" />

                            </div>
                        </div>

                    </div>
                </div>
                  
            </div>

        </div>
    </div>
</asp:Content>
