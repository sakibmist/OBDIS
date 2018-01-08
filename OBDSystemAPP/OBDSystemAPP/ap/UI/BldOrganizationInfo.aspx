<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="BldOrganizationInfo.aspx.cs" Inherits="OBDSystemAPP.ap.UI.BldOrganizationInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
       /* .customStyle {
            height: auto;
        }*/
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">
    <div class="col-md-offset-1 col-md-10">
        <div class="panel panel-primary">
            <div class="panel-heading "><span class="glyphicon glyphicon-paperclip"></span>Add New Blood Organization</div>
            <div class="panel-body">
                <div class="col-md-offset-1 col-md-10">
                    <div class="form-horizontal">
                        <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                        <div class="form-group">
                            <label for="organizationNameTextBox" class="col-sm-4 control-label">Blood Organization:<i class="required">*</i></label>
                            <div class="col-sm-8">

                                <asp:TextBox ID="organizationNameTextBox" runat="server" CssClass="form-control" ClientIDMode="Static" Placeholder=" Organization Name"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="addressTextBox" class="col-sm-4 control-label">Address:<i class="required">*</i></label>
                            <div class="col-sm-8">

                                <asp:TextBox ID="addressTextBox" runat="server" CssClass="form-control" MultiLine="true" ClientIDMode="Static" Placeholder=" Address"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="mobileTextBox" class="col-sm-4 control-label">TelePhone/Mobile:<i class="required">*</i></label>
                            <div class="col-sm-8">

                                <asp:TextBox ID="mobileTextBox" runat="server" CssClass="form-control" ClientIDMode="Static" Placeholder=" Telephone/Mobile"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="emailTextBox" class="col-sm-4 control-label">Email:<i class="required">*</i></label>
                            <div class="col-sm-8">

                                <asp:TextBox ID="emailTextBox" runat="server" CssClass="form-control" TextMode="Email" ClientIDMode="Static" Placeholder=" Email(if you have)"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="divisionNameDropDownList" class="col-sm-4 control-label">Division:<i class="required">*</i></label>
                            <div class="col-sm-8">

                                <asp:DropDownList ID="divisionNameDropDownList" runat="server" ClientIDMode="Static" AutoPostBack="True " CssClass="form-control dropdown-toggle" OnSelectedIndexChanged="divisionNameDropDownList_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="districtNameDropDownList" class="col-sm-4 control-label">District:<i class="required">*</i></label>
                            <div class="col-sm-8">

                                <asp:DropDownList ID="districtNameDropDownList" runat="server" ClientIDMode="Static" AutoPostBack="True " CssClass="form-control dropdown-toggle"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-4"></div>
                            <div class="col-sm-8">
                                <asp:Button ID="OrganizationSaveButton" runat="server" Text="Save" ClientIDMode="Static" CssClass="btn btn-success col-sm-5" OnClick="OrganizationSaveButton_Click" />

                                <div class="col-sm-2"></div>
                                <asp:Button ID="resetButton" runat="server" ClientIDMode="Static" Text="Reset" CssClass="btn btn-info col-sm-5" OnClick="resetButton_Click" />

                            </div>
                        </div>

                    </div>
                </div> 
            </div> 
        </div>
        
    </div>
</asp:Content>
