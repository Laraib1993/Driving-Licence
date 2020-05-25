<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminEditVendorForm.aspx.cs" Inherits="AdminEditVendorForm" %>

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
                                            <h5 class="m-b-10">Vendor Form</h5>
                                            <p class="m-b-0">Edit Vendor By Yourselft</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminEditVendorForm.aspx">Vendor</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminEditVendorForm.aspx">Form</a>
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
                                                        <h5>Edit Vendor</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form id="main"  novalidate>
                                                           <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">Select Vendor</div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <select class="form-control required">
                                                                                            <option>Select Vendor To Be Edited</option>
                                                                                            <option>Vendor A</option>
                                                                                            <option>Vendor B</option>
                                                                                            <option>Vendor C</option>
                                                                                            <option>Vendor D</option>
                                                                                            <option>Vendor E</option>
                                                                                        </select>
                                                                                    </div>
                                                              </div>
                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Vendor Name</label>
                                                                <div class="col-sm-10">
                                                                    <input type="text" class="form-control" name="name" id="name" placeholder="Vendor Name">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>
                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Email</label>
                                                                <div class="col-sm-10">
                                                                    <input type="email" class="form-control" id="email" name="email" placeholder="Vendor E-mail Address">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                              <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Phone</label>
                                                                <div class="col-sm-10">
                                                                    <input type="text" class="form-control" name="numeric" id="numeric" placeholder="Vendor Phone">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                            <div class="row form-group">
                                                                <label class="col-sm-2 col-form-label">Address</label>
                                                                <div class="col-sm-10">
                                                                   <textarea class="form-control max-textarea" maxlength="255" rows="4"></textarea>
                                                                </div>
                                                            </div>

                                                            <div class="row form-group">
                                                                <label class="col-sm-2 col-form-label">Discription</label>
                                                                <div class="col-sm-10">
                                                                   <textarea class="form-control max-textarea" maxlength="255" rows="4"></textarea>
                                                                </div>
                                                            </div>


                                                            <div class="row form-group">
                                                                <label class="col-sm-2 col-form-label">Logo</label>
                                                                <div class="col-sm-10">
                                                                   <input type="file" name="files[]" id="filer_input" multiple="multiple">
                                                                </div>
                                                            </div>



                                                             
                                                            <div class="form-group row">
                                                                <label class="col-sm-2"></label>
                                                                <div class="col-sm-10">
                                                                    <button type="submit" class="btn btn-primary m-b-0">Submit</button>
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

