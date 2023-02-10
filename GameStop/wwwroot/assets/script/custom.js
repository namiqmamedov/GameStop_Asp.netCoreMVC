
// product search
$(document).ready(function () {

    $('#inputSearch').keyup(function () {

        let inputValue = $(this).val();
        let url = $(this).data('url')


        url = url + '?search=' + inputValue;

        if (inputValue) {
            fetch(url)
                .then(res => res.text())
                .then(data => {
                    $('.search-brand .search-item').html(data);
                })
        }
        else {
            $('.search-brand .search-item').html('');

        }
          
    })

});


