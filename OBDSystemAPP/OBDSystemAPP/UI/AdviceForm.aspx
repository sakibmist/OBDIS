<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Index.Master" AutoEventWireup="true" CodeBehind="AdviceForm.aspx.cs" Inherits="OBDSystemAPP.UI.AdviceForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainBodyMaster" runat="server">
    <!-- slider start-->
    <div class="row" id="slider2">
        <div id="slider" class="carousel slide" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#slider" data-slide-to="0" class="active"></li>
                <li data-target="#slider" data-slide-to="1"></li>
                <li data-target="#slider" data-slide-to="2"></li>
                <li data-target="#slider" data-slide-to="3"></li>
                <li data-target="#slider" data-slide-to="4"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner">

                <div class="item active">
                    <img src="/Content/Slider/b1.jpg" alt="Slider 1" />
                    <div class="carousel-caption">
                    </div>
                </div>

                <div class="item">
                    <img src="/Content/Slider/slider1.jpg" alt="Slider 2" />
                    <div class="carousel-caption">
                    </div>
                </div>

                <div class="item">
                    <img src="/Content/Slider/b2.jpg" alt="Slider 3" />
                    <div class="carousel-caption">
                    </div>
                </div>

                <div class="item">
                    <img src="/Content/Slider/b3.jpg" alt="Slider 4" />
                    <div class="carousel-caption">
                    </div>
                </div>

                <div class="item">
                    <img src="/Content/Slider/slider6.jpg" alt="Slider 6" />
                    <div class="carousel-caption">
                    </div>
                </div>

            </div>

            <!-- Controls -->
            <a class="left carousel-control" href="#slider" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left"></span>
            </a>
            <a class="right carousel-control" href="#slider" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right"></span>
            </a>
        </div>
        <!-- Carousel -->
    </div>
    <!-- marquee start-->
    <div class="col-md-12" style="background-color: #53f558;" >
        <marquee style="background-color: #53f558;">
		         <b style="color: maroon;"> <h4><span style="color:red">Notice:</span> Total Number Of Donor:&nbsp;<%=totalNumberOfDonor%></>&nbsp;&nbsp; And &nbsp;Total Number Of Organizations:<label style="color:maroon;">&nbsp;<%=totalNumberOfOrganization%></label></h4></b>
	    </marquee>
    </div>
    <!--advice form start-->
    <div class="row" id="donationPrescription">
        <div class="col-md-12">
            <div class="col-md-5">
                <div class="row">
                    <h4><strong style="font-size: 30px; color: green; margin-left: 40px;">Who Can Donate Blood</strong></h4>
                    <hr class="hr_style" />
                </div>
                <ol>
                    <h5><strong>Do donate blood if...</strong></h5>
                </ol>
                <ul id="ul_style">
                    <li>you are between age group of 18-60 years.</li>
                    <li>your weight is 45 kgs or more.</li>
                    <li>your haemoglobin is 12.5 gm% minimum.</li>
                    <li>your last blood donation was 3 months earlier.</li>
                    <li>you are healthy and have not suffered from malaria, typhoid or other transmissible disease in the recent past.</li>
                </ul>
            </div>
            <div class="col-md-2"></div>
            <div class="col-md-5">
                <div class="row">
                    <h4>
                        <strong style="font-size: 30px; margin-left: 40px;">Who Cann't Donate Blood
                        </strong>
                    </h4>
                    <hr id="hr_style" style="margin-right: 62px;" />
                </div>
                <ol>
                    <h5><strong>Do not donate blood if you have any of these conditions,</strong></h5>
                </ol>
                <ul style="font-size: 16px;">
                    <li>cold / fever in the past 1 week.</li>
                    <li>under treatment with antibiotics or any other medication.</li>
                    <li>cardiac problems, hypertension, epilepsy, diabetes (on insulin therapy), history of cancer,chronic kidney or liver disease, bleeding tendencies, venereal disease etc.</li>
                    <li>major surgery in the last 6 months.</li>
                    <li>vaccination in the last 24 hours. 
                    </li>
                    <li>have been pregnant / lactating in the last one year. 
                    </li>
                    <li>had fainting attacks during last donation.</li>
                    <li>shared a needle to inject drugs/ have history of drug addiction.</li>
                    <li>had sexual relations with different partners or with a high risk individual.</li>
                    <li>been tested positive for antibodies to HIV.</li>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>
