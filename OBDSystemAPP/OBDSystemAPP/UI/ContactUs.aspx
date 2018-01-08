<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Index.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="OBDSystemAPP.UI.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            display: block;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            box-shadow: inset 0 1px 1px rgba(0,0,0,.075);
            -webkit-transition: border-color ease-in-out .15s,-webkit-box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainBodyMaster" runat="server">
    <div class="col-md-12">
        <div class="col-md-offset-2 col-md-8" id="pagePosition">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <label><strong>Contact Information</strong></label>
                </div>
                <div class="panel-body">
                    <div class="form-horizontal col-md-offset-2 col-md-8">
                        <table>
                            <tr>
                                <td><strong style="color: maroon;">Director:</strong></td>
                                <td>&nbsp;</td>
                                <td>Sakib Al Samad</td>
                            </tr>
                            <tr>
                                <td><strong style="color: maroon;">Contact No:</strong></td>
                                <td>&nbsp;</td>
                                <td>01982879339</td>
                            </tr>
                            <tr>
                                <td><strong style="color: maroon;">Email:</strong></td>
                                <td>&nbsp;</td>
                                <td>sakib.mist.cse@gmail.com</td>
                            </tr>
                            <tr>
                                <td></td>
                                <td>&nbsp;</td>
                                <td></td>
                            </tr>
                            <tr>
                                <td><strong style="color: maroon;">Co-Director:</strong></td>
                                <td>&nbsp;</td>
                                <td>Bidhan Chakma</td>
                            </tr>
                            <tr>
                                <td><strong style="color: maroon;">Contact No:</strong></td>
                                <td>&nbsp;</td>
                                <td>01828845922</td>
                            </tr>
                            <tr>
                                <td><strong style="color: maroon;">Email:</strong></td>
                                <td>&nbsp;</td>
                                <td>bidhan@gmail.com</td>
                            </tr>
                        </table>
                        <br />
                        <br />
                        <strong>
                            <a href="ReportInfo.aspx">Send Message</a>
                        </strong>
                        <br />
                    </div> 
                </div>
                <div class="panel-footer">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
