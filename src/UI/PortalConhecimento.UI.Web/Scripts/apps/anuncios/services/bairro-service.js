app.factory('bairroService', ['$http', function ($http) {
    return {
        listarPorCidade: function (cidadeId) {
            return $http.get('/portaldoconhecimento1br/api/bairros/listarporcidade/' + cidadeId)
                .success(function (data) {
                    return data;
                })
                .error(function (data) {
                    return data;
                });
        }
    };
}]);