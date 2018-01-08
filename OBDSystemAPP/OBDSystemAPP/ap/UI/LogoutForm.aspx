<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="LogoutForm.aspx.cs" Inherits="OBDSystemAPP.ap.UI.LogoutForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">
     <div class="row" id="pagePosition">
        <div class="col-md-offset-2 col-md-8">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <span class="glyphicon glyphicon-eye-open"></span><b>View Admin Profile</b>
                <p class="nav navbar-nav navbar-right" style="margin-right: 20px;">
                    <span class="glyphicon glyphicon-log-out"></span> 
                <asp:Button ID="LogOutButton" runat="server" Text="Logout" ClientIDMode="Static" CssClass=" btn-primary btn-circle" OnClick="LogOutButton_Click"   />
                </p>
                </div>
                <div class="panel-body">
                    <div class="col-md-offset-1 col-md-10">
                        <asp:DataList ID="AdminDataList" runat="server">
                            <HeaderTemplate>
                                <table>
                                    <thead></thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate> 
                                <tr>
                                    <td><b style="color: maroon;">Admin Name:</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("AdminName") %></td>
                                </tr>
                                <%-- <tr>
                                    <td><b style="color: maroon;">Photo:</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("AdminName") %></td>
                                </tr>--%>
                                 <tr>
                                    <td><b style="color: maroon;">Designation:</b></td>
                                      <td>&nbsp;</td>
                                    <td><%# Eval("Designation") %></td>
                                </tr> 
                                <tr>
                                    <td><b style="color: maroon;">Email :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("AdminName") %></td>
                                </tr>
                                 <tr>
                                    <td><b style="color: maroon;">Admin Id :</b></td>
                                      <td>&nbsp;</td>
                                    <td><%# Eval("AdminId") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">Password :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("Passwords") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">Created At :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("CreatedAt") %></td>
                                </tr>
                                 
                                <tr>
                                    <td></td>
                                    <td>&nbsp;</td>
                                    <td></td>
                                </tr>
                                <tr>
                                   
                                    <td> <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-primary">UPDATE</asp:HyperLink>  </td>
                                     <td></td>
                                     <td> </td>
                                </tr>
                            </ItemTemplate>
                             
                            <FooterTemplate>
                                
                                </tbody>
                                 </table>
                                
                            </FooterTemplate>
                            
                        </asp:DataList>
                    </div>
                </div>
                <div class="panel-footer">
                   
                </div>
            </div>
        </div>
    </div> 
</asp:Content>
