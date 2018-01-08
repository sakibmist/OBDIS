<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="SubDistrictInfo.aspx.cs" Inherits="OBDSystemAPP.ap.UI.SubDistrictInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<script type="text/javascript">
        $(document).ready(function() {
            $("#subDistrictNameTextBox").Keyup(function () {
                $("#InfoMessageLabel").hide(); 
            });
        } );
    </script>--%>
   <%-- <script type="text/javascript">
        function subdisBox() {
            
        }
    </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">
    <div class="col-md-offset-2 col-md-8">
        <div class="panel panel-primary">
            <div class="panel-heading "><span class="glyphicon glyphicon-paperclip"></span>Add New SubDistrict(Upazila)</div>
            <div class="panel-body">
                <div class="col-md-12" >
                    <div class="form-horizontal"> 
                         <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                        <div class="form-group">
                            <label for="divisionNameDropDownList" class="col-sm-4 control-label">Division:<i class="required">*</i></label>
                            <div class="col-sm-8"> 
                                <asp:DropDownList ID="divisionNameDropDownList" runat="server" ClientIDMode="Static" AutoPostBack="True" CssClass="form-control dropdown-toggle" OnSelectedIndexChanged="divisionNameDropDownList_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                        </div> 
                         <div class="form-group">
                            <label for="districtNameDropDownList" class="col-sm-4 control-label">District:<i class="required">*</i></label>
                            <div class="col-sm-8">
                                
                                <asp:DropDownList ID="districtNameDropDownList" runat="server" ClientIDMode="Static" AutoPostBack="True" placeholder="DistrictName" CssClass="form-control dropdown-toggle"></asp:DropDownList>
                            </div>
                        </div> 
                        <div class="form-group">
                            <label for="subDistrictNameTextBox" class="col-sm-4 control-label">Upazila:<i class="required">*</i></label>
                            <div class="col-sm-8"> 
                                <asp:TextBox ID="subDistrictNameTextBox" runat="server" CssClass="form-control" ClientIDMode="Static" Placeholder="Sub-district Name"></asp:TextBox>
                            </div>
                        </div> 
                        <div class="form-group">
                            <div class="col-sm-4"> 
                            </div>
                            <div class="col-sm-8">
                                <a href="SubDistrictGridView.aspx">
                                    <asp:Button ID="subdistrictNameSaveButton" runat="server" Text="Save" ClientIDMode="Static" CssClass="btn btn-success col-sm-5" OnClick="subdistrictNameSaveButton_Click" />
                                </a>  
                                <div class="col-sm-2"></div>
                                <asp:Button ID="resetButton" runat="server" ClientIDMode="Static" Text="Reset" CssClass="btn btn-info col-sm-5" OnClick="resetButton_Click" style="left: 0px; top: 0px"   />

                            </div>
                        </div>

                    </div>
                </div>  
            </div>

        </div>
    </div>
</asp:Content>
