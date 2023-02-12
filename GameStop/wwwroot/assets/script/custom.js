
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


    $(document).on('click', '.inputs-block .minus', function () {
        var $_inp = $(this).parent().find('input');
        $_inp.val(parseInt($_inp.val()) - 1);
        $_inp.trigger('propertychange');
        return false;
    });

    $(document).on('click', '.inputs-block .plus', function () {
        var $_inp = $(this).parent().find('input');
        $_inp.val(parseInt($_inp.val()) + 1);
        $_inp.trigger('propertychange');
        return false;
    });

    $('.inputs-block input').bind('input propertychange', function () {
        var $this = $(this);
        $this.val($this.val().replace(/[^0-9]/gim, ''));
        if ($this.val().length == 0 || parseInt($this.val()) <= 0)
            $this.val(1);
        var a = $('.inputs-block input').val();
        var b = $('body').find('#pum-344').find('input[name="count"]').val(a);
    });

  

});


let inputBox = document.querySelector('#inputSearch')

inputBox.addEventListener('input', function () {
    document.querySelector('.search-brand').style.display = "block";
});

