var objThat = this;

$(document).ready(function () {
    objThat.GetTotalCart();
    $("#Phone").setMask("(99) 99999-9999");
});

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