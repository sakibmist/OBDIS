﻿<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Index.Master" AutoEventWireup="true" CodeBehind="ProfileGridview.aspx.cs" Inherits="OBDSystemAPP.UI.ProfileGridview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        label.error {
            color: red;
            font-size: 15px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainBodyMaster" runat="server">
    <div class="row">
        <div class="col-md-offset-1 col-md-10" id="pagePosition">
            <div class="panel panel-primary">
                <div class="panel-heading"><span class="glyphicon glyphicon-user"></span><strong>Donor Information For Update</strong>
                   <%-- <a href="DonorProfile.aspx" style="float: right;" ><strong style="color: white;">Show Details</strong> </a>--%>
                    <div style="float: right;">
                    <span class="glyphicon glyphicon-log-out"></span>
                    <asp:Button Text=" Logout" ID="logoutButton" runat="server" ClientIDMode="static" CssClass="btn-primary  btn-circle" OnClick="logoutButton_Click" />
                </div>
                </div>
                
                <div class="form-horizontal">
                    <div class="panel-body">
                        <div class="col-md-12">

                            <div class="col-md-12">
                                <div class="form-group col-md-offset-2 col-md-10">

                                    <label for="donorTypeDropDownList" class="col-sm-6 control-label">Donor Type<i class="required">*</i></label>
                                    <div class="col-sm-6">
                                        <asp:DropDownList ID="donorTypeDropDownList" runat="server" ClientIDMode="Static" CssClass="dropdown-toggle form-control">
                                            <%--<asp:ListItem Value=" ">--Select One--</asp:ListItem>--%>
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
                                    <asp:TextBox ID="donorNameTextBox" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                                </div>
                                <label for="fatherNameTextBox" class="col-sm-2 control-label">Father's Name<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="fatherNameTextBox" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>

                                </div>
                            </div>
                            <div class="form-group">
                                <label for="bloodGroupDropDownList" class="col-sm-2 control-label">
                                    Blood Group<i
                                        class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:DropDownList ID="bloodGroupDropDownList" runat="server" ClientIDMode="Static" CssClass="dropdown-toggle form-control">
                                    </asp:DropDownList>

                                </div>
                                <label for="motherNameTextBox" class="col-sm-2 control-label">
                                    Mother's Name<i
                                        class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="motherNameTextBox" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                                </div>

                            </div>

                            <!--Gender & DOB-->

                            <div class="form-group">
                                <label for="genderDropDownList" class="col-sm-2 control-label">Gender<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:DropDownList ID="genderDropDownList" runat="server" ClientIDMode="Static" CssClass="dropdown-toggle form-control">
                                        <%-- <asp:ListItem Value=" ">--Select One--</asp:ListItem>--%>
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
                                    <asp:TextBox ID="mobileNoTextBox" runat="server" ClientIDMode="Static" ReadOnly="True"   CssClass="form-control"></asp:TextBox>
                                </div>
                                <label for="alterPhoneTextBox" class="col-sm-2 control-label">Alternate Mobile No</label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="alterPhoneTextBox" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <!--Email and facebook Id -->
                            <div class="form-group">
                                <label for="emailTextBox" class="col-sm-2 control-label">Email<i class="required"></i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="emailTextBox" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                                </div>


                            </div>

                            <legend>Permanent Address</legend>
                            <!--Division & District Field-->
                            <div class="form-group">
                                <label for="divisionDropDownList" class="col-sm-2 control-label">Division<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:DropDownList ID="divisionDropDownList" runat="server" ClientIDMode="Static" AutoPostBack="True " CssClass="dropdown-toggle form-control" OnSelectedIndexChanged="divisionDropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </div>
                                <label for="districtDropDownList" class="col-sm-2 control-label">District<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:DropDownList ID="districtDropDownList" runat="server" AutoPostBack ="True " ClientIDMode="Static" CssClass="dropdown-toggle form-control" OnSelectedIndexChanged="districtDropDownList_SelectedIndexChanged">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <!--Upazila and city name-->
                            <div class="form-group">
                                <label for="subDistrictDropDownList" class="col-sm-2 control-label">Upazila<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:DropDownList ID="subDistrictDropDownList" runat="server" ClientIDMode="Static" AutoPostBack ="True " CssClass="dropdown-toggle form-control">
                                    </asp:DropDownList>
                                </div>
                                <label for="cityTextBox" class="col-sm-2 control-label">City<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="cityTextBox" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <legend>User Usability</legend>
                            <div class="form-group">
                                <label for="donorIdTextBox" class="col-sm-2 control-label">Donor Id</label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="donorIdTextBox" runat="server" ClientIDMode="Static" ReadOnly="True"   CssClass="form-control"></asp:TextBox>

                                </div>
                                <label for="passwordTextBox" class=" col-sm-2 control-label">Password<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:TextBox ID="passwordTextBox" runat="server" ClientIDMode="Static" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="abilityDropDownList" class="control-label col-sm-2">Ability to donate blood<i class="required">*</i></label>
                                <div class="col-sm-4">
                                    <asp:DropDownList ID="abilityDropDownList" runat="server" CssClass="dropdown-toggle form-control" ClientIDMode="Static">
                                        <%-- <asp:ListItem Value=" ">--Select One--</asp:ListItem>--%>
                                        <asp:ListItem Value="Enable">Available</asp:ListItem>
                                        <asp:ListItem Value="Disable">Unavailable</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                            </div>

                        </div>

                        <div class="panel-footer">
                            <asp:Button ID="updateButton" runat="server" Text="Update" ClientIDMode="Static" CssClass="btn btn-primary" OnClick="updateButton_Click" />

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
            $("#UserSideForm ").validate( {
                rules:
                {
                   <%=donorTypeDropDownList.UniqueID %>: "required",

                    <%=donorNameTextBox.UniqueID %>: "required",

                    <%=fatherNameTextBox.UniqueID %>: "required",

                    <%=motherNameTextBox.UniqueID %>: "required" ,

                    <%=bloodGroupDropDownList.UniqueID %>: "required", 

                    <%=genderDropDownList.UniqueID %>: "required",  

                    <%=dobTextBox.UniqueID %>: "required",

                    <%=mobileNoTextBox.UniqueID %>: "required",

                    <%=divisionDropDownList.UniqueID %>: "required",

                    <%=districtDropDownList.UniqueID %>: "required",

                    <%=subDistrictDropDownList.UniqueID %>: "required",

                    <%=cityTextBox.UniqueID %>: "required",

                    <%=donorIdTextBox.UniqueID %>: "required",

                    <%=passwordTextBox.UniqueID %>: "required",

                    <%=abilityDropDownList.UniqueID %>: "required" 
                },
                messages: {
                    <%=donorTypeDropDownList.UniqueID %>: "Donor Type field can not be empty!",

                    <%=donorNameTextBox.UniqueID %>: "Name field can not be empty!",

                    <%=fatherNameTextBox.UniqueID %>: "Father Name field can not be empty!",

                    <%=motherNameTextBox.UniqueID %>: "Mother Name field can not be empty!",

                    <%=bloodGroupDropDownList.UniqueID %>: "Blood Group field can not be empty!",

                    <%=genderDropDownList.UniqueID %>: "Gender field can not be empty!",

                    <%=dobTextBox.UniqueID %>: "Date field can not be empty!",

                    <%=mobileNoTextBox.UniqueID %>: "Mobile No. field can not be empty!",

                    <%=divisionDropDownList.UniqueID %>: "Division field can not be empty!",

                    <%=districtDropDownList.UniqueID %>: "District field can not be empty!",

                    <%=subDistrictDropDownList.UniqueID %>: "Sub-District field can not be empty!",

                    <%=cityTextBox.UniqueID %>: "City field can not be empty!",

                    <%=donorIdTextBox.UniqueID %>: "Donor Id field can not be empty!",

                    <%=passwordTextBox.UniqueID %>: "Password field can not be empty!",

                    <%=abilityDropDownList.UniqueID %>: "Donor Ability field can not be empty!" 
                }

            });
        });
    </script>
</asp:Content>

