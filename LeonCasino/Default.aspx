<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="Server">


    <section class="home-slider owl-carousel">
        <div class="slider-item" style="background-image: url('img/fondo2.jpg');">

            <div class="container">
                <div class="row slider-text align-items-center justify-content-center">
                    <div class="col-md-8 text-center col-sm-12 element-animate">
                        <h1>CASINO DREAM TEAM</h1>
                        <p class="mb-5">A place where you can play BLACKJACK as a true Champion</p>


                        <a class="btn btn-white btn-outline-white" onclick="scrollWin()">Start</a>
                    </div>
                </div>
            </div>

        </div>

        <div class="slider-item" style="background-image: url('img/fondo3.png');">
            <div class="container">
                <div class="row slider-text align-items-center justify-content-center">
                    <div class="col-md-8 text-center col-sm-12 element-animate">
                        <h1>Join Casino DREAM TEAM</h1>
                        <p class="mb-5">Join Casino Leon to Play Blackjack for free and become the best of times</p>
                        <p>
                            <a href="RegisterLogin.aspx" class="btn btn-white btn-outline-white">Join</a>
                    </div>
                </div>
            </div>

        </div>

    </section>
    <!-- END slider -->


    <section class="section element-animate" style="background-image: url('img/fondo1.jpg');">

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
                    <asp:Button class="class-price" ID="btnJugar" runat="server" Text="PLAY" OnClick="btnJugar_Click" />
                    <h2 class="class-heading">Play BLackJack</h2>

                </div>
                <img src="img/fondo5.jpg" alt="" class="img-fluid" />
            </a>
            <a href="#" class="item-class">
                <div class="text">
                    <asp:Button class="class-price" ID="btnTokens" runat="server" Text="TAKE ME THERE" OnClick="btnTokens_Click" />
                    <h2 class="class-heading">BANK</h2>
                </div>
                <img src="img/banco4.png" alt="" class="img-fluid" />
            </a>

        </div>
    </section>
    <!-- .section -->



   
                <!-- END slider -->
            </div>
        </div>

    </section>

    <!-- .section -->

    <section class="section element-animate" style="background-image: url('img/fondobj.jpg');">
        <div class="clearfix mb-5 pb-5">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-12 text-center heading-wrap">
                        <h2>MORE INFO</h2>
                        <span class="back-text"></span>
                    </div>
                </div>
            </div>
        </div>

        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <div class="blog d-block d-lg-flex">
                        <div class="bg-image" style="background-image: url('img/fondo8.jpg');"></div>
                        <div class="text">
                            <h3>Rules</h3>
                            <p class="sched-time">
                            </p>
                            <p>Learn more about the rules of BlackJack</p>

                            <p>
                                <a target="_blank" rel="noopener noreferrer" href="https://www.bicyclecards.com/how-to-play/blackjack/" class="btn btn-primary btn-sm">Read More</a>

                            </p>

                        </div>

                    </div>
                </div>
                <div class="col-md-6">
                    <div class="blog d-block d-lg-flex">
                        <div class="bg-image" style="background-image: url('img/bjcartas.jpg');"></div>
                        <div class="text">
                            <h3>How To Play</h3>
                            <p class="sched-time">
                            </p>
                            <p>Learn how to play blackjack in this tutorial by Grosvernor Casinos</p>

                            <p>
                                <a target="_blank" rel="noopener noreferrer" href="https://www.youtube.com/watch?v=mHWqgAc_qmw" class="btn btn-primary btn-sm">Watch Video</a>
                            </p>

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
                    <p class="mb-5">Casino DREAM TEAM is a Casino website where you can play BlackJack for free made by DREAM TEAM</p>
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
                        <li class="d-block" />


                        <li class="d-block"><span class="d-block">Telephone:</span><span class="text-white">+506 DREAM TEAM</span></li>
                        <li class="d-block"><span class="d-block">Email:</span><span class="text-white">DREAMTEAM@ulacit.ed.cr</span></li>

                    </ul>

                </div>
                <div class="col-md-3">
                </div>
            </div>
            <div class="row">
                <div class="col-12 text-md-center text-left">
                    <p>

                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->

                        DREAM TEAM | Template by <a href="https://colorlib.com" target="_blank">Colorlib</a>
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->


                    </p>
                </div>
            </div>
        </div>
    </footer>

    <!-- END footer -->

    <!-- loader -->

    <script>
        function scrollWin() {
            window.scrollTo(000, 800);
        }
    </script>





</asp:Content>

