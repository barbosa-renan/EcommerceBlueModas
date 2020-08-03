var objThat = this;

$(document).ready(function () {

    objThat.CalculateOrder();
});

this.CalculateOrder = function () {

    let total = 0;

    for (i = 1; i <= $("#tbOrder > tbody > tr").length; i++) {
        this.UpdateSubTotal(i);
    }

    this.UpdateTotal();
}

this.IncrementOrderItem = function (id) {

    let quantity = +$("#txtQuantity_" + id).val();
    quantity += 1;

    $("#txtQuantity_" + id).val(quantity);

    this.UpdateSubTotal(id);
    this.UpdateTotal();
}

this.DecrementOrderItem = function (id) {

    let quantity = +$("#txtQuantity_" + id).val();
    quantity -= 1;

    if (quantity < 0)
        quantity = 0;

    $("#txtQuantity_" + id).val(quantity);

    this.UpdateSubTotal(id);
    this.UpdateTotal();
}

this.UpdateSubTotal = function (id) {

    let subTotal = objThat.CalculateSubTotal(id);
    $("#lblTotalCostProduct_" + id).text(this.ToCurrency(subTotal));
}

this.UpdateTotal = function () {

    let total = 0;

    for (i = 1; i <= $("#tbOrder > tbody > tr").length; i++) {
        total += this.CalculateSubTotal(i);
    }

    $("#lblTotal").text(this.ToCurrency(total));
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