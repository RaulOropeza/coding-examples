<section id="adv-1">
    
    <?php 
    if ( wp_is_mobile() ) {
        echo adrotate_ad(4); 
    } else {
        echo adrotate_ad(3); 
    }
  
    ?>
    <!--div class="holder mx-auto container bg-gris-800">
        <div class="grid grid-cols-4 lg:grid-cols-12 lg:bg-none" style="background-image: url(https://source.unsplash.com/768x900); background-size: cover;">
            <div class="col-span-4 xl:col-span-6 lg:col-span-6 bg-rosa-600 bg-opacity-70 z-20">
                <div class="inner p-20 mb-28 lg:p-8 xl:p-16 xl:mb-20 2xl:p-20 2xl:mb-28">
                    <h4 class="font-bold text-white font-sans text-6xl">
                        entrena ahora con nuestro contenido de libre acceso
                    </h4>
                    <p class="font-serif text-4xl lg:text-xl text-white my-6 text-4xl lg:text-base">
                        totalmente libre, no se necesita una tarjeta de crédito o algún dato, cancela en cualquier momento
                    </p>
                    <button class="text-4xl lg:text-xl mt-8 md:mt-2 w-full lg:w-auto px-10 py-4+ rounded-full text-gris-950 font-sans bg-white  md:ml-2 xl:ml-4 flex items-center">
                        prueba 7 días gratis
                    </button>
                </div>
                
            </div>
            <div class="col-span-4 xl:col-span-6 lg:col-span-6 sm:absolute lg:relative z-0 overflow-hidden">
                <span class="h-full w-full absolute bg-no-repeat bg-cover bg-rosa-200" style="background-image:url('https://source.unsplash.com/768x700')" ></span>
            </div>
        </div>
    </div-->
</section>
