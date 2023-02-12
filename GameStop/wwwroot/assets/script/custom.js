﻿
// product search
$(document).ready(function () {

    $('#inputSearch').keyup(function (e) {

        e.preventDefault();


        let inputValue = $(this).val().trim();
        let url = $(this).data('url')

        let searchBrand = $(".search-brand").attr("class");


        url = url + '?search=' + inputValue;

        if (inputValue) {
            fetch(url)
                .then(res => res.text())
                .then(data => {
                    $('.search-brand .search-item').html(data);
                })
        }
        else
        {
            $('.search-brand .search-item').html('');
        }        
    })


    $(".close_button").click(function () {
        $(".search-brand").css({
            display: "none"
        });

    });

    $('#inputSearch').bind('focus', function () {
        $(".close_button").css({
            opacity: "1"
        });
    });


    $('#inputSearch').bind('blur', function () {
        $(".close_button").css({
            opacity: "0"
        });
    });

    // input count 

    $('.qtyOrder select').on('change', function (e) {
        e.preventDefault();

        let inputCount = $(this).val();

        if (inputCount >= 2) {
            let url = $(this).attr('href') + '/?count=' + inputCount;

            console.log(url);


            fetch(url)
                .then(res => res.text())
                .then(date => {
                    $('.basketindexcontainer').html(date);
                });
        }

        
    });

});


let inputBox = document.querySelector('#inputSearch')

inputBox.addEventListener('input', function () {
    document.querySelector('.search-brand').style.display = "block";
});