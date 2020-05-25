<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminSlider.aspx.cs" Inherits="AdminSlider" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Blue Slider</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="pcoded-content">   
    
    
     <!-- Page-header start -->
                        <div class="page-header">
                            <div class="page-block">
                                <div class="row align-items-center">
                                    <div class="col-md-8">
                                        <div class="page-header-title">
                                            <h5 class="m-b-10">Blue Slider Form</h5>
                                            <p class="m-b-0">Blue Slider will be add by admin only</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i>Home </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminSlider.aspx">Blue Slider</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminSlider.aspx">Form</a>
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
                                        <div class="row">
                                            <div class="col-sm-12">
                                                <!-- Basic Inputs Validation start -->
                                                <div class="card">
                                                    <div class="card-header">
                                                        <h5>Update Blue Slider</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat ="server">
                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">1st Heading</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtheading1" runat="server" type="text" class="form-control" name="name" placeholder="1st Heading">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                               <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">2nd Heading</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtheading2" runat="server" type="text" class="form-control" name="name" placeholder="2nd Heading">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                          <%--<div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">Browse By</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                 <select id="slctLink" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                        <option value="opt1">Select Search Option</option>
                                                                        <option value="opt2">Search By Product</option>
                                                                        <option value="opt3">Search By Patner</option>
                                                                        <option value="opt3">Search By Service </option>
                                                                  </select>
                                                             </div>
                                                          </div>--%>

                                                            <div class="form-group row">
                                                                <label class="col-sm-2"></label>
                                                                <div class="col-sm-10">
                                                                    <asp:Button ID="btnsubmit" class="btn btn-primary m-b-0" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
                                                                   
                                                                </div>
                                                            </div>
                                                        </form>
                                                    </div>
                                                </div>
                                                <!-- Basic Inputs Validation end -->
                                               
                                        </div>
                                    </div>
                                </div>
                                <!-- Page body end -->
                            </div>
                        </div>
                    </div>
     </div>
</asp:Content>

