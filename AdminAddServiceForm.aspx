<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAddServiceForm.aspx.cs" Inherits="AdminAddServiceTypeForm" %>

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
                                            <h5 class="m-b-10">Searching Outward Form</h5>
                                            <p class="m-b-0">Add Inword Case By Yourselft</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddServiceForm.aspx">Searching Outward</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddServiceForm.aspx">Form</a>
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
                                                        <form  runat="server"  >
                                                            <div class="form-group row">
                                                                   <div class="col-md-4 col-lg-2">
                                                                       <label for="userName-1" class="block">Select Inword</label>
                                                                   </div>
                                                                   <div class="col-md-8 col-lg-10">
                                                                       <asp:DropDownList ID="slctinword" runat="server" class="form-control form-control-primary"></asp:DropDownList>
                                                                       
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
                                                            </div>

                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">No Of Pages</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtnoofPages" runat="server" type="text" class="form-control" name="name" placeholder="Insert Record" visible="False">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>--%>

                                                            <%--<div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Inword Date</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtInworddate" runat="server" type="text" class="form-control" name="name" placeholder="Insert Record" visible="False">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Reason</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtreason" runat="server" type="text" class="form-control" name="name" placeholder="Insert Record" visible="False">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>--%>

                                                            <div class="form-group row">

                                                             
                                                                 <div class="col-md-4 col-lg-2">
                                                                     <label for="userName-2" class="block">No of New ID's</label>
                                                                 </div>
                                                                 <div class="col-md-8 col-lg-10 js-default js-primary js-success js-info js-warning js-inverse js-danger js-large js-medium js-small js-single js-dynamic-state js-dynamic-enable js-dynamic-disable m-t-10">
                                                                      <input id="txtnoofNewID" type="text" class="form-control required thresold-i" runat="server" placeholder="No of New ID's">
                                                                 </div>
                                                             </div>

                                                            <div class="form-group row">

                                                             
                                                                 <div class="col-md-4 col-lg-2">
                                                                     <label for="userName-2" class="block">No of Same ID's</label>
                                                                 </div>
                                                                 <div class="col-md-8 col-lg-10 js-default js-primary js-success js-info js-warning js-inverse js-danger js-large js-medium js-small js-single js-dynamic-state js-dynamic-enable js-dynamic-disable m-t-10">
                                                                      <input id="txtSameid" type="text" class="form-control required thresold-i" runat="server" placeholder="No of Same ID's">
                                                                 </div>
                                                             </div>

                                                            <div class="form-group row">

                                                             
                                                                 <div class="col-md-4 col-lg-2">
                                                                     <label for="userName-2" class="block">No of Modification</label>
                                                                 </div>
                                                                 <div class="col-md-8 col-lg-10 js-default js-primary js-success js-info js-warning js-inverse js-danger js-large js-medium js-small js-single js-dynamic-state js-dynamic-enable js-dynamic-disable m-t-10">
                                                                      <input id="txtnoofModification" type="text" class="form-control required thresold-i" runat="server" placeholder="No of Modification">
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
                                                                         <label for="phone-2" class="block">No Of New ID's</label>
                                                                     </div>
                                                                     <div class="col-md-8 col-lg-10">
                                                                         <input id="txtnewIDs" runat="server"  class="form-control dropper-default" type="text" placeholder="Select date" />
                                                                     </div>
                                                                 </div>--%>

                                                            <%--<div class="row form-group">
                                                                <label class="col-sm-2 col-form-label">Detail</label>
                                                                <div class="col-sm-10">
                                                                   <textarea id="txtdetail" runat="server" class="form-control max-textarea" maxlength="255" rows="4"></textarea>
                                                                </div>
                                                            </div>--%>

                                                             <%--<div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="userName-1" class="block">District</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <select id="slctDistrict" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                                            <option value="opt1">Select District</option>
                                                                                            <option value="opt2">Rack Server</option>
                                                                                            <option value="opt3">Tower Server</option>
                                                                                            <option value="opt4">Blade Server</option>
                                                                                        </select>
                                                                                    </div>
                                                                                </div>--%>

                                                             <%-- Pic Start--%>
                                                             <%--<div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="University-2" class="block">Product </label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                            <input required="required" type="file"  id="pic1" runat="server" />
                                                                                    </div>
                                                                                    
                                                                                </div>--%>
                                                            <%-- Pic end --%>
                                                             
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

