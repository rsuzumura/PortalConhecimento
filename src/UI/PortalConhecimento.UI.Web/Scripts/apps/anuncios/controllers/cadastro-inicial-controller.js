app.controller('cadastroInicialCtrl', ['$scope', '$location', '$cookies', function ($scope, $location, $cookies) {
    if ($cookies.anuncio) {
        $scope.anuncio = $cookies.anuncio;
    }

    $scope.avancar = function () {
        $cookies.anuncio = $scope.anuncio;
        $location.url('proximo');
    };
}]);