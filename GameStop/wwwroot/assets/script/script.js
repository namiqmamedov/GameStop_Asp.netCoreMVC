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
  


  $(document).ready(function() {
    $('.dropdown-menu li a').click(function() {
      $('.selected-option').text($(this).text());
    });
  })

  $(document).ready(function() {
    if ($('.minicart-quantity').html() <= 0) {
       $(".minicart-quantity").hide();
    }
  });
  
