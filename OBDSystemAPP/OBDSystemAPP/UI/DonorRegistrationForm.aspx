<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Index.Master" AutoEventWireup="true" CodeBehind="DonorRegistrationForm.aspx.cs" Inherits="OBDSystemAPP.UI.DonorRegistrationForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        label.error {
            color: red;
            font-size: 15px;
        }
        </style> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainBodyMaster" runat="server">
    <!-- Donor Registration Page -->
    <div class="row">
        <div class="col-md-offset-1 col-md-10" id="pagePosition">
            <div class="panel panel-primary">
                <div class="panel-heading"><span class="glyphicon glyphicon-user"></span>Donor Registration Form</div>

                <div class="form-horizontal">
                    <div class="panel-body">
                        <div class="col-md-12">
                            <div class="form-group">
                                <p><strong>Please, fill the following information to register as a paid donor or voluntary blood donor and shows the highest manner of  humanity.</strong></p>
                            </div>
                            <div class="col-md-12">
                                <div class="form-group col-md-offset-2 col-md-10">

                                    <label for="donorTypeDropDownList" class="col-sm-6 control-label">Donor Type<i class="required">*</i></label>
                                    <div class="col-sm-6">
                                        <asp:DropDownList ID="donorTypeDropDownList" runat="server" ClientIDMode="Static" CssClass="dropdown-toggle form-control">
                                            <asp:ListItem Value="">--Select One--</asp:ListItem>
                                            <asp:ListItem Value="Unpaid">Unpaid Donor</asp:ListItem>
                                            <asp:ListItem Value="Paid">Paid Donor</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>

                                </div>
                            </div>
                            <strong>
                                <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label></strong>


                            <legend>Personal Information</legend>
                            <!--Name and Father's Name Field-->
                            <div class="form-group">
                                <label for="donorNameTextBox" class="col-sm-2 control-label">Donor Name<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="donorNameTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Your Name"></asp:TextBox>
                                </div>
                                <label for="fatherNameTextBox" class="col-sm-2 control-label">Father's Name<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="fatherNameTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Father's Name"></asp:TextBox>

                                </div>
                            </div>
                            <div class="form-group">
                                <label for="bloodGroupDropDownList" class="col-sm-2 control-label">
                                    Blood Group<i
                                        class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:DropDownList ID="bloodGroupDropDownList" runat="server" ClientIDMode="Static" CssClass="dropdown-toggle form-control">
                                        <asp:ListItem Value=" ">--Select One--</asp:ListItem>
                                        <asp:ListItem Value="1">A+</asp:ListItem>
                                        <asp:ListItem Value="2">O+</asp:ListItem>
                                    </asp:DropDownList>

                                </div>
                                <label for="motherNameTextBox" class="col-sm-2 control-label">
                                    Mother's Name<i
                                        class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="motherNameTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Mother's Name"></asp:TextBox>
                                </div> 
                            </div> 
                            <!--Gender & DOB--> 
                            <div class="form-group">
                                <label for="genderDropDownList" class="col-sm-2 control-label">Gender<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:DropDownList ID="genderDropDownList" runat="server" ClientIDMode="Static" CssClass="dropdown-toggle form-control">
                                        <asp:ListItem Value="">--Select One--</asp:ListItem>
                                        <asp:ListItem Value="Male">Male</asp:ListItem>
                                        <asp:ListItem Value="Female">Female</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <label for="dobTextBox" class="col-sm-2 control-label">Date of Birth<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="dobTextBox" runat="server" TextMode="Date" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>

                            <legend>Contact Information</legend>
                            <!--Phone No & Email-->
                            <div class="form-group">
                                <label for="mobileNoTextBox" class="col-sm-2 control-label">Mobile No.<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="mobileNoTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Phone No"></asp:TextBox>
                                </div>
                                <label for="alterPhoneTextBox" class="col-sm-2 control-label">Alternate Mobile No</label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="alterPhoneTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Alternate Phone(If you have)"></asp:TextBox>
                                </div>
                            </div>
                            <!--Email and facebook Id -->
                            <div class="form-group">
                                <label for="emailTextBox" class="col-sm-2 control-label">Email<i class="required"></i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="emailTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Email (If you have)"></asp:TextBox>
                                </div>
                            </div>
                            <legend>Permanent Address</legend>
                            <!--Division & District Field-->
                            <div class="form-group">
                                <label for="divisionDropDownList" class="col-sm-2 control-label">Division<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:DropDownList ID="divisionDropDownList" runat="server" ClientIDMode="Static" AutoPostBack="True" CssClass="dropdown-toggle form-control" OnSelectedIndexChanged="divisionDropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </div>
                                <label for="districtDropDownList" class="col-sm-2 control-label">District<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:DropDownList ID="districtDropDownList" runat="server" ClientIDMode="Static" AutoPostBack="True" CssClass="dropdown-toggle form-control" OnSelectedIndexChanged="districtDropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <!--Upazila and city name-->
                            <div class="form-group">
                                <label for="subDistrictDropDownList" class="col-sm-2 control-label">Upazila<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:DropDownList ID="subDistrictDropDownList" runat="server" ClientIDMode="Static" AutoPostBack="True" CssClass="dropdown-toggle form-control">
                                    </asp:DropDownList>
                                </div>
                                <label for="cityTextBox" class="col-sm-2 control-label">City<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="cityTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Nearest City Name"></asp:TextBox>
                                </div>
                            </div>
                            <legend>User Usability</legend>
                            <div class="form-group">
                                <label for="donorIdTextBox" class="col-sm-2 control-label">Donor Id</label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="donorIdTextBox" runat="server" ClientIDMode="Static" placeholder="Donor User Id" CssClass="form-control"></asp:TextBox>

                                </div>
                                <label for="passwordTextBox" class=" col-sm-2 control-label">Password<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password" ClientIDMode="Static" placeholder="Enter Password" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="abilityDropDownList" class="control-label col-sm-2">Ability to donate blood<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:DropDownList ID="abilityDropDownList" runat="server" CssClass="dropdown-toggle form-control" ClientIDMode="Static">
                                        <asp:ListItem Value="">--Select One--</asp:ListItem>
                                        <asp:ListItem Value="Enable">Available</asp:ListItem>
                                        <asp:ListItem Value="Disable">Unavailable</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <label for="reenterPasswordTextBox" class="control-label col-sm-2">Re-type Password<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="reenterPasswordTextBox" runat="server" TextMode="Password" ClientIDMode="Static" placeholder="Re-enter Password" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <legend>Declarations</legend>
                            <div class="form-group">
                                <div class="col-lg-12">
                                    <asp:CheckBox ID="trueInfoCheckBox" runat="server" ClientIDMode="Static" Text="All above Provided informations are true." CssClass="checkbox" />
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-lg-12">
                                    <asp:CheckBox ID="PermissionInfoCheckBox" runat="server" ClientIDMode="Static" Text="I authorise this site to display my name and contact information, sothat the needy people can contact me, as and when there is an emergency." CssClass="checkbox" />
                                </div>
                            </div>
                        </div>
                        <div class="col-md-offset-2 col-md-10">
                            <div class="row required">
                                <div class="caption">
                                    <strong>Important:</strong>If You got illegal something by hospital's stuff and blood receiver. You can <a href="ReportInfo.aspx">report</a> us.</div>
                            </div>
                        </div>
                    </div>

                    <div class="panel-footer">
                        <asp:Button ID="submitButton" runat="server" Text="Submit" ClientIDMode="Static" CssClass="btn btn-primary" OnClick="submitButton_Click" />
                        <asp:Button ID="resetButton" runat="server" Text="Reset" type="reset" CssClass="btn btn-danger" OnClick="resetButton_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content runat="server" ID="Content3" ContentPlaceHolderID="script">
    <script>
        $(document).ready(function() {
            $("#UserSideForm ").validate({
                rules:
                {
                    <%=donorTypeDropDownList.UniqueID %>: "required",

                    <%=donorNameTextBox.UniqueID %>:{
                        required: true,
                        minlength: 3,
                        maxlength: 50
                    },

                    <%=fatherNameTextBox.UniqueID %>:{
                        required: true,
                        minlength: 3,
                        maxlength: 50
                    },

                    <%=motherNameTextBox.UniqueID %>:{
                        required: true,
                        minlength: 3,
                        maxlength: 50
                    },

                    <%=bloodGroupDropDownList.UniqueID %>: "required",

                    <%=genderDropDownList.UniqueID %>: "required",

                    <%=dobTextBox.UniqueID %>: "required",
                    <%=emailTextBox.UniqueID %>: "email",

                    <%=mobileNoTextBox.UniqueID %>: {
                        required: true,
                        minlength: 11,
                        maxlength: 15
                    },
                     <%=alterPhoneTextBox.UniqueID %>: {  
                         minlength: 11,
                         maxlength: 15
                     }, 
                    <%=divisionDropDownList.UniqueID %>: "required",

                    <%=districtDropDownList.UniqueID %>: "required",

                    <%=subDistrictDropDownList.UniqueID %>: "required",

                    <%=cityTextBox.UniqueID %>: {
                        required: true,
                        minlength: 3,
                        maxlength: 50
                    },

                    <%=donorIdTextBox.UniqueID %>: {
                        required: true,
                        minlength: 5,
                        maxlength: 32
                    },

                    <%=passwordTextBox.UniqueID %>: {
                        required: true,
                        minlength: 8,
                        maxlength: 32
                    },
                    <%=abilityDropDownList.UniqueID %>: "required",

                    <%=reenterPasswordTextBox.UniqueID %>: {
                        required: true,
                        minlength: 8,
                        maxlength: 20
                    },

                    <%=trueInfoCheckBox.UniqueID %>: "required",

                    <%=PermissionInfoCheckBox.UniqueID %>: "required"

                },
                messages: {
                    <%=donorTypeDropDownList.UniqueID %>: "Donor Type field can not be empty!",

                    <%=donorNameTextBox.UniqueID %>: {
                        required: "Name field can not be empty!",
                        minlength: "Minimum 3 Characters.",
                        maxlength:"Maximum 50 Characters."
                    },

                    <%=fatherNameTextBox.UniqueID %>: {
                        required: "Father Name field can not be empty!",
                        minlength: "Minimum 3 Characters.",
                        maxlength:"Maximum 50 Characters."
                    },

                    <%=motherNameTextBox.UniqueID %>:  {
                        required: "Mother Name field can not be empty!",
                        minlength: "Minimum 3 Characters.",
                        maxlength:"Maximum 50 Characters."
                    },

                    <%=bloodGroupDropDownList.UniqueID %>: "Blood Group field can not be empty!",

                    <%=genderDropDownList.UniqueID %>: "Gender field can not be empty!",

                    <%=dobTextBox.UniqueID %>: "Date field can not be empty!",
                    <%=emailTextBox.UniqueID %>: {
                        email: "Enter a valid email address"
                    },

                    <%=mobileNoTextBox.UniqueID %>: {
                        required: "Mobile No. field can not be empty.",
                        minlength: "Minimum mobile number is 11 digit.",
                        maxlength: "Maximum mobile number is 15 digit."
                    },
                    <%=alterPhoneTextBox.UniqueID %>: { 
                        minlength: "Minimum mobile number is 11 digit.",
                        maxlength: "Maximum mobile number is 15 digit."
                    },

                    <%=divisionDropDownList.UniqueID %>: "Division field can not be empty!",

                    <%=districtDropDownList.UniqueID %>: "District field can not be empty!",

                    <%=subDistrictDropDownList.UniqueID %>: "Sub-District field can not be empty!",

                    <%=cityTextBox.UniqueID %>:{
                        required: "City field can not be empty!",
                        minlength: "Minimum 3 Characters.",
                        maxlength:"Maximum 50 Characters."
                    },

                    <%=donorIdTextBox.UniqueID %>: {
                        required: "Donor Id field can not be empty!",
                        minlength: "Minimum 5 Characters.",
                        maxlength:"Maximum 20 Characters."
                    },

                    <%=passwordTextBox.UniqueID %>:{
                        required: "Password field can not be empty.",
                        minlength: "Minimum  8 digit.",
                        maxlength: "Maximum  32 digit."
                    },

                    <%=abilityDropDownList.UniqueID %>: "Donor Ability field can not be empty!",

                    <%=reenterPasswordTextBox.UniqueID %>: {
                        required: "Re-enter Password field can not be empty!",
                        minlength: "Minimum  8 digit.",
                        maxlength: "Maximum  32 digit."
                    },

                    <%=trueInfoCheckBox.UniqueID %>: "True Check field can not be empty!",

                    <%=PermissionInfoCheckBox.UniqueID %>: "Permission Check field can not be empty!"
                   
                }

            });
        });
    </script>
</asp:Content>
