<script>
   /* Swiper */
var swiper = Swiper;
var init = false;



/* Media query */
function swiperMode() 
{
    let mobile = window.matchMedia('(min-width: 0px) and (max-width: 768px)');
    let desktop = window.matchMedia('(min-width: 769px)');

    // Enable (for mobile)
  if(desktop.matches) 
  { 
    if (!init) 
    {
      init = true;
<?php 
$array = array("1","2","3","4");
foreach ($array as $number) {
?>

swiper = new Swiper('.clases-slider-<?php echo $number; ?>', 
      {
        slidesPerView: 1,
        spaceBetween: 10,
        loop: false,
        scrollbar: 
          {
            el: ".scrollbar-<?php echo $number; ?>",
            hide: false,
                        draggable: true,
                        snapOnRelease: true,
          },
          breakpoints: 
          {
            320: {
                        slidesPerView: 1.3,
                        spaceBetween: 15,
                    },
                    768: {
                         slidesPerView: 2.5,
                         spaceBetween: 20,
                    },
                    1024: {
                      slidesPerView: 2.5,
                      spaceBetween: 20,
                      centeredSlides: true
                    },
                    1424: {
                      slidesPerView: 3.5,
                      spaceBetween: 20,
                      centeredSlides: true
                    }

          }
      }); // swiper 1ß
<?php 
}
?>
    } // if init
  }  // match desktop    
  else if(mobile.matches) 
  {
    swiper.destroy();
    init = false;
  }
} // function
/* On Load
**************************************************************/
window.addEventListener('load', function() {
    swiperMode();
});

/* On Resize
**************************************************************/
window.addEventListener('resize', function() {
    swiperMode();
});

    
  </script>