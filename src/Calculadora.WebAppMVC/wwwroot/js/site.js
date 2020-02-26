$(document).ready(function () {
    var agregado = 0;
    var valorTotal = 0;
    var valorOperacao = "";

    $(".btn-numero").click(function () {
        let valorVisor = $("#visorCalculadora").val();
        valorVisor += $(this).html();

        $("#visorCalculadora").val(valorVisor);
    });

    $(".btn-operacao").click(function () {
        let operacao = $(this).html();
        let valorVisor = parseInt($("#visorCalculadora").val());
        

        switch (operacao) {
            case "+":
                agregado = agregado == 0 ? valorVisor : agregado + valorVisor;
                valorOperacao = "+";
                $("#visorCalculadora").val("");
                break;
            case "-":
                agregado = agregado == 0 ? valorVisor : agregado - valorVisor;
                $("#visorCalculadora").val("");
                valorOperacao = "-";
                break;
            case "x":
                agregado = agregado == 0 ? valorVisor : agregado * valorVisor;
                valorOperacao = "X";
                $("#visorCalculadora").val("");
                break;
            case "/":
                agregado = agregado == 0 ? valorVisor : agregado / valorVisor;
                valorOperacao = "/";
                $("#visorCalculadora").val("");
                break;
            case "=":
                if (valorOperacao == "+") {
                    valorTotal = agregado + valorVisor;
                    $("#visorCalculadora").val(valorTotal);
                } 
                
                if (valorOperacao == "-"){
                    valorTotal = agregado - valorVisor;
                    $("#visorCalculadora").val(valorTotal);
                } 
                
                if (valorOperacao == "X") {
                    valorTotal = agregado * valorVisor;
                    $("#visorCalculadora").val(valorTotal);
                }
                
                if (valorOperacao == "/") {
                    valorTotal = agregado / valorVisor;
                    $("#visorCalculadora").val(valorTotal);
                }
                else 
                break;
                agregado = 0;
                break;
            default:
                $("#visorCalculadora").val("");
                agregado = 0;
                valorVisor = 0;
                valorTotal = 0;
                valorOperacao = ""
                break;
        }
    });
});