<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Admin Dashboard</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="pcoded-content">
                        <!-- Page-header start -->
                        <div class="page-header">
                            <div class="page-block">
                                <div class="row align-items-center">
                                    <div class="col-md-8">
                                        <div class="page-header-title">
                                            <%--<h5 class="m-b-10">Dashboard</h5>--%>
                                            <h3>Dashboard</h3>
                                            <h4>Welcome to Karachi Metropolitan Corporation</h4>
                                            <h5>(Admin Panel)</h5>
                                            <%--<p class="m-b-0">Welcome to Karachi Metropolitan Corporation</p>--%>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="#!">Dashboard</a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- Page-header end -->
                        <div class="pcoded-inner-content">
                            <!-- Main-body start -->
                            <div class="main-body">
                                <div class="page-wrapper">
                                    <!-- Page-body start -->
                                    <div class="page-body">
                                        <div class="row">
                                            <!-- task, page, download counter  start -->
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                
                                                                <h4 class="text-c-purple"><asp:Label ID="lblTotalScanningInword" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <h6 class="text-muted m-b-0">Total Scanning Inword</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-bar-chart f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-purple">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">Detail</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>

                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                <h4 class="text-c-green"><asp:Label ID="lblTotalSearchingInword" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <h6 class="text-muted m-b-0">Total Searching Sheet Inword</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-file-text-o f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-green">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">Detail</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                <h4 class="text-c-red"><asp:Label ID="lblTotalNewIDInword" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <h6 class="text-muted m-b-0">Total New ID Sheet Inword</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-calendar-check-o f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-red">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">Detail</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                <h4 class="text-c-purple"><asp:Label ID="lblTotalScanningOutward" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <h6 class="text-muted m-b-0">Total Scanning Outward</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-bar-chart f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-purple">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">Detail</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>

                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                <h4 class="text-c-green"><asp:Label ID="lblTotalSearchingOutward" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <h6 class="text-muted m-b-0">Total Searching Sheet Outward</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-file-text-o f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-green">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">Detail</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                <h4 class="text-c-red"><asp:Label ID="lblTotalNewIDOutward" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <h6 class="text-muted m-b-0">Total New ID Sheet Outward</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-calendar-check-o f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-red">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">Detail</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                <h4 class="text-c-blue"><asp:Label ID="lblTotalSearchingCaseInword" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <h6 class="text-muted m-b-0">Total Searching (Case) Inword</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-hand-o-down f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-blue">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">Detail</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                <h4 class="text-c-blue"><asp:Label ID="lblTotalSearchingCaseOutward" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <h6 class="text-muted m-b-0">Total Searching (Case) Outward</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-hand-o-down f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-blue">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">Detail</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                <h4 class="text-c-blue"><asp:Label ID="lblTotalNewIDCaseInword" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <h6 class="text-muted m-b-0">Total New ID (Case) Inword</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-hand-o-down f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-blue">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">Detail</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-xl-3 col-md-6">
                                                <div class="card">
                                                    <div class="card-block">
                                                        <div class="row align-items-center">
                                                            <div class="col-8">
                                                                <h4 class="text-c-blue"><asp:Label ID="lblTotalNewIDCaseOutward" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <h6 class="text-muted m-b-0">Total New iD (Case) Outward</h6>
                                                            </div>
                                                            <div class="col-4 text-right">
                                                                <i class="fa fa-hand-o-down f-28"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="card-footer bg-c-blue">
                                                        <div class="row align-items-center">
                                                            <div class="col-9">
                                                                <p class="text-white m-b-0">Detail</p>
                                                            </div>
                                                            <div class="col-3 text-right">
                                                                <i class="fa fa-line-chart text-white f-16"></i>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- task, page, download counter  end -->

                                            <!--  sale analytics start -->
                                            <%--<div class="col-xl-8 col-md-12">
                                                <div class="card">
                                                    <div class="card-header">
                                                        <h5>Sales Analytics</h5>
                                                        <span class="text-muted"></span>
                                                        <div class="card-header-right">
                                                            <ul class="list-unstyled card-option">
                                                                <li><i class="fa fa fa-wrench open-card-option"></i></li>
                                                                <li><i class="fa fa-window-maximize full-card"></i></li>
                                                                <li><i class="fa fa-minus minimize-card"></i></li>
                                                                <li><i class="fa fa-refresh reload-card"></i></li>
                                                                <li><i class="fa fa-trash close-card"></i></li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                    <div class="card-block">
                                                        <div id="sales-analytics" style="height: 400px;"></div>
                                                    </div>
                                                </div>
                                            </div>--%>
                                            <div class="col-xl-4 col-md-12">
                                                
                                                <div class="card quater-card">
                                                    <div class="card-block">
                                                        <h6 class="text-muted m-b-15">Previous Quarter</h6>
                                                        <h4>7,39,45,250+</h4>
                                                        <%--<p class="text-muted">7,39,45,250+</p>--%>
                                                        <%--<h5>87</h5>--%>
                                                        <p class="text-muted">Online Revenue<span class="f-right">17%</span></p>
                                                        <div class="progress">
                                                            <div class="progress-bar bg-c-blue" style="width: 17%"></div>
                                                        </div>
                                                        <%--<h5 class="m-t-15">68</h5>--%>
                                                        <p class="text-muted">Offline Revenue<span class="f-right">83%</span></p>
                                                        <div class="progress">
                                                            <div class="progress-bar bg-c-green" style="width: 83%"></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <!--  sale analytics end -->

                                            <!--  project and team member start -->
                                            <%--<div class="col-xl-8 col-md-12">
                                                <div class="card table-card">
                                                    <div class="card-header">
                                                        <h5>Top 4 Vendors</h5>
                                                        <div class="card-header-right">
                                                            <ul class="list-unstyled card-option">
                                                                <li><i class="fa fa fa-wrench open-card-option"></i></li>
                                                                <li><i class="fa fa-window-maximize full-card"></i></li>
                                                                <li><i class="fa fa-minus minimize-card"></i></li>
                                                                <li><i class="fa fa-refresh reload-card"></i></li>
                                                                <li><i class="fa fa-trash close-card"></i></li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                    <div class="card-block">
                                                        <div class="table-responsive">
                                                            <table class="table table-hover">
                                                                <thead>
                                                                    <tr>
                                                                        <th>
                                                                            <div class="chk-option">
                                                                                <div class="checkbox-fade fade-in-primary">
                                                                                    <label class="check-task">
                                                <input type="checkbox" value="">
                                                <span class="cr">
                                                  <i class="cr-icon fa fa-check txt-default"></i>
                                                </span>
                                              </label>
                                                                                </div>
                                                                            </div>
                                                                            Vendor</th>
                                                                        <th>Region</th>
                                                                        <th>Country</th>
                                                                        <th class="text-right">City</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    <tr>
                                                                        <td>
                                                                            <div class="chk-option">
                                                                                <div class="checkbox-fade fade-in-primary">
                                                                                    <label class="check-task">
                                                  <input type="checkbox" value="">
                                                  <span class="cr">
                                                    <i class="cr-icon fa fa-check txt-default"></i>
                                                  </span>
                                                </label>
                                                                                </div>
                                                                            </div>
                                                                            <div class="d-inline-block align-middle">
                                                                                <img src="files/assets/images/avatar-4.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                                                <div class="d-inline-block">
                                                                                    <h6>HP</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td>Asia</td>
                                                                        <td>Pakistan</td>
                                                                        <td class="text-right"><label class="label label-danger">Karachi</label></td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <div class="chk-option">
                                                                                <div class="checkbox-fade fade-in-primary">
                                                                                    <label class="check-task">
                                                  <input type="checkbox" value="">
                                                  <span class="cr">
                                                    <i class="cr-icon fa fa-check txt-default"></i>
                                                  </span>
                                                </label>
                                                                                </div>
                                                                            </div>
                                                                            <div class="d-inline-block align-middle">
                                                                                <img src="files/assets/images/avatar-5.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                                                <div class="d-inline-block">
                                                                                    <h6>Dell</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td>Asia</td>
                                                                        <td>Bangladesh</td>
                                                                        <td class="text-right"><label class="label label-primary">Dhaka</label></td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <div class="chk-option">
                                                                                <div class="checkbox-fade fade-in-primary">
                                                                                    <label class="check-task">
                                                  <input type="checkbox" value="">
                                                  <span class="cr">
                                                    <i class="cr-icon fa fa-check txt-default"></i>
                                                  </span>
                                                </label>
                                                                                </div>
                                                                            </div>
                                                                            <div class="d-inline-block align-middle">
                                                                                <img src="files/assets/images/avatar-3.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                                                <div class="d-inline-block">
                                                                                    <h6>HTC</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td>Asia</td>
                                                                        <td>Afghanistan</td>
                                                                        <td class="text-right"><label class="label label-success">Kabul</label></td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <div class="chk-option">
                                                                                <div class="checkbox-fade fade-in-primary">
                                                                                    <label class="check-task">
                                                  <input type="checkbox" value="">
                                                  <span class="cr">
                                                    <i class="cr-icon fa fa-check txt-default"></i>
                                                  </span>
                                                </label>
                                                                                </div>
                                                                            </div>
                                                                            <div class="d-inline-block align-middle">
                                                                                <img src="files/assets/images/avatar-2.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                                                <div class="d-inline-block">
                                                                                    <h6>3 M Gulf</h6>
                                                                                    <p class="text-muted m-b-0"></p>
                                                                                </div>
                                                                            </div>
                                                                        </td>
                                                                        <td>UAE</td>
                                                                        <td>Iraq</td>
                                                                        <td class="text-right"><label class="label label-primary">Iraq</label></td>
                                                                    </tr>
                                                                </tbody>
                                                            </table>
                                                            <div class="text-right m-r-20">
                                                                <a href="#!" class=" b-b-primary text-primary">View all Vendors</a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>--%>
                                            <%--<div class="col-xl-4 col-md-12">
                                                <div class="card ">
                                                    <div class="card-header">
                                                        <h5>Region (With Distributers)</h5>
                                                        <div class="card-header-right">
                                                            <ul class="list-unstyled card-option">
                                                                <li><i class="fa fa fa-wrench open-card-option"></i></li>
                                                                <li><i class="fa fa-window-maximize full-card"></i></li>
                                                                <li><i class="fa fa-minus minimize-card"></i></li>
                                                                <li><i class="fa fa-refresh reload-card"></i></li>
                                                                <li><i class="fa fa-trash close-card"></i></li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                    <div class="card-block">
                                                        <div class="align-middle m-b-30">
                                                            <img src="files/assets/images/avatar-2.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                            <div class="d-inline-block">
                                                                <h6>Asia</h6>
                                                                <p class="text-muted m-b-0">10</p>
                                                            </div>
                                                        </div>
                                                        <div class="align-middle m-b-30">
                                                            <img src="files/assets/images/avatar-1.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                            <div class="d-inline-block">
                                                                <h6>Europe</h6>
                                                                <p class="text-muted m-b-0">20</p>
                                                            </div>
                                                        </div>
                                                        <div class="align-middle m-b-30">
                                                            <img src="files/assets/images/avatar-3.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                            <div class="d-inline-block">
                                                                <h6>Middle East</h6>
                                                                <p class="text-muted m-b-0">50</p>
                                                            </div>
                                                        </div>
                                                        <div class="align-middle m-b-30">
                                                            <img src="files/assets/images/avatar-4.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                            <div class="d-inline-block">
                                                                <h6>UAE</h6>
                                                                <p class="text-muted m-b-0">25</p>
                                                            </div>
                                                        </div>
                                                        <div class="align-middle m-b-30">
                                                            <img src="files/assets/images/avatar-4.jpg" alt="user image" class="img-radius img-40 align-top m-r-15">
                                                            <div class="d-inline-block">
                                                                <h6>South Asia</h6>
                                                                <p class="text-muted m-b-0">05</p>
                                                            </div>
                                                        </div>
                                                        <div class="text-center">
                                                            <a href="#!" class="b-b-primary text-primary">View all</a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>--%>
                                            <!--  project and team member end -->

                                            <!--  whether order-visitor start -->
                                            <div class="col-xl-6 col-md-12">
                                                <div class="row">
                                                    <div class="col-md-6">
                                                        <div class="card text-center order-visitor-card">
                                                            <div class="card-block">
                                                                <h6 class="m-b-0">Total Scanning Sheet Pending</h6>
                                                                <h4 class="m-t-15 m-b-15"><i class="fa fa-arrow-down m-r-15 text-c-red"></i><asp:Label ID="lblTotalScanningSheetOutward_Pending" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <p class="m-b-0">From 'Feb 2020'</p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-6">
                                                        <div class="card text-center order-visitor-card">
                                                            <div class="card-block">
                                                                <h6 class="m-b-0">Total Searching Sheet Pending</h6>
                                                                <h4 class="m-t-15 m-b-15"><i class="fa fa-arrow-down m-r-15 text-c-red"></i><asp:Label ID="lblTotalSearchingSheetOutward_Pending" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <p class="m-b-0">From 'Feb 2020'</p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-6">
                                                        <div class="card text-center order-visitor-card">
                                                            <div class="card-block">
                                                                <h6 class="m-b-0">Total New ID Sheet Pending</h6>
                                                                <h4 class="m-t-15 m-b-15"><i class="fa fa-arrow-down m-r-15 text-c-red"></i><asp:Label ID="lblTotalNewIDSheetOutward_Pending" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <p class="m-b-0">From 'Feb 2020'</p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-6">
                                                        <div class="card text-center order-visitor-card">
                                                            <div class="card-block">
                                                                <h6 class="m-b-0">Total Searching Case Pending</h6>
                                                                <h4 class="m-t-15 m-b-15"><i class="fa fa-arrow-down m-r-15 text-c-red"></i><asp:Label ID="lblTotalSearchingCaseOutward_Pending" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <p class="m-b-0">From 'Feb 2020'</p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-6">
                                                        <div class="card text-center order-visitor-card">
                                                            <div class="card-block">
                                                                <h6 class="m-b-0">Total New ID Case Pending</h6>
                                                                <h4 class="m-t-15 m-b-15"><i class="fa fa-arrow-down m-r-15 text-c-red"></i><asp:Label ID="lblTotalNewIDCaseOutward_Pending" runat="server" Text="Not Working"></asp:Label></h4>
                                                                <p class="m-b-0">From 'Feb 2020'</p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-6">
                                                        <div class="card">
                                                            <div class="card-block">
                                                                <div class="row align-items-center m-l-0">
                                                                    <div class="col-auto">
                                                                        <i class="fa fa-user f-30 text-c-red"></i>
                                                                    </div>
                                                                    <div class="col-auto">
                                                                        <h6 class="text-muted m-b-10">Happy Consumers</h6>
                                                                        <h2 class="m-b-0">7984+</h2>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <%--<div class="col-md-6">
                                                        <div class="card">
                                                            <div class="card-block">
                                                                <div class="row align-items-center m-l-0">
                                                                    <div class="col-auto">
                                                                        <i class="fa fa-lightbulb-o f-30 text-c-blue"></i>
                                                                    </div>
                                                                    <div class="col-auto">
                                                                        <h6 class="text-muted m-b-10">Complaint Pending</h6>
                                                                        <h2 class="m-b-0">7</h2>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>--%>
                                                </div>

                                            </div>
                                            


                                            <div class="card">
                                                    <div class="card-block">
                                                        <div class="row">
                                                            <div class="col">
                                                                <h4>14,23,000+</h4>
                                                                <p class="text-muted">Current Month Revenue</p>
                                                            </div>
                                                            <div class="col-auto">
                                                                <label class="label label-success">+20%</label>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-sm-8">
                                                                <canvas id="this-month" style="height: 150px;"></canvas>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            <%--<div class="col-xl-3 col-md-6">
                                                <div class="card user-card">
                                                    <div class="card-block text-center">
                                                        <div class="usre-image">
                                                            <img src="files/assets/images/avatar-4.jpg" class="img-radius" alt="User-Profile-Image">
                                                        </div>
                                                        <h6 class="m-t-25 m-b-10">John Deo</h6>
                                                        <p class="text-muted">Web Designer</p>
                                                        <a href="#!" class="text-c-red d-block">websitename.com</a>
                                                        <button class="btn btn-primary d-block">View Profile</button>
                                                        <div class="row justify-content-center user-social-link m-b-25 p-t-10">
                                                            <div class="col-auto"><a href="#!" data-toggle="tooltip" data-placement="bottom" title="facebook"><i class="fa fa-facebook text-facebook f-20"></i></a></div>
                                                            <div class="col-auto"><a href="#!" data-toggle="tooltip" data-placement="bottom" title="twitter"><i class="fa fa-twitter text-twitter f-20"></i></a></div>
                                                            <div class="col-auto"><a href="#!" data-toggle="tooltip" data-placement="bottom" title="dribbble"><i class="fa fa-dribbble text-dribbble f-20"></i></a></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>--%>

                                            <%--<div class="col-xl-3 col-md-6">
                                                <div class="card wather-card">
                                                    <div class="nature-card">
                                                        <img src="files/assets/images/widget/wathernature.png" alt="whether image" class="img-fluid main-img">
                                                        <img src="files/assets/images/widget/watherstar1.png" alt="whether image" class="snow1">
                                                        <img src="files/assets/images/widget/watherstar2.png" alt="whether image" class="snow2">
                                                        <img src="files/assets/images/widget/watherbottom.png" alt="whether image" class="bottom-img">
                                                        <div class="nature-cont text-white">
                                                            <h6>Snow</h6>
                                                            <h2>-10°</h2>
                                                            <h6>10:20 AM</h6>
                                                        </div>
                                                    </div>
                                                    <div class="card-block">
                                                        <div class="row text-c-blue">
                                                            <div class="col">
                                                                <h6>Sunday</h6></div>
                                                            <div class="col text-right">-10°<i class="fa fa-snowflake-o m-l-20"></i></div>
                                                        </div>
                                                        <div class="row m-t-15">
                                                            <div class="col">
                                                                <h6>Monday</h6></div>
                                                            <div class="col text-right">8°<i class="fa fa-cloud m-l-20"></i></div>
                                                        </div>
                                                        <div class="row m-t-15">
                                                            <div class="col">
                                                                <h6>Tuesday</h6></div>
                                                            <div class="col text-right">20°<i class="fa fa-sun-o m-l-20"></i></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>--%>
                                            <!--  whether order-visitor end -->

                                   

                                     
                                        </div>
                                    </div>
                                    <!-- Page-body end -->
                                </div>
                                <div id="styleSelector"> </div>
                            </div>
                        </div>
                    </div>
</asp:Content>

