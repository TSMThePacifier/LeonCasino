<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.master" AutoEventWireup="true" CodeFile="RegisterLogin.aspx.cs" Inherits="_RegisterLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="Server">

    <section class="home-slider-loop-false  inner-page owl-carousel">
        <div class="slider-item" style="background-image: url('img/fondobj.jpg');">

            <div class="container">
                <div class="row slider-text align-items-center justify-content-center">
                    <div class="col-md-8 text-center col-sm-12 element-animate">
                        <h1>Sign up / Login</h1>
                    </div>
                </div>
            </div>

        </div>

    </section>
    <!-- END slider -->


    <section class="section">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <div class="form-wrap overlap primary element-animate">
                        <h2 class="h2">Become A Member</h2>
                        
                            <div class="form-group">

                                <asp:TextBox ID="txtRegisterName" runat="server" class="form-control" placeholder="First Name" AutoCompleteType="None"></asp:TextBox>
                            </div>

                            <div class="form-group">

                                <asp:TextBox ID="txtRegisterLastName" runat="server" class="form-control" placeholder="Last Name" AutoCompleteType="None"></asp:TextBox>
                            </div>


                            <div class="form-group">

                                <asp:TextBox ID="txtRegisterEmail" runat="server" class="form-control" placeholder="Email" AutoCompleteType="None" TextMode="Email"></asp:TextBox>
                            </div>

                            <div class="form-group">

                                <asp:TextBox ID="txtRegisterUser" runat="server" class="form-control" placeholder="User" AutoCompleteType="None"></asp:TextBox>
                            </div>


                            <div class="form-group">

                                <asp:TextBox ID="txtRegisterPassword" runat="server" class="form-control" placeholder="Password" AutoCompleteType="None" TextMode="Password"></asp:TextBox>
                            </div>

                            <div class="form-group">

                                <asp:CheckBox ID="checkboxmas18" runat="server" Text="     Are you " ForeColor="Black" Font-Size="Large" />
                                <asp:Label ID="lblmas18" runat="server" Text="+18" ForeColor="Red" Font-Size="X-Large"></asp:Label>


                            </div>

                            <div class="form-group">

                                <asp:CheckBox ID="checkboxTerms" runat="server" Text="     Please accept our " ForeColor="Black" Font-Size="Large" />
                                <a>
                                    <asp:HyperLink ID="HyperLinkTerms" href="#" runat="server" Font-Size="Large" ForeColor="Blue" Font-Underline="true">Terms and Conditions</asp:HyperLink>
                                </a>
                            </div>




                            <%--<div class="form-group">
                                <div class="select-wrap">
                                    <span class="ion-ios-arrow-down select-arrow-icon"></span>
                                    <select name="" id="" class="form-control">
                                        <option value="#">--Select</option>
                                        <option value="#">Silver</option>
                                        <option value="#">Gold</option>
                                        <option value="#">Platinum</option>
                                    </select>
                                </div>
                            </div>--%>

                            <div class="form-group">

                                <asp:Button ID="btnCreateAccount" class="btn btn-warning btn-block py-3" runat="server" Text="Create an account" OnClick="btnCreateAccount_Click" />
                            </div>




                       
                    </div>
                </div>

                            <div class="col-md-6">
                <div class="form-wrap overlap element-animate">
                    <h2 class="h2">Log in</h2>
                    
                        <div class="form-group">

                            <asp:TextBox ID="txtLoginUser" runat="server" class="form-control" placeholder="User" AutoCompleteType="None"></asp:TextBox>

                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtLoginPassword" runat="server" class="form-control" placeholder="Password" TextMode="Password" AutoCompleteType="None"></asp:TextBox>

                        </div>
                        <%--<div class="form-group">
                                <p>Forgot your password? <a href="#">click here</a></p>
                            </div>--%>
                        <div class="form-group">


                            <asp:Button ID="btnLogin" class="btn btn-warning btn-block py-3" runat="server" Text="Login" OnClick="btnLogin_Click" />

                        </div>
                    
                </div>
            </div>



            </div>
        </div>
    </section>





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
                        <li class="d-block" />


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


                    </p>
                </div>
            </div>
        </div>
    </footer>

    <!-- END footer -->




</asp:Content>


