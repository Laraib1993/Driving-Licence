<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAddResellerForm.aspx.cs" Inherits="AdminAddResellerForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <title>Admin || Add Reseller Form</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="pcoded-content">   
    
                 <!-- Page-header start -->
                        <div class="page-header">
                            <div class="page-block">
                                <div class="row align-items-center">
                                    <div class="col-md-8">
                                        <div class="page-header-title">
                                            <h5 class="m-b-10">Reseller Form</h5>
                                            <p class="m-b-0">Add Reseller By Yourselft</p>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <ul class="breadcrumb">
                                            <li class="breadcrumb-item">
                                                <a href="Dashboard.aspx"> <i class="fa fa-home"></i>Home</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddResellerForm.aspx">Reseller</a>
                                            </li>
                                            <li class="breadcrumb-item"><a href="AdminAddResellerForm.aspx">Form</a>
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
                                                <!-- Form wizard with validation card start -->
                                                <div class="card">
                                                    <div class="card-header">
                                                        <h5>Reseller Form</h5>
                                                        <span>Please enter <code>Valid</code>  <code>&lt;Information&gt;</code> otherwise your data will not be submitted</span>
                                                    </div>
                                                    <div class="card-block">
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div id="wizard">
                                                                    <section >
                                                                        <form  class="reseller-forms" runat="server" novalidate="novalidate">

                                                                           





                                                                              <h3> Welcome </h3>
                                                                            <fieldset>

                                                                                    <div class="card">
                                                    
                                                                                         

                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="userName-2" class="block">Name</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                         <input id="txtpatnername" ClientIDMode="Static" runat="server" type="text" class="form-control form-control-capitalize required thresold-i" placeholder="Type your name here (Only 50 words here)" maxlength="50">
                                                                                    </div>
                                                                                </div>
                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="userName-1" class="block">Address</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <textarea id="txtaddress" ClientIDMode="Static" runat="server" class="form-control max-textarea form-control-capitalize required" maxlength="255" rows="4" placeholder="Type your Address here (Only 255 words here)"></textarea>
                                                                                      
                                                                                    </div>
                                                                                </div>
                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="email-2" class="block">Email</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input id="txtemail" ClientIDMode="Static" name="email" type="email" class="required form-control thresold-i" placeholder="Type your email here (Only 50 words here)" maxlength="50">
                                                                                    </div>
                                                                                </div>
                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="phone-2" class="block">Phone</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input id="txtphone" ClientIDMode="Static" name="phone" type="number" class="form-control required phone thresold-i" placeholder="Type your phone number here (Only 11 words here)" maxlength="11">
                                                                                    </div>
                                                                                </div>
                                                                            </fieldset>


                                                                            <h3> Contact Information </h3>
                                                                            <fieldset>
                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="name-2" class="block">Contact Person Name</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input id="txtcontactpersonname" ClientIDMode="Static" name="name" type="text" class="form-control form-control-capitalize  thresold-i" placeholder="Type contact preson name here (Only 50 words here)" maxlength="50">
                                                                                    </div>
                                                                                </div>
                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="email-2" class="block">Contact Person Email</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input id="txtcontactpersonemail" ClientIDMode="Static" name="email" type="email" class=" form-control thresold-i" placeholder="Type your email here (Only 50 words here)" maxlength="50">
                                                                                    </div>
                                                                                </div>
                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="phone-2" class="block">Contact Person Phone</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input id="txtcontactpersonphone" ClientIDMode="Static" name="phone" type="number" class="form-control phone thresold-i" placeholder="Type your email here (Only 11 words here)" maxlength="11">
                                                                                    </div>
                                                                                </div>
                                                                            </fieldset>
                                                                            
                                                                            
                                                                            
                                                                            <h3>Comapany Information</h3>
                                                                            <fieldset>
                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="University-2" class="block">Logo</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input type="file" id="Upload">
                                                                                        
                                                                                            
                                                                                    </div>
                                                                                </div>
                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="Country-2" class="block">Website</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input id="txtwebsite" ClientIDMode="Static"  type="url" class="form-control required">
                                                                                    </div>
                                                                                </div>
                                                                                <div class="form-group row">
                                                                                  <div class="col-md-4 col-lg-2">Company Size</div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <select id="slctcompsize" ClientIDMode="Static" class="form-control required">
                                                                                            <option value="0">Select Number of Employees</option>
                                                                                            <option value="1 to 10 Employees">1 to 10 Employees</option>
                                                                                            <option value="10 to 30 Employees">10 to 30 Employees</option>
                                                                                            <option value="30 to 50 Employees">30 to 50 Employees</option>
                                                                                            <option value="50 to 100 Employees">50 to 100 Employees</option>
                                                                                            <option value="100 to 200 Employees">100 to 200 Employees</option>
                                                                                            <option value="200 to 500 Employees">200 to 500 Employees</option>
                                                                                            <option value="500 to 1000 Employees">500 to 1000 Employees</option>
                                                                                             <option value="1000 to 10,000 Employees">1000 to 10,000 Employees</option>
                                                                                            <option value="10,000 to 50,000 Employees">10,000 to 50,000 Employees</option>
                                                                                            <option value="Up to 100,000 Employees">Up to 100,000 Employees</option>
                                                                                        </select>
                                                                                    </div>
                                                                                </div>
                                                                                <div class="form-group row">
                                                                                  <div class="col-md-4 col-lg-2">Annual Revenue</div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <select id="slctrevenue" ClientIDMode="Static" class="form-control required">
                                                                                            <option value="0">Select Anunual Revenue</option>
                                                                                            <option value="$1,000 to $5,000"> $1,000 to $5,000</option>
                                                                                            <option value="$5,000 to $10,000">$5,000 to $10,000</option>
                                                                                            <option value="$10,000 to $50 billion">$10,000 to $50 billion</option>
                                                                                            <option value="Above $50 billion">Above $50 billion</option>
                                                                                        </select>
                                                                                       
                                                                                    </div>
                                                                                </div>
                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="Country-2" class="block">Postal Code</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <input id="txtpostalcode" ClientIDMode="Static" name="Country" type="text" class="form-control required">
                                                                                    </div>
                                                                                </div>
                                                                               <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">City</div>
                                                                                    <div class="col-md-8 col-lg-10">
                                                                                        <select id="txtcity" ClientIDMode="Static" runat="server" class="form-control required">
                                                                                            <option value="1">Karachi</option>
                                                                                            <option value="2">Lahore</option>
                                                                                        </select>
                                                                                    </div>
                                                                                </div>
                                                                              
                                                                            </fieldset>
                                                                            











                                                                            
                                                                            <h3>Business Information</h3>
                                                                            <fieldset>


                                                                                <div class="form-group row">
                                                                                    <div class="col-md-4 col-lg-2">
                                                                                        <label for="University-2" class="block">Patner Type</label>
                                                                                    </div>
                                                                                    <div class="col-md-8 col-lg-10 form-radio m-b-30">
                                                                                          
                                                                                
                                                                                        <div class="radio radiofill radio-default radio-inline"></div>
                                                                                <div class="radio radiofill radio-default radio-inline"></div>
                                                                                <div class="radio radiofill radio-success radio-inline">
                                                                                    <label>
                                                                                        <input type="radio" name="radio" value="5" ClientIDMode="Static" disabled="disabled">
                                                                                        <i class="helper"></i>I am Vendor
                                                                                    </label>
                                                                                </div>
                                                                                <div class="radio radiofill radio-default radio-inline"></div>
                                                                                <div class="radio radiofill radio-default radio-inline"></div>
                                                                                <div class="radio radiofill radio-info radio-inline">
                                                                                    <label>
                                                                                        <input type="radio" name="radio" value="6" ClientIDMode="Static" disabled="disabled" >
                                                                                        <i class="helper"></i>I am Distributor
                                                                                    </label>
                                                                                </div>
                                                                                <div class="radio radiofill radio-default radio-inline"></div>
                                                                                <div class="radio radiofill radio-default radio-inline"></div>
                                                                                 <div class="radio radiofill radio-warning radio-inline">
                                                                                    <label>
                                                                                        <input type="radio" name="radio" value="7" ClientIDMode="Static" checked="checked">
                                                                                        <i class="helper"></i>I am Reseller
                                                                                    </label>
                                                                                </div>
                                                                                <span class="messages"></span>
                                                                                            
                                                                                    </div>
                                                                                </div>
                                                                          </fieldset>
                                                        

                                                                             </form> 
                                                                         </section>  
                                                                                   </div>


                                                                         
                                                                        
                                                                   
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <!-- Form wizard with validation card end -->

                                       
                                                </div><!-- col-md-12 End -->
                                            </div>  <!-- Row End -->
                                        </div>
                                        <!-- Page body end -->
                                    </div>
                                </div>
                
                            </div>
</asp:Content>

