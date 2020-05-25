<%@ Page Title="" Language="C#" MasterPageFile="~/Vendor.master" AutoEventWireup="true" CodeFile="VendorEditProductForm.aspx.cs" Inherits="VendorEditProductForm" %>

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
                                            <h5 class="m-b-10">Product Form</h5>
                                            <p class="m-b-0">Edit Product By Yourselft</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="#"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddProductForm.aspx">Product</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddProductForm.aspx">Form</a>
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
                                                        <h5>Add Product</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat="server">


                                                                                  <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="userName-1" class="block">Select Product</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <asp:DropDownList ID="Slcteditproduct" runat="server" name="select" class="form-control form-control-primary" AutoPostBack="true" OnSelectedIndexChanged="Slcteditproduct_SelectedIndexChanged" required="required"></asp:DropDownList>
                                                                                    </div>
                                                                                </div>

                                                                               <div class="form-group row">

                                                                            
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="userName-2" class="block">Product Name</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10 js-default js-primary js-success js-info js-warning js-inverse js-danger js-large js-medium js-small js-single js-dynamic-state js-dynamic-enable js-dynamic-disable m-t-10">
                                                                                         <input id="txtproductname" type="text" class="form-control required thresold-i" runat="server" placeholder="Type your product name here (Only 50 words here)" maxlength="50">
                                                                                    </div>
                                                                                </div>
                                                                                <%--<div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="userName-1" class="block">Select Vendor</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <select id="slctvendor" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                                            <option value="opt1">Select Vendor</option>
                                                                                            <option value="opt2">HP</option>
                                                                                            <option value="opt3">HTC</option>
                                                                                            <option value="opt4">3M Gulf</option>
                                                                                            <option value="opt5">Acer</option>
                                                                                            <option value="opt6">Adobe System MENA</option>
                                                                                            <option value="opt7">Apacer</option>
                                                                                            <option value="opt8">Apple</option>
                                                                                        </select>
                                                                                    </div>
                                                                                </div>--%>
                                                                                 

                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="userName-2" class="block">Detail</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10 js-default js-primary js-success js-info js-warning js-inverse js-danger js-large js-medium js-small js-single js-dynamic-state js-dynamic-enable js-dynamic-disable m-t-10">
                                                                                         <textarea id="txtdetail" runat="server" class="form-control max-textarea" maxlength="255" rows="4" required="required"></textarea>
                                                                                    </div>
                                                                                </div>


                                                             <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="name-2" class="block">Model No</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input id="txtmodelno" runat="server" name="name" type="text" class="form-control required thresold-i" placeholder="Type contact preson name here (Only 50 words here)" maxlength="50">
                                                                                    </div>
                                                                                </div>
                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="email-2" class="block">Price in Dollar ($)</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input id="txtprice" runat="server" type="text" class="form-control autonumber" >
                                                                                    </div>
                                                                                </div>
                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="phone-2" class="block">Launch Date</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input id="txtlaunchdate" runat="server"  class="form-control dropper-default" type="text" placeholder="Select launch date" />
                                                                                    </div>
                                                                                </div>

                                                                                


                                                                                    <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="userName-1" class="block">Product Type</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <select id="slctproducttype" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                                            <option value="opt1">Select Product Type</option>
                                                                                            <option value="opt2">Rack Server</option>
                                                                                            <option value="opt3">Tower Server</option>
                                                                                            <option value="opt4">Blade Server</option>
                                                                                        </select>
                                                                                    </div>
                                                                                </div>



                                                            <%--pic start --%>
                                                              <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="University-2" class="block">Front Pic</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input type="file" id="pic1" runat="server" required="required" />
                                                                                        <span>Please upload <code>Front Picture</code>  <code>&lt;&gt;</code></span>
                                                                                            
                                                                                    </div>
                                                                                    
                                                                                    
                                                                                </div>

                                                            <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="University-2" class="block">Second Pic</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input type="file" id="pic2" runat="server" required="required" />
                                                                                        <span>Please upload <code>Second Picture</code>  <code>&lt;&gt;</code></span>
                                                                                            
                                                                                    </div>
                                                                                    
                                                                                    
                                                                                </div>


                                                            <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="University-2" class="block">Third Pic</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input type="file" id="pic3" runat="server" required="required" />
                                                                                        <span>Please upload <code>Third Picture</code>  <code>&lt;&gt;</code></span>
                                                                                            
                                                                                    </div>
                                                                                    
                                                                                    
                                                                                </div>


                                                            <%--pic end--%>

                                                              <div class="form-group row">
                                                                <label class="col-sm-2"></label>
                                                                <div class="col-sm-10">
                                                                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" class="btn btn-primary m-b-0" OnClick="btnsubmit_Click" />
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

