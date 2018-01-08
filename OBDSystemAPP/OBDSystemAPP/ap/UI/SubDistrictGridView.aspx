<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="SubDistrictGridView.aspx.cs" Inherits="OBDSystemAPP.ap.UI.SubDistrictGridView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">
     <div class="col-md-offset-2 col-md-8" id="pagePosition">
        <div class="panel panel-primary">
            <div class="panel-heading "><span class="glyphicon glyphicon-paperclip"></span>All SubDistrict(Upazila) Information</div>
            <div class="panel-body">
                  <div class="col-md-12">
                       <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                    <asp:GridView ID="SubDistrictInfoGridView" ShowHeaderWhenEmpty="True" CssClass="table table-bordered table-responsive "  AutoGenerateColumns="False" runat="server"  ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText="SL">
                                <ItemTemplate><%# Container.DataItemIndex +1 %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Sub-District Name">
                                <ItemTemplate><%# Eval("SubDistrictName") %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="District Name">
                                <ItemTemplate><%# Eval("DistrictName") %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Division Name">
                                <ItemTemplate><%# Eval("DivisionName") %></ItemTemplate>
                            </asp:TemplateField>
                            
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate> 
                                    <asp:HyperLink runat="server" ID="deleteCheck" NavigateUrl='<%#String.Format("SubDistrictGridView.aspx?delete=1&Id={0}",Eval("SubDistrictId")) %>'>Delete</asp:HyperLink>||<asp:HyperLink runat="server">Edit</asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <EmptyDataTemplate >
                            <center> No Information Is Loaded!</center>
                           
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
