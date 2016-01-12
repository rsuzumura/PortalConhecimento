app.controller('cadastroFinalCtrl', ['$scope', '$location', '$cookies', 'estadoService', 'cidadeService', 'bairroService', 'anuncioService', '$sce', function ($scope, $location, $cookies, estadoService, cidadeService, bairroService, anuncioService, $sce) {
    $scope.anuncio = {};
    $scope.estados = [];
    $scope.cidades = [];
    $scope.bairros = [];

    $scope.regiaoHelp = $sce.trustAsHtml("Indique o estado, cidade e, no caso das capitais, os bairros que você pode atender, marcando as caixas de seleção correspondentes.");
    $scope.custoHelp = $sce.trustAsHtml("<p>Especifique o valor de sua palestra. Dica: Não vale a pena fazer segredo do valor cobrado. Pesquisas apontam claramente que " +
        "itens com indicação de valor são muito mais procurados do que aqueles que não apresentam preço. Muitas vezes possíveis interessados não se dão ao trabalho de " +
        "perguntar o valor e escolhem algo que já deixa isso claro.</p><p>Você também tem a opção de oferecer palestrar gratuitas. Dica: Algumas pessoas podem estranhar " +
        "o fato de existir a opção de oferecer as palestras gratuitamente. Entretanto, a realidade é que hoje em dia, é normal isso acontecer. Pode ser um trabalho " +
        "voluntário, um tipo de treinamento para novatos, uma forma de conhecer mais pessoas, lugares ou empresas (ampliar o network), etc. Se você gosta dessa ideia, " +
        "faça como tantas outras pessoas e espalhe o conhecimento sem custo!</p>");

    $scope.palavraChaveHelp = $sce.trustAsHtml("<p>Dica: Esse campo não é obrigatório, mas pode aumentar a procura por sua palestra.</p>" +
        "<p>Anote aqui palavras chave que tenham a ver com o assunto de sua palestra. Essas palavras podem ajudar possíveis interessados (ou motores eletrônicos de busca) " +
        "a encontrar seu anúncio. Exemplo: Digamos que você oferece uma palestra sobre &quotTécnicas de Vendas&quot;, nesse caso as palavras chave poderiam ser: " +
        "<b>venda; cliente; empresarial, mercado, confiança, cenário, estratégia, organização, marketing, melhoria, aprimoramento, profissional, psicologia.</b></p>" +
        "<p>Sendo assim, se alguém tentar procurar por &quot;venda empresarial&quot;, ou &quot;usando marketing em vendas&quot;, etc. teria boa possibilidade de te " +
        "encontrar, já que você menciona tais denominações no seu anúncio.</p>");

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
                window.location.href = "/portaldoconhecimento1br/home/index/?cadastroOk=true";
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