<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

   <%-- <title>Glocali Chanl</title>
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
      <!-- Font Awesome -->
      <link rel="stylesheet" type="text/css" href="/files/assets/icon/font-awesome/css/font-awesome.min.css">
      <!-- Style.css -->
      <link rel="stylesheet" type="text/css" href="/files/assets/css/style.css">
      <link rel="stylesheet" type="text/css" href="/files/assets/css/jquery.mCustomScrollbar.css">--%>

     <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        
        <title>Inword Management System(KMC)</title>
        <meta name="description" content="#" />
        <meta name="author" content="" />
        <meta name="keywords" content="" />
        <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" />

        <!-- FAVICON -->
        <link rel="shortcut icon" href="favicon.ico" type="image/x-icon" />
        
        <!-- STYLESHEETS -->
        <link rel="stylesheet" type="text/css" href="css2/bootstrap.css" />
        <link rel="stylesheet" type="text/css" href="css2/style.css" />
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.2.0/css/all.css" integrity="sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ" crossorigin="anonymous">

        <!-- Google Fonts -->
        <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700|Roboto:400,900" rel="stylesheet">
      



</head>


    <body>
        <!-- Login -->
        <section class="container">
            <div class="login-box">
                <form runat="server">
                    <h1>LOGIN</h1>
                    <div class="form-group">
                        <label for="exampleInputEmail1">Username</label>
                        <input id="txtemail" runat="server" type="text" class="form-control" placeholder="Username" />
                    </div>
                    <div class="form-group">
                        <label for="exampleInputPassword1">Password</label>
                        <input id="password" runat="server" type="password" class="form-control" placeholder="Password" />
                    </div>
                    <div class="form-check">
                        <input type="checkbox" class="form-check-input" id="exampleCheck1">
                        <label class="form-check-label" for="exampleCheck1">Remember me</label>
                        <span class="psw"><a href="#">Forgot password?</a></span>
                    </div>
                    <asp:Button ID="btnsubmit" runat="server" Text="Login" class="btn btn-primary" OnClick="btnsubmit_Click" />
                   
                    <div class="form-signup">
                        <label>Your not a Member? <a href="#">Register Now</a></label>
                    </div>
                </form>          
            </div>
        </section>
        
        <section class="container">
            <div class="login-content">
                <div class="row">
                    <div class="col-md-4 left-img">
                        <img src="img2/Karachi_Metropolitan_Corporation.png" />
                    </div>
                    <div class="col-md-8 right-text">
                        <p>
                            Our mission is to bring simplicity and synergy to the IT Channel business to create an efficient and profitable business environment for all stakeholders. GCS is unique in its overall approach towards addressing the challenges facing the IT Channel business. We understand the entire eco-system of the IT Channel in the Middle East and combine it with our expertise to design fit-for-purpose solutions. We simply connect stakeholders in a way that is unique and simple and creates meaningful alliances.
                        </p>
                    </div>
                </div>   
            </div>
        </section>
    </body>

</html>
