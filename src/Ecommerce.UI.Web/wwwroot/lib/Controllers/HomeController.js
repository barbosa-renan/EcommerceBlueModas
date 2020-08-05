var objThat = this;

$(document).ready(function () {
    objThat.GetTotalCart();
});

this.AddToCart = function (productId) {

    $.ajax({
        type: "POST",
        url: '/add-to-cart',
        contentType: 'application/json',
        dataType: 'JSON',
        headers: { "RequestVerificationToken": $('input[name="__RequestVerificationToken"]').val() },
        data: JSON.stringify(productId),
        success: function (res) {

            debugger;

            if (res > 0) {
                alert("Produto adicionado!");
            }
            $("#lblBasketCounter").text(res);
        }
    });
}

this.GetTotalCart = function () {

    $.ajax({
        type: "GET",
        url: '/get-total-cart',
        contentType: 'application/json',
        dataType: 'JSON',
        headers: { "RequestVerificationToken": $('input[name="__RequestVerificationToken"]').val() },
        success: function (res) {

            $("#lblBasketCounter").text(res);
        }
    });
}