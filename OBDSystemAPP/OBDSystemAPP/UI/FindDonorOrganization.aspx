<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Index.Master" AutoEventWireup="true" CodeBehind="FindDonorOrganization.aspx.cs" Inherits="OBDSystemAPP.UI.FindDonorOrganization" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainBodyMaster" runat="server">


    <div class="col-md-offset-1 col-md-10" id="pagePosition">
        <div class="panel panel-primary">
            <div class="panel-heading">
                <span class="glyphicon glyphicon-user"></span>Blood Donation Organization Information
            </div>
            <div class="panel-body">
                <div class="col-md-offset-3 col-md-6">
                    <div class="form-horizontal">
                        <div class="panel panel-primary">
                            <div class="panel-heading "><span class="glyphicon glyphicon-search"></span>Find Organization</div>
                            <div class="panel-body">
                                <div class="col-md-12">
                                    <div class="form-horizontal">
                                        <div class="form-group">
                                            <label for="OrgDivisionDropdownList" class="col-sm-4 control-label">
                                                Division:<i class="required">*</i>
                                            </label>
                                            <div class="col-sm-8">
                                                <asp:DropDownList ID="OrgDivisionDropdownList" runat="server" ClientIDMode="Static" CssClass="dropdown-toggle form-control">
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <label for="OrgDistrictDropDownList" class="col-sm-4 control-label">District:<i class="required">*</i></label>
                                            <div class="col-sm-8">
                                                <asp:DropDownList ID="OrgDistrictDropDownList" runat="server" ClientIDMode="Static" CssClass="dropdown-toggle form-control">
                                                </asp:DropDownList>
                                            </div>
                                        </div>

                                        <div class="form-group">
                                            <div class="col-sm-4"></div>
                                            <div class="col-sm-8">
                                                <%-- <a href="#collapseExample" data-toggle="collapse"
                                                aria-expanded="false" aria-controls="collapseExample">--%>
                                                <asp:Button runat="server" ID="SearchOrganizationButton" ClientIDMode="Static" CssClass="btn btn-primary col-sm-5" Text="Search" OnClick="SearchOrganizationButton_Click" />
                                                <div class="col-sm-2"></div>
                                                <asp:Button runat="server" ID="resetButton" ClientIDMode="Static" Text="Reset" CssClass="btn btn-info col-sm-5" OnClick="resetButton_Click" />
                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
                <div class="col-sm-12">
                    <%-- <div class="collapse" id="collapseExample">
                        <div class="row table-responsive">
                            <table class="table table-hover table-striped table-bordered">
                                <thead>
                                    <tr class="success">
                                        <th>#</th>
                                        <th>Organization</th>
                                        <th>Address</th>
                                        <th>Tele Phone/Mobile No.</th>
                                        <th>Email</th>  
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>01</td>
                                        <td>BADHAN</td>
                                        <td>TSC(Ground Floor), DIU,Dhaka </td>
                                        <td>+880-2-8629042</td>
                                        <td>cenral@badhan.org</td>
                                    </tr> 
                                    <tr>
                                        <td>02</td>
                                        <td>BANGLADESH RED CRESCENT BLOOD BANK</td>
                                        <td>7/5, Aurongzeb Road, Mohammadpur, Dhaka.</td>
                                        <td>+880-02-9116563, +880-02-8121497</td>
                                        <td>www.redcrescent.org</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>--%>
                </div>
            </div>
            <div class="panel-footer">
            </div>
        </div>
    </div>
</asp:Content>
