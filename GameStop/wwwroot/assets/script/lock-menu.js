const menu = $("#mMenu").click(function () {
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


const ratingRemove = $(".over_lay").click(function () {
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
   $(".m-menu__header").css({
      visibility: "visible"
   })
});

$(".menu-ul").click(function () {
   $(".menu1 li").css({
      display: "none"
   })
});



const scrollNone = $(".back-label").click(function () {

   if ($('#menuUl').addClass("vVisible")) {}

})

const scrollNone2 = $(".a-label__chevron").click(function () {

   if ($('.menu-ul').removeClass("vVisible")) {}

})