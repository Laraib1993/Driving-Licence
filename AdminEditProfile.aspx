<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminEditProfile.aspx.cs" Inherits="AdminEditProfile" %>

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
                                            <h5 class="m-b-10"></h5>
                                            <p class="m-b-0"></p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="#!"></a>
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
                                    <!-- Page-body start -->
                                    <div class="page-body">
                                        <!--profile cover start-->
                                        <div class="row">
                                            <div class="col-lg-12">
                                                <div class="cover-profile">
                                                    <div class="profile-bg-img">
                                                        
                                                        <div class="card-block user-info">
                                                            <div class="col-md-12">
                                                                <div class="media-left">
                                                                    <a href="#" class="profile-image">
                                                                        <img runat="server" id="imgadminlogo" width="100" height="100" class="user-img img-radius" alt="user-img">
                                                                    </a>
                                                                </div>
                                                                <div class="media-body row">
                                                                    <div class="col-lg-12">
                                                                        <div class="user-title">
                                                                            <h2 id="hflname" runat="server">Josephin Villa</h2>
                                                                            <span class="text-white">Glocali Admin</span>
                                                                        </div>
                                                                    </div>
                                                                    <div>
                                                                        <div class="pull-right cover-btn">
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <!--profile cover end-->
                                        <div class="row">
                                            <div class="col-lg-12">
                                                <!-- tab header start -->
                                                <div class="tab-header card">
                                                    <ul class="nav nav-tabs md-tabs tab-timeline" role="tablist" id="mytab">
                                                        <li class="nav-item">
                                                            <a class="nav-link active" data-toggle="tab" href="#personal" role="tab">Profile Information</a>
                                                            <div class="slide"></div>
                                                        </li>
                                                    </ul>
                                                </div>
                                                <!-- tab header end -->
                                                <!-- tab content start -->
                                                <div class="tab-content">
                                                    <form runat="server">
                                                    <!-- tab panel personal start -->
                                                    <div class="tab-pane active" id="personal" role="tabpanel">
                                                        <!-- personal card start -->
                                                        <div class="card">
                                                            <div class="card-header">
                                                                <h5 class="card-header-text">About Me</h5>
                                                                <button id="edit-btn" type="button" class="btn btn-sm btn-primary waves-effect waves-light f-right">
                                                                    <i class="icofont icofont-edit"></i>
                                                                </button>
                                                            </div>
                                                            <div class="card-block">
                                                                <div class="view-info">
                                                                    <div class="row">
                                                                        <div class="col-lg-12">
                                                                            <div class="general-info">
                                                                                <div class="row">
                                                                                    <div class="col-lg-12 col-xl-6">
                                                                                        <div class="table-responsive">
                                                                                            <table class="table m-0">
                                                                                                <tbody>
                                                                                                    <tr>
                                                                                                        <th scope="row">Full Name</th>
                                                                                                        <td id="tbfulname" runat="server">Josephine Villa</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Gender</th>
                                                                                                        <td id="tbgender" runat="server">Female</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Birth Date</th>
                                                                                                        <td id="tbdate" runat="server">October 25th, 1990</td>
                                                                                                    </tr>
                                                                                                    
                                                                                                </tbody>
                                                                                            </table>
                                                                                        </div>
                                                                                    </div>
                                                                                    <!-- end of table col-lg-6 -->
                                                                                    <div class="col-lg-12 col-xl-6">
                                                                                        <div class="table-responsive">
                                                                                            <table class="table">
                                                                                                <tbody>
                                                                                                    <tr>
                                                                                                        <th scope="row">Marital Status</th>
                                                                                                        <td id="tbmartial" runat="server">Single</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Email</th>
                                                                                                        <td id="tbemail" runat="server"><a href="#!">Demo@example.com</a></td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Mobile Number</th>
                                                                                                        <td id="tbphone" runat="server">(0123) - 4567891</td>
                                                                                                    </tr>
                                                                                                </tbody>
                                                                                            </table>
                                                                                        </div>
                                                                                    </div>
                                                                                    <!-- end of table col-lg-6 -->
                                                                                </div>
                                                                                <!-- end of row -->
                                                                            </div>
                                                                            <!-- end of general info -->
                                                                        </div>
                                                                        <!-- end of col-lg-12 -->
                                                                    </div>
                                                                    <!-- end of row -->
                                                                </div>
                                                                <!-- end of view-info -->
                                                                <div class="edit-info">
                                                                    <div class="row">
                                                                        <div class="col-lg-12">
                                                                            <div class="general-info form-material">
                                                                                <div class="row">
                                                                                    <div class="col-lg-6 ">



                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="icofont icofont-user"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                                <input type="text" name="footer-email" id="txtfullname" runat="server" class="form-control" required="required">
                                                                                                <span class="form-bar"></span>
                                                                                                <label class="float-label">Full Name</label>
                                                                                            </div>
                                                                                        </div>
                                                                                       

                                                                                    
                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-birthday-cake"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                                <input id="txtbday" runat="server" type="text" name="footer-email" class="form-control dropper-default" placeholder="Select Your Birth Date" required="required" />
                                                                                                <span class="form-bar"></span>
                                                                                                <label class="float-label"></label>
                                                                                            </div>
                                                                                        </div>

                                                                                        <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-email"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input id="txtemail" runat="server" type="text" name="footer-email" class="form-control" required="required"/>
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Email</label>
                                                                                        </div>
                                                                                    </div>

                                                                                        
<div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-heart"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                             <select id="slctmartial" runat="server" class="form-control" required="required">
                                                                                                <option value="">Select Marital Status </option>
                                                                                                <option value="Married">Married</option>
                                                                                                <option value="Unmarried">Unmarried</option>
                                                                                            </select>
                                                                                            <span class="form-bar"></span>

                                                                                        </div>
                                                                                    </div>

                                                                                </div>


                                                                                <!-- end of table col-lg-6 -->
                                                                                <div class="col-lg-6">

                                                                                    
                                                                                        

                                                                                     

                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-mobile-phone"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input id="txtphonwe" runat="server" type="text" name="footer-email" class="form-control" required="required" />
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Mobile Number</label>
                                                                                        </div>
                                                                                    </div>


                                                                                  
                                                                                     <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-mars-double"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary form-radio">
                                                                                                <div class="form-group form-primary form-radio"></div>
                                                                                                <br />
                                                                                                <div class="radio  radio-inline">
                                                                                                    <label>
                                                                                                        <input type="radio" name="radio" value="Male" required="required"><i class="helper"></i> Male
                                                                                                    </label>
                                                                                                </div>
                                                                                                <div class="radio  radio-inline">
                                                                                                    <label>
                                                                                                        <input type="radio" name="radio" value="Female" required="required"><i class="helper"></i> Female
                                                                                                    </label>
                                                                                                </div>
                                                                                            </div>
                                                                                        </div>


                                                                                  


                                                                                     <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-picture"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="file" name="files[2]" id="flpupload" runat="server" class="form-control filer_input_single"  multiple="multiple">
                                                                                            
                                                                                            <span class="form-bar"></span>
                                                                                        </div>
                                                                                    </div>




                                                                                </div>
                                                                                <!-- end of table col-lg-6 -->

                                                                            </div>
                                                                            <!-- end of row -->
                                                                            <div class="text-center">
                                                                                <asp:Button ID="btnsubmit" runat="server" Text="Save" class="btn btn-primary waves-effect waves-light m-r-20" OnClick="btnsubmit_Click" />
                                                                                <a href="#!" id="edit-cancel" class="btn btn-default waves-effect">Cancel</a>
                                                                            </div>
                                                                        </div>
                                                                        <!-- end of edit info -->
                                                                    </div>
                                                                    <!-- end of col-lg-12 -->
                                                                </div>
                                                                <!-- end of row -->
                                                            </div>
                                                            <!-- end of edit-info -->
                                                        </div>
                                                        <!-- end of card-block -->
                                                    </div>
                                                    
                                                    </div>
                                                    <!-- tab pane personal end -->
                                                    <!-- tab pane info start -->
                                                
                                                    <!-- tab pane info end -->
                                                    </form>
                                                   
                                                        </div>
                                                        <!-- tab content end -->
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- Page-body end -->
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- Main body end -->
                            <div id="styleSelector">

                            </div>
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>

