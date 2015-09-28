app.controller('cadastroFinalCtrl', ['$scope', 'estadoService', 'cidadeService', 'bairroService', function ($scope, estadoService, cidadeService, bairroService) {
    $scope.anuncio = {};
    $scope.estados = [];
    $scope.cidades = [];
    $scope.bairros = [];
    $scope.carregarCidades = function () {
        if ($scope.anuncio.EstadoId) {
            cidadeService.listarPorEstado($scope.anuncio.EstadoId)
                .success(function (data) {
                    $scope.cidades = data;
                });
        } else {
            $scope.cidades = [];
        }
        $scope.anuncio.CidadeId = null;
    }

    $scope.carregarBairros = function () {
        if ($scope.anuncio.CidadeId) {
            bairroService.listarPorCidade($scope.anuncio.CidadeId)
                .success(function (data) {
                    $scope.bairros = data;
                });
        } else {
            $scope.bairros = [];
        }
        $scope.anuncio.BairroId = null;
    }

    estadoService.listar()
        .success(function (data) {
            $scope.estados = data;
        });
}]);