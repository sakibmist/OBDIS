<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="AllDivisions.aspx.cs" Inherits="OBDSystemAPP.ap.UI.AllDivisions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        label .error {
            color: red;
            font-size: 14px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">
     <div class="col-md-offset-1 col-md-10" id="pagePosition">
        <div class="panel panel-primary">
            <div class="panel-heading "><span class="glyphicon glyphicon-paperclip"></span>All Division Information</div>
            <div class="panel-body">
                 <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                <div class="col-md-12">
                     <asp:GridView ID="DivisionInfoGridView" ShowHeaderWhenEmpty="True" CssClass="table table-bordered table-responsive " AutoGenerateColumns="False" AllowPaging="True" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText="SL">
                                <ItemTemplate><%# Container .DataItemIndex +1 %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="DivisionName">
                                <ItemTemplate><%# Eval("DivisionName") %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:HyperLink runat="server" ID="deleteCheck"   NavigateUrl='<%#String.Format("AllDivisions.aspx?delete=1&Id={0}",Eval("Id")) %>'>Delete</asp:HyperLink>||<asp:HyperLink runat="server" NavigateUrl='<%#string.Format("UpdateDivisionInfo.aspx?update=1&Id={0}",Eval("Id")) %>'>Edit</asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>

                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <EmptyDataTemplate>
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
<asp:Content ID="Content3" ContentPlaceHolderID="dashboardScript" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $("#deleteCheck").click(function () {
                if (!confirm("Do you want to delete")) {
                    return false;
                }
            });
        });
    </script>
    
</asp:Content>
