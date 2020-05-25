<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminSignupSecond.aspx.cs" Inherits="AdminSignupSecond" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Signup Second Div</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="pcoded-content">   
    
    
     <!-- Page-header start -->
                        <div class="page-header">
                            <div class="page-block">
                                <div class="row align-items-center">
                                    <div class="col-md-8">
                                        <div class="page-header-title">
                                            <h5 class="m-b-10">Signup Second Div Form</h5>
                                            <p class="m-b-0">Signup Second Div will be updated by admin only</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i>Home </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminSignupSecond.aspx">Signup Second Div</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminSignupSecond.aspx">Form</a>
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
                                                        <h5>Signup Second Div</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <form runat ="server">
                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Heading</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtheading" runat="server" type="text" class="form-control form-control-bold form-control-capitalize" name="name" placeholder="Heading">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Text Area</label>
                                                                <div class="col-sm-10">
                                                                    <textarea id="txttext" runat="server" class="form-control max-textarea form-control-capitalize required" maxlength="200" rows="4" placeholder="Type your text here (Only 200 words here)"></textarea>
                                                                                      
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                            <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Button Text</label>
                                                                <div class="col-sm-10">
                                                                    <input id="txtbtntext" runat="server" type="text" class="form-control form-control-bold form-control-capitalize" name="name" placeholder="Button Text e.g Learn more ">
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>


                                                               <div class="form-group row">
                                                                <label class="col-sm-2 col-form-label">Upload pic</label>
                                                                <div class="col-sm-10">
                                                                    <asp:FileUpload ID="flppic" runat="server" class="form-control" />
                                                                    <span class="messages"></span>
                                                                </div>
                                                            </div>

                                                         

                                                            <div class="form-group row">
                                                                <label class="col-sm-2"></label>
                                                                <div class="col-sm-10">
                                                                    <asp:Button ID="btnsubmit" class="btn btn-primary m-b-0 btn-upload" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
                                                                   
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

