$(window).scroll(function(){
    var wScroll = $(this).scrollTop();


    $('.dashboard').css({
        'transform' : 'translate(0px, '+ wScroll/13 +'%)'
    });

    $('.plx').css({
        'transform' : 'translate(0px, '+ wScroll/100 +'%)'
    });

});