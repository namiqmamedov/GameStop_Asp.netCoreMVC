$(".btn_container").click(function () {
    $(".over_lay").css({
        width: "100%"
    });
    $(".list_items_container").css({
        left: "0px"
    });
});
$(".over_lay, .close_btn").click(function () {
    $(".over_lay").css({
        width: "0px"
    });
    $(".list_items_container").css({
        left: "-300px"
    });
});



$(document).ready(function () {
    $('.dropdown-menu li a').click(function () {
        $('.selected-option').text($(this).text());
    });
})

//$(document).ready(function () {
//    if ($('.minicart-quantity').html() <= 0) {
//        $(".minicart-quantity").hide();
//    }
//});


var perfEntries = performance.getEntriesByType("navigation");

if (perfEntries[0].type === "back_forward") {
    location.reload();
}

$("#mMenu").click(function () {
    $(".search .fa-search").css({
        display: "none"
    })
});


$(".m-menu__toggle .close").click(function () {
    $(".search .fa-search").css({
        display: "block"
    })
});

$(".m-menu__overlay").click(function () {
    $(".search .fa-search").css({
        display: "block"
    })
});



$('.add-to-cart-menu').click(function (e) {
    e.preventDefault();

    let cartBtn = $(this).attr('href');
    let labelId = $(".labelId").val();


  /*  cartBtn = cartBtn + "?labelId=" + labelId*/

    fetch(cartBtn)
        .then(res => res.text())
        .then(data => {
            $('#mini-cart').html(data);
        });

});




