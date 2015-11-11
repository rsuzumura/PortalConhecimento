app.controller('cadastroInicialCtrl', ['$scope', '$location', '$cookies', function ($scope, $location, $cookies) {
    $scope.anuncio = {};
    if ($cookies.anuncio) {
        $scope.anuncio = $cookies.anuncio;
    }
    $scope.anuncio.TipoAnuncio = $("#hdnTipoAnuncio").val();

    $scope.avancar = function () {
        $cookies.anuncio = $scope.anuncio;
        $location.url('proximo');
    };
}]);