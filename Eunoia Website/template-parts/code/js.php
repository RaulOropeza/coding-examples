<?php
// Codigo JS distribuido por página
$swiper_js = '<script src="https://unpkg.com/swiper/swiper-bundle.min.js"></script>';
$isotope = '<script src="https://npmcdn.com/isotope-layout@3/dist/isotope.pkgd.js"></script>';
get_template_part('template-parts/code/js/nav');
get_template_part('template-parts/code/js/footer');
$gtag = '<!-- Global site tag (gtag.js) - Google Ads: 382182577 -->
<script async src="https://www.googletagmanager.com/gtag/js?id=AW-382182577"></script>
<script>
  window.dataLayer = window.dataLayer || [];
  function gtag(){dataLayer.push(arguments);}
  gtag("js", new Date());
  gtag("config", "AW-382182577");
</script>';

echo $gtag;
if ( is_front_page() ) {
// HOME
    echo $swiper_js;
    get_template_part('template-parts/code/js/carousel'); 
    get_template_part('template-parts/code/js/gallery'); 
} elseif ( is_page('clases') ) {
    echo $swiper_js;
    get_template_part('template-parts/code/js/clases');
    get_template_part('template-parts/code/js/gallery');
} elseif ( is_page('studio-info') ) {
    echo $swiper_js;
    get_template_part('template-parts/code/js/studio');
} elseif ( is_page('coaches') ) {
    echo $swiper_js;
    get_template_part('template-parts/code/js/gallery');
} elseif ( is_page('contacto-largo') ) {
    get_template_part('template-parts/code/js/franquicias');
} elseif ( is_page('clases-gratuitas') ) {
    echo $swiper_js;
    get_template_part('template-parts/code/js/gallery');
} elseif ( is_page('preguntas-frecuentes') ){
    get_template_part('template-parts/code/js/faq');
} elseif ( is_page ('blog')){
    echo $swiper_js;
    get_template_part('template-parts/code/js/blog');
} elseif ( is_author ()){
    echo $swiper_js;
    get_template_part('template-parts/code/js/blog');
} elseif ( is_category() ){
    echo $swiper_js;
    get_template_part('template-parts/code/js/gallery');
    echo $isotope;
    get_template_part('template-parts/code/js/videos');
} elseif ( is_singular( 'coach' ) ){
    get_template_part('template-parts/code/js/coach-page');
    echo $swiper_js;
    get_template_part('template-parts/code/js/gallery');
} elseif( is_single() ){
    get_template_part('template-parts/code/js/entrada');
} elseif ( is_search() ){
    echo $isotope;
    get_template_part('template-parts/code/js/videos');
    get_template_part('template-parts/code/js/faq');
}
?>