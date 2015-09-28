var app = angular.module('AnuncioApp', ['ngTagsInput', 'ngRoute', 'ngCookies', 'ngAnimate', 'angular-bootstrap-select']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: '../scripts/apps/anuncios/cadastro-pagina1.html',
            controller: 'cadastroInicialCtrl'
        })
        .when("/proximo", {
            templateUrl: '../scripts/apps/anuncios/cadastro-pagina2.html',
            controller: 'cadastroProximoCtrl'
        })
        .when("/final", {
            templateUrl: '../scripts/apps/anuncios/cadastro-pagina3.html',
            controller: 'cadastroFinalCtrl'
        })
        .otherwise({ redirectTo: "/" });
}]);