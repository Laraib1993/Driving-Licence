<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAddProductForm.aspx.cs" Inherits="AdminAddProductForm" %>

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
                                            <h5 class="m-b-10">Searching Inword Form</h5>
                                            <p class="m-b-0">Add Inword By Yourself</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="#"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddProductForm.aspx">Searching</a>
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
                                                        <h5>Add Inword</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat="server">

                                                            <div class="form-group row">
                                                                   <div class="col-md-4 col-lg-2">
                                                                       <label for="userName-1" class="block">Select Inword</label>
                                                                   </div>
                                                                   <div class="col-md-8 col-lg-10">
                                                                       <asp:DropDownList ID="slctinword" runat="server" class="form-control form-control-primary"></asp:DropDownList>
                                                                       <%--<select id="slctinword" runat="server" name="select" class="form-control form-control-primary" required="required">--%>
                                                                           
                                                                           
                                                                   </div>
                                                               </div>

                                                             <%--<div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Department</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtdept" runat="server" type="text" class="form-control" name="name" placeholder="Insert Record" visible="False">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">No Of ID's</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtNoOfIDs" runat="server" type="text" class="form-control" name="name" placeholder="Insert Record" visible="False">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>--%>

                                                            <%--<div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">No Of Pages</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtnoofPages" runat="server" type="text" class="form-control" name="name" placeholder="Insert Record" visible="False">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Scanning Description</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtdescription" runat="server" type="text" class="form-control" name="name" placeholder="Insert Record" visible="False">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>--%>
                                                             <div class="form-group row">
                                                                <div class="col-md-4 col-lg-2">
                                                                    <label for="phone-2" class="block">Inword Date</label>
                                                                </div>
                                                                <div class="col-md-8 col-lg-10">
                                                                    <input id="txtlaunchdate" runat="server"  class="form-control dropper-default" type="text" placeholder="Select date" />
                                                                </div>
                                                            </div>
                                                                                
                                                                                 

                                                                                <%--<div class="form-group row">
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
                                                                                </div>--%>
                                                                                <%--<div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="phone-2" class="block">Inword Date and Time</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input id="txtlaunchdate" runat="server"  class="form-control dropper-default" type="text" placeholder="Select date" />
                                                                                    </div>
                                                                                </div>

                                                                                


                                                                                    <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="userName-1" class="block">Reason</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <select id="slctReason" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                                            <option value="opt1">Select Product Type</option>
                                                                                            <option value="opt2">Rack Server</option>
                                                                                            <option value="opt3">Tower Server</option>
                                                                                            <option value="opt4">Blade Server</option>
                                                                                        </select>
                                                                                    </div>
                                                                                </div>--%>



                                                            <%--<%--pic start --%>
                                                              <%--<div class="form-group row">
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
                                                                                    
                                                                                    
                                                                                </div>--%>


                                                            <%--pic end--%>
                                                            <%--<div class="form-group row">

                                                                            
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="userName-2" class="block">No of Records</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10 js-default js-primary js-success js-info js-warning js-inverse js-danger js-large js-medium js-small js-single js-dynamic-state js-dynamic-enable js-dynamic-disable m-t-10">
                                                                                         <input id="txtNoofRecord" type="text" class="form-control required thresold-i" runat="server" placeholder="No of Records" maxlength="5">
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

