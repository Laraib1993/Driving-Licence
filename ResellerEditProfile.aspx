<%@ Page Title="" Language="C#" MasterPageFile="~/Reseller.master" AutoEventWireup="true" CodeFile="ResellerEditProfile.aspx.cs" Inherits="ResellerEditProfile" %>

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
                                            <h5 class="m-b-10">User Profile</h5>
                                            <p class="m-b-0">Lorem Ipsum is simply dummy text of the printing</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="index.html"> <i class="fa fa-home"></i> </a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="#!">User Profile</a>
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
                                                        <img class="profile-bg-img img-fluid" src="../files/assets/images/user-profile/bg-img1.jpg" alt="bg-img">
                                                        <div class="card-block user-info">
                                                            <div class="col-md-12">
                                                                <div class="media-left">
                                                                    <a href="#" class="profile-image">
                                                                        <img class="user-img img-radius" src="../files/assets/images/user-profile/user-img.jpg" alt="user-img">
                                                                    </a>
                                                                </div>
                                                                <div class="media-body row">
                                                                    <div class="col-lg-12">
                                                                        <div class="user-title">
                                                                            <h2>Josephin Villa</h2>
                                                                            <span class="text-white">Web designer</span>
                                                                        </div>
                                                                    </div>
                                                                    <div>
                                                                        <div class="pull-right cover-btn">
                                                                            <button type="button" class="btn btn-primary m-r-10 m-b-10"><i class="icofont icofont-plus"></i> Follow</button>
                                                                            <button type="button" class="btn btn-primary m-b-10"><i class="icofont icofont-ui-messaging"></i> Message</button>
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
                                                            <a class="nav-link active" data-toggle="tab" href="#personal" role="tab">Personal Info</a>
                                                            <div class="slide"></div>
                                                        </li>
                                                        <li class="nav-item">
                                                            <a class="nav-link" data-toggle="tab" href="#binfo" role="tab">Contact Info</a>
                                                            <div class="slide"></div>
                                                        </li>
                                                        <li class="nav-item">
                                                            <a class="nav-link" data-toggle="tab" href="#contacts" role="tab">Company Info</a>
                                                            <div class="slide"></div>
                                                        </li>
                                                        <li class="nav-item">
                                                            <a class="nav-link" data-toggle="tab" href="#review" role="tab">Buisness Info</a>
                                                            <div class="slide"></div>
                                                        </li>
                                                    </ul>
                                                </div>
                                                <!-- tab header end -->
                                                <!-- tab content start -->
                                                <div class="tab-content">
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
                                                                                                        <td>Josephine Villa</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Gender</th>
                                                                                                        <td>Female</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Birth Date</th>
                                                                                                        <td>October 25th, 1990</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Marital Status</th>
                                                                                                        <td>Single</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Location</th>
                                                                                                        <td>New York, USA</td>
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
                                                                                                        <th scope="row">Email</th>
                                                                                                        <td><a href="#!">Demo@example.com</a></td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Mobile Number</th>
                                                                                                        <td>(0123) - 4567891</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Twitter</th>
                                                                                                        <td>@xyz</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Skype</th>
                                                                                                        <td>demo.skype</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Website</th>
                                                                                                        <td><a href="#!">www.demo.com</a></td>
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
                                                                                                <input type="text" name="footer-email" class="form-control" required="">
                                                                                                <span class="form-bar"></span>
                                                                                                <label class="float-label">Full Name</label>
                                                                                            </div>
                                                                                        </div>
                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-mars-double"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                              <div class="form-radio">
                                                                                            <div class="group-add-on">
                                                                                                <div class="radio radiofill radio-inline">
                                                                                                    <label>
                                                                                                        <input type="radio" name="radio" checked><i class="helper"></i> Male
                                                                                                    </label>
                                                                                                </div>
                                                                                                <div class="radio radiofill radio-inline">
                                                                                                    <label>
                                                                                                        <input type="radio" name="radio"><i class="helper"></i> Female
                                                                                                    </label>
                                                                                                </div>
                                                                                            </div>
                                                                                        </div>
                                                                                            </div>
                                                                                        </div>

                                                                                    
                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-birthday-cake"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                                <input type="text" name="footer-email" class="form-control" required="">
                                                                                                <span class="form-bar"></span>
                                                                                                <label class="float-label">Select Your Birth Date</label>
                                                                                            </div>
                                                                                        </div>


                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-heart"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                             <select id="hello-single" class="form-control">
                                                                                                <option value="">---- Marital Status ----</option>
                                                                                                <option value="married">Married</option>
                                                                                                <option value="unmarried">Unmarried</option>
                                                                                            </select>
                                                                                            <span class="form-bar"></span>

                                                                                        </div>
                                                                                    </div>



                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-location-pin"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Address</label>
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
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Mobile Number</label>
                                                                                        </div>
                                                                                    </div>


                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-social-twitter"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Twitter Id</label>
                                                                                        </div>
                                                                                    </div>



                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-social-skype"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Skype Id</label>
                                                                                        </div>
                                                                                    </div>




                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-earth"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">website</label>
                                                                                        </div>
                                                                                    </div>



                                                                                </div>
                                                                                <!-- end of table col-lg-6 -->
                                                                            </div>
                                                                            <!-- end of row -->
                                                                            <div class="text-center">
                                                                                <a href="#!" class="btn btn-primary waves-effect waves-light m-r-20">Save</a>
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
                                                    <div class="tab-pane" id="binfo" role="tabpanel">
                                                        <!-- info card start -->
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
                                                                                                        <td>Josephine Villa</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Gender</th>
                                                                                                        <td>Female</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Birth Date</th>
                                                                                                        <td>October 25th, 1990</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Marital Status</th>
                                                                                                        <td>Single</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Location</th>
                                                                                                        <td>New York, USA</td>
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
                                                                                                        <th scope="row">Email</th>
                                                                                                        <td><a href="#!">Demo@example.com</a></td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Mobile Number</th>
                                                                                                        <td>(0123) - 4567891</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Twitter</th>
                                                                                                        <td>@xyz</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Skype</th>
                                                                                                        <td>demo.skype</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Website</th>
                                                                                                        <td><a href="#!">www.demo.com</a></td>
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
                                                                                                <input type="text" name="footer-email" class="form-control" required="">
                                                                                                <span class="form-bar"></span>
                                                                                                <label class="float-label">Full Name</label>
                                                                                            </div>
                                                                                        </div>
                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-mars-double"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                              <div class="form-radio">
                                                                                            <div class="group-add-on">
                                                                                                <div class="radio radiofill radio-inline">
                                                                                                    <label>
                                                                                                        <input type="radio" name="radio" checked><i class="helper"></i> Male
                                                                                                    </label>
                                                                                                </div>
                                                                                                <div class="radio radiofill radio-inline">
                                                                                                    <label>
                                                                                                        <input type="radio" name="radio"><i class="helper"></i> Female
                                                                                                    </label>
                                                                                                </div>
                                                                                            </div>
                                                                                        </div>
                                                                                            </div>
                                                                                        </div>

                                                                                    
                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-birthday-cake"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                                <input type="text" name="footer-email" class="form-control" required="">
                                                                                                <span class="form-bar"></span>
                                                                                                <label class="float-label">Select Your Birth Date</label>
                                                                                            </div>
                                                                                        </div>


                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-heart"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                             <select id="hello-single" class="form-control">
                                                                                                <option value="">---- Marital Status ----</option>
                                                                                                <option value="married">Married</option>
                                                                                                <option value="unmarried">Unmarried</option>
                                                                                            </select>
                                                                                            <span class="form-bar"></span>

                                                                                        </div>
                                                                                    </div>



                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-location-pin"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Address</label>
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
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Mobile Number</label>
                                                                                        </div>
                                                                                    </div>


                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-social-twitter"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Twitter Id</label>
                                                                                        </div>
                                                                                    </div>



                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-social-skype"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Skype Id</label>
                                                                                        </div>
                                                                                    </div>




                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-earth"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">website</label>
                                                                                        </div>
                                                                                    </div>



                                                                                </div>
                                                                                <!-- end of table col-lg-6 -->
                                                                            </div>
                                                                            <!-- end of row -->
                                                                            <div class="text-center">
                                                                                <a href="#!" class="btn btn-primary waves-effect waves-light m-r-20">Save</a>
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
                                                        <!-- info card end -->
                                                    </div>
                                                    <!-- tab pane info end -->
                                                    <!-- tab pane contact start -->
                                                    <div class="tab-pane" id="contacts" role="tabpanel">
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
                                                                                                        <td>Josephine Villa</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Gender</th>
                                                                                                        <td>Female</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Birth Date</th>
                                                                                                        <td>October 25th, 1990</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Marital Status</th>
                                                                                                        <td>Single</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Location</th>
                                                                                                        <td>New York, USA</td>
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
                                                                                                        <th scope="row">Email</th>
                                                                                                        <td><a href="#!">Demo@example.com</a></td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Mobile Number</th>
                                                                                                        <td>(0123) - 4567891</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Twitter</th>
                                                                                                        <td>@xyz</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Skype</th>
                                                                                                        <td>demo.skype</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Website</th>
                                                                                                        <td><a href="#!">www.demo.com</a></td>
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
                                                                                                <input type="text" name="footer-email" class="form-control" required="">
                                                                                                <span class="form-bar"></span>
                                                                                                <label class="float-label">Full Name</label>
                                                                                            </div>
                                                                                        </div>
                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-mars-double"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                              <div class="form-radio">
                                                                                            <div class="group-add-on">
                                                                                                <div class="radio radiofill radio-inline">
                                                                                                    <label>
                                                                                                        <input type="radio" name="radio" checked><i class="helper"></i> Male
                                                                                                    </label>
                                                                                                </div>
                                                                                                <div class="radio radiofill radio-inline">
                                                                                                    <label>
                                                                                                        <input type="radio" name="radio"><i class="helper"></i> Female
                                                                                                    </label>
                                                                                                </div>
                                                                                            </div>
                                                                                        </div>
                                                                                            </div>
                                                                                        </div>

                                                                                    
                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-birthday-cake"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                                <input type="text" name="footer-email" class="form-control" required="">
                                                                                                <span class="form-bar"></span>
                                                                                                <label class="float-label">Select Your Birth Date</label>
                                                                                            </div>
                                                                                        </div>


                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-heart"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                             <select id="hello-single" class="form-control">
                                                                                                <option value="">---- Marital Status ----</option>
                                                                                                <option value="married">Married</option>
                                                                                                <option value="unmarried">Unmarried</option>
                                                                                            </select>
                                                                                            <span class="form-bar"></span>

                                                                                        </div>
                                                                                    </div>



                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-location-pin"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Address</label>
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
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Mobile Number</label>
                                                                                        </div>
                                                                                    </div>


                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-social-twitter"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Twitter Id</label>
                                                                                        </div>
                                                                                    </div>



                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-social-skype"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Skype Id</label>
                                                                                        </div>
                                                                                    </div>




                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-earth"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">website</label>
                                                                                        </div>
                                                                                    </div>



                                                                                </div>
                                                                                <!-- end of table col-lg-6 -->
                                                                            </div>
                                                                            <!-- end of row -->
                                                                            <div class="text-center">
                                                                                <a href="#!" class="btn btn-primary waves-effect waves-light m-r-20">Save</a>
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
                                                    <!-- tab pane contact end -->
                                                    <div class="tab-pane" id="review" role="tabpanel">
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
                                                                                                        <td>Josephine Villa</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Gender</th>
                                                                                                        <td>Female</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Birth Date</th>
                                                                                                        <td>October 25th, 1990</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Marital Status</th>
                                                                                                        <td>Single</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Location</th>
                                                                                                        <td>New York, USA</td>
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
                                                                                                        <th scope="row">Email</th>
                                                                                                        <td><a href="#!">Demo@example.com</a></td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Mobile Number</th>
                                                                                                        <td>(0123) - 4567891</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Twitter</th>
                                                                                                        <td>@xyz</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Skype</th>
                                                                                                        <td>demo.skype</td>
                                                                                                    </tr>
                                                                                                    <tr>
                                                                                                        <th scope="row">Website</th>
                                                                                                        <td><a href="#!">www.demo.com</a></td>
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
                                                                                                <input type="text" name="footer-email" class="form-control" required="">
                                                                                                <span class="form-bar"></span>
                                                                                                <label class="float-label">Full Name</label>
                                                                                            </div>
                                                                                        </div>
                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-mars-double"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                              <div class="form-radio">
                                                                                            <div class="group-add-on">
                                                                                                <div class="radio radiofill radio-inline">
                                                                                                    <label>
                                                                                                        <input type="radio" name="radio" checked><i class="helper"></i> Male
                                                                                                    </label>
                                                                                                </div>
                                                                                                <div class="radio radiofill radio-inline">
                                                                                                    <label>
                                                                                                        <input type="radio" name="radio"><i class="helper"></i> Female
                                                                                                    </label>
                                                                                                </div>
                                                                                            </div>
                                                                                        </div>
                                                                                            </div>
                                                                                        </div>

                                                                                    
                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-birthday-cake"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                                <input type="text" name="footer-email" class="form-control" required="">
                                                                                                <span class="form-bar"></span>
                                                                                                <label class="float-label">Select Your Birth Date</label>
                                                                                            </div>
                                                                                        </div>


                                                                                        <div class="material-group">
                                                                                            <div class="material-addone">
                                                                                                <i class="fa fa-heart"></i>
                                                                                            </div>
                                                                                            <div class="form-group form-primary">
                                                                                             <select id="hello-single" class="form-control">
                                                                                                <option value="">---- Marital Status ----</option>
                                                                                                <option value="married">Married</option>
                                                                                                <option value="unmarried">Unmarried</option>
                                                                                            </select>
                                                                                            <span class="form-bar"></span>

                                                                                        </div>
                                                                                    </div>



                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-location-pin"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Address</label>
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
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Mobile Number</label>
                                                                                        </div>
                                                                                    </div>


                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-social-twitter"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Twitter Id</label>
                                                                                        </div>
                                                                                    </div>



                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-social-skype"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">Skype Id</label>
                                                                                        </div>
                                                                                    </div>




                                                                                    <div class="material-group">
                                                                                        <div class="material-addone">
                                                                                            <i class="icofont icofont-earth"></i>
                                                                                        </div>
                                                                                        <div class="form-group form-primary">
                                                                                            <input type="text" name="footer-email" class="form-control" required="">
                                                                                            <span class="form-bar"></span>
                                                                                            <label class="float-label">website</label>
                                                                                        </div>
                                                                                    </div>



                                                                                </div>
                                                                                <!-- end of table col-lg-6 -->
                                                                            </div>
                                                                            <!-- end of row -->
                                                                            <div class="text-center">
                                                                                <a href="#!" class="btn btn-primary waves-effect waves-light m-r-20">Save</a>
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

