app.controller('cadastroProximoCtrl', ['$scope', '$cookies', '$location', '$sce', function ($scope, $cookies, $location, $sce) {
    $scope.anuncio = $cookies.anuncio ? $cookies.anuncio : {
        'DiaUtil': [0, 0],
        'FimDeSemanaFeriado': [0, 0]
    };

    $scope.horariosHelp = $sce.trustAsHtml("Indique se você tem disponibilidade de horário nos dias de semana, nos finais de semana, ou em ambos. Para isso, Deixe marcadas as caixas de seleção abaixo  (X).<br />" +
        "Depois, arraste os círculos brancos para indicar qual o período do dia (horário) que você tem disponível.<br />" +
        "Os horários também aparecerão na caixa azul: (<label class='label label-primary ng-binding'>Das 00:00 até 23:59</label>)<br />" +
        "Caso você tenha um horário mais flexível, você ainda pode marcar a opção &quot;À combinar&quot;");

    $scope.slideOptions = {
        formatter: function (value) {
            var hora1 = parseInt(value[0] / 60);
            var minutos1 = value[0] % 60;
            var hora2 = parseInt(value[1] / 60);
            var minutos2 = value[1] % 60;
            return [right('0' + hora1, 2) + ':' + right('0' + minutos1, 2), right('0' + hora2, 2) + ':' + right('0' + minutos2, 2)];
        }
    };

    if ($cookies.anuncio) {
        $scope.anuncio = $cookies.anuncio;
    }

    $scope.formatarHora = function (valor) {
        var hora = "0" + parseInt(valor / 60).toString();
        var minutos = "0" + (valor % 60).toString();
        return right(hora, 2) + ":" + right(minutos, 2);
    };

    $scope.voltar = function () {
        $cookies.anuncio = $scope.anuncio;
        $location.url('/');
    };

    $scope.avancar = function () {
        $cookies.anuncio = $scope.anuncio;
        $location.url('final');
    };

    function right(value, size) {
        if (size <= 0) {
            return "";
        } else if (size > String(value).length) {
            return value;
        } else {
            var iLen = String(value).length;
            return String(value).substring(iLen, iLen - size);
        }
    }
}]);