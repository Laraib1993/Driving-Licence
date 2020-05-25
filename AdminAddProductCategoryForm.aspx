<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAddProductCategoryForm.aspx.cs" Inherits="AdminAddProductCategoryForm" %>

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
                                            <h5 class="m-b-10">New ID Inword Form</h5>
                                            <p class="m-b-0">ID will be add by admin only</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddProductCategoryForm.aspx">New ID Sheet</a>
                                            </li>
                                             <li class="breadcrumb-item"><a href="AdminAddProductCategoryForm.aspx">Form</a>
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
                                                        <h5>Add New ID Inword</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat ="server">

                                                             <div class="form-group row">
                                                                   <div class="col-md-4 col-lg-2">
                                                                       <label for="userName-1" class="block">Select Inword</label>
                                                                   </div>
                                                                   <div class="col-md-8 col-lg-10">
                                                                       <asp:DropDownList ID="slctinword" runat="server" name="select" class="form-control form-control-primary"></asp:DropDownList>
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
                                                                <label class="col-sm-2 col-form-label">No Of New ID's</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtNoOfnewIDs" runat="server" type="text" class="form-control" name="name" placeholder="No Of New ID's" visible="False">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">No Of Same ID's</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtSameid" runat="server" type="text" class="form-control" name="name" placeholder="No Of Same ID's" visible="False">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>--%>

                                                            <%--<div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">No Of Modification ID's</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtnoofModificationid" runat="server" type="text" class="form-control" name="name" placeholder="No Of Modification ID's" visible="False">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Description</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtdescription" runat="server" type="text" class="form-control" name="name" placeholder="Description" visible="False">
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

                                                             <div class="form-group row">
                                                                  <div class="col-md-4 col-lg-2">
                                                                        <label for="userName-1" class="block">Discription</label>
                                                                  </div>
                                                                  <div class="col-md-8 col-lg-10">
                                                                        <textarea id="txtDiscription" runat="server" class="form-control max-textarea form-control-capitalize required" maxlength="255" rows="4" placeholder="Type your Discription here (Only 255 words here)"></textarea>
                                                                                      
                                                                  </div>
                                                              </div>
                                                           



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
                                                                    <asp:Button ID="btnScan" runat="server" Text="Scan" class="btn btn-primary m-b-0" OnClick="btnsubmit_Click" />
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

