<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAddRegionForm.aspx.cs" Inherits="AdminAddRegionForm" %>

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
                                            <h5 class="m-b-10">Outward Form</h5>
                                            <p class="m-b-0">Outward will be add by admin only</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddRegionForm.aspx">Outward</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddRegionForm.aspx">Form</a>
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
                                                        <h5>Add Outward</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat="server">
                                                            
                                                          <div class="form-group row">
                                                               <div class="col-md-4 col-lg-2">
                                                                   <label for="userName-1" class="block">Outward No</label>
                                                               </div>
                                                               <div class="col-md-8 col-lg-10">
                                                                   <select id="slctOutward" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                       <option value="opt1">Select Inword No</option>
                                                                       <option value="opt2">Rack Server</option>
                                                                       <option value="opt3">Tower Server</option>
                                                                       <option value="opt4">Blade Server</option>
                                                                   </select>
                                                               </div>
                                                           </div>

                                                            <div class="form-group row">
                                                                <div class="col-md-4 col-lg-2">
                                                                    <label for="phone-2" class="block">Outward Date</label>
                                                                </div>
                                                                <div class="col-md-8 col-lg-10">
                                                                    <input id="txtlaunchdate" runat="server"  class="form-control dropper-default" type="text" placeholder="Select date" />
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

