<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUpDistributer.aspx.cs" Inherits="SignUpDistributer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Glocali Channel || Reseller Registration </title>
    <!-- HTML5 Shim and Respond.js IE10 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 10]>
      <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
      <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
      <![endif]-->
      <!-- Meta -->
      <meta charset="utf-8">
      <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimal-ui">
      <meta http-equiv="X-UA-Compatible" content="IE=edge" />
      <meta name="description" content="Gradient Able Bootstrap admin template made using Bootstrap 4 and it has huge amount of ready made feature, UI components, pages which completely fulfills any dashboard needs." />
      <meta name="keywords" content="bootstrap, bootstrap admin template, admin theme, admin dashboard, dashboard template, admin template, responsive" />
      <meta name="author" content="Phoenixcoded" />
      <!-- Favicon icon -->

      <link rel="icon" href="/files/assets/images/favicon.ico" type="image/x-icon">
      <!-- Google font-->     
      <link href="https://fonts.googleapis.com/css?family=Roboto:400,500" rel="stylesheet">
      <!-- Required Fremwork -->
      <link rel="stylesheet" type="text/css" href="/files/bower_components/bootstrap/css/bootstrap.min.css">
      <!-- waves.css -->
      <link rel="stylesheet" href="/files/assets/pages/waves/css/waves.min.css" type="text/css" media="all">
      <!-- themify-icons line icon -->
      <link rel="stylesheet" type="text/css" href="/files/assets/icon/themify-icons/themify-icons.css">
      <!-- ico font -->
      <link rel="stylesheet" type="text/css" href="/files/assets/icon/icofont/css/icofont.css">
      <!-- Stylesheets -->
      <link rel="stylesheet" href="/files/assets/pages/multi-step-sign-up/css/reset.min.css">
      <link rel="stylesheet" href="/files/assets/pages/multi-step-sign-up/css/style.css">
      <!-- Style.css -->
      <link rel="stylesheet" type="text/css" href="/files/assets/css/style.css">
     <!-- Switch component css -->
      <link rel="stylesheet" type="text/css" href="/files/bower_components/switchery/css/switchery.min.css">
     <script type="text/javascript">

         function SavePersonRecord() {


             var Companyname = $.trim($("[id*=txtname]").val());
             var city = $.trim($("[id*=slctcity]").val());
             var email = $("[id*=txtemail]").val();
             var phone = $("[id*=txtphone]").val();
             var address = $.trim($("[id*=txtaddress]").val());
             var postalcode = $.trim($("[id*=txtpostalcode]").val());
             var contactpersonname = $.trim($("[id*=txtcontactpersonname]").val());
             var contactpersonalemail = $.trim($("[id*=txtcontactpersonemail]").val());
             var contactpersonphone = $("[id*=txtcontactpersonphone]").val();
             var website = $.trim($("[id*=txtwebsite]").val());
             var companysize = $.trim($("[id*=slctcompanysize]").val());
             var companyrevenue = $.trim($("[id*=slctrevenue]").val());
             var selValue = $('input[name=radio]:checked').val();
             var patner = selValue;

             var fileUpload = $("#Upload").get(0);
             var files = fileUpload.files;
             var test = new FormData();
             for (var i = 0; i < files.length; i++) {
                 test.append(files[i].name, files[i]);
             }
             test.append("Companyname", JSON.stringify(Companyname));
             test.append("city", JSON.stringify(city));
             test.append("email", JSON.stringify(email));
             test.append("phone", JSON.stringify(phone));
             test.append("address", JSON.stringify(address));
             test.append("postalcode", JSON.stringify(postalcode));
             test.append("contactpersonname", JSON.stringify(contactpersonname));
             test.append("contactpersonalemail", JSON.stringify(contactpersonalemail));
             test.append("contactpersonphone", JSON.stringify(contactpersonphone));
             test.append("website", JSON.stringify(website));
             test.append("companysize", JSON.stringify(companysize));
             test.append("companyrevenue", JSON.stringify(companyrevenue));
             test.append("patner", JSON.stringify(patner));

             var Messege = "";

             if (Companyname == '') {
                 Messege = "Can not Blank Name";
             }

             if (Companyname == '') {
                 Messege += "Can not Blank Last Name";
             }

             if (Messege.length == 0) {



                 $.ajax({
                     url: "RegisterHandler.ashx",
                     type: "POST",
                     contentType: false,
                     processData: false,
                     data: test,
                     dataType: "json",
                     success: function (result) {
                         alert(result);
                     },
                     error: function (err) {
                         alert(err.statusText);
                     }
                 });


             }
         }

    </script>
</head>
<body themebg-pattern="theme1">
    <!-- Pre-loader start --> 
      <div class="theme-loader">     
      <div class="loader-track">         
          <div class="preloader-wrapper active">            
           <div class="spinner-layer spinner-blue">                
               <div class="circle-clipper left">                    
                <div class="circle"></div>                
                </div>                
               <div class="gap-patch">                    
                <div class="circle"></div>                 
               </div>                 
              <div class="circle-clipper right">                    
                <div class="circle"></div>                 
               </div>             
              </div>             
          <div class="spinner-layer spinner-red">                
               <div class="circle-clipper left">                     
              <div class="circle"></div>                 
              </div>                 
              <div class="gap-patch">                    
               <div class="circle"></div>                 
              </div>                 
              <div class="circle-clipper right">                    
               <div class="circle"></div>                 
              </div>             
              </div>                  
          <div class="spinner-layer spinner-yellow">                
               <div class="circle-clipper left">                   
                <div class="circle"></div>              
                 </div>                 
              <div class="gap-patch">                    
               <div class="circle"></div>                 
              </div>                 
              <div class="circle-clipper right">             
                      <div class="circle"></div>              
                 </div>         
                  </div>               
             <div class="spinner-layer spinner-green">     
                          <div class="circle-clipper left">    
                                  <div class="circle"></div>    
                              </div>                 
              <div class="gap-patch">                
                      <div class="circle"></div>            
                      </div>               
                <div class="circle-clipper right">         
                             <div class="circle"></div>      
                            </div>           
                </div>       
            </div>    
           </div>
       </div> <!-- Pre-loader end -->
    <form id="msform"  runat="server">
        <!-- progressbar -->
        <ul id="progressbar">
            <li class="active">Welcome</li>
            <li>Contact Information</li>
            <li>Company Information</li>
        </ul>
        <!-- fieldsets -->
       <fieldset>                 
            <img class="logo" src="/files/assets/images/5.png" alt="logo.png">
            <h2 class="fs-title">Registration</h2>
            <h3 class="fs-subtitle">Let’s have a new beginning. Sign up for new</h3>
            <div class="input-group">
                <input id="txtname" ClientIDMode="Static"  type="text" class="form-control" name="username" placeholder="Company Name" />
            </div>
            <div class="input-group">
                <input id="txtemail" ClientIDMode="Static"  type="text" class="form-control" name="email" placeholder="Email" />
            </div>
            <div class="input-group">
                <input id="txtphone" ClientIDMode="Static"  type="text" class="form-control" name="phone" placeholder="Phone" />
            </div>
           
            <div class="input-group">
                <textarea id="txtaddress" ClientIDMode="Static" name="address" class="form-control" placeholder="Address"></textarea>
            </div>
            <div class="input-group">
                <input id="txtpostalcode" ClientIDMode="Static"  type="text" class="form-control" placeholder="Postal code" />
            </div>
            <div class="input-group">
                <select id="slctcity" ClientIDMode="Static" runat="server" class="form-control" >
                    <option value="0"> Select City</option>
                    <option value="1">Karachi</option>
                    <option value="2">Lahore</option>
                    <option value="3">Islamabad</option>
                </select>
            </div>
            <button type="button" name="next" class="btn btn-primary next" value="Next">Next</button>
        </fieldset>




         <fieldset class="">
            <img class="logo" src="/files/assets/images/5.png" alt="logo.png">
            <h2 class="fs-title">Contact Information</h2>
            <h3 class="fs-subtitle">Little bit about your contact person</h3>
            <div class="input-group">
                <input id="txtcontactpersonname" ClientIDMode="Static" type="text" class="form-control form-control-capitalize" name="username" placeholder="Contact Person Name" />
            </div>
            <div class="input-group">
                <input id="txtcontactpersonemail" ClientIDMode="Static" type="text" class="form-control" name="email" placeholder="Contact Person Email" />
            </div>
            <div class="input-group">
                <input id="txtcontactpersonphone" ClientIDMode="Static" type="text" class="form-control" name="phone" placeholder="Contact Person Phone" />
            </div>
             <div class="input-group">
                <input id="txtwebsite" ClientIDMode="Static" type="text" class="form-control" name="url" placeholder="Website" />
            </div>
            <button type="button" name="previous" class="btn btn-inverse btn-outline-inverse previous" value="Previous">Previous</button>
            <button type="button" name="next" class="btn btn-primary next" value="Next">Next</button>
        </fieldset>


               <fieldset>

            <img class="logo" src="../files/assets/images/5.png" alt="logo.png">
            <h2 class="fs-title">Company Information</h2>
            <h3 class="fs-subtitle">And something about company</h3>
            <div class="input-group">
                <input id="Upload" type="file" name="files[2]" id="filer_input_single" class="form-control" ClientIDMode="Static"  multiple="multiple">
                
            </div>
            
            
            <div class="input-group">
                <select id="slctcompanysize" ClientIDMode="Static" class="form-control" >
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
            <div class="input-group">
                <select id="slctrevenue" ClientIDMode="Static" class="form-control" >
                     <option value="0">Select Anunual Revenue</option>
                                                                                            <option value="$1,000 to $5,000"> $1,000 to $5,000</option>
                                                                                            <option value="$5,000 to $10,000">$5,000 to $10,000</option>
                                                                                            <option value="$10,000 to $50 billion">$10,000 to $50 billion</option>
                                                                                            <option value="Above $50 billion">Above $50 billion</option>
                </select>
            </div>

            <div class="input-group">
                <label>
                                        <span class="text-inverse m-t-25">Select Your Role</span>
                 </label>
                   <div class="row m-t-10 text-left">
                                    <div class="col-md-12 form-radio fade-in-primary">
                                        
                                        <div class="radio radio-inline">
                                             
                                              <label>
                                                  <input type="radio" name="radio" value="5" ClientIDMode="Static" disabled="disabled">
                                                      <i class="helper"></i>Vendor
                                              </label>
                                          </div>
                                        <div class="radio radio-inline">
                                              <label>
                                                  <input type="radio" name="radio" value="6" ClientIDMode="Static" checked="checked">
                                                      <i class="helper"></i>Distributer
                                                  </label>
                                          </div>
                                        
                                          <div class="radio radio-inline">
                                              <label>
                                                  <input type="radio" name="radio" value="7" ClientIDMode="Static" disabled="disabled">
                                                      <i class="helper"></i>Reseller
                                                  </label>
                                          </div>
                                        
                                    </div>
               </div>
            </div>



            <div class="input-group">
                   <div class="row m-t-10 text-left">
                                    <div class="col-md-12">
                                        <div class="checkbox-fade fade-in-primary">
                                            <label>
                                                <input type="checkbox" value="">
                                                <span class="cr"><i class="cr-icon icofont icofont-ui-check txt-primary"></i></span>
                                                <span class="text-inverse">I read and accept <a href="#">Terms &amp; Conditions.</a></span>
                                            </label>
                                        </div>
                                    </div>
               </div>
            </div>
            
            <button type="button" name="previous" class="btn btn-inverse btn-outline-inverse previous" value="Previous">Previous</button>
            <button type="button" name="next" class="btn btn-primary" value="Submit" onclick="SavePersonRecord(); return false">Submit</button>
        </fieldset>
    </form>

<script type="text/javascript" src="/files/bower_components/jquery/js/jquery.min.js"></script>
<script type="text/javascript" src="/files/bower_components/jquery-ui/js/jquery-ui.min.js"></script>
<script type="text/javascript" src="/files/bower_components/popper.js/js/popper.min.js"></script>
<script type="text/javascript" src="/files/bower_components/bootstrap/js/bootstrap.min.js"></script>
<!-- waves js -->
<script src="/files/assets/pages/waves/js/waves.min.js"></script>
<!-- jquery slimscroll js -->
<script type="text/javascript" src="/files/bower_components/jquery-slimscroll/js/jquery.slimscroll.js"></script>
<!-- modernizr js -->
<script type="text/javascript" src="/files/bower_components/modernizr/js/modernizr.js"></script>
<script type="text/javascript" src="/files/bower_components/modernizr/js/css-scrollbars.js"></script>

<script src='http://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js'></script>
<script src="/files/assets/pages/multi-step-sign-up/js/main.js"></script>
<!-- i18next.min.js -->
<script type="text/javascript" src="/files/bower_components/i18next/js/i18next.min.js"></script>
<script type="text/javascript" src="/files/bower_components/i18next-xhr-backend/js/i18nextXHRBackend.min.js"></script>
<script type="text/javascript" src="/files/bower_components/i18next-browser-languagedetector/js/i18nextBrowserLanguageDetector.min.js"></script>
<script type="text/javascript" src="/files/bower_components/jquery-i18next/js/jquery-i18next.min.js"></script>
<script type="text/javascript" src="/files/assets/js/common-pages.js"></script>

<!-- Switch component js -->
<script type="text/javascript" src="/files/bower_components/switchery/js/switchery.min.js"></script>
<script type="text/javascript" src="/files/assets/pages/advance-elements/swithces.js"></script>
</body>
</html>
