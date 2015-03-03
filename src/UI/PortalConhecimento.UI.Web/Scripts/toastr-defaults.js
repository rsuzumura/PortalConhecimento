$(function () {
    toastr.options.closeButton = true;
    toastr.options.progressBar = true;

    var errors = $(".validation-summary-errors>ul");
    var title = $(".validation-summary-errors>span").text();
    if (errors.length > 0) {
        toastr["error"](errors.html(), title);
    }
});