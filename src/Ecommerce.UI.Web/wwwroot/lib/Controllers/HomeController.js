var objThat = this;

$(document).ready(function () {

});

this.AddToCart = function (productId) {

    debugger;

    $.ajax({
        type: "POST",
        url: '/add-to-cart',
        contentType: 'application/json',
        dataType: 'JSON',
        headers: { "RequestVerificationToken": $('input[name="__RequestVerificationToken"]').val() },
        data: JSON.stringify(productId),
        success: function (json) {

            debugger;
            // alterar botão
        },
        error: function (error) {

            debugger;
            // exibir mensagem
        }
    });
}
