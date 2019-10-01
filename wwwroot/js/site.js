/*grava o estado do menu 
encolhido e expandido */
var sidebarState = localStorage.getItem('sidebarState');

windowWidth = $(window).width();

$(window).resize(function() {
  windowWidth = $(window).width();

  if( windowWidth < 768 ){ //768 is the value of $screen-md-min in boostrap variables.scss
      $("body").addClass("sidebar-toggled");
      $(".sidebar").addClass("toggled");
        
    }
    else{
        if(sidebarState){
            $("body").addClass("sidebar-toggled");
            $(".sidebar").addClass("toggled");
           
        }
        else{
            $("body").removeClass("sidebar-toggled");
            $(".sidebar").removeClass("toggled");
           
        }
    }
});
function setSidebarState(value){
    localStorage.setItem('sidebarState', value);
}

function clearSidebarState(){
 localStorage.removeItem('sidebarState');
}

function collapseSidebar(){
    $("body").toggleClass("sidebar-toggled");
      $(".sidebar").toggleClass("toggled");
   
}

function expandSidebar(){
    $("body").removeClass("sidebar-toggled");
    $(".sidebar").removeClass("toggled");
   
}

$(function () {

    console.log(windowWidth);

    /** check sessionStorage to expand/collapse sidebar onload **/


    if (sidebarState == "collapsed") {
        collapseSidebar();
    }
    else {



        if (windowWidth < 768) { //992 is the value of $screen-md-min in boostrap variables.scss
            $("body").addClass("sidebar-toggled");
            $(".sidebar").addClass("toggled");
           
        }
        else {
            if (sidebarState) {
                $("body").addClass("sidebar-toggled");
                $(".sidebar").addClass("toggled");
            
            }
            else {
                $("body").removeClass("sidebar-toggled");
                $(".sidebar").removeClass("toggled");
            
            }
        }
        
    }

    
   
    /** collapse the sidebar navigation **/
    
       
      
    // Toggle the side navigation
    $("#sidebarToggleTop").on('click', function () {
        if (!($("body").hasClass("sidebar-toggled"))) { // if sidebar is not yet collapsed
            expandSidebar();
            clearSidebarState();
           
        }
        else {
            setSidebarState('collapsed');
        }
        return false;
    });
});

