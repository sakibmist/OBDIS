<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="DistrictInfo.aspx.cs" Inherits="OBDSystemAPP.ap.UI.DistrictInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        label.error {
            color: red;
            font-size: 14px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">
     <div class="col-md-offset-2 col-md-8" id="pagePosition">
        <div class="panel panel-primary">
            <div class="panel-heading "><span class="glyphicon glyphicon-paperclip"></span>Add New District</div>
            <div class="panel-body">
                <div class="col-md-12">
                    <div class="form-horizontal">
                         <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                        <div class="form-group">
                            <label for="divisionNameDropDownList" class="col-sm-4 control-label">Division:<i class="required">*</i></label>
                            <div class="col-sm-8">
                                
                                <asp:DropDownList ID="divisionNameDropDownList" runat="server" ClientIDMode="Static" CssClass="form-control dropdown-toggle"></asp:DropDownList>
                            </div>
                        </div> 
                        <div class="form-group">
                            <label for="districtNameTextBox" class="col-sm-4 control-label">District:<i class="required">*</i></label>
                            <div class="col-sm-8">
                                
                                <asp:TextBox ID="districtNameTextBox" runat="server" CssClass="form-control" ClientIDMode="Static" Placeholder="District Name"></asp:TextBox>
                            </div>
                        </div> 
                         
                        <div class="form-group">
                            <div class="col-sm-4"></div>
                            <div class="col-sm-8"> 
                                    <asp:Button ID="districtNameSaveButton" runat="server" Text="Save" ClientIDMode="Static" CssClass="btn btn-success col-sm-5" OnClick="districtNameSaveButton_Click" />
                                
                                <div class="col-sm-2"></div>
                                <asp:Button ID="resetButton" runat="server" ClientIDMode="Static" Text="Reset" CssClass="btn btn-info col-sm-5" OnClick="resetButton_Click" />

                            </div>
                        </div>

                    </div>
                </div>
                 
            </div>

        </div>
    </div>
</asp:Content>
<asp:Content runat="server" ID="Content3" ContentPlaceHolderID="dashboardScript">
    <script type="text/javascript"> 
        $(document).ready(function() {
            $("#DashBoardMasterForm").validate({
                rules: {
                    <%=divisionNameDropDownList.UniqueID%>: {
                        required:true  
                    },
                     <%=districtNameTextBox.UniqueID%>: {
                         required:true  
                     } 
                },
                messages: { 
                    <%=divisionNameDropDownList.UniqueID%>:  {
                        required: "Division field cannot be empty!" 
                    },
                     <%=districtNameTextBox.UniqueID%>:  {
                         required: "District field cannot be empty!" 
                     }
                }
            });
        });
    </script>
</asp:Content>


