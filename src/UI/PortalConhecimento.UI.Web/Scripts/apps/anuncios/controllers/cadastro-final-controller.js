app.controller('cadastroFinalCtrl', ['$scope', '$location', '$cookies', 'estadoService', 'cidadeService', 'bairroService', 'anuncioService', function ($scope, $location, $cookies, estadoService, cidadeService, bairroService, anuncioService) {
    $scope.anuncio = {};
    $scope.estados = [];
    $scope.cidades = [];
    $scope.bairros = [];

    if ($cookies.anuncio) {
        $scope.anuncio = $cookies.anuncio;
    }

    $scope.carregarCidades = function () {
        if ($scope.anuncio.EstadoId) {
            cidadeService.listarPorEstado($scope.anuncio.EstadoId)
                .success(function (data) {
                    $scope.cidades = data;
                    if ($scope.anuncio.CidadeId) {
                        $scope.carregarBairros();
                    }
                });
        } else {
            $scope.cidades = [];
            $scope.anuncio.CidadeId = null;
        }
    };

    $scope.carregarBairros = function () {
        if ($scope.anuncio.CidadeId) {
            bairroService.listarPorCidade($scope.anuncio.CidadeId)
                .success(function (data) {
                    $scope.bairros = data;
                });
        } else {
            $scope.bairros = [];
            $scope.anuncio.BairroId = null;
        }
    };

    $scope.voltar = function () {
        $cookies.anuncio = $scope.anuncio;
        $location.url('proximo');
    };

    $scope.gravar = function () {
        anuncioService.post($scope.anuncio)
            .success(function (data) {
                console.log('ok')
            });
    };

    $scope.obterBairro = function (id) {
        for (var i = 0; i < $scope.bairros.length; i++) {
            if ($scope.bairros[i].Id == id) {
                return $scope.bairros[i].Nome;
            }
        }
        return '';
    };

    $scope.loadTags = function (query) {
        return anuncioService.listarPalavras(query);
    };

    estadoService.listar()
        .success(function (data) {
            $scope.estados = data;
            if ($scope.anuncio.EstadoId) {
                $scope.carregarCidades();
            }
        });
}]);