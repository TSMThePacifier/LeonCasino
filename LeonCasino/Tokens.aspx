<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.master" AutoEventWireup="true" CodeFile="Tokens.aspx.cs" Inherits="Tokens" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" Runat="Server">

    <section class="home-slider-loop-false  inner-page owl-carousel">
        <div class="slider-item" style="background-image: url('img/dinerito3.jpg');">

            <div class="container">
                <div class="row slider-text align-items-center justify-content-center">
                    <div class="col-md-8 text-center col-sm-12 element-animate">
                        <h1>Add Tokens</h1>
                    </div>
                </div>
            </div>

        </div>

    </section>

      <!-- .section -->


    <section class="section element-animate" style="background-image: url('img/dinerit.png');">

        <div class="clearfix mb-5 pb-5">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-md-12 text-center heading-wrap">
                        <h2>
                            <asp:Label ID="lblAnuncio" runat="server" Text="You can add free coins once a day, everyday"></asp:Label></h2>
                        <span class="back-text"></span>
                    </div>
                </div>
            </div>
        </div>

          
                        <div class="media d-block media-custom text-center">
                            <a href="#">
                                <asp:ImageButton ID="imgBtnTokens" runat="server" src="img/dinerito2.png" alt="Image Placeholder" class="img-fluid" OnClick="imgBtnTokens_Click"/>
                                
                            <div class="media-body">
                                <h3 class="mt-0 text-black">Add Tokens</h3>
                                <p class="lead">DEALER</p>
                            </div>
                        </div>



    </section>

    <!-- .section -->
</asp:Content>

