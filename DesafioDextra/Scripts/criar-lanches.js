﻿$(document).ready(function () {
    $("li").removeClass("active");
    $("#criar-lanche").addClass("active");
        
});

var ingredientes = [];
var precoFinal = 0;
var adicionar = function (ingrediente) {
    ingredientes.push(parseInt(ingrediente.getAttribute("data-ingredienteId")));

    var indice = ingredientes.length - 1;
    calcularPreco(ingredientes);


    var inserir = {
        id: ingrediente.getAttribute("data-ingredienteId"),
        nome: ingrediente.getAttribute("data-nome")
    };

    var tabela = $("#tabela-pedido");
    tabela.children("tbody").append('<tr id="ingrediente' + indice + '"><td>' + inserir.nome + '</td><td><button data-indice="' + indice + '" data-id="' + inserir.id + '" onclick="remover(this)">Remover</button></td></tr>');

}

var remover = function (ingrediente) {
    var indice = parseInt(ingrediente.getAttribute("data-indice"));

    var ingredienteId = parseInt(ingrediente.getAttribute("data-id"));

    var posicao = ingredientes.indexOf(ingredienteId);

    ingredientes.splice(posicao, 1);


    calcularPreco(ingredientes);

    var htmlRemover = $("#ingrediente" + indice);
    htmlRemover.remove();
}

var comprar = function () {
    if (precoFinal)
        alert("Obrigado por comprar com a gente! \n Preço total: " + precoFinal);
    else
        alert("Escolhe a seu pedido!")
}

var calcularPreco = function (ingredientes) {
    $.ajax({
        type: "POST",
        url: this.urls.calcularValor.replace("/Cardapio", ""),
        data: JSON.stringify(ingredientes),
        contentType: "application/json",
        success: function (response) {
            var preco = $("#preco");
            preco.children().remove();
            preco.append("<span>" + response.preco + "</span>");
            precoFinal = response.preco;
        },
        error: function (error) {
            console.log(error);
        }
    })
}