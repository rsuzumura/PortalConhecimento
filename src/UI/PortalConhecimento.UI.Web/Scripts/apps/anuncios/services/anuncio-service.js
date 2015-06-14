app.factory('anuncioService', ['$http', function ($http) {
    return {
        listarPalavras: function (palavraInicial) {
            return $http.get('/portaldoconhecimento1br/api/Anuncios/ListarPalavras', {
                params: { palavraInicial: palavraInicial }
            })
                .success(function (data) {
                    return data;
                })
                .error(function (data) {
                    return data;
                });
        },
        post: function (anuncio) {
            return $http.post('/portaldoconhecimento1br/api/Anuncios', anuncio)
                .success(function (data) {
                    return data;
                })
                .error(function (data) {
                    return data;
                });
        }
    };
}]);