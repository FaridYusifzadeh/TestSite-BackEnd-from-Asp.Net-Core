$(document).ready(function() {
    $("header").css("background-color", "white");
    $(".first-line").css("boxShadow","5px 10px 15px lightgray");
    $(window).scroll(function() {
       
        if (scrollY > 140) {
           
            $("header").css("background-color", "white");
            $("header").css("boxShadow","10px 20px 30px lightgray");
            $(".navbar-brand img").attr("src","img/logo_black.png");
            $(".navbar-nav .nav-link ").attr("style", "color: black !important");
            $(".first-line").hide(1000);
        } else {
            $("header").css("background-color", "white");
            $(".navbar-brand img").attr("src", "img/logo_black.png");
            $(".navbar-nav .nav-link ").attr("style", "color: black !important");
            $("header").css("boxShadow","0px 0px 0px lightgray");
            $(".first-line").show(1000);
        }
    })

//accordeon easy open-close start

$(".accordions h6").click(function(){
   
    
    
    if(!$(this).next().hasClass("stop")){

        $(this).next().addClass("stop");
        $(this).next().hide(500);
        this.lastChild.children[0].classList.replace("fa-minus","fa-plus")
    }else{
        $(this).next().removeClass("stop");
        $(this).next().show(500);
        this.lastChild.children[0].classList.replace("fa-plus","fa-minus")
    }
    

})

    //accordeon easy open-close end
    
    
})