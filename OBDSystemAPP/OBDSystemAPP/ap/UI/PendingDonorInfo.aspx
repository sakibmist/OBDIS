﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="PendingDonorInfo.aspx.cs" Inherits="OBDSystemAPP.ap.UI.DonorDetailInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">
    <div class="col-md-12" id="pagePosition">
        <div class="panel panel-primary">
            <div class="panel-heading "><span class="glyphicon glyphicon-paperclip"></span>Pending Donor Request Information</div>
            <div class="panel-body">
                <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                <div class="col-sm-12">
                    <asp:GridView ID="DonorDetailGridView" ShowHeaderWhenEmpty="True" CssClass="table table-bordered table-responsive " AutoGenerateColumns="False" runat="server" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText="SL">
                                <ItemTemplate><%# Container.DataItemIndex +1 %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Donor Name">
                                <ItemTemplate><%# Eval("DonorName") %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Blood Group">
                                <ItemTemplate><%# Eval("BloodGroupName") %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Mobile No.">
                                <ItemTemplate><%# Eval("Mobile") %></ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Email">
                                <ItemTemplate><%# Eval("Email") %></ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Upazilla">
                                <ItemTemplate><%# Eval("SubDistrictName") %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="District">
                                <ItemTemplate><%# Eval("DistrictName") %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Division">
                                <ItemTemplate><%# Eval("DivisionName") %></ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:HyperLink runat="server" ID="updateCheck"  NavigateUrl='<%#String.Format("UpdateDonorPublishStatus.aspx?Update=1&DonorId={0}",Eval("DonorId")) %>'>Accept</asp:HyperLink> || <asp:HyperLink runat="server" NavigateUrl='<%#String.Format("PendingDonorInfo.aspx?delete=1&DonorId={0}",Eval("DonorId")) %>'>Remove</asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <EmptyDataTemplate>
                            <center> No Information Is Found!</center>

                        </EmptyDataTemplate>
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                </div> 
            </div> 
        </div> 
    </div> 
</asp:Content>
