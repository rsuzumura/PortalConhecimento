/// <reference path="_references.js" />
jQuery.validator.unobtrusive.adapters.addSingleVal("cpf");

jQuery.validator.addMethod("cpf",
    function (val, element) {
        if (val) {
            return false;
        }
        return true;
    }
);