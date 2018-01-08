<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Index.Master" AutoEventWireup="true" CodeBehind="ReportInfo.aspx.cs" Inherits="OBDSystemAPP.UI.MsgToBldDonor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainBodyMaster" runat="server">
    <div class="col-md-offset-2 col-md-8" style="margin-top: 20px;">
        <div class="panel panel-primary">
            <div class="panel-heading "><span class="glyphicon glyphicon-home"></span>Send Message To Administration</div>
            <div class="panel-body">
                <div class="col-md-offset-1 col-md-10">
                    <div class="form-horizontal">
                        <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                        <div class="form-group col-md-12">
                            <label for="NameTextBox" class="col-sm-6 control-label">
                                Name:<i class="required">*</i>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="NameTextBox" runat="server" ClientIDMode="Static " CssClass="form-control "></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group col-md-12">
                            <label for="DonorIdTextBox" class="col-sm-6 control-label">
                                DonorId:<i class="required">*</i>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="DonorIdTextBox" runat="server" ClientIDMode="Static " CssClass="form-control "></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group col-md-12">
                            <label for="msgTextBox" class="col-sm-6 control-label">
                                Message<i class="required">*</i>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox ID="msgTextBox" runat="server" ClientIDMode="Static " CssClass="form-control " TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div> 
                        <div class="form-group col-md-12">
                            <div class="col-sm-6"></div>
                            <div class="col-sm-6">
                                <asp:Button ID="sendMsgButton" runat="server" Text="Send" ClientIDMode="Static" CssClass="btn btn-success col-sm-5 " OnClick="sendMsgButton_Click" />

                                <div class="col-sm-2"></div>

                                <asp:Button runat="server" ID="resetButton" ClientIDMode="Static" Text="Reset" CssClass="btn btn-info col-sm-5 " OnClick="resetButton_Click" />

                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
