<%@ Page Title="" Language="C#" MasterPageFile="~/DataEntryDashboard.master" AutoEventWireup="true" CodeFile="DataEntryReportReturnedstep.aspx.cs" Inherits="DataEntryReportReturnedstep" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Returned Step</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="pcoded-content">
                        <!-- Page-header start -->
                        <div class="page-header">
                            <div class="page-block">
                                <div class="row align-items-center">
                                    <div class="col-md-8">
                                        <div class="page-header-title">
                                            <h5 class="m-b-10">Returned Step List</h5>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="#"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="#">Returned Step List</a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- Page-header end -->

                        <div class="pcoded-inner-content">
                            <div class="main-body">
                                <div class="page-wrapper">
                                    <div class="page-body">
                                        <!-- `New` Constructor table start -->
                                        <div class="card">
                                            <div class="card-header">
                                                <h5>Returned Step List</h5>
                                        <%--        <span>Responsive will automatically detect new DataTable instances being created on a page and initialize itself if it finds the responsive option or responsive class name on the table, as shown in the other examples.</span>--%>
                                            </div>
                                            <div class="card-block">
                                                <div class="dt-responsive table-responsive">
                                                    <table id="ajax-table2" class="table table-striped table-bordered nowrap">
                                                       <thead>
                                                            <tr>
                                                                <th>S.NO #</th>
                                                                <th>Licence #</th>
                                                                <th>District</th>
                                                                <th>Reason</th>
                                                                <th>Description</th>
                                                                <th>Rider</th>
                                                                <th>Returned on </th>
                                                                <th>Estimated Date </th>
                                                            </tr>
                                                        </thead>
                                                        <tfoot>
                                                             <tr>
                                                                 <th>S.NO #</th>
                                                                <th>Licence #</th>
                                                                <th>District</th>
                                                                <th>Reason</th>
                                                                <th>Description</th>
                                                                <th>Rider</th>
                                                                <th>Returned on </th>
                                                                <th>Estimated Date </th>
                                                            </tr>
                                                        </tfoot>
                                                        <tbody>
                                                       <%--     <%= getattendance() %>--%>
                                                        </tbody>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- `New` Constructor table end -->
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Warning Section Starts -->
                    <div id="styleSelector">

                    </div>
</asp:Content>

