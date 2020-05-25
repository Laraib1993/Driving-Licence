<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminHeaderDropdown.aspx.cs" Inherits="AdminHeaderDropdown" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Header's Dropdowns Option</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="pcoded-content">   
    
    
     <!-- Page-header start -->
                        <div class="page-header">
                            <div class="page-block">
                                <div class="row align-items-center">
                                    <div class="col-md-8">
                                        <div class="page-header-title">
                                            <h5 class="m-b-10">Header's Dropdowns Option Form</h5>
                                            <p class="m-b-0">Header's Dropdowns Option will be add by admin only</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminHeaderDropdown.aspx">Header's Dropdowns Option</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminHeaderDropdown.aspx">Form</a>
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
                                                        <h5>Add Header's Dropdowns Option</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat ="server">
                                                           <div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">First Options</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                 <select id="slctfirstoption" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                        <option value="opt1">Select List</option>
                                                                        <option value="opt2">Products</option>
                                                                        <option value="opt3">Patner </option>
                                                                        <option value="opt3">Service </option>
                                                                        <option value="opt3">Category </option>
                                                                        <option value="opt3">Type</option>
                                                                  </select>
                                                             </div>
                                                          </div>

                                                          <div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">Page</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                 <select id="slctSecondoption" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                        <option value="opt1">Select List</option>
                                                                        <option value="opt2">Products</option>
                                                                        <option value="opt3">Patner </option>
                                                                        <option value="opt3">Service </option>
                                                                        <option value="opt3">Category </option>
                                                                        <option value="opt3">Type</option>
                                                                  </select>
                                                             </div>
                                                          </div>

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

