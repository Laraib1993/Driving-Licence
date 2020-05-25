<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminEditProductTypeForm.aspx.cs" Inherits="AdminEditProductTypeForm" %>

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
                                            <h5 class="m-b-10">Product Type Form</h5>
                                            <p class="m-b-0">Edit Product Type will be add by admin only</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i>Home</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminEditProductTypeForm.aspx">Product Type</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminEditProductTypeForm.aspx">Form</a>
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
                                                        <h5>Edit Product Type</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form  runat="server">
                                                                  <div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">Select Type</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                 <asp:DropDownList ID="slcteditproducttype" OnSelectedIndexChanged="slcteditproducttype_SelectedIndexChanged" AutoPostBack="true" runat="server" name="select" class="form-control form-control-primary" required="required"></asp:DropDownList>
                                                                
                                                             </div>
                                                          </div>
                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Type Name</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtproducttype" runat="server" type="text" class="form-control" name="name" placeholder="Type Name">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>
                                                           
                                                            <div class="form-group row">
                                                                 <div class="col-md-4 col-lg-2">
                                                                    <label for="phone-2" class="block">Launch Date</label>
                                                                 </div>
                                                                 <div class="col-md-8 col-lg-10">
                                                                    <input id="txtlaunchdate" runat="server" class="form-control dropper-default" type="text" placeholder="Select launch date" />
                                                                 </div>
                                                           </div>

                                                          <div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">Product Category</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                 <select id="slctproductcategory" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                        <option value="opt1">Select Product Category</option>
                                                                        <option value="opt2">Server</option>
                                                                        <option value="opt3">Storage</option>
                                                                        <option value="opt4">Network</option>
                                                                        <option value="opt5">Power</option>
                                                                        <option value="opt6">Cloud</option>
                                                                  </select>
                                                             </div>
                                                          </div>

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

