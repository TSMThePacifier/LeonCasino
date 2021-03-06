﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PrincipalCasino2.aspx.cs" Inherits="PrincipalCasino2" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <title>CASINO LEON</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,700,800" rel="stylesheet">

    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/animate.css">
    <link rel="stylesheet" href="css/owl.carousel.min.css">

    <link rel="stylesheet" href="css/magnific-popup.css">


    <link rel="stylesheet" href="fonts/ionicons/css/ionicons.min.css">
    <link rel="stylesheet" href="fonts/fontawesome/css/font-awesome.min.css">

    <!-- Theme Style -->
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
    <form id="form1" runat="server">

        <header role="banner">
            <nav class="navbar navbar-expand-md navbar-dark bg-dark">
                <div class="container">
                    <a class="navbar-brand" href="Default.aspx">CASINO<span>LEON</span></a>
                    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExample05" aria-controls="navbarsExample05" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>

                    <div class="collapse navbar-collapse" id="navbarsExample05">
                        <ul class="navbar-nav mr-auto pl-lg-5 pl-0">
                            <li class="nav-item">
                                <a class="nav-link active" href="Default.aspx">Home</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="about.html">Profile</a>
                            </li>
                            <li class="nav-item dropdown">
                                <a class="nav-link dropdown-toggle" href="services.html" id="dropdown04" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Bank</a>
                                <div class="dropdown-menu" aria-labelledby="dropdown04">
                                    <a class="dropdown-item" href="services.html">Tokens</a>
                                    <a class="dropdown-item" href="services.html">History</a>
                                    <a class="dropdown-item" href="services.html">Add Tokens</a>
                                </div>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="news.html">Play Blackjack</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="contact.html">Contact</a>
                            </li>
                        </ul>

                        <ul class="navbar-nav ml-auto">
                            <li class="nav-item cta-btn">
                                <a class="nav-link" href="member.html">Join / Sign in</a>
                            </li>
                        </ul>

                    </div>
                </div>
            </nav>
        </header>
        <!-- END header -->

        <section class="home-slider owl-carousel">
            <div class="slider-item" style="background-image: url('img/fondobj.jpg');">

                <div class="container">
                    <div class="row slider-text align-items-center justify-content-center">
                        <div class="col-md-8 text-center col-sm-12 element-animate">
                            <h1>CASINO LEON</h1>
                            <p class="mb-5">A place where you can play BLACKJACK as a true Champion</p>
                        </div>
                    </div>
                </div>

            </div>

            <div class="slider-item" style="background-image: url('img/bjcartas.jpg');">
                <div class="container">
                    <div class="row slider-text align-items-center justify-content-center">
                        <div class="col-md-8 text-center col-sm-12 element-animate">
                            <h1>join Casino Leon</h1>
                            <p class="mb-5">Join Casino Leon to Play Blackjack for free and become the best of times</p>
                            <p>
                                <a href="member.html" class="btn btn-white btn-outline-white">Get Started</a>
                        </div>
                    </div>
                </div>

            </div>

        </section>
        <!-- END slider -->


        <section class="section element-animate" style="background-image: url('img/fondobj.jpg');">

            <div class="clearfix mb-5 pb-5">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-md-12 text-center heading-wrap">
                            <h2>Do what YOU want</h2>
                            <span class="back-text"></span>
                        </div>
                    </div>
                </div>
            </div>

            <div class="owl-carousel centernonloop">
                <a href="#" class="item-class">
                    <div class="text">
                        <asp:Button class="class-price" ID="btnPerfil" runat="server" Text="GO" OnClick="btnPerfil_Click" />
                        <h2 class="class-heading">Profile</h2>
                    </div>
                    <img src="img/bjcartas.jpg" alt="" class="img-fluid">
                </a>
                <a href="#" class="item-class">
                    <div class="text">
                        <asp:Button class="class-price" ID="btnJugar" runat="server" Text="PLAY" OnClick="btnJugar_Click" />
                        <h2 class="class-heading">Play BLackJack</h2>

                    </div>
                    <img src="img/fondobj.jpg" alt="" class="img-fluid">
                </a>
                <a href="#" class="item-class">
                    <div class="text">
                        <asp:Button class="class-price" ID="btnHistorial" runat="server" Text="TAKE ME THERE" OnClick="btnHistorial_Click" />
                        <h2 class="class-heading">History</h2>
                    </div>
                    <img src="img/img_3_square.jpg" alt="" class="img-fluid">
                </a>

            </div>
        </section>
        <!-- .section -->



        <section class="section element-animate">

            <div class="clearfix mb-5 pb-5">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-md-12 text-center heading-wrap">
                            <h2>OUR STAFF</h2>
                            <span class="back-text"></span>
                        </div>
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="major-caousel js-carousel-1 owl-carousel">
                        <div>
                            <div class="media d-block media-custom text-center">
                                <a href="#">
                                    <img src="img/raul3.png" alt="Image Placeholder" class="img-fluid"></a>
                                <div class="media-body">
                                    <h3 class="mt-0 text-black">Raul Leon</h3>
                                    <p class="lead">CREATOR</p>
                                </div>
                            </div>
                        </div>
                        <div>
                            <div class="media d-block media-custom text-center">
                                <a href="#">
                                    <img src="img/raul3.png" alt="Image Placeholder" class="img-fluid"></a>
                                <div class="media-body">
                                    <h3 class="mt-0 text-black">mr. Robot</h3>
                                    <p class="lead">DEALER</p>
                                </div>
                            </div>
                        </div>

                        <div>
                            <div class="media d-block media-custom text-center">
                                <a href="#">
                                    <img src="img/raul3.png" alt="Image Placeholder" class="img-fluid"></a>
                                <div class="media-body">
                                    <h3 class="mt-0 text-black">mr. Banks</h3>
                                    <p class="lead">BANKER</p>
                                </div>
                            </div>
                        </div>

                        

                        
                            
                        



                    </div>
                    <!-- END slider -->
                </div>
            </div>

        </section>
        
        <!-- .section -->

        <section class="section element-animate">
            <div class="clearfix mb-5 pb-5">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-md-12 text-center heading-wrap">
                            <h2>MORE INFORMATION</h2>
                            <span class="back-text">More Information</span>
                        </div>
                    </div>
                </div>
            </div>

            <div class="container">
                <div class="row">
                    <div class="col-md-6">
                        <div class="blog d-block d-lg-flex">
                            <div class="bg-image" style="background-image: url('img/img_2_square.jpg');"></div>
                            <div class="text">
                                <h3>Rules</h3>
                                <p class="sched-time">
                                    
                                    <br>
                                </p>
                                <p>Learn more about the rules of BlackJack</p>

                               <p> <asp:Button  class="btn btn-primary btn-sm" ID="btnReglas" runat="server" Text="Read More" OnClick="btnReglas_Click"/></p>

                            </div>

                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="blog d-block d-lg-flex">
                            <div class="bg-image" style="background-image: url('img/img_2_square.jpg');"></div>
                            <div class="text">
                                <h3>How To Play</h3>
                                <p class="sched-time">
                                    
                                    <br>
                                </p>
                                <p>Learn how to play blackjack in this tutorial by ...</p>

                                 <p> <asp:Button  class="btn btn-primary btn-sm" ID="btnTutorial" runat="server" Text="Watch Video" OnClick="btnTutorial_Click"/></p>

                            </div>

                        </div>
                    </div>

                    <div class="col-md-6">
                        <div class="blog d-block d-lg-flex">
                            <div class="bg-image" style="background-image: url('img/img_2_square.jpg');"></div>
                            <div class="text">
                                <h3>Otra Cosa</h3>
                                <p class="sched-time">
                                    
                                    <br>
                                </p>
                                <p>Learn more about the rules of BlackJack</p>

                               <p> <asp:Button  class="btn btn-primary btn-sm" ID="btnOtraCosa" runat="server" Text="Read More" OnClick="btnOtraCosa_Click"/></p>

                            </div>

                        </div>
                    </div>
                </div>
            </div>

        </section>
        <!-- .section -->





        <footer class="site-footer" role="contentinfo">
            <div class="container">
                <div class="row mb-5">
                    <div class="col-md-4 mb-5">
                        <h3>About Us</h3>
                        <p class="mb-5">Casino Leon is a Casino website where you can play BlackJack for free made by Raul Leon</p>
                        <ul class="list-unstyled footer-link d-flex footer-social">
                            <li><a href="#" class="p-2"><span class="fa fa-twitter"></span></a></li>
                            <li><a href="#" class="p-2"><span class="fa fa-facebook"></span></a></li>
                            <li><a href="#" class="p-2"><span class="fa fa-linkedin"></span></a></li>
                            <li><a href="#" class="p-2"><span class="fa fa-instagram"></span></a></li>
                        </ul>

                    </div>
                    <div class="col-md-5 mb-5">
                        
                    </div>
                    <div class="col-md-3 mb-5">
                       <h3>Contact Info</h3>
                        <ul class="list-unstyled footer-link">
                            <li class="d-block">
                                
                               
                            <li class="d-block"><span class="d-block">Telephone:</span><span class="text-white">+506 6150 0978</span></li>
                            <li class="d-block"><span class="d-block">Email:</span><span class="text-white">rleonc452@ulacit.ed.cr</span></li>
                        </ul>
                       
                    </div>
                    <div class="col-md-3">
                    </div>
                </div>
                <div class="row">
                    <div class="col-12 text-md-center text-left">
                        <p>
                            
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                            
                            RAUL LEON | Template by <a href="https://colorlib.com" target="_blank">Colorlib</a>
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                            <br>
                             
                        </p>
                    </div>
                </div>
            </div>
        </footer>

        <!-- END footer -->

        <!-- loader -->
        <div id="loader" class="show fullscreen">
            <svg class="circular" width="48px" height="48px">
                <circle class="path-bg" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke="#eeeeee" />
                <circle class="path" cx="24" cy="24" r="22" fill="none" stroke-width="4" stroke-miterlimit="10" stroke="#f4b214" />
            </svg></div>

        <script src="js/jquery-3.2.1.min.js"></script>
        <script src="js/popper.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
        <script src="js/owl.carousel.min.js"></script>
        <script src="js/jquery.waypoints.min.js"></script>

        <script src="js/jquery.magnific-popup.min.js"></script>
        <script src="js/magnific-popup-options.js"></script>


        <script src="js/main.js"></script>

    </form>
</body>
</html>
