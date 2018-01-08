<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Index.Master" AutoEventWireup="true" CodeBehind="DonorProfile.aspx.cs" Inherits="OBDSystemAPP.UI.DonorProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainBodyMaster" runat="server">
    <div class="row" id="pagePosition">
        <div class="col-md-offset-2 col-md-8">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <span class="glyphicon glyphicon-eye-open"></span><b>View Donor Profile</b>
                <p class="nav navbar-nav navbar-right" style="margin-right: 20px;">
                    <span class="glyphicon glyphicon-log-out"></span>
                    <asp:Button Text=" Logout" ID="logoutButton" runat="server" ClientIDMode="static" CssClass="btn-primary  btn-circle" OnClick="logoutButton_Click" />
                </p>
                </div>
                <div class="panel-body">
                    <div class="col-md-offset-1 col-md-10">
                        <asp:DataList ID="DonorDataList" runat="server">
                            <HeaderTemplate>
                                <table>
                                    <thead></thead>
                                    <tbody>
                            </HeaderTemplate>
                            <ItemTemplate> 
                                <tr>
                                    <td><b style="color: maroon;">Donor Name:</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("DonorName") %></td>
                                </tr>
                                 <tr>
                                    <td><b style="color: maroon;">Donor Type:</b></td>
                                      <td>&nbsp;</td>
                                    <td><%# Eval("DonorType") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">Father Name :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("FatherName") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">Mother Name :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("MotherName") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">Blood Group :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("BloodGroupName") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">Gender :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("Gender") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">Date Of Birth :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("Dob") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">Mobile No. :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("Mobile") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">Alter MobileNo. :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("AlterMobile") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">Email :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("Email") %></td>
                                </tr>
                                 <tr>
                                    <td><b style="color: maroon;">DonorId :</b></td>
                                      <td>&nbsp;</td>
                                    <td><%# Eval("DonorUserId") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">Password :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("DonorPassword") %></td>
                                </tr>
                                 <tr>
                                    <td><b style="color: maroon;">Ability :</b></td>
                                      <td>&nbsp;</td> 
                                    <td><%# Eval("AbilityToDonate") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">NearestCity :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("City") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">Upazilla :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("SubDistrictName") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">District :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("DistrictName") %></td>
                                </tr>
                                <tr>
                                    <td><b style="color: maroon;">Division :</b></td>
                                     <td>&nbsp;</td>
                                    <td><%# Eval("DivisionName") %></td>
                                </tr> 
                                <tr>
                                    <td></td>
                                    <td></td>
                                    <td></td>
                                </tr>
                                <tr>
                                    <td> <asp:HyperLink runat="server" CssClass="btn btn-primary" NavigateUrl='<%#String.Format("ProfileGridview.aspx?DonorId={0}",Eval("DonorId")) %>'><strong>Edit Profile</strong></asp:HyperLink> </td>
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
