﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="AllReportInfo.aspx.cs" Inherits="OBDSystemAPP.ap.UI.AllReportInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">
    <div class="col-md-12">
        <div class="panel panel-primary">
            <div class="panel-heading "><span class="glyphicon glyphicon-paperclip"></span>All Report Information</div>
            <div class="panel-body">
                <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label> 
                <div class="col-sm-12">
                    <asp:GridView ID="AllReportInfoGridView" ShowHeaderWhenEmpty="True" CssClass="table table-bordered table-responsive " AutoGenerateColumns="False" runat="server" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText="#">
                                <ItemTemplate><%# Container.DataItemIndex +1 %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText=" Name">
                                <ItemTemplate><%# Eval("Name") %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Donor Id">
                                <ItemTemplate><%# Eval("DonorId") %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Message">
                                <ItemTemplate><%# Eval("Msg") %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Created At">
                                <ItemTemplate><%# Eval("CreatedAt") %></ItemTemplate>
                            </asp:TemplateField>  
                             <asp:TemplateField HeaderText="Action">
                                <ItemTemplate> 
                                    <asp:HyperLink runat="server" ID="deleteCheck" NavigateUrl='<%#String.Format("AllReportInfo.aspx?delete=1&Id={0}",Eval("Id")) %>'>Delete</asp:HyperLink> 
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
<asp:Content ID="Content3" ContentPlaceHolderID="dashboardScript" runat="server">
</asp:Content>
