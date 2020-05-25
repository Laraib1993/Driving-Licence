<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="DataEntryStep10History.aspx.cs" Inherits="DataEntryStep10History" %>

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
                                            <h5 class="m-b-10">New ID (Case) Outward List</h5>
                                            <p class="m-b-0">Step # 10</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="index.html"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="DataEntryGridView.aspx">Outward List</a>
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
                                                <h5>New ID (Case) Outward List</h5>
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
                                                                <th>Inword No</th>
                                                                <th>Description</th>
                                                                <th>Outward On</th>
                                                                <th>Outward By</th>
                                                                <th>Outward To</th>
                                                                <%--<th>Reason</th>--%>
                                                            </tr>
                                                        </thead>
                                                        <tfoot>
                                                             <tr>
                                                                <th>SNO</th>
                                                                <th>Inword No</th>
                                                                <th>Description</th>
                                                                <th>Outward On</th>
                                                                <th>Outward By</th>
                                                                <th>Outward To</th>
                                                                <%--<th>Reason</th>--%>
                                                            </tr>
                                                        </tfoot>
                                                      
                                                         <tbody>
                                                           <%= getattendance() %>
                                                        </tbody>
                                                    </table>
                                                </div>
                                                        
                                                    </div>
                                                    </form>





                                                    <%--<table id="ajax-table2" class="table table-striped table-bordered nowrap">
                                                        <thead>
                                                            <tr>
                                                                <th>SNO</th>
                                                                <th>Logo</th>
                                                                <th>Patner</th>
                                                                <th>Email</th>
                                                                <th>Phone</th>
                                                                <th>Type</th>
                                                                <th>Contact Person</th>
                                                                <th>Contact Person Email</th>
                                                                <th>Contact Person Phone : </th>
                                                                <th>Annual Revenue : </th>
                                                                <th>Company Size : </th>
                                                                <th>Region : </th>
                                                                <th>Country : </th>
                                                                <th>City : </th>
                                                            </tr>
                                                        </thead>
                                                        <tfoot>
                                                             <tr>
                                                                <th>SNO</th>
                                                                <th>Logo</th>
                                                                <th>Patner</th>
                                                                <th>Email</th>
                                                                <th>Phone</th>
                                                                <th>Type</th>
                                                                <th>Contact Person</th>
                                                                <th>Contact Person Email</th>
                                                                <th>Contact Person Phone : </th>
                                                                <th>Annual Revenue : </th>
                                                                <th>Company Size : </th>
                                                                <th>Region : </th>
                                                                <th>Country : </th>
                                                                <th>City : </th>
                                                            </tr>
                                                        </tfoot>
                                                        <tbody>
                                                            
                                                         
                                                        </tbody>
                                                    </table>--%>
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

