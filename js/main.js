$(function() {
    $('.page-scroll a').bind('click', function(event) {
        var $anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: $($anchor.attr('href')).offset().top 
        }, 1400, 'easeInOutExpo');
        event.preventDefault();
    });
});