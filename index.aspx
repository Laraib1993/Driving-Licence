<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
     <meta charset="UTF-8">
    <title>glocali</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.2.0/css/all.css" integrity="sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ"
        crossorigin="anonymous">
    <link rel="stylesheet" href="css/style.css">

</head>
<body>
    <form runat="server">

    
    <section class="sec_1">
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-md-12">
                    <div class="row">
                        <div class="col-md-6"></div>
                        <div class="col-md-6">
                            <div class="contact_head pull-right">
                                <ul>
                                    <li>
                                        <i class="fas fa-phone"></i>
                                        +97142432336
                                    </li>
                                    <li>
                                        <span style="color: #888888">|</span>
                                    </li>
                                    <li>
                                        <i class="far fa-envelope"></i>
                                        info@glocal.ae
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class="sec_2">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="row">
                        <div class="col-md-4">
                            <img src="css/images/logo.png" />
                        </div>
                        <div class="col-md-6">
                            <div style="margin-top: 15px;">
                                <nav class="navbar">
                                    <ul class="nav navbar-nav">
                                        <li class="dropdown">
                                            <a class="dropdown-toggle" data-toggle="dropdown" href="content.aspx">Find Products
                                                <span class="caret"></span>
                                            </a>
                                            <ul class="dropdown-menu list_mrg">
                                                <li>
                                                    <a href="content.aspx">Find Products 01</a>
                                                </li>
                                                <li>
                                                    <a href="content.aspx">Find Products 02</a>
                                                </li>
                                                <li>
                                                    <a href="content.aspx">Find Products 03</a>
                                                </li>
                                            </ul>
                                        </li>
                                        <li class="dropdown">
                                            <a class="dropdown-toggle" data-toggle="dropdown" href="content.aspx">Find Partners
                                                <span class="caret"></span>
                                            </a>
                                            <ul class="dropdown-menu list_mrg">
                                                <li>
                                                    <a href="content.aspx">Find Partners 01</a>
                                                </li>
                                                <li>
                                                    <a href="content.aspx">Find Partners 02</a>
                                                </li>
                                                <li>
                                                    <a href="content.aspx">Find Partners 03</a>
                                                </li>
                                            </ul>
                                        </li>
                                        <li>
                                            <a href="Dashboard.aspx">Dashboard</a>
                                        </li>
                                        <li>
                                            <a href="#">Subscription</a>
                                        </li>
                                    </ul>
                                </nav>
                            </div>
                        </div>
                        <div class="col-md-2">
                            <div style="margin-top: 15px;">
                                <a class="btn btn-primary btn-lg" href="SignIn.aspx">Register/Sign in</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <div class="slider" id = "slider1">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="row">
                        <div class="col-md-8">
                            <div>
                                <h2>Information Hub for your
                                    <br>
                                    <span>Technology Needs</span>
                                </h2>
                                <p>Find everything here</p>


                                <div class="navbar-form navbar-left">
                                    <div class="input-group">
                                        <input type="text" class="form-control" placeholder="All Products" name="search">
                                    </div>
                                    <div class="input-group">
                                        <input type="text" class="form-control" placeholder="Vendor" name="search">
                                    </div>
                                    <div class="input-group">
                                        <input type="text" class="form-control" placeholder="Country" name="search">
                                      <%--  <div class="input-group-btn">
                                            <button class="btn btn-default btn-lg" type="submit">
                                                <i class="glyphicon glyphicon-search"></i>
                                            </button>
                                        </div>--%>
                                    </div>
                                    <div class="input-group">
                                        <div class="input-group-btn">
                                            <button class="btn btn-default btn-md" type="submit">
                                                <i class="glyphicon glyphicon-search"></i>
                                            </button>
                                        </div>
                                    </div>
                                </div>


                            </div>
                        </div>
                        <div class="col-md-4">
                            <div id="myCarousel" class="carousel slide" data-ride="carousel">
                                <ol class="carousel-indicators">
                                    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                                    <li data-target="#myCarousel" data-slide-to="1"></li>
                                    <li data-target="#myCarousel" data-slide-to="2"></li>
                                </ol>
                                <div class="carousel-inner">
                                    <div class="item active">
                                        <img src="css/images/smaill_slider_bg.png" alt="Los Angeles" style="width:100%; height: 243px; margin-top: 31px;">
                                        <div class="carousel-caption">
                                            <div class=" row">
                                                <div class="col-md-12">
                                                    <div class="col-md-7">
                                                        <h3 style="font-size:20px;">Sign up today!</h3>
                                                        <p style="font-size: 12px;">Register and be part of a new IT Channel Revolution!
                                                            <br> Become a part of our star program and get global attention.
                                                        </p>
                                                    </div>
                                                    <div class="col-md-5">
                                                        <img src="css/images/icons/document_icon.png">
                                                        <p style="font-size: 16px; text-decoration: #ffffff underline; font-weight: bold;">Register ></p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="item">
                                        <img src="css/images/smaill_slider_bg.png" alt="Los Angeles" style="width:100%; height: 243px; margin-top: 31px;">
                                        <div class="carousel-caption">
                                            <div class=" row">
                                                <div class="col-md-12">
                                                    <div class="col-md-7">
                                                        <h3 style="font-size:20px;">Sign up today!</h3>
                                                        <p style="font-size: 12px;">Register and be part of a new IT Channel Revolution!
                                                            <br> Become a part of our star program and get global attention.
                                                        </p>
                                                    </div>
                                                    <div class="col-md-5">
                                                        <img src="css/images/icons/document_icon.png">
                                                        <p style="font-size: 16px; text-decoration: #ffffff underline; font-weight: bold;">Register ></p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="item">
                                        <img src="css/images/smaill_slider_bg.png" alt="Los Angeles" style="width:100%; height: 243px; margin-top: 31px;">
                                        <div class="carousel-caption">
                                            <div class=" row">
                                                <div class="col-md-12">
                                                    <div class="col-md-7">
                                                        <h3 style="font-size:20px;">Sign up today!</h3>
                                                        <p style="font-size: 12px;">Register and be part of a new IT Channel Revolution!
                                                            <br> Become a part of our star program and get global attention.
                                                        </p>
                                                    </div>
                                                    <div class="col-md-5">
                                                        <img src="css/images/icons/document_icon.png">
                                                        <p style="font-size: 16px; text-decoration: #ffffff underline; font-weight: bold;">Register ></p>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2 mt-10">
                            <p>Or browse by Products</p>
                        </div>
                        <div class="col-md-10" style="margin-top: 25px;">
                            <hr>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12 col-lg-12 mt-15">
                            <a href="content.aspx">
                                <div class="col-md-1">
                                    <img width="75%" src="css/images/icons/slider-icons/server.png">
                                    <p style="font-size: 12px;">Servers</p>
                                </div>
                            </a>
                            <a href="content.aspx">
                                <div class="col-md-1">
                                    <img width="70%" src="css/images/icons/slider-icons/storage.png">
                                    <p style="font-size: 12px;">Storage</p>
                                </div>
                            </a>
                            <a href="content.aspx">
                                <div class="col-md-1">
                                    <img width="70%" src="css/images/icons/slider-icons/network.png">
                                    <p style="font-size: 12px;">Networking</p>
                                </div>
                            </a>
                            <a href="content.aspx">
                                <div class="col-md-1">
                                    <img width="70%" src="css/images/icons/slider-icons/power.png">
                                    <p style="font-size: 12px;">Power</p>
                                </div>
                            </a>
                            <a href="content.aspx">
                                <div class="col-md-1">
                                    <img width="70%" src="css/images/icons/slider-icons/voice-video.png">
                                    <p style="font-size: 12px;">Voice & Video</p>
                                </div>
                            </a>
                            <a href="content.aspx">
                                <div class="col-md-1">
                                    <img width="65%" src="css/images/icons/slider-icons/security.png">
                                    <p style="font-size: 12px;">Security</p>
                                </div>
                            </a>
                            <a href="content.aspx">
                                <div class="col-md-1">
                                    <img width="70%" src="css/images/icons/slider-icons/robotic.png">
                                    <p style="font-size: 12px;">Robotics</p>
                                </div>
                            </a>
                            <a href="content.aspx">
                                <div class="col-md-1">
                                    <img width="70%" src="css/images/icons/slider-icons/drone.png">
                                    <p style="font-size: 12px;">Drones</p>
                                </div>
                            </a>
                            <a href="content.aspx">
                                <div class="col-md-1">
                                    <img width="70%" src="css/images/icons/slider-icons/3d-printing.png">
                                    <p style="font-size: 12px;">3D Printing</p>
                                </div>
                            </a>
                            <a href="content.aspx">
                                <div class="col-md-1">
                                    <img width="90%" src="css/images/icons/slider-icons/computing.png">
                                    <p style="font-size: 12px;">Computing</p>
                                </div>
                            </a>
                            <a href="content.aspx">
                                <div class="col-md-1">
                                    <img width="70%" src="css/images/icons/slider-icons/viryual-reality.png">
                                    <p style="font-size: 12px;">Virtual Reality-VR</p>
                                </div>
                            </a>
                            <a href="content.aspx">
                                <div class="col-md-1">
                                    <img width="70%" src="css/images/icons/slider-icons/compute.png">
                                    <p style="font-size: 12px;">Compute</p>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-10 col-lg-10 mt-15">
                            <div class="row">
                                <div class="col-md-4" style="padding-right: 0px;">
                                    <a href="content.aspx">
                                        <div class="col-md-4">
                                            <img width="75%" src="css/images/icons/slider-icons/cyber-security.png">
                                            <p style="font-size: 12px;">Cyber Security</p>
                                        </div>
                                    </a>
                                    <a href="content.aspx">
                                        <div class="col-md-4">
                                            <img width="75%" src="css/images/icons/slider-icons/enterprise-solution.png">
                                            <p style="font-size: 12px;">Enterprise Solutions</p>
                                        </div>
                                    </a>
                                    <a href="content.aspx">
                                        <div class="col-md-4" style="padding-right: 0px;">
                                            <img width="70%" src="css/images/icons/slider-icons/cloud.png">
                                            <p style="font-size: 12px;">Cloud</p>
                                        </div>
                                    </a>
                                </div>
                                <div class="col-md-4" style="padding-right: 0px;">
                                    <a href="content.aspx">
                                        <div class="col-md-4">
                                            <img width="75%" src="css/images/icons/slider-icons/block-chain.png">
                                            <p style="font-size: 12px;">Block Chain</p>
                                        </div>
                                    </a>
                                    <a href="content.aspx">
                                        <div class="col-md-4">
                                            <img width="75%" src="css/images/icons/slider-icons/analytics.png">
                                            <p style="font-size: 12px;">Analytics</p>
                                        </div>
                                    </a>
                                    <a href="content.aspx">
                                        <div class="col-md-4" style="padding-right: 0px;">
                                            <img width="70%" src="css/images/icons/slider-icons/iot.png">
                                            <p style="font-size: 12px;">IOT</p>
                                        </div>
                                    </a>
                                </div>
                                <div class="col-md-4" style="padding-right: 0px;">
                                    <a href="content.aspx">
                                        <div class="col-md-4">
                                            <img width="75%" src="css/images/icons/slider-icons/convrged-infrastructure.png">
                                            <p style="font-size: 12px;">Converged infrastructure</p>
                                        </div>
                                    </a>
                                    <a href="content.aspx">
                                        <div class="col-md-4">
                                            <img width="80%" src="css/images/icons/slider-icons/artificial-intelligence.png">
                                            <p style="font-size: 12px;">Artificial intellegence</p>
                                        </div>
                                    </a>
                                    <a href="content.aspx">
                                        <div class="col-md-4">
                                            <img width="59%" src="css/images/icons/slider-icons/machine-learning.png">
                                            <p style="font-size: 12px;">Machine Learning</p>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-1"></div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <section class="sec_3">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <h2 style="margin-bottom: 50px; margin-top: 30px;">
                        <b>Authorised Channel for Your Products</b>
                    </h2>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div class="row" id="divdistributerinfo" runat="server">
                        
<%--                        <div class="col-md-3">
                            <div class="border">
                                <img class="img-responsive" src="css/images/redington.png" />
                                <p>Tier Level : 1
                                    <br> Locations : Qatar, Kuwait, Bahrian,
                                    <br> Oman & KSA
                                    <br> Website : www.redington.com
                                    <br> Partner Status : Distributor/ reseller/ retailor/SI/MSP
                                </p>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="border">
                                <img class="img-responsive" src="css/images/2.png" />
                                <p>Tier Level : 1
                                    <br> Locations : Qatar, Kuwait, Bahrian,
                                    <br> Oman & KSA
                                    <br> Website : www.redington.com
                                    <br> Partner Status : Distributor/ reseller/ retailor/SI/MSP
                                </p>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="border">
                                <img class="img-responsive" src="css/images/on24.png" />
                                <p>Tier Level : 1
                                    <br> Locations : Qatar, Kuwait, Bahrian,
                                    <br> Oman & KSA
                                    <br> Website : www.redington.com
                                    <br> Partner Status : Distributor/ reseller/ retailor/SI/MSP
                                </p>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="border">
                                <img  class="img-responsive" src="css/images/inovar.png" />
                                <p>Tier Level : 1
                                    <br> Locations : Qatar, Kuwait, Bahrian,
                                    <br> Oman & KSA
                                    <br> Website : www.redington.com
                                    <br> Partner Status : Distributor/ reseller/ retailor/SI/MSP
                                </p>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="border mt-30">
                                <img class="img-responsive" src="css/images/hw.png" />
                                <p>Tier Level : 1
                                    <br> Locations : Qatar, Kuwait, Bahrian,
                                    <br> Oman & KSA
                                    <br> Website : www.redington.com
                                    <br> Partner Status : Distributor/ reseller/ retailor/SI/MSP
                                </p>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="border mt-30">
                                <img class="img-responsive" src="css/images/op.png" />
                                <p>Tier Level : 1
                                    <br> Locations : Qatar, Kuwait, Bahrian,
                                    <br> Oman & KSA
                                    <br> Website : www.redington.com
                                    <br> Partner Status : Distributor/ reseller/ retailor/SI/MSP
                                </p>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="border mt-30">
                                <img class="img-responsive" src="css/images/jobscan.png" />
                                <p>Tier Level : 1
                                    <br> Locations : Qatar, Kuwait, Bahrian,
                                    <br> Oman & KSA
                                    <br> Website : www.redington.com
                                    <br> Partner Status : Distributor/ reseller/ retailor/SI/MSP
                                </p>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="border mt-30">
                                <img style="margin-bottom: 10px;" class="img-responsive" src="css/images/timer.png" />
                                <p>Tier Level : 1
                                    <br> Locations : Qatar, Kuwait, Bahrian,
                                    <br> Oman & KSA
                                    <br> Website : www.redington.com
                                    <br> Partner Status : Distributor/ reseller/ retailor/SI/MSP
                                </p>
                            </div>
                        </div>--%>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class="sec_4">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="row">
                        <div class="col-md-6">
                            <div class="mt-80">
                                <h3>
                                    <b>Channel Partner Recruitment</b>
                                </h3>
                                <p>Identifying a right partner is key to success for any distributor.</p>
                                <a class="btn btn-default">Learn More</a>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <img class="img-responsive" src="css/images/service.png" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class="sec_5">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <h3>
                        <b>Discover the GCS Platform and Services</b>
                    </h3>
                </div>
                <div class="row">
                    <div class="col-md-2"></div>
                    <div class="col-md-8">
                        <div class="v_set">
                            <video loop poster="css/images/40-years.png" controls>
                                <source src="css/videos/mov_bbb.mp4" type="video/mp4">
                            </video>
                        </div>
                    </div>
                    <div class="col-md-2"></div>

                </div>
            </div>
        </div>
    </section>

    <section class="sec_6">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <h2 class="text-center">
                        <b>Select the Product and services you are looking for</b>
                    </h2>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <h5>
                        <b>Browse by Product</b>
                    </h5>
                    <div class="row">
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/server.png" />
                                        </li>
                                        <li class="list_text">Servers</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/storage.png" />
                                        </li>
                                        <li class="list_text">Storage</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/network.png" />
                                        </li>
                                        <li class="list_text">Networking</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/power.png" />
                                        </li>
                                        <li class="list_text">Power</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/voice-video.png" />
                                        </li>
                                        <li class="list_text">Voice & Video</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/security.png" />
                                        </li>
                                        <li class="list_text">Security</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/robotic.png" />
                                        </li>
                                        <li class="list_text">Robotics</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/drone.png" />
                                        </li>
                                        <li class="list_text">Drones</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/3d-printing.png" />
                                        </li>
                                        <li class="list_text">3D Printing</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/computing.png" />
                                        </li>
                                        <li class="list_text">Computing</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/viryual-reality.png" />
                                        </li>
                                        <li class="list_text">Virtual Reality-VR</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/compute.png" />
                                        </li>
                                        <li class="list_text">Compute</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12 mt-30">
                    <h5>
                        <b>Browse by Services</b>
                    </h5>
                    <div class="row">
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/cyber-security.png" />
                                        </li>
                                        <li class="list_text">Cyber Security</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/enterprise-solution.png" />
                                        </li>
                                        <li class="list_text">Enterprise Solutions</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/cloud.png" />
                                        </li>
                                        <li class="list_text">Cloud</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/block-chain.png" />
                                        </li>
                                        <li class="list_text">Blocak Chain</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/analytics.png" />
                                        </li>
                                        <li class="list_text">Analytics</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/iot.png" />
                                        </li>
                                        <li class="list_text">IOT</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/convrged-infrastructure.png" />
                                        </li>
                                        <li class="list_text">Converged infrastructure</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/artificial-intelligence.png" />
                                        </li>
                                        <li class="list_text">Artificial intellegence</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <div class="b_product">
                                    <ul>
                                        <li>
                                            <img src="css/images/icons/machine-learning.png" />
                                        </li>
                                        <li class="list_text">Machine Learning</li>
                                    </ul>
                                </div>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
        <%--Vendor Section Start--%>
    <section class="sec_7">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="" style="display: none">
                        <img class="img-responsive" src="css/images/brands/brands_logo_03.png" />
                    </div>
                    <div class="row" id="vendor" runat="server" >
                       <%-- <div class="col-md-3">
                            <a href="#slider1" onclick="#slider1">
                                <img src="css/images/brands/apple.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/hp.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/amazon.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/microsoft.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/google.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/cisco.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/dell.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/ibm.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/intel.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/sap.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/oracle.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/lenovo.png" />
                            </a>
                        </div>

                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/vm-ware.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/huawei.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/symantec.png" />
                            </a>
                        </div>
                        <div class="col-md-3">
                            <a href="#slider1">
                                <img src="css/images/brands/citrix.png" />
                            </a>
                        </div>--%>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class="sec_8">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <h2 class="text-center" style="margin-bottom: 50px;">
                        <b>Sign up now</b>
                    </h2>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <div class="row">
                        <div class="col-md-4">
                            <div class="get_start_border">
                                <div>
                                    <div class="col-md-8">
                                        <span>I am a Vendor</span>
                                        <p>
                                            Yes. I want to enter new markets and build my Channel and create new opportunities for everyone involved
                                        </p>
                                    </div>
                                    <div class="col-md-4">
                                        <img src="css/images/icons/i-am-a-vendor.png" />
                                    </div>
                                    <div class="col-md-12">
                                        <div>
                                            <img width="100%" src="css/images/get_start_01.png" />
                                            <a href="content.aspx" class="btn btn-primary start_btn" style="width: 100%">Get Started</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="get_start_border">
                                <div>
                                    <div class="col-md-8">
                                        <span>I am a Distributor</span>
                                        <p>
                                            Yes. I want to add new products and services to my portfolio and yes I want to keep my channel breadth healthy
                                        </p>
                                    </div>
                                    <div class="col-md-4">
                                        <img src="css/images/icons/i-am-distributer.png" />
                                    </div>
                                    <div class="col-md-12">
                                        <div>
                                            <img width="100%" src="css/images/get_start_02.png" />
                                            <a href="content.aspx" class="btn btn-primary start_btn" style="width: 100%">Get Started</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="get_start_border">
                                <div>
                                    <div class="col-md-8">
                                        <span>I am a Partner</span>
                                        <p>
                                            Yes. I want to share my local knowledge of the market with my vendor. Yes. I want to team up with new technology vendors
                                            to create unbeatable offers
                                        </p>
                                    </div>
                                    <div class="col-md-4">
                                        <img src="css/images/icons/i-am-partner.png" />
                                    </div>
                                    <div class="col-md-12">
                                        <div>
                                            <img width="100%" src="css/images/get_start_03.png" />
                                            <a href="content.aspx" class="btn btn-primary start_btn" style="width: 100%">Get Started</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class="sec_9">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="row">
                        <div class="col-md-5">
                            <div class="row">
                                <div class="col-md-7">
                                    <img style="margin-bottom: 25px;" src="css/images/logo2.png" />
                                    <div>
                                        <p class="fas fa-phone mt-10" style="font-size: 20px; color: #ffffff;">&nbsp; +971 4 243 2336</p>
                                    </div>
                                    <div>
                                        <p class="fas fa-envelope mt-10" style="font-size: 20px; color: #ffffff;">&nbsp; info@glocal.ae</p>
                                    </div>
                                    <p class="fas fa-map-marker-alt mt-10" style="font-size: 20px; color: #ffffff;"> &nbsp; #2705, Concord &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Towers Internet City &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Dubai</p>
                                </div>
                                <div class="col-md-5">
                                    <h3 style="color: #ffffff; margin-top: 28px; margin-bottom: 25px;">
                                        <b>COMPANY</b>
                                    </h3>
                                    <a href="content.aspx" style="text-decoration: none;">
                                        <p class="mt-60" style="font-size: 20px; color: #ffffff;">What we do</p>
                                    </a>
                                    <a href="content.aspx" style="text-decoration: none;">
                                        <p class="mt-10" style="font-size: 20px; color: #ffffff;">Who we are</p>
                                    </a>
                                    <a href="content.aspx" style="text-decoration: none;">
                                        <p class="mt-10" style="font-size: 20px; color: #ffffff;">Our Partners</p>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-7">
                            <div class="row">
                                <div class="col-md-4">
                                    <h3 style="color: #ffffff; margin-top: 28px; margin-bottom: 25px;">
                                        <b>SERVICES</b>
                                    </h3>
                                    <a href="content.aspx" style="text-decoration: none;">
                                        <p class="mt-60" style="font-size: 20px; color: #ffffff;">Channel Recruitment</p>
                                    </a>
                                    <a href="content.aspx" style="text-decoration: none;">
                                        <p class="mt-10" style="font-size: 20px; color: #ffffff;">Channel Marketing</p>
                                    </a>
                                    <a href="content.aspx" style="text-decoration: none;">
                                        <p class="mt-10" style="font-size: 20px; color: #ffffff;">Trade % Dustribution</p>
                                    </a>
                                </div>
                                <div class="col-md-4">
                                    <h3 style="color: #ffffff; margin-top: 28px; margin-bottom: 25px;">
                                        <b>SUBSCRIBE</b>
                                    </h3>
                                    <a href="content.aspx" style="text-decoration: none;">
                                        <p class="mt-60" style="font-size: 20px; color: #ffffff;">Become a member</p>
                                    </a>
                                </div>
                                <div class="col-md-4">
                                    <h3 style="color: #ffffff; margin-top: 28px; margin-bottom: 25px;">
                                        <b>follow Us</b>
                                    </h3>
                                    <div class="row">
                                        <div class="col-md-3 mt-30">
                                            <a href="content.aspx">
                                                <i class="fab fa-facebook-square" style="color: #ffffff; font-size: 25px;"></i>
                                            </a>
                                        </div>
                                        <div class="col-md-3 mt-30">
                                            <a href="content.aspx">
                                                <i class="fab fa-twitter" style="color: #ffffff; font-size: 25px;"></i>
                                            </a>
                                        </div>
                                        <div class="col-md-3 mt-30">
                                            <a href="content.aspx">
                                                <i class="fab fa-google-plus-g" style="color: #ffffff; font-size: 25px;"></i>
                                            </a>
                                        </div>
                                        <div class="col-md-3 mt-30">
                                            <a href="content.aspx">
                                                <i class="fab fa-youtube" style="color: #ffffff; font-size: 25px;"></i>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class="sec_10">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <p style="text-align: center; color: #ffffff; font-size: 18px;">Copyright © 2017 All Rights Reserved By Glocali 2016 Powered by: Multi Marketing</p>
                </div>
            </div>
        </div>
    </section>

    
    </form>

</body>
</html>
