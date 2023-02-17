$(document).ready(function () {
    $(document).on('click', '.removeBtn', function (e) {
        e.preventDefault();

        Swal.fire({
            title: 'Are you sure?',
            text: "You won't be able to revert this!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it!'
        }).then((result) => {
            if (result.isConfirmed) {


                let url = $(this).attr('href');

                fetch(url)
                    .then(res => res.text())
                    .then(data => {
                        $('.tbl-content').html(data)
                    });

                Swal.fire(
                    'Deleted!',
                    'Your file has been deleted.',
                    'success'
                )
            }
        })


    })

    $(document).on('click', '.restoreBtn', function (e) {
        e.preventDefault();

        Swal.fire({
            title: 'Are you sure you want to restore this category?',
            icon: 'info',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes'
        }).then((result) => {
            if (result.isConfirmed) {


                let url = $(this).attr('href');

                fetch(url)
                    .then(res => res.text())
                    .then(data => {
                        $('.tbl-content').html(data)
                    });

                Swal.fire(
                    'Recovered!',
                    'Your file has been recovered.',
                    'success'
                )
            }
        })


    })

    $(document).on("click", ".swal2-confirm", function (e) {
        e.preventDefault()

        let url = $(this).attr("class")

        alert("log");

        //fetch(url)
        //    .then(res => res.text())
        //    .then(data => {
        //        $('.tbl-content').html(data);
        //    })
    })


    // filter sort
    $(document).on("click", ".priceSortArea", function (e) {
        e.preventDefault()

        let url = $(this).attr("href")

        fetch(url)
            .then(res => res.text())
            .then(data => {
                $('.tbl-content').html(data);
            })
    })


    $('.dropdown-menu li a').click(function () {
        $('.selected-option').text($(this).text());
    });


    //$(document).on("click", ".page-link", function (e) {
    //    e.preventDefault()

    //    let url = $(this).attr("href")

    //    fetch(url)
    //        .then(res => res.text())
    //        .then(data => {
    //            $('.table-main').html(data);
    //        })
    //})
})