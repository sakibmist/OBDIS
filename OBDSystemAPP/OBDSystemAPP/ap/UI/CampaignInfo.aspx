<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="CampaignInfo.aspx.cs" Inherits="OBDSystemAPP.ap.UI.CampaignInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">
    <div class="col-md-12">
        <div class="col-md-offset-2 col-md-8" id="pagePosition">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <label><strong>Add Campaign Information</strong></label>
                </div>
                <div class="panel-body">
                    <div class="col-md-offset-1 col-md-10">
                        <div class="form-horizontal">
                             <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                            <div class="form-group">
                                <label for="campaignImageFileUpload" class="control-label col-sm-4">Campaign Picture<i class="required">*</i></label>
                                <div class="col-sm-8">
                                    <asp:FileUpload ID="campaignImageFileUpload" runat="server" ClientIDMode="Static " CssClass="form-control" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="titleTextBox" class="control-label col-sm-4 ">Title<i class="required">*</i></label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="titleTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Enter Title"></asp:TextBox>
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="locationTextBox" class="control-label col-sm-4">Location<i class="required">*</i></label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="locationTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Location"> </asp:TextBox>
                                </div>
                            </div>
                             <div class="form-group">
                                <label for="achievementTextBox" class="control-label col-sm-4">Achievement<i class="required">*</i></label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="achievementTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" placeholder="Achievement"> </asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="publishDateTextBox" class="control-label col-sm-4">Publish Date<i class="required">*</i></label>
                                <div class="col-sm-8">
                                    <asp:TextBox ID="publishDateTextBox" runat="server" ClientIDMode="Static" CssClass="form-control" TextMode="Date"> </asp:TextBox>
                                </div>
                            </div>
                            <div>
                                <div class="col-sm-4"></div>
                            <asp:Button ID="saveCampaignButton" runat="server" Text="Save" CssClass="btn btn-primary  col-sm-3" ClientIDMode="Static" OnClick="saveCampaignButton_Click" />
                                <div class="col-sm-2"></div>
                            <asp:Button ID="resetButton" runat="server" Text="Reset" CssClass="btn btn-warning   col-sm-3 " ClientIDMode="Static" OnClick="resetButton_Click" />
                            </div>
                             
                        </div>
                    </div>
                </div>
    <div class="panel-footer">
    </div>
    </div>
        </div>
    </div>
</asp:Content>
