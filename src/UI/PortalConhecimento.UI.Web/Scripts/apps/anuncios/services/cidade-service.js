app.factory('cidadeService', ['$http', function ($http) {
    return {
        listarPorEstado: function (estadoId) {
            return $http.get('/portaldoconhecimento1br/api/cidades/listarporestado/' + estadoId)
                .success(function (data) {
                    return data;
                })
                .error(function (data) {
                    return data;
                });
        }
    };
}]);