﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="DataEntryStep6History.aspx.cs" Inherits="DataEntryStep6History" %>

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
                                            <h5 class="m-b-10">New ID Outward List</h5>
                                            <p class="m-b-0">Step # 06</p>
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
                                                <h5>New ID Outward List</h5>
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
                                                                <th>Outward Date Time</th>
                                                                <th>No of New ID's</th>
                                                                <th>Discription</th>
                                                                <th>Reason</th>
                                                                <th>Outward By</th>
                                                            </tr>
                                                        </thead>
                                                        <tfoot>
                                                             <tr>
                                                              <th>SNO</th>
                                                                <th>Inword No</th>
                                                                <th>Outward Date Time</th>
                                                                <th>No of New ID's</th>
                                                                <th>Discription</th>
                                                                <th>Reason</th>
                                                                <th>Outward By</th>
                                                            </tr>
                                                        </tfoot>
                                                      
                                                         <tbody>
                                                          <%= getattendance() %>
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
