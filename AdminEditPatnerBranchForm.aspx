<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminEditPatnerBranchForm.aspx.cs" Inherits="AdminEditPatnerBranchForm" %>

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
                                            <h5 class="m-b-10">Patner Branch Form</h5>
                                            <p class="m-b-0">Edit Patner Branch will be add by admin only</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i>Home</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddPatnerBranchForm.aspx">Patner Branch</a>
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
                                                        <h5>Edit Patner Branch</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat ="server">
                                                            <%--///--%>
                                                            <div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">Select Patner</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                 <asp:DropDownList ID="slcteditpatner" OnSelectedIndexChanged="slcteditpatner_SelectedIndexChanged1" AutoPostBack="true" runat="server" class="form-control required"></asp:DropDownList>
                                                                     <%--<option value="opt1">Select Patner</option>
                                                                        <option value="opt2">Pakistan</option>
                                                                        <option value="opt3">Europe</option>--%>
                             
                                                             </div>
                                                          </div>
                                                            <%--///--%>
                                                             <div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">Patner</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                 <select id="slctpatnerbranch" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                        <option value="opt1">Select Patner</option>
                                                                        <option value="opt2">Pakistan</option>
                                                                        <option value="opt3">Europe</option>
                                                                  </select>
                                                             </div>
                                                          </div>


                                                          <div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">City</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                 <select id="Slctcity" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                        <option value="opt1">Select City</option>
                                                                        <option value="opt2">Pakistan</option>
                                                                        <option value="opt3">Europe</option>
                                                                  </select>
                                                             </div>
                                                          </div>


                                                              <div class="form-group row">
                                                                  <div class="col-md-4 col-lg-2">
                                                                        <label for="userName-1" class="block">Address</label>
                                                                  </div>
                                                                  <div class="col-md-8 col-lg-10">
                                                                        <textarea id="txtaddress" runat="server" class="form-control max-textarea form-control-capitalize required" maxlength="255" rows="4" placeholder="Type your Address here (Only 255 words here)"></textarea>
                                                                                      
                                                                  </div>
                                                              </div>

                                                           
                                                             <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Postal Code</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtpostalcode" runat="server" type="text" class="form-control" name="name" placeholder="Postal Code">
                                                                    <span class="messages"></span>
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

