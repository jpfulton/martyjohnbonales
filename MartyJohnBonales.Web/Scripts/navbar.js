$(function () {
    var currentUrl = document.URL;

    if (currentUrl.indexOf("Resources") > -1) {
        $("#resources-navbar-link").addClass("active");
    }
    else if (currentUrl.indexOf("Contact") > -1) {
        $("#contact-navbar-link").addClass("active");
    }
});