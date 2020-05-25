<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminEditProductCategoryForm.aspx.cs" Inherits="AdminEditProductCategoryForm" %>

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
                                            <h5 class="m-b-10">Product Category Form</h5>
                                            <p class="m-b-0">Edit Product Category will be add by admin only</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminEditProductCategoryForm.aspx">Product Category</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminEditProductCategoryForm.aspx">Form</a>
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
                                                        <h5>Edit Product Category</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat="server">
                                                              <div class="form-group row">
                                                                <div class="col-sm-2 col-form-label">Select Product Category</div>
                                                                     <div class="col-md-8 col-lg-10">
                                                                         <asp:DropDownList ID="slcteditrpoductcategory" OnSelectedIndexChanged="slcteditrpoductcategory_SelectedIndexChanged" AutoPostBack="true" runat="server" class="form-control required"></asp:DropDownList>
                                                                        
                                                                     </div>
                                                            </div>
                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Category Name</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtproductcategory" runat="server" type="text" class="form-control" name="name" placeholder="Category Name">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>
                                                             <div class="form-group row">
                                                                <div class="col-sm-2 col-form-label">Select Product Category</div>
                                                                     <div class="col-md-8 col-lg-10">
                                                                         <select id="slctservices" runat="server" name="select" class="form-control form-control-primary" required="required">
                                                                        <option value="opt1">Select Services</option>
                                                                        <option value="opt2">Cloud</option>
                                                                        <option value="opt3">Machine Learning</option>
                                                                        </select>
                                                                     </div>
                                                            </div>

                                                             <%-- Pic Start--%>

                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="University-2" class="block">Product </label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                            <input required="required" type="file"  id="pic1" runat="server" />
                                                                                    </div>
                                                                                    
                                                                                </div>


                                                           <%-- Pic end --%>

                                                            <div class="form-group row">
                                                                <label class="col-sm-2"></label>
                                                                <div class="col-sm-10">

                                                                        <asp:Button ID="btnsubmit" runat="server" Text="Submit" class="btn btn-primary m-b-0" OnClick="btnsubmit_Click" /></button>
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

