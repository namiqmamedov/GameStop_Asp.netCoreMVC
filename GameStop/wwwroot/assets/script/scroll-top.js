const toTop = document.querySelector(".to-top");

window.addEventListener("scroll", () => {
  if (window.pageYOffset > 235) {
    toTop.classList.add("active");
  } else {
    toTop.classList.remove("active");
  }
})


$(document).ready(function() {

  $('.one').on('click', function() {


    $('.features').get(0).scrollIntoView({
      block: "start",
      behavior: "smooth"
    });

  });

  
  function scrollToElement(element, parent) {
    $(parent)[0].scrollIntoView(true);
    $(parent).animate({
      scrollTop: $(parent).scrollTop() + $(element).offset().top - $(parent).offset().top
    }, {
      duration: 'slow',
      easing: 'swing'
    });
  }

  $('.two').on('click', function() {
    var paretq = $('.description');
    var elemq = $('.twoDesc');
    scrollToElement(elemq, paretq);
  })

  $('.three').on('click', function() {
    var paretq = $('.specifications');
    var elemq = $('.twoDesc');
    scrollToElement(elemq, paretq);
  })

  $('.four').on('click', function() {
    var paretq = $('.rating-and-reviews');
    var elemq = $('.twoDesc');
    scrollToElement(elemq, paretq);
  })


  $('.five').on('click', function() {
    var paretq = $('.question-and-answers');
    var elemq = $('.twoDesc');
    scrollToElement(elemq, paretq);
  })


})



var container = $('#menu1');

function topNav() {
	var scrollTo = $("#m-menu2");
    var position = scrollTo.offset().top * 10  - container.offset().top + container.scrollTop() ;
	container.animate({
		scrollTop: position
	});
}













