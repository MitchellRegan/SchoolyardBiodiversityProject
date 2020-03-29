var menumoved = false;

$(window).scroll(function () {
    if ($(window).scrollTop() > 200) {
        //main menu
        $("div.navbar.main-navi").css("position", "fixed");
        $("div.navbar.main-navi").css("z-index", "9999");
        $("div.navbar.main-navi").css("top", "0px");
        $("div.navbar.main-navi").css("left", "0px");
        $("div.navbar.main-navi").css("width", "100%");
        menumoved = true;
    }
    else if (menumoved == true) {
        //main menu
        $("div.navbar.main-navi").css("position", "");
        $("div.navbar.main-navi").css("z-index", "");
        $("div.navbar.main-navi").css("top", "-10px");
        menumoved = false;
    }
});


$(function () {
    $("li.mainmenu").each(function () {
        $(this).mouseover(function () {

            var submenuID = "#" + $(this).attr('id') + " .submenu";
            var internalWidth = 0;

            if ($(submenuID + " .submenu3").length) {
                $(submenuID + " .submenu3").each(function () {
                    internalWidth = internalWidth + $(this).outerWidth();
                });
                internalWidth = internalWidth + 25;
                $(submenuID).css({ 'width': internalWidth + 'px' });
            }


            var submenuRight = $(submenuID).offset().left + $(submenuID).outerWidth();
            var menuRight = $(this).offset().left + $(this).outerWidth();
            var menuWindowDif = $(window).outerWidth() - menuRight;
            if (submenuRight > $(window).outerWidth()) {
                $(submenuID).css({ 'left': 'auto' });
                $(submenuID).css({ 'right': '-' + menuWindowDif + 'px' });
            }

        });
    });
});