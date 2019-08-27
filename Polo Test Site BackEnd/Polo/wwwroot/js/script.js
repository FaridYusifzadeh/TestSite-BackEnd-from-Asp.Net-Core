$(document).ready(function () {
	$(".navbar-nav .nav-link ").attr("style", "color: white !important");
	var check=true;
	$(window).scroll(function () {
		if (scrollY > 140) {
			$("header").css("background-color", "white");
			$("header").css("boxShadow", "10px 20px 30px lightgray");
			$(".navbar-brand img").attr("src", "img/logo_black.png");
			$(".navbar-nav .nav-link ").attr("style", "color: black !important");
		} else {
			$("header").css("background-color", "");
			$(".navbar-brand img").attr("src", "img/brand.png");
			$(".navbar-nav .nav-link ").attr("style", "color: white !important");
			$("header").css("boxShadow", "0px 0px 0px lightgray");
		}
	// zzzzzzzzz// statistics counter///////////////////////////////////start zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz


		$('#results').each(function () {
			var $this = $(this), countTo = $this.attr('data-count');
			var bottom_of_object = $(this).position().top + $(this).outerHeight();
			var bottom_of_window = $(window).scrollTop() + $(window).height();
		
			if (bottom_of_window > bottom_of_object && check) {
				
				var numbers = $("#results h1");
			
				for (var i = 0; i < numbers.length; i++) {
					counting(numbers[i]);
				}
			}
			if (bottom_of_window > bottom_of_object){
			
				check=false;
			}
			else{
				check=true;
			}
		});
	})
	var counting = function (n) {
 var num_value = $(n).data("count");
		$({ Counter: 0 }).animate({
			Counter: num_value
		  }, {
			duration: 3000,
			easing: 'swing',
			step: function() {
			  $(n).text(Math.ceil(this.Counter));
			}
		  });
		
		
	}
//zzzzzz//statistics counter/////////////////////////////endd//zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz




	//main slider start
	// individual slide animations
	var slides = function slides(i) {
		// var _from = '#slide-1';
		var _to = '#slide-' + i;
		var bg = '#slide-' + i + ' .bg';
		var title = '#slide-' + i + ' h1';
		var text = '#slide-' + i + ' p';

		TweenLite.from(bg, 1, { scale: 1.25 });
		TweenLite.from(title, 1, { y: '105px', autoAlpha: 0 });
		TweenLite.from(text, 1, { delay: .5, y: '105px', autoAlpha: 0 });
	};

	// setup for the flickity slider
	var slideFlickity = function slideFlickity() {
		// flickity init	
		var slideList = $('.main-carousel').flickity({
			cellAlign: 'center',
			wrapAround: true,
			pageDots: true
		});

		slideClick(slideList);
	};

	var slideClick = function slideClick(slideList) {
		slideList.data('flickity').on('select', function () {
			var index = this.selectedIndex + 1;
			slides(index);
		});
	};

	// load flickity first
	slideFlickity();

	// intro animation second
	TweenLite.from('#slide-1 .bg', 1, { autoAlpha: 0 });
	TweenLite.from('#slide-1 h1', 1.5, { autoAlpha: 0, y: '-105px' });
	TweenLite.from('#slide-1 p', 1.5, { autoAlpha: 0, y: '105px' });
	TweenLite.from('.previous', .5, { x: '-50px' });
	TweenLite.from('.next', .5, { x: '50px' });
	TweenLite.from('.flickity-page-dots', .5, { y: '105%' });





	

	// brand slider start

	$('.customer-logos').slick({
		slidesToShow: 6,
		slidesToScroll: 1,
		autoplay: true,
		autoplaySpeed: 1000,
		arrows: false,
		dots: false,
		pauseOnHover: false,
		responsive: [{
			breakpoint: 768,
			settings: {
				slidesToShow: 4
			}
		}, {
			breakpoint: 520,
			settings: {
				slidesToShow: 3
			}
		}]
	});
	//brand slider end





})



