$(document).ready(function () {
    var ulProducts = $('#ulProducts');

    $('#btn').click(function () {
        
        $.ajax({
            type: 'GET',
            url: 'https://localhost:44383/api/products',
            dataType: 'json',
            success: function (data) {
                ulProducts.empty();
                
                $.each(data, function (index, val) {
                    var name = val.name;
                    var price = val.price;
                    ulProducts.append('<li class="list-group-item d-flex justify-content-between align-items-center">' + name + '<span class="badge badge-primary badge-pill">' + price + 'EGP' + '</span></li>');
                    //var div = $('#productsDiv');
                    $('html, body').animate({
                        scrollTop: $($('#productsDiv')).offset().top
                    }, 2000);
                    
                });
            }
        });
    });
    $('#btnClear').click(function () {
        ulProducts.empty();
    });
});