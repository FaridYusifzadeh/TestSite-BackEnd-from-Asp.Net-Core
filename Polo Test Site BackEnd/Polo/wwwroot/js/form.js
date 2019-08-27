$(document).ready(function() {
    $(".first-line").css("boxShadow","5px 10px 15px lightgray");
    $("header").css("background-color", "white");
    $(window).scroll(function() {
        if (scrollY > 140) {
            $("header").css("background-color", "white");
            $("header").css("boxShadow","10px 20px 30px lightgray");
            $(".navbar-brand img").attr("src","img/logo_black.png");
            $(".first-line").hide(1000);
           
            // $(".navbar-nav .nav-link ").attr("style", "color: black !important");
        } else {
            $("header").css("background-color", "white");
            $(".navbar-brand img").attr("src", "img/logo_black.png");
            // $(".navbar-nav .nav-link ").attr("style", "color: black !important");
            $("header").css("boxShadow","0px 0px 0px lightgray");
            $(".first-line").show(1000);
        }
    })
})