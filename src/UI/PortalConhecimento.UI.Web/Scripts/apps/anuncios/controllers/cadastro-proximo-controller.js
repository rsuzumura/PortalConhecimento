app.controller('cadastroProximoCtrl', ['$scope', '$cookies', '$location', function ($scope, $cookies, $location) {
    $scope.anuncio = {
        DiaUtilInicio: 0,
        DiaUtilFim: 0,
        FimDeSemanaFeriadoInicio: 0,
        FimDeSemanaFeriadoFim: 0
    };

    $scope.formatarHora = function (valor) {
        var hora = "0" + parseInt(valor / 60).toString();
        var minutos = "0" + (valor % 60).toString();
        return right(hora, 2) + ":" + right(minutos, 2);
    }

    function right(value, size) {
        if (size <= 0) {
            return "";
        } else if (size > String(value).length) {
            return value;
        } else {
            var iLen = String(value).length;
            return String(value).substring(iLen, iLen - size);
        }
    }
}]);