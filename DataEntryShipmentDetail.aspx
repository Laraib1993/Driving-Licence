<%@ Page Title="" Language="C#" MasterPageFile="~/DataEntryDashboard.master" AutoEventWireup="true" CodeFile="DataEntryShipmentDetail.aspx.cs" Inherits="DataEntryShipmentDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Shipment Detail Form</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="pcoded-content">   
    
    
     <!-- Page-header start -->
                        <div class="page-header">
                            <div class="page-block">
                                <div class="row align-items-center">
                                    <div class="col-md-8">
                                        <div class="page-header-title">
                                            <h5 class="m-b-10">New Shipment Detail Form</h5>
                                            <p class="m-b-0">Data will be add by data entry operator only</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="#"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="#">New Shipment Detail</a>
                                            </li>
                                             <li class="breadcrumb-item"><a href="#">Form</a>
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
                                                        <h5>New Shipment Detail</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat ="server">
                                                    

                                                             <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Licence No</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtlicence" runat="server" type="text" class="form-control" name="name" placeholder="Licence ID"/>
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                             <div class="form-group row">
                                                                   <div class="col-md-4 col-lg-2">
                                                                       <label for="userName-1" class="block">Select District</label>
                                                                   </div>
                                                                   <div class="col-md-8 col-lg-10">
                                                                       <asp:DropDownList ID="slctdistrict" runat="server" class="form-control form-control-primary"></asp:DropDownList>
                                                                           
                                                                   </div>
                                                               </div>

                                                             <div class="form-group row">
                                                                  <div class="col-md-4 col-lg-2">
                                                                        <label for="userName-1" class="block">Address</label>
                                                                  </div>
                                                                  <div class="col-md-8 col-lg-10">
                                                                        <textarea id="txtarea" runat="server" class="form-control max-textarea form-control-capitalize required" maxlength="255" rows="4" placeholder="Type your Address here (Only 255 words here)"></textarea>
                                                                                      
                                                                  </div>
                                                              </div>


                                                             <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">CNIC</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtcnic" runat="server" type="text" class="form-control" name="name" placeholder="CNIC" />
                                                                    <span class="messages"></span>
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

