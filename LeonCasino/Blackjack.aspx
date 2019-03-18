<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageBJ.master" AutoEventWireup="true" CodeFile="Blackjack.aspx.cs" Inherits="Blackjack" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <p style="height: 402px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="imgProfile" runat="server" Height="32px" ImageUrl="https://cdn4.iconfinder.com/data/icons/eldorado-user/40/user-128.png" Visible="False" Width="33px" />
        &nbsp;&nbsp;
       
        <asp:Label font-name="Lucida Console" ForeColor="#000000" Font-Size="X-Large" ID="lblName"  runat="server" ></asp:Label>
        &nbsp;&nbsp;

       <asp:Label  ID="lblMonto" runat="server" font-name="Lucida Console" ForeColor="#000000" Font-Size="X-Large" ></asp:Label>
        &nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <br />
        <br />
        <%--<asp:Image ID="imgDealer" runat="server" Height="359px" Width="380px" ImageUrl="~/dealer.png" />--%>
        <asp:Button ID="BtnDelear" runat="server" OnClick="Button1_Click" Text="Deal Cards" class="btn btn-info"  BorderStyle="Dotted" />
    </p>
    <p style="height: 50px">
        <asp:ImageButton ID="imgBtnApostar10" runat="server" Height="100px" Width="100px" ImageUrl="~/Fichas/Ficha10.png" OnClick="imgBtnApostar10_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
       
        <asp:ImageButton ID="imgBtnApostar50" runat="server" Height="100px" Width="100px" ImageUrl="~/Fichas/Ficha50.png" OnClick="imgBtnApostar50_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
       
        <asp:ImageButton ID="imgBtnApostar100" runat="server" Height="100px" Width="100px" ImageUrl="~/Fichas/Ficha100.png" OnClick="imgBtnApostar100_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
       
        <asp:ImageButton ID="imgBtnApostar500" runat="server" Height="100px" Width="100px" ImageUrl="~/Fichas/Ficha500.png" OnClick="imgBtnApostar500_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
       
        <asp:ImageButton ID="imgBtnApostar1000" runat="server" Height="100px" Width="100px" ImageUrl="~/Fichas/Ficha1000.png" OnClick="imgBtnApostar1000_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
       
        <asp:Label ID="lblApuesta" runat="server" Text="Apuesta: " font-name="Lucida Console" ForeColor="#000000" Font-Size="X-Large"></asp:Label>
    </p>

    <p style="height: 402px">
        <asp:Image ID="imgCarta1Dealer" runat="server" Height="272px" Width="216px" />
        &nbsp;&nbsp;<asp:Image ID="imgCarta2Dealer" runat="server" Height="272px" Width="216px" />
        &nbsp;
       
        <asp:Image ID="imgCarta3Dealer" runat="server" Height="272px" Width="216px" />
        &nbsp;
       
        <asp:Image ID="imgCarta4Dealer" runat="server" Height="272px" Width="216px" />
        &nbsp;
       
        <asp:Image ID="imgCarta5Dealer" runat="server" Height="272px" Width="216px" />
        &nbsp;&nbsp;
       
        <asp:Button ID="btnVolverAJugar" runat="server" OnClick="btnVolverAJugar_Click" class="btn btn-info" Text="Play Again" BorderColor="#CC0066" BorderStyle="Dotted" />
    </p>
    <p style="height: 402px">
        <asp:Image ID="imgCarta1Usuario" runat="server" Height="272px" Width="216px" />
        &nbsp;
       
        <asp:Image ID="imgCarta2Usuario" runat="server" Height="272px" Width="216px" />
        &nbsp;
       
        <asp:Image ID="imgCarta3Usuario" runat="server" Height="272px" Width="216px" />
        &nbsp;
       
        <asp:Image ID="imgCarta4Usuario" runat="server" Height="272px" Width="216px" />
        &nbsp;
       
        <asp:Image ID="imgCarta5Usuario" runat="server" Height="272px" Width="216px" />
        &nbsp;
       
        <asp:Button ID="btnDouble" class="btn btn-danger" runat="server"  OnClick="btnDouble_Click" Text="Double" BorderStyle="Dotted" />
        &nbsp;<asp:Button ID="btnPEDIRSINI" runat="server" class="btn btn-success" OnClick="btnPEDIRSINI_Click" Text="Hit" BorderColor="Lime" BorderStyle="Dotted" />
        <asp:Button ID="btnQuedarse" runat="server" class="btn btn-warning" Text="Stay" OnClick="Button1_Click1" BorderColor="Red" BorderStyle="Dotted" />
        <asp:Label ID="lblAgregar" runat="server"></asp:Label>
    </p>
    <p style="height: 202px">
        <asp:Label ID="lbLINFO" runat="server" font-name="Lucida Console" ForeColor="#000000" Font-Size="X-Large"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
   
    </p>
    <p style="height: 202px">
        <asp:Button class="btn btn-danger" ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Back to principal"  BorderStyle="Dotted" />
    </p>
</asp:Content>



