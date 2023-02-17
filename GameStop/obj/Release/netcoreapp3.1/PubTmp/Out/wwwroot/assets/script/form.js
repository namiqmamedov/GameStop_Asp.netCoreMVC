  
$(document).ready(function(){
	var formInputs = $('input[type="email"],input[type="password"],input[type="text"],input[type="tel"],.custom-select');
	formInputs.focus(function() {
       $(this).parent().children('p.formLabel').addClass('formTop');
       $(this).parent().children('label.checkoutLabel').addClass('formTop');
       $('div.logo').addClass('logo-active');
	});
	formInputs.focusout(function() {
		if ($.trim($(this).val()).length == 0){
		$(this).parent().children('p.formLabel').removeClass('formTop');
		$(this).parent().children('label.checkoutLabel').removeClass('formTop');
		}
		$('div.logo').removeClass('logo-active');
	});
	$('p.formLabel').click(function(){
		 $(this).parent().children('.form-style').focus();
	});
	$('label.checkoutLabel').click(function(){
		$(this).parent().children('.form-style').focus();
   });
});


