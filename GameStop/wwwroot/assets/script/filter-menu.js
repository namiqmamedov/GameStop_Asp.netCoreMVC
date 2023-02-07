
$(".write-menu").click(function () {
  $(".header-main").css({
    position: "static"
  });

});

$(".bar").click(function () {
  $(".header-main").css({
    position: "sticky"
  });

});


$(".question-menu").click(function () {
  $(".header-main").css({
    position: "static"
  });

});

$(".add-to-cart-menu").click(function () {
  $(".header-main").css({
    position: "static"
  });

});

$(".bar1").click(function () {
  $(".header-main").css({
    position: "sticky"
  });

});

$(".bar2").click(function () {
  $(".header-main").css({
    position: "sticky"
  });

});





(function () {
  $('.write-menu').on('click', function () {
    $(".overlay-back").css({
      width: "100%"
    });


    $('.bar').toggleClass('animate');
    $('.navMenu').toggleClass('active');
    return false;
  })

  $('.question-menu').on('click', function () {
    $(".overlay-back1").css({
      width: "100%"
    });



    $('.bar1').toggleClass('animate');
    $('.navMenu1').toggleClass('active');
    return false;
  })


  $('.add-to-cart-menu').on('click', function () {
    $(".overlay-back2").css({
      width: "100%"
    });

    $('.bar2').toggleClass('animate');
    $('.navMenu2').toggleClass('active');
    return false;
  })


  $(".overlay-back").on('click', function () {
    $(".overlay-back").css({
      width: "0%"
    });


  });

  $(".overlay-back1").on('click', function () {
    $(".overlay-back1").css({
      width: "0%"
    });


  });

  
  $(".overlay-back2").on('click', function () {
    $(".overlay-back2").css({
      width: "0%"
    });


  });


  $(".bar").on('click', function () {
    $(".overlay-back").css({
      width: "0%"
    });


  });

  $(".bar1").on('click', function () {
    $(".overlay-back1").css({
      width: "0%"
    });


  });

  $(".bar2").on('click', function () {
    $(".overlay-back2").css({
      width: "0%"
    });


  });




})();


const ratingRemove = $(".bar").click(function () {
  if ($('.navMenu').removeClass("active")) {}

  if ($('.overlay-back').removeClass("active")) {}


})

const askRemove = $(".bar1").click(function () {
  if ($('.navMenu1').removeClass("active")) {}

  if ($('.navMenu').removeClass("active")) {}

  if ($('.overlay-back1').removeClass("active")) {}


})

const askRemove2 = $(".bar2").click(function () {
  if ($('.navMenu2').removeClass("active")) {}

  

  if ($('.overlay-back2').removeClass("active")) {}


})


const posStat22ic2 = $(".bar2").click(function () {
  if ($('.navMenu2').removeClass("filterRemove")) {}

})


const ratingActive = $(".write-menu").click(function () {
  if ($('.navMenu').addClass("active")) {}

})

const ratingActiv2e = $(".add-to-cart-menu").click(function () {
  if ($('.navMenu2').addClass("active")) {}

})


const posSticky = $(".write-menu").click(function () {
  if ($('.all-table').addClass("filterRemove")) {}

})

const posStickyy = $(".question-menu").click(function () {
  if ($('.all-table').addClass("filterRemove")) {}

})


const posStickyyy = $(".add-to-cart-menu").click(function () {
  if ($('.all-table').addClass("filterRemove")) {}

})



const posStatic1 = $(".bar").click(function () {
  if ($('.all-table').removeClass("filterRemove")) {}

})
const posStatic2 = $(".bar1").click(function () {
  if ($('.all-table').removeClass("filterRemove")) {}

})

const posStatic3 = $(".bar2").click(function () {
  if ($('.all-table').removeClass("filterRemove")) {}

})


const owHidden = $(".write-menu").click(function () {
  if ($('body').addClass("overflow-hidden")) {}

})
const owHidden1 = $(".question-menu").click(function () {
  if ($('body').addClass("overflow-hidden")) {}

})
const owHidde2 = $(".add-to-cart-menu").click(function () {
  if ($('body').addClass("overflow-hidden")) {}

})

const owStatic1 = $(".overlay-back1").click(function () {
  if ($('body').removeClass("overflow-hidden")) {}

})

const owStatic2 = $(".overlay-back2").click(function () {
  if ($('body').removeClass("overflow-hidden")) {}

})

const owStatic = $(".overlay-back").click(function () {
  if ($('body').removeClass("overflow-hidden")) {}

})

const owStaticBar = $(".bar").click(function () {
  if ($('body').removeClass("overflow-hidden")) {}

  if ($('.scroll-up').removeClass("filterRemove")) {}

})
const owStaticBar1 = $(".bar1").click(function () {
  if ($('body').removeClass("overflow-hidden")) {}

  if ($('.scroll-up').removeClass("filterRemove")) {}
  
  if ($('.navMenu').removeClass("filterRemove")) {}


})

const owStaticBar2 = $(".bar2").click(function () {
  if ($('body').removeClass("overflow-hidden")) {}

  if ($('.scroll-up').removeClass("filterRemove")) {}
  
  if ($('.navMenu2').removeClass("filterRemove")) {}


})




const posStatic = $(".overlay-back").click(function () {
  if ($('.all-table').removeClass("filterRemove")) {}

})

const ratingOverlay = $(".overlay-back").click(function () {
  if ($('.navMenu').removeClass("active")) {}

})

const posStaticc = $(".overlay-back1").click(function () {
  if ($('.all-table').removeClass("filterRemove")) {}

  if ($('.navMenu').removeClass("active")) {}

})

const ratingOverlayy = $(".overlay-back1").click(function () {
  if ($('.navMenu1').removeClass("active")) {}

})

const posStaticDas = $(".overlay-back2").click(function () {
  if ($('.all-table').removeClass("filterRemove")) {}

  if ($('.navMenu').removeClass("active")) {}

})

const ratingOverlayCnt = $(".overlay-back2").click(function () {
  if ($('.navMenu2').removeClass("active")) {}

})


const scrollNone = $(".question-menu").click(function () {
  if ($('.scroll-up').addClass("filterRemove")) {}

  if ($('.navMenu').addClass("filterRemove")) {}

})

const cartMenu = $(".add-to-cart-menu").click(function () {
  if ($('.scroll-up').addClass("filterRemove")) {}

  if ($('.navMenu').addClass("filterRemove")) {}

})


const scrollBlock = $(".overlay-back1").click(function () {
  if ($('.scroll-up').removeClass("filterRemove")) {}

  if ($('.navMenu').removeClass("filterRemove")) {}

})


const scrollBlock2 = $(".overlay-back2").click(function () {
  if ($('.scroll-up').removeClass("filterRemove")) {}

  if ($('.navMenu').removeClass("filterRemove")) {}

})

const scrollNone1 = $(".write-menu").click(function () {
  if ($('.scroll-up').addClass("filterRemove")) {}

})

const scrollBlock1 = $(".overlay-back").click(function () {
  if ($('.scroll-up').removeClass("filterRemove")) {}

})





const menu1 = $("#mMenu").click(function () {
  if ($('body').addClass("lock-scroll")) {}
})


const menuover = $(".m-menu__overlay").click(function () {
  if ($('body').removeClass("lock-scroll")) {}
})

const menuClose = $(".close").click(function () {
  if ($('body').removeClass("lock-scroll")) {}
})


const filterOptions = $(".filter-options").click(function () {
  if ($('body').addClass("lock-scroll")) {}
})

const filterRemove = $(".over_lay").click(function () {
  if ($('body').removeClass("lock-scroll")) {}
})

const filterRemoveBtn = $(".close_btn").click(function () {
  if ($('body').removeClass("lock-scroll")) {}
})


const filterOptions1 = $(".filter-options").click(function () {
  if ($('.header-main').addClass("none")) {}
})

const filterRemove1 = $(".over_lay").click(function () {
  if ($('.header-main').removeClass("none")) {}
})

const menuPosition = $("#mMenu").click(function () {
  if ($('.filter-options').addClass("filterRemove")) {}
})

const menuPosition1 = $(".close").click(function () {
  if ($('.filter-options').removeClass("filterRemove")) {}
})


const menuPositionn2 = $(".close").click(function () {
  if ($('.filter-options').removeClass("filterRemove")) {}
})


const ratingOptions = $(".filter-options").click(function () {
  if ($('body').addClass("lock-scroll")) {}
})

const ratingRemoveBtn = $(".close_btn").click(function () {
  if ($('body').removeClass("lock-scroll")) {}
})

const ratingRasemove = $(".over_lay").click(function () {
  if ($('body').removeClass("lock-scroll")) {}

})

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


$(".menu-ul").click(function () {
  $(".menu-ul-1").css({
    visibility: "visible"
  })
});

$(".menu-ul").click(function () {
  $(".menu-ul").css({
    visibility: "hidden"
  })
});




$(".menu-ul").click(function () {
  $(".menu1 li").css({
    display: "none"
  })
});

$("#mMenu").click(function () {
  $(".all-table").css({
  
  transform: "translateY(533px)"
  })
});

$(".close").click(function () {
  $(".all-table").css({
  
  transform: "translateY(0px)"
  })
});

$(".m-menu__overlay").click(function () {
  $(".all-table").css({
  
  transform: "translateY(0px)"
  })
});






const scroddllNone = $(".back-label").click(function () {

  if ($('#menuUl').addClass("vVisible")) {}

})

const scrollNone2 = $(".a-label__chevron").click(function () {

  if ($('.menu-ul').removeClass("vVisible")) {}

})



const menuOverflow = $(".img-main").click(function () {
  if ($('body').addClass("lock-scroll")) {}
})

const closeModel = $(".item-overlay__btn-img").click(function () {
  if ($('body').removeClass("lock-scroll")) {}
})

const closeModel1 = $(".item-overlay slide").click(function () {
  if ($('body').removeClass("lock-scroll")) {}
})
$(".img-main").click(function () {
  $(".all-table").css({
    top: "100%"
  });
});

$(".item-overlay__btn-img").click(function () {
  $(".all-table").css({
    top: "0%"
  });
});

