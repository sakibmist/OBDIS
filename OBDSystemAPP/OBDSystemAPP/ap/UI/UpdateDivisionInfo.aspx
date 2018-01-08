<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="UpdateDivisionInfo.aspx.cs" Inherits="OBDSystemAPP.ap.UI.UpdateDivisionInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">
     <div class="col-md-offset-2 col-md-8" id="pagePosition">
        <div class="panel panel-primary">
            <div class="panel-heading "><span class="glyphicon glyphicon-paperclip"></span>Udate Division Information</div>
            <div class="panel-body">
                <div class="col-md-12">
                    <div class="form-horizontal">
                        <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                        <div class="form-group">
                            <label for="divisionNameTextBox" class="col-sm-4 control-label">Division:<i class="required">*</i></label>
                            <div class="col-sm-8">

                                <asp:TextBox ID="divisionNameTextBox" runat="server" CssClass="form-control" ClientIDMode="Static" ></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-4">
                                 
                            </div>
                            <div class="col-sm-8">
                                <asp:Button ID="UpdateDivisionButton" runat="server" Text="Update" ClientIDMode="Static" CssClass="btn btn-success " OnClick="UpdateDivisionButton_Click"   />
                                 
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
