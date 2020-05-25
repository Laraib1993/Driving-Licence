<%@ Page Title="" Language="C#" MasterPageFile="~/Distributer.master" AutoEventWireup="true" CodeFile="DistributerAddProductForm.aspx.cs" Inherits="DistributerAddProductForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Product Form</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="pcoded-content">   
    
    
     <!-- Page-header start -->
                        <div class="page-header">
                            <div class="page-block">
                                <div class="row align-items-center">
                                    <div class="col-md-8">
                                        <div class="page-header-title">
                                            <h5 class="m-b-10">Product Form</h5>
                                            <p class="m-b-0">Add Product By Yourselft</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="#"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="ResellerAddProductForm.aspx">Product</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="ResellerAddProductForm.aspx">Form</a>
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
                                                        <h5>Add Product</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat="server" >


                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="userName-1" class="block">Product</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <asp:DropDownList ID="slcteditproduct" runat="server" AutoPostBack="true" OnSelectedIndexChanged="slcteditproduct_SelectedIndexChanged" name="select" class="form-control form-control-primary" required="required"></asp:DropDownList>
                                                                                     
                                                                                    </div>
                                                                                </div>
                                                                                 

                                                            <div class="form-group row">
                                                                <div class="col-md-4 col-lg-2">
                                                                                        <label for="userName-1" class="block"></label>
                                                                </div>
                                                                    <div class="col-md-8 col-lg-10">
                                                                <div class="grid">
                                                                    <figure class="effect-ming">
                                                                        <img id="imgprodA" runat="server" src="/files/assets/images/light-box/l2.jpg" alt="img09" />
                                                                        <figcaption>
                                                                           <h2 id="ProductNameA" runat="server"><span>Product Name</span></h2>
                                                                            
                                                                            <p><strong id="VendornameA" runat="server">Vendor Name</strong> </p>
                                                                           <p id="DetailA" runat="server">Ming sits in the corner the whole day. She's into crochet</p>
                                                                        </figcaption>
                                                                    </figure>
                                                                    <figure class="effect-ming">
                                                                        <img id="imgprodB" runat="server" src="../files/assets/images/light-box/l2.jpg" alt="img08" />
                                                                        <figcaption>
                                                                            <h2 id="ProductNameB" runat="server"><span>WINDOWS 10</span></h2>
                                                                            
                                                                            <p><strong id="VendornameB" runat="server">Microsoft</strong> </p>
                                                                           <p id="DetailB" runat="server">Ming sits in the corner the whole day. She's into crochet</p>
                                                                        </figcaption>
                                                                    </figure>
                                                                     <figure class="effect-ming">
                                                                        <img id="imgprodC" runat="server" src="../files/assets/images/light-box/l2.jpg" alt="img08" />
                                                                        <figcaption>
                                                                           <h2><span id="ProductNameC" runat="server">WINDOWS 10</span></h2>
                                                                            
                                                                            <p><strong id="VendorNameC" runat="server">Microsoft</strong> </p>
                                                                           <p id="DetailC" runat="server">Ming sits in the corner the whole day. She's into crochet</p>
                                                                        </figcaption>
                                                                    </figure>
                                                                </div>
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

