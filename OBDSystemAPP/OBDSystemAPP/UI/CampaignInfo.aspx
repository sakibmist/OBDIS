<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Index.Master" AutoEventWireup="true" CodeBehind="CampaignInfo.aspx.cs" Inherits="OBDSystemAPP.UI.CampaignInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainBodyMaster" runat="server">
    <div class="col-md-12" id="pagePosition"  >
        <div class="col-md-offset-2 col-md-8" >
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <label><strong>Campaign Information</strong></label>
                </div>
                <div class="panel-body">
                    <div class="form-horizontal col-md-offset-2 col-md-10">
                        <asp:DataList ID="CampainInfoDataList" runat="server">
                            <HeaderTemplate>
                                <table>
                                    <thead></thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td></td>
                                    <%--<td>
                                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Image") %>' />
                                    </td>--%>
                                    <td>&nbsp;</td>
                                    <td>
                                        <img src="../ap/UI/ImageBox/campaign.jpg"   alt="Campaign Pic"/>
                                         
                                       <%-- <img src='<%#("~/ap/UI/ImageBox/CampaignPic/")+Eval("Image") %>' alt="Campaign Picture" />--%>
                                    </td>
                                </tr>
                                <tr>
                                    <td><b>Title</b></td>
                                    <td>&nbsp;</td>
                                    <td><%# Eval("Title") %></td>
                                </tr>
                                <tr>
                                    <td><b>Location</b></td>
                                    <td>&nbsp;</td>
                                    <td><%# Eval("Location") %></td>
                                </tr>
                                <tr>
                                    <td><b>Achievement</b></td>
                                    <td>&nbsp;</td>
                                    <td><%# Eval("Achievement") %></td>
                                </tr>

                                <tr>
                                    <td><b>Publish</b></td>
                                    <td>&nbsp;</td>
                                    <td><%# Eval("PublishDate") %></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>&nbsp;</td>
                                    <td></td>

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
