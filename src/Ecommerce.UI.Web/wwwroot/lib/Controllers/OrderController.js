var objThat = this;

$(document).ready(function () {

    objThat.CalculateOrder();
    objThat.UpdateBasketCounter();
});

this.IncrementOrderItem = function (id) {

    this.ChangeQuantityOrderItem(id, true);
}

this.DecrementOrderItem = function (id) {

    this.ChangeQuantityOrderItem(id, false);
}

this.CalculateOrder = function () {

    $("#tbOrder > tbody > tr").each(function () {

        let productId = +$(this).attr("product-id");
        objThat.UpdateSubTotal(productId);
    });

    this.UpdateTotal();
}

this.ChangeQuantityOrderItem = function (id, isAdd) {

    let quantity = +$("#txtQuantity_" + id).val();
    quantity = isAdd ? quantity + 1 : quantity - 1;

    if (quantity < 0)
        quantity = 0;

    $("#txtQuantity_" + id).val(quantity);

    this.UpdateSubTotal(id);
    this.UpdateTotal();
    this.UpdateBasketCounter();
}

this.CalculateSubTotal = function (id) {

    let unitPrice = +$("#lblUnitPrice_" + id).text().replace(",", ".");
    let quantity = +$("#txtQuantity_" + id).val();
    return (unitPrice * quantity);
}

this.ToCurrency = function (value) {

    var number = +value;
    return new Intl.NumberFormat('pt-BR', { style: 'currency', currency: 'BRL' }).format(number);
}

this.UpdateSubTotal = function (id) {

    let subTotal = objThat.CalculateSubTotal(id);
    $("#lblTotalCostProduct_" + id).text(this.ToCurrency(subTotal));
}

this.UpdateTotal = function () {

    let total = 0;

    $("#tbOrder > tbody > tr").each(function () {

        let productId = +$(this).attr("product-id");
        total += objThat.CalculateSubTotal(productId);
    });

    $("#lblTotal").text(this.ToCurrency(total));
}

this.UpdateBasketCounter = function () {

    let count = 0;

    for (i = 0; i < $("input[id^='txtQuantity_']").length; i++) {
        debugger;
        count += +$("input[id^='txtQuantity_']")[i].value;
    }

    $("#lblBasketCounter").text(count);
}

this.RemoveOrderItem = function (id) {

    $("#tbOrder > tbody > tr[product-id='" + id + "']").remove();

    this.RemoveFromCart(id);

    this.UpdateSubTotal(id);
    this.UpdateTotal();
    this.UpdateBasketCounter();
}

this.RemoveFromCart = function (id) {

    $.ajax({
        type: "POST",
        url: '/remove-from-cart',
        contentType: 'application/json',
        dataType: 'JSON',
        headers: { "RequestVerificationToken": $('input[name="__RequestVerificationToken"]').val() },
        data: JSON.stringify(id)
    });
}
