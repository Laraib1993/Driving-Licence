<%@ Page Title="" Language="C#" MasterPageFile="~/SprintDashboard.master" AutoEventWireup="true" CodeFile="SprintDashboardRiderPerformanceDailyReport.aspx.cs" Inherits="SprintDashboardRiderPerformanceDailyReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="pcoded-content">
                        <!-- Page-header start -->
                        <div class="page-header">
                            <div class="page-block">
                                <div class="row align-items-center">
                                    <div class="col-md-8">
                                        <div class="page-header-title">
                                            <h5 class="m-b-10">Rider's Performance List</h5>
                                            <p class="m-b-0">This list will be visible to Sprint Employee only</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="index.html"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="DataEntryGridView.aspx">Rider's Performance List</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="DataEntryGridView.aspx">Active</a>
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
                                                <h5>Daily Report</h5>
                                            </div>
                                            <div class="card-block">
                                                <div class="dt-responsive table-responsive">

                                                    <form id="form1" runat="server">
                                                    <div>
                                                         <div class="dt-responsive table-responsive">
                                                    <table id="ajax-table2" class="table table-striped table-bordered nowrap">
                                                        <thead>
                                                            <tr>
                                                                <th>SNO</th>
                                                                <th>Rider</th>
                                                                <th>Delivered</th>
                                                                <th>Returned</th>
                                                                <th>Pending</th>
                                                                <th>OnGoing</th>
                                                            </tr>
                                                        </thead>
                                                        <tfoot>
                                                             <tr>
                                                                <th>SNO</th>
                                                                <th>Rider</th>
                                                                <th>Delivered</th>
                                                                <th>Returned</th>
                                                                <th>Pending</th>
                                                                <th>OnGoing</th>
                                                            </tr>
                                                        </tfoot>
                                                      
                                                         <tbody>
                                                         <%-- <%= getattendance() %>--%>
                                                        </tbody>
                                                    </table>
                                                </div>
                                                        
                                                    </div>
                                                    </form>

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

