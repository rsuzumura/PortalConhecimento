app.controller('AnuncioController', ['$scope', 'anuncioService', function ($scope, anuncioService) {
    $scope.anuncio = {};
    $scope.anuncio.Tags = [];

    $scope.loadTags = function (query) {
        return anuncioService.listarPalavras(query);
    };

    $scope.gravar = function () {
        if (!formAnuncio.$invalid) {
            anuncioService.post($scope.anuncio)
            .success(function (data) {
                $(".btn-default")[0].click();
            })
            .error(function (data) {
                if (data.ModelState) {
                    var $errors = $("<ul></ul>");
                    for (var key in data.ModelState) {
                        for (var i = 0; i < data.ModelState[key].length; i++) {
                            $errors.append("<li>" + data.ModelState[key][i] + "</li>");
                        }
                    }

                    toastr.warning($errors, "Atenção, verifique os seguintes erros:");
                }
            });
        }
    };

    $scope.verificarTamanhoDescricao = function () {
        var tamanhoAtual = 4000 - ($scope.anuncio.Descricao ? $scope.anuncio.Descricao.length : 0);
        return tamanhoAtual;
    }
}]);