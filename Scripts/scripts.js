function remove_vcenter_on_mobile(el){
	if($(window).width()<=768){	
		el.removeClass("vertical-center-ead");
	}
	else{
		el.addClass("vertical-center-ead");
	}
}

$(document).ready(function(){
	//$("#sidebar-ead").css({'height':$(window).height()});
	remove_vcenter_on_mobile($("#left-sidebar-ead"));
	$(window).resize(function(){
		//$("#sidebar-ead").css({'height':$(window).height()});
		remove_vcenter_on_mobile($("#left-sidebar-ead"));
	});
	$('html').click(function(){
		$("#bubble-login-ead").addClass("no-display-ead");
		$("#bubble-signup-ead").addClass("no-display-ead");
	});
	$("#login-trigger-ead").click(function(event){
		event.stopPropagation();
		$("#bubble-signup-ead").addClass("no-display-ead");
		$("#bubble-login-ead").toggleClass("no-display-ead");
		/*$("#bubble-login-ead")
		  .css('opacity', 0)
		  .slideDown('slow')
		  .animate(
		    { opacity: 1 },
		    { queue: false, duration: 'slow' }
		  );*/
	});
	$("#signup-trigger-ead").click(function(event){
		event.stopPropagation();
		$("#bubble-login-ead").addClass("no-display-ead");
		$("#bubble-signup-ead").toggleClass("no-display-ead");
		/*$("#bubble-signup-ead")
		  .css('opacity', 0)
		  .slideDown('slow')
		  .animate(
		    { opacity: 1 },
		    { queue: false, duration: 'slow' }
		  );*/
	});
});