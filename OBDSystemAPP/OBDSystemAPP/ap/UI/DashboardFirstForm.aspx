<%@ Page Title="" Language="C#" MasterPageFile="~/ap/UI/DashBoardForm.Master" AutoEventWireup="true" CodeBehind="DashboardFirstForm.aspx.cs" Inherits="OBDSystemAPP.ap.UI.DashboardFirstForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="DashboardMasterBody" runat="server">
    <!-- Right side column. Contains the navbar and content of the page -->
    <div class="container">
        <div>
            <!-- Main content -->
            <section class="content"> 
                <!-- Small boxes (Stat box) -->
                <div class="row">
                    <div class="col-lg-3 col-xs-6">
                        <!-- small box -->
                        <div class="small-box bg-red">
                            <div class="inner"> 
                                <h3>
                                   <%=totalNumberOfDonor %>
                              </h3>
                                <p>
                                    Number of Donors
                                </p>
                            </div>
                            <div class="icon">
                                <i class="ion ion-person-add"></i>
                            </div>
                            <a href="DonorDetailInfo.aspx" class="small-box-footer">More info<i class="fa fa-arrow-circle-right"></i> </a>
                        </div>
                    </div>
                    <!-- ./col -->
                    <div class="col-lg-3 col-xs-6">
                        <!-- small box -->
                        <div class="small-box bg-green">
                            <div class="inner">
                                <h3><%=totalNumberOfOrganization %></h3>
                                <p>
                                    Number of Organization
                                </p>
                            </div>
                            <div class="icon">
                                <i class="ion ion-stats-bars"></i>
                            </div>
                            <a href="BldOrganizationDetailInfo.aspx" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a>
                        </div>
                    </div>
                    <!-- ./col -->
                    <div class="col-lg-3 col-xs-6">
                        <!-- small box -->
                        <div class="small-box bg-yellow">
                            <div class="inner">
                                <h3>44
                                </h3>
                                <p>
                                    Number of Viewer 
                                </p>
                            </div>
                            <div class="icon">
                                <i class="ion ion-person-add"></i>
                            </div>
                            <a href="#" class="small-box-footer">More info <%--<i class="fa fa-arrow-circle-right"></i>--%>
                            </a>
                        </div>
                    </div>
                    <!-- ./col -->
                    
                </div>
                <!-- /.row -->

                <div class="row">
                </div>
               
            </section>
        </div>
    </div> 
</asp:Content>
<asp:Content runat="server" ID="Content3" ContentPlaceHolderID="dashboardScript">
    <script type="text/javascript">
        
    </script>
</asp:Content>
