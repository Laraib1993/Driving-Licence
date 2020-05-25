<%@ Page Title="" Language="C#" MasterPageFile="~/Reseller.master" AutoEventWireup="true" CodeFile="ResellerReportActiveReport.aspx.cs" Inherits="ResellerReportActiveReport" %>

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
                                            <h5 class="m-b-10">Product</h5>
                                            <p class="m-b-0">List of product are given below</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="ResellerReportActiveReport.aspx">List</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="ResellerReportActiveReport.aspx">Product</a>
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
                                    <!-- Page body start -->
                                    <div class="page-body">
                                        <!-- Product list start -->
                                        <div class="row">
                                            <div class="col-xl-4 col-md-6 col-sm-6 col-xs-12">
                                                <div class="card prod-view">
                                                    <div class="prod-item text-center">
                                                        <div class="prod-img">
                                                            <div class="option-hover">
                                                                <button type="button" class="btn btn-success btn-icon waves-effect waves-light m-r-15 hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-cart-alt f-20"></i>
                                                                </button>
                                                                <button type="button" class="btn btn-primary btn-icon waves-effect waves-light m-r-15 hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-eye-alt f-20"></i>
                                                                </button>
                                                                <button type="button" class="btn btn-danger btn-icon waves-effect waves-light hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-heart-alt f-20"></i>
                                                                </button>
                                                            </div>
                                                            <a href="AdminReportActiveProductDetail.aspx" class="hvr-shrink">
                                                                <img src="../files/assets/images/product/p1.jpg" class="img-fluid o-hidden" alt="prod1.jpg">
                                                            </a>
                                                            <div class="p-new"><a href="AdminReportActiveProductDetail.aspx"> Active </a></div>
                                                        </div>
                                                        <div class="prod-info">
                                                            <a href="AdminReportActiveProductDetail.aspx" class="txt-muted"><h4>Product Name</h4></a>
                                                            <div class="m-b-10">
                                                                <a class="text-muted f-w-600"> Launched Date </a>
                                                            </div>
                                                            <span class="prod-price">Vendor Name</span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="col-xl-4 col-md-6 col-sm-6 col-xs-12">
                                                <div class="card prod-view">
                                                    <div class="prod-item text-center">
                                                        <div class="prod-img">
                                                            <div class="option-hover">
                                                                <button type="button" class="btn btn-success btn-icon waves-effect waves-light m-r-15 hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-cart-alt f-20"></i>
                                                                </button>
                                                                <button type="button" class="btn btn-primary btn-icon waves-effect waves-light m-r-15 hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-eye-alt f-20"></i>
                                                                </button>
                                                                <button type="button" class="btn btn-danger btn-icon waves-effect waves-light hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-heart-alt f-20"></i>
                                                                </button>
                                                            </div>
                                                            <a href="AdminReportActiveProductDetail.aspx" class="hvr-shrink">
                                                                <img src="../files/assets/images/product/p1.jpg" class="img-fluid o-hidden" alt="prod1.jpg">
                                                            </a>
                                                            <div class="p-new"><a href="AdminReportActiveProductDetail.aspx"> Active </a></div>
                                                        </div>
                                                        <div class="prod-info">
                                                            <a href="AdminReportActiveProductDetail.aspx" class="txt-muted"><h4>Product Name</h4></a>
                                                            <div class="m-b-10">
                                                                <a class="text-muted f-w-600"> Launched Date </a>
                                                            </div>
                                                            <span class="prod-price">Vendor Name</span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="col-xl-4 col-md-6 col-sm-6 col-xs-12">
                                                <div class="card prod-view">
                                                    <div class="prod-item text-center">
                                                        <div class="prod-img">
                                                            <div class="option-hover">
                                                                <button type="button" class="btn btn-success btn-icon waves-effect waves-light m-r-15 hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-cart-alt f-20"></i>
                                                                </button>
                                                                <button type="button" class="btn btn-primary btn-icon waves-effect waves-light m-r-15 hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-eye-alt f-20"></i>
                                                                </button>
                                                                <button type="button" class="btn btn-danger btn-icon waves-effect waves-light hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-heart-alt f-20"></i>
                                                                </button>
                                                            </div>
                                                            <a href="AdminReportActiveProductDetail.aspx" class="hvr-shrink">
                                                                <img src="../files/assets/images/product/p1.jpg" class="img-fluid o-hidden" alt="prod1.jpg">
                                                            </a>
                                                            <div class="p-new"><a href="AdminReportActiveProductDetail.aspx"> Active </a></div>
                                                        </div>
                                                        <div class="prod-info">
                                                            <a href="AdminReportActiveProductDetail.aspx" class="txt-muted"><h4>Product Name</h4></a>
                                                            <div class="m-b-10">
                                                                <a class="text-muted f-w-600"> Launched Date </a>
                                                            </div>
                                                            <span class="prod-price">Vendor Name</span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="col-xl-4 col-md-6 col-sm-6 col-xs-12">
                                                <div class="card prod-view">
                                                    <div class="prod-item text-center">
                                                        <div class="prod-img">
                                                            <div class="option-hover">
                                                                <button type="button" class="btn btn-success btn-icon waves-effect waves-light m-r-15 hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-cart-alt f-20"></i>
                                                                </button>
                                                                <button type="button" class="btn btn-primary btn-icon waves-effect waves-light m-r-15 hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-eye-alt f-20"></i>
                                                                </button>
                                                                <button type="button" class="btn btn-danger btn-icon waves-effect waves-light hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-heart-alt f-20"></i>
                                                                </button>
                                                            </div>
                                                            <a href="AdminReportActiveProductDetail.aspx" class="hvr-shrink">
                                                                <img src="../files/assets/images/product/p1.jpg" class="img-fluid o-hidden" alt="prod1.jpg">
                                                            </a>
                                                            <div class="p-new"><a href="AdminReportActiveProductDetail.aspx"> Active </a></div>
                                                        </div>
                                                        <div class="prod-info">
                                                            <a href="AdminReportActiveProductDetail.aspx" class="txt-muted"><h4>Product Name</h4></a>
                                                            <div class="m-b-10">
                                                                <a class="text-muted f-w-600"> Launched Date </a>
                                                            </div>
                                                            <span class="prod-price">Vendor Name</span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="col-xl-4 col-md-6 col-sm-6 col-xs-12">
                                                <div class="card prod-view">
                                                    <div class="prod-item text-center">
                                                        <div class="prod-img">
                                                            <div class="option-hover">
                                                                <button type="button" class="btn btn-success btn-icon waves-effect waves-light m-r-15 hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-cart-alt f-20"></i>
                                                                </button>
                                                                <button type="button" class="btn btn-primary btn-icon waves-effect waves-light m-r-15 hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-eye-alt f-20"></i>
                                                                </button>
                                                                <button type="button" class="btn btn-danger btn-icon waves-effect waves-light hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-heart-alt f-20"></i>
                                                                </button>
                                                            </div>
                                                            <a href="AdminReportActiveProductDetail.aspx" class="hvr-shrink">
                                                                <img src="../files/assets/images/product/p1.jpg" class="img-fluid o-hidden" alt="prod1.jpg">
                                                            </a>
                                                            <div class="p-new"><a href="AdminReportActiveProductDetail.aspx"> Active </a></div>
                                                        </div>
                                                        <div class="prod-info">
                                                            <a href="AdminReportActiveProductDetail.aspx" class="txt-muted"><h4>Product Name</h4></a>
                                                            <div class="m-b-10">
                                                                <a class="text-muted f-w-600"> Launched Date </a>
                                                            </div>
                                                            <span class="prod-price">Vendor Name</span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class="col-xl-4 col-md-6 col-sm-6 col-xs-12">
                                                <div class="card prod-view">
                                                    <div class="prod-item text-center">
                                                        <div class="prod-img">
                                                            <div class="option-hover">
                                                                <button type="button" class="btn btn-success btn-icon waves-effect waves-light m-r-15 hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-cart-alt f-20"></i>
                                                                </button>
                                                                <button type="button" class="btn btn-primary btn-icon waves-effect waves-light m-r-15 hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-eye-alt f-20"></i>
                                                                </button>
                                                                <button type="button" class="btn btn-danger btn-icon waves-effect waves-light hvr-bounce-in option-icon">
                                                                    <i class="icofont icofont-heart-alt f-20"></i>
                                                                </button>
                                                            </div>
                                                            <a href="AdminReportActiveProductDetail.aspx" class="hvr-shrink">
                                                                <img src="../files/assets/images/product/p1.jpg" class="img-fluid o-hidden" alt="prod1.jpg">
                                                            </a>
                                                            <div class="p-new"><a href="AdminReportActiveProductDetail.aspx"> Active </a></div>
                                                        </div>
                                                        <div class="prod-info">
                                                            <a href="AdminReportActiveProductDetail.aspx" class="txt-muted"><h4>Product Name</h4></a>
                                                            <div class="m-b-10">
                                                                <a class="text-muted f-w-600"> Launched Date </a>
                                                            </div>
                                                            <span class="prod-price">Vendor Name</span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                           
                                        </div>
                                        <!-- Product list end -->
                                    </div>
                                    <!-- Page body end -->
                                </div>
                            </div>
                        </div>
                    </div>
</asp:Content>

