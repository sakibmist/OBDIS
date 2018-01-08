<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="UpdateDonorPublishStatus.aspx.cs" Inherits="OBDSystemAPP.ap.UI.UpdatDonorPublishStatus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">
    <div class="col-md-offset-2 col-md-8" id="pagePosition">
        <div class="panel panel-primary">
            <div class="panel-heading "><span class="glyphicon glyphicon-paperclip"></span>Update Donor Information Publish Status</div>
            <div class="panel-body">
                <div class="col-md-12">
                    <div class="form-horizontal">
                        <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                        <div class="form-group col-sm-12">
                            <label for="publishStatusDropDownList" class="col-sm-6">Publish Status:</label>
                            <div class="col-sm-6">
                                <asp:DropDownList ID="publishStatusDropDownList" runat="server" CssClass="dropdown-toggle form-control " ClientIDMode="Static">
                                     <asp:ListItem Value="">--Select One--</asp:ListItem>
                                    <asp:ListItem Value="unpublish">Unpublish</asp:ListItem>
                                    <asp:ListItem Value="Publish">Publish</asp:ListItem>
                                </asp:DropDownList>
                            </div> 
                        </div>
                        <div class="form-group col-sm-12">
                            <div class="col-sm-6">
                            </div>
                            <div class="col-sm-6">
                                <asp:Button ID="UpdatePublishButton" runat="server" Text="Update" ClientIDMode="Static" CssClass="btn btn-success" OnClick="UpdatePublishButton_Click" />
                                 
                            </div>
                        </div>

                    </div>
                </div>
            </div>

        </div>

    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="dashboardScript" runat="server">
</asp:Content>
