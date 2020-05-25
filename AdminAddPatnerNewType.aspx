<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAddPatnerNewType.aspx.cs" Inherits="AdminAddPatnerNewType" %>

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
                                            <h5 class="m-b-10">Scanning Outward</h5>
                                            <p class="m-b-0">Inword will be add by admin</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i>Home</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddPatnerNewType.aspx">Scanning Inword</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddPatnerNewType.aspx">Form</a>
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
                                                        <h5>Add Scanning outward</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat ="server">
                                                           <%--<div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">Patner</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                 <asp:DropDownList ID="slctpatner" runat="server" OnSelectedIndexChanged="slctpatner_SelectedIndexChanged" AutoPostBack="true" name="select" class="form-control form-control-primary" required="required">

                                                                 </asp:DropDownList>
                                                              
                                                             </div>
                                                          </div>--%>

                                                            <div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">Inword No</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                 <asp:DropDownList ID="slctinwordno" runat="server"  class="form-control form-control-primary" ></asp:DropDownList>
                                                               
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
                                                                <label class="col-sm-2 col-form-label">Inword Date</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtinworddate" runat="server" type="text" class="form-control" name="name" placeholder="Insert Record" visible="False">
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

                                                            <div class="form-group row">
                                                                <div class="col-md-4 col-lg-2">
                                                                    <label for="phone-2" class="block">Outward Date</label>
                                                                </div>
                                                                <div class="col-md-8 col-lg-10">
                                                                    <input id="txtlaunchdate" runat="server"  class="form-control dropper-default" type="text" placeholder="Select date" />
                                                                </div>
                                                            </div>

                                                            <div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">Outward to</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                 <select id="slctOutwardto" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                        <option value="opt1">Select Employee</option>
                                                                        <option value="opt2">emp1</option>
                                                                        <option value="opt3">emp2</option>
                                                                  </select>
                                                             </div>
                                                          </div>

                                                            

                                                            <%--<div class="form-group row">
                                                                  <div class="col-md-4 col-lg-2">
                                                                        <label for="userName-1" class="block">Discription</label>
                                                                  </div>
                                                                  <div class="col-md-8 col-lg-10">
                                                                        <textarea id="txtDiscription" runat="server" class="form-control max-textarea form-control-capitalize required" maxlength="255" rows="4" placeholder="Type your Discription here (Only 255 words here)"></textarea>
                                                                                      
                                                                  </div>
                                                              </div>--%>

                                                        <%--<div class="form-group row">
                                                             <div class="col-md-4 col-lg-2">
                                                                 <label for="userName-1" class="block">Patner Type</label>
                                                             </div>
                                                             <div class="col-md-8 col-lg-10">
                                                                <h4 class="sub-title">Select Patner Type</h4>
                                                                    <div class="checkbox-zoom zoom-success">
                                                                    <label>
                                                                        <input id="chkvendor" runat="server" type="checkbox" value="5" name="Items">
                                                                        <span class="cr">
                                                                            <i class="cr-icon icofont icofont-ui-check txt-success"></i>
                                                                        </span>
                                                                        <span>I am Vendor</span>
                                                                    </label>
                                                                </div>
                                                                <div class="checkbox-zoom zoom-info">
                                                                    <label>
                                                                        <input id="chkdistributer" runat="server" type="checkbox" value="6" name="Items">
                                                                        <span class="cr">
                                                                            <i class="cr-icon icofont icofont-ui-check txt-info"></i>
                                                                        </span>
                                                                        <span>I am Distributer</span>
                                                                    </label>
                                                                </div>
                                                                 <div class="checkbox-zoom zoom-warning">
                                                                    <label>
                                                                        <input id="chkreseller" runat="server" type="checkbox" value="7" name="Items">
                                                                        <span class="cr">
                                                                            <i class="cr-icon icofont icofont-ui-check txt-warning"></i>
                                                                        </span>
                                                                        <span>I am Reseller</span>
                                                                    </label>
                                                                </div>
                                                             </div>
                                                          </div>--%>
                                                            
                                                            <%--<div class="form-group row">
                                                                <label class="col-sm-2"></label>
                                                                <div class="col-sm-10">
                                                                    <asp:Button ID="btnscan" class="btn btn-primary m-b-0" runat="server" Text="Scan" OnClick="btnsubmit_Click" />
                                                                   
                                                                </div>
                                                            </div>--%>

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

