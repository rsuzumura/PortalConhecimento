app.controller('cadastroProximoCtrl', ['$scope', '$cookies', '$location', function ($scope, $cookies, $location) {
    $scope.anuncio = {};
    if ($cookies.anuncio) {
        $scope.anuncio = $cookies.anuncio;
    }

    if (!$scope.anuncio.DiaUtilInicio) {
        $scope.anuncio.DiaUtilInicio = 0;
    }
    if (!$scope.anuncio.DiaUtilFim) {
        $scope.anuncio.DiaUtilFim = 0;
    }
    if (!$scope.anuncio.FimDeSemanaFeriadoInicio) {
        $scope.anuncio.FimDeSemanaFeriadoInicio = 0;
    }
    if (!$scope.anuncio.FimDeSemanaFeriadoFim) {
        $scope.anuncio.FimDeSemanaFeriadoFim = 0;
    }

    $scope.formatarHora = function (valor) {
        var hora = "0" + parseInt(valor / 60).toString();
        var minutos = "0" + (valor % 60).toString();
        return right(hora, 2) + ":" + right(minutos, 2);
    };

    $scope.voltar = function () {
        $cookies.anuncio = $scope.anuncio;
        $location.url('/');
    };

    $scope.avancar = function () {
        $cookies.anuncio = $scope.anuncio;
        $location.url('final');
    };

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