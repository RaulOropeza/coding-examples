<script>
   /* Swiper
**************************************************************/
var swiper= Swiper;
var init = false;
function swiperMode_gallery() { 
       if (init) {
       // swiper.destroy();
       }
      
           init = true;
           
           swiper = new Swiper('.categorias-slider', {
             slidesPerView: 1,
             spaceBetween: 10,
             loop: false,
             scrollbar: {
                       el: ".scrollbar-5",
                       hide: false,
                       draggable: true,
                       snapOnRelease: true,
                     },
             breakpoints: {

                   320: {
                       slidesPerView: 1.3,
                       spaceBetween: 15,
                   },
                   768: {
                        slidesPerView: 2.5,
                        spaceBetween: 20,
                   },
                   1024: {
                     slidesPerView: 4.5,
                     spaceBetween: 20,
                     
                   },
                   1424: {
                     slidesPerView: 5.5,
                     spaceBetween: 20,
                   }
               }
           });
}
/* On Load
**************************************************************/
window.addEventListener('load', function() {
   swiperMode_gallery();
   
});

/* On Resize
**************************************************************/
window.addEventListener('resize', function() {
  swiperMode_gallery();
 
});

// let array = document.getElementById("array").innerHTML;
 </script>