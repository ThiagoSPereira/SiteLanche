$(document).ready(function () {
    $("li").removeClass("active");
    $("#prontos").addClass("active");
});

var escolher = function (lanche) {
    var mensagem = "Lanche: " + lanche.getAttribute("data-nome") + " \n Preco: " + lanche.getAttribute("data-preco");

    alert(mensagem);
}