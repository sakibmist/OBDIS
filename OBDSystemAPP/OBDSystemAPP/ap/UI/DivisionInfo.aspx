<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="DivisionInfo.aspx.cs" Inherits="OBDSystemAPP.ap.UI.DivisionInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        label.error {
            color: red;
            font-size: 14px;
        }
    </style>

    <%--<script src="../../Scripts/additional-methods.js"></script>
    <script src="../../Scripts/additional-methods.min.js"></script>
    <style type="text/css">
        label.error{
            color:red;
        }
    </style> 
    
    <script type="text/javascript">
        $(document).ready(function() {
            $("#divisionNameTextBox").keypress(function() {
                $("#InfoMessageLabel").hide();
            });

            /* $("#delete-button").click(function(){
          if(confirm("Are you sure you want to delete this?")){
              $("#delete-button").attr("href", "query.php?ACTION=delete&ID='1'");
          }
          else{
              return false;
          }
      });*/
           
   
        $("#DashBoardMasterForm ").validate({
            rules: {
                <%=divisionNameTextBox.UniqueID%>: {

                    required: true


                }
            },
            messages: {
                 <%=divisionNameTextBox.UniqueID%>:
                {
                    required: "* Required Field *"
                }
            }

        });
   
           


        });
    </script>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">

    <div class="col-md-offset-2 col-md-8" id="pagePosition">
        <div class="panel panel-primary">
            <div class="panel-heading "><span class="glyphicon glyphicon-paperclip"></span>Add New Division</div>
            <div class="panel-body">
                <div class="col-md-12">
                    <div class="form-horizontal" id="bodyhide">
                        <asp:Label ID="InfoMessageLabel" runat="server" Text=" " Visible="False" CssClass="control-label" ClientIDMode="Static "></asp:Label>
                        <div class="form-group">
                            <label for="divisionNameTextBox" class="col-sm-4 control-label">Division:<i class="required">*</i></label>
                            <div class="col-sm-8">

                                <asp:TextBox ID="divisionNameTextBox" runat="server" CssClass="form-control" ClientIDMode="Static" ></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-4">
                                 
                            </div>
                            <div class="col-sm-8">
                                <asp:Button ID="divisionNameSaveButton" runat="server" Text="Save" ClientIDMode="Static" CssClass="btn btn-success col-sm-5" Style="left: -1px; top: 0px" OnClick="divisionNameSaveButton_Click1" />

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
                    <%=divisionNameTextBox.UniqueID%>: {
                        required:true  
                    } 
                },
                messages: { 
                    <%=divisionNameTextBox.UniqueID%>:  {
                        required: "Division field cannot be empty!" 
                    }
                } 
                 
            }); 
        
        });
    </script>
</asp:Content>
