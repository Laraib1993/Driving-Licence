<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAddSearchingCase.aspx.cs" Inherits="AdminAddSearchingCase" %>

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
                                            <h5 class="m-b-10">Searching Case Inword Form</h5>
                                            <p class="m-b-0">Inword will be add by Admin</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i>Home</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddPatnerBranchForm.aspx">Case Inword</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddPatnerBranchForm.aspx">Form</a>
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
                                                        <h5>Add Inword</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat ="server">
                                                             <div class="form-group row">

                                                              
                                                                  <div class="col-md-4 col-lg-2">
                                                                      <label for="userName-2" class="block">Inword No</label>
                                                                  </div>
                                                                  <div class="col-md-8 col-lg-10 js-default js-primary js-success js-info js-warning js-inverse js-danger js-large js-medium js-small js-single js-dynamic-state js-dynamic-enable js-dynamic-disable m-t-10">
                                                                       <input id="txtinwordno" type="text" class="form-control required thresold-i" runat="server" placeholder="Type your inword no here " maxlength="5">
                                                                  </div>
                                                              </div>

                                                            <div class="form-group row">
                                                                  <div class="col-md-4 col-lg-2">
                                                                        <label for="userName-1" class="block">Discription</label>
                                                                  </div>
                                                                  <div class="col-md-8 col-lg-10">
                                                                        <textarea id="txtDiscription" runat="server" class="form-control max-textarea form-control-capitalize required" maxlength="255" rows="4" placeholder="Type your Discription here (Only 255 words here)"></textarea>
                                                                                      
                                                                  </div>
                                                              </div>


                                                           <div class="form-group row">
                                                                <div class="col-md-4 col-lg-2">
                                                                    <label for="phone-2" class="block">Inword Date</label>
                                                                </div>
                                                                <div class="col-md-8 col-lg-10">
                                                                    <input id="txtlaunchdate" runat="server"  class="form-control dropper-default" type="text" placeholder="Select date" />
                                                                </div>
                                                            </div>

                                                         
                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">No of ID's</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtNoofID" runat="server" type="text" class="form-control" name="name" placeholder="No Of ID's">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">No of Pages</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtpages" runat="server" type="text" class="form-control" name="name" placeholder="No Of Pages">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                            

                                                            <%--<div class="form-group row">
                                                                <label class="col-sm-2"></label>
                                                                <div class="col-sm-10">
                                                                    <asp:Button ID="btnscan" class="btn btn-primary m-b-0" runat="server" Text="Scan" OnClick="btnsubmit_Click" />
                                                                   
                                                                </div>
                                                            </div>--%>

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

