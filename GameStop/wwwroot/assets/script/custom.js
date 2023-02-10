
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

    $("#btn").click(function () {
        $("p").hide();
    });


    $('#inputSearch').on('input', function (e) {
       
    });

});


let inputBox = document.querySelector('#inputSearch')

inputBox.addEventListener('input', function () {
    document.querySelector('.search-brand').style.display = "block";
});