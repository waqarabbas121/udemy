// custom-js

jQuery(document).ready(function($) {

    // menu-js
    jQuery('.stellarnav').stellarNav();

    // flexslider
    $('.flexslider').flexslider({
        animation: "fade",
        slideshowSpeed: 6000, //Integer: Set the speed of the slideshow cycling, in milliseconds
        animationSpeed: 800
    });

    // owl-carousel-financial
    $('.owl-carousel-financial').owlCarousel({
        loop: false,
        margin: 20,
        nav: true,
        rewind: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            1000: {
                items: 3
            }
        }
    })

    // owl-carousel
    $('.owl-carousel').owlCarousel({
        loop: false,
        margin: 20,
        nav: true,
        rewind: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 3
            },
            1000: {
                items: 4
            }
        }
    })


    // owl-carousel-related-course
    $('.owl-carousel-related-course').owlCarousel({
        loop: false,
        margin: 20,
        nav: true,
        rewind: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            1000: {
                items: 3
            }
        }
    })

    // adding,removing active class on tabs li
    $('.nav-tabs').on('click', 'li', function() {
        $('.nav-tabs li.active').removeClass('active');
        $(this).addClass('active');
    });



});