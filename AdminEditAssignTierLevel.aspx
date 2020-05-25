<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminEditAssignTierLevel.aspx.cs" Inherits="AdminEditAssignTierLevel" %>

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
                                            <h5 class="m-b-10">Assign Tier Level Form</h5>
                                            <p class="m-b-0">Tier Level will be Assign by admin only</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i>Home</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddAssignTierLevel.aspx">Assign Tier Level</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddAssignTierLevel.aspx">Form</a>
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
                                                        <h5>Update Assign Tier Level</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat ="server">

                                                            <div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">Distributer For Edit</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                     <asp:DropDownList ID="Select1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="slcttierlevel_SelectedIndexChanged1" class="form-control form-control-primary" required="required">
                                                                        
                                                                     </asp:DropDownList>
                                                                
                                                             </div>
                                                          </div>
                                                            <div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">Tier Level</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                              <select id="slctdistributer" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                        <option value="opt1">Select Distributer</option>
                                                                  </select>
                                                             </div>
                                                          </div>

                                                          <div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">Distributer</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                 <select id="slcttierlevel" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                        <option value="opt1">Select Tier Level</option>
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

