<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Index.Master" AutoEventWireup="true" CodeBehind="FindOrgInfo.aspx.cs" Inherits="OBDSystemAPP.UI.FindOrgInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        label.error {
    color: red;
    font-size: 13px; 
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainBodyMaster" runat="server">
     <div class="col-md-offset-1 col-md-10" id="pagePosition">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <span class="glyphicon glyphicon-home"></span><b>Organization Information</b>
                </div>
                <div class="panel-body">
                    <div class="col-md-offset-2 col-md-8 " >
                        <div > 
                            <div class="panel panel-primary">
                                <div class="panel-heading "><span class="glyphicon glyphicon-search"></span>Search For Blood Donation Organization</div>
                                <div class="panel-body">
                                    <div class="col-md-12">
                                        <div class="form-horizontal">
                                             <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label> 
                                            <div class="form-group">
                                                <label for="findDivisionDropDownList" class="col-sm-4 control-label">Division:<i class="required">*</i>
                                                </label>
                                                <div class="col-sm-8">
                                                     <asp:DropDownList ID="findDivisionDropDownList" runat="server" ClientIDMode="Static" AutoPostBack="True" CssClass="dropdown-toggle form-control" OnSelectedIndexChanged="findDivisionDropDownList_SelectedIndexChanged">
                                                        
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                            <div class="form-group">
                                                <label for="findDistrictDropDownList" class="col-sm-4 control-label">District:<i class="required">*</i></label>
                                                <div class="col-sm-8">
                                                     <asp:DropDownList ID="findDistrictDropDownList" runat="server" AutoPostBack="True" ClientIDMode="Static"  CssClass="dropdown-toggle form-control">
                                                        
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                             
                                            <div class="form-group">
                                                <div class="col-sm-4"></div>
                                                <div class="col-sm-8">  
                                                             <asp:Button ID="searchOrgButton" runat="server" Text="Search" ClientIDMode="Static" CssClass="btn btn-success col-sm-5" OnClick="searchOrgButton_Click" />
                                                     
                                                    <div class="col-sm-2"></div>
                                                    <asp:Button runat="server" ID="resetButton" ClientIDMode="Static" Text="Reset" CssClass="btn btn-info col-sm-5" OnClick="resetButton_Click"/>
                                                    
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class="col-sm-12">
                     <asp:GridView ID="FindOrganizationInfoGridView" ShowHeaderWhenEmpty="True" CssClass="table table-bordered table-responsive "  AutoGenerateColumns="False" AllowPaging="True" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText="SL">
                                <ItemTemplate><%# Container.DataItemIndex +1 %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Organization Name">
                                <ItemTemplate><%# Eval("OrganizationName") %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Address">
                                <ItemTemplate><%# Eval("Address") %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Telephone/Mobile No.">
                                <ItemTemplate><%# Eval("Mobile") %></ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Email">
                                <ItemTemplate><%# Eval("Email") %></ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="District Name">
                                <ItemTemplate><%# Eval("DistrictName") %></ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Division Name">
                                <ItemTemplate><%# Eval("DivisionName") %></ItemTemplate>
                            </asp:TemplateField> 
                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <EmptyDataTemplate >
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

                <div class="panel-footer">
                </div>
            </div>
        </div>
</asp:Content>
 <asp:Content runat="server" ID ="Content3" ContentPlaceHolderID="script">
       <script>
        $(function() {

            $("#UserSideForm").validate({
                rules: {
                    <%=findDivisionDropDownList.UniqueID %>: "required",

                    <%=findDistrictDropDownList.UniqueID %>: {
                        required: true
                       /* minlength: 11,
                        maxlength: 15*/
                    }
                   
                },
                messages: {
                    <%=findDivisionDropDownList.UniqueID %>: "Division field cannot be empty!",
                    <%=findDistrictDropDownList.UniqueID %>: {
                        required: "District field cannot be empty!"
                    }
                }
            });
        });
    </script>
 </asp:Content>
