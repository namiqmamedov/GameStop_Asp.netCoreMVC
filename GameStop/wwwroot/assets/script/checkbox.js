$(".platform-box input:checkbox").on('click', function () {

   // console.log('hello');
   var $box = $(this);
   if ($box.is(":checked")) {

      var group = "input:checkbox[name='" + $box.attr("name") + "']";

      $(group).prop("checked", false);
      $box.prop("checked", true);
   } else {
      $box.prop("checked", false);
   }

});

function clearRadioButtons() {
   var ele = document.querySelectorAll("input[type=radio],input[type=checkbox]");
   for (var i = 0; i < ele.length; i++) {
      ele[i].checked = false;
   }
}


$(document).ready(function () {

   var checkElem = $('.platform-box input[type="checkbox"');
   var checkElem1 = $('.condition-box input[type="checkbox"');


   checkItem();

   checkElem.change(function (event) {
      checkItem();
      checkDelete();
   });


   
   checkElem1.change(function (event) {
      checkItem();
      checkDelete();
   });



   function checkItem() {
      var itemLabel = Array();
      var itemLabel1 = Array();
      checkElem.each(function () {
         if ($(this).prop('checked')) {
            itemLabel.push($(this).next('label').text());
         }
      });
      checkElem1.each(function () {
         if ($(this).prop('checked')) {
            itemLabel1.push($(this).next('label').text());
         }
      });
      var itemLabelsStr = itemLabel.join();
      var itemLabelsStr1 = itemLabel1.join();
      if (itemLabel.length > 0) {
         $('.platform-name').text(itemLabelsStr);
      } 
      if (itemLabel1.length > 0) {
         $('.condition-name').text(itemLabelsStr1);
      } 
   }

});