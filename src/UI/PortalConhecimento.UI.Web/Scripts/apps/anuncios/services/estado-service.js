app.factory('estadoService', ['$http', function ($http) {
    return {
        listar: function () {
            return $http.get('/portaldoconhecimento1br/api/estados')
                .success(function (data) {
                    return data;
                })
                .error(function (data) {
                    return data;
                });
        }
    };
}]);