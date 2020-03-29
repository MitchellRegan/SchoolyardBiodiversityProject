//Controls toggleing of blocks in block templates that are wrapped in a clickhead class.
var opendivs='';
$(function() {
	opendivs = docCookies.getItem("opendivs");
  $(".clickhead").button({icons: {primary: "ui-icon-circle-plus"} });
  $('.clickhead').click(function() {
    var togglediv='#'+this.id+'div';
    var picturediv='#'+this.id+'img';
    if($(picturediv).length !=0){
      $(picturediv).toggle('fade','linear','slow',function(){
      $(togglediv).toggle('fade','linear','fast'); 
	  
   
	});
    }
    else
    {
      $(togglediv).toggle('fade','linear','fast'); 
    }
     
    $(this).data('state', ($(this).data('state') == 'expand') ? 'collapse' : 'expand');
    $(this).button({icons: { primary: ($(this).data('state') == "expand") ? "ui-icon-circle-minus" : "ui-icon-circle-plus"} });
	
	if(docCookies.getItem("opendivs") != this.id)
	{
		docCookies.setItem("opendivs", this.id, Infinity , "/" );
	}
	else{
			docCookies.setItem("opendivs",'none', Infinity , "/" );
	}
	
	
  });
  
  
  $('.blockimage').click(function() {
    var idHold=this.id;
    var idlength=idHold.length;
    var idroot=idHold.substr(0,idlength-3);
	
    var togglediv='#'+idroot+'div';
    var picturediv='#'+idroot+'img';
    $(picturediv).toggle('fade','linear','slow',function(){
      $(togglediv).toggle('fade','linear','fast'); 
   
	}); 
	$('#'+idroot).data('state', ($('#'+idroot).data('state') == 'expand') ? 'collapse' : 'expand');
	$('#'+idroot).button({icons: { primary: ($('#'+idroot).data('state') == "collapse") ?  "ui-icon-circle-plus" : "ui-icon-circle-minus" } });
  });

  
});
