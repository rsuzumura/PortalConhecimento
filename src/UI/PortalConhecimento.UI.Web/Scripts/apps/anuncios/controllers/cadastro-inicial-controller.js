app.controller('cadastroInicialCtrl', ['$scope', '$location', '$cookies', '$sce', function ($scope, $location, $cookies, $sce) {
    $scope.anuncio = {};
    if ($cookies.anuncio) {
        $scope.anuncio = $cookies.anuncio;
    }

    $scope.assuntoHelp = $sce.trustAsHtml("Coloque aqui, em poucas palavras, o tema, assunto ou título da palestra que você oferece. Exemplo: <b>Técnicas de Vendas</b>. " +
        "Lembre-se que essa será a primeira coisa que levará as pessoas a te procurar. Busque uma forma resumida, mas que traga a essência daquilo que você oferece. Outros exemplos: " +
        "<b>Palestra Motivacional; Alimentação Saudável; Técnicas de Autodefesa; Atendimento no Setor Público; Degustação de Vinhos; Como Fabricar Pães Caseiros; Adestramento de cães; Mecânica de aviões; Como Assentar Porcelanato; Sistemas de Qualidade para Laboratórios; etc.</b>" +
        "Lembre-se que você pode abordar assuntos mais genéricos ou bastante específicos, complexos ou simples. O conhecimento que você possui, pode ser exatamente o que alguém está buscando. Sendo assim, não tenha receio " +
        "de oferecer algo, só porque é &quot;diferente&quot; do que normalmente se encontra por aí, ou porque é muito &quot;simples&quot;, &quot;complicado&quot; ou &quot;específico&quot;. Esse pode ser exatamente o seu ponto de destaque.");

    $scope.descricaoHelp = $sce.trustAsHtml("Nesse campo, insira mais informações e detalhes sobre o que você irá expor. Digamos que o tema de sua palestra " +
        "seja Técnicas de Vendas. Nesse caso, um exemplo de descrição detalhada poderia ser: <b>Na palestra são abordados os seguintes tópicos: Como entender a " +
        "necessidade do cliente; Ganhando a confiança do cliente; Adaptação ao cenário do cliente; Estratégias e Organização para vendas; Noções de Marketing e; Como Fechar o Negócio.</b>");

    $scope.observacoesHelp = $sce.trustAsHtml("Nesse campo, insira informações adicionais sobre a palestra, as quais você julgue pertinentes. Exemplo: " +
        "<b>Material de apoio disponível em forma de slides (Power Point). Se possível, é indicado o uso de projetor (Datashow) do cliente. " +
        "Outro exemplo: <b>Como material de apoio à palestra, são fornecidas aos participantes, apostilas com textos explicativos e exercícios.</b> " +
        "Se você possui um site, vídeos no Youtube, um escritório, etc., você pode citar aqui o endereço do seu site, vídeo ou escritório para divulgação " +
        "ainda mais detalhada. Não há restrição.");

    $scope.experienciaHelp = $sce.trustAsHtml("Indique aqui suas qualificações para falar sobre o tema.  Qual sua formação ou experiência no assunto, quais são os seus diferenciais, etc. " +
        "Exemplos: <b>Formado em Administração de empresas e 10 anos atuando como vendedor de uma multinacional;</b> ou: <b>5 anos trabalhando como mestre de obras em grandes " +
        "construtoras brasileiras;</b> ou: <b>Formado em Engenharia Química e Autor de um TCC com o título &quot;Sistemas de Qualidade para Laboratórios&quot;;</b> ou: " +
        "<b>20 anos como Dona de Casa e assando pães que são adorados pelos familiares e amigos;</b> ou: <b>Formado em técnico aeronáutico, mais de 15 anos trabalhando " +
        "com manutenções de aviões de grande porte e palestrante sobre o tema a mais de 5 anos;</b> ou:<b> Faixa preta de karatê, formado em técnicas de autodefesa e outros treinamentos no exército brasileiro.</b>");

    $scope.anuncio.TipoAnuncio = $("#hdnTipoAnuncio").val();

    $scope.avancar = function () {
        $cookies.anuncio = $scope.anuncio;
        $location.url('proximo');
    };
}]);