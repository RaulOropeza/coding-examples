<?php
$swiper = '<link rel="stylesheet" href="https://unpkg.com/swiper@6.8.0/swiper-bundle.min.css" />';
$swiper8 = '<link rel="stylesheet" href="https://unpkg.com/swiper@8/swiper-bundle.min.css"/>';

// Codigo CSS distribuido por página
get_template_part('template-parts/code/css/nav');

if ( is_front_page() ) {
// HOME 
    echo $swiper;
    get_template_part('template-parts/code/css/carousel');
    get_template_part('template-parts/code/css/gallery');
} elseif ( is_page('clases') ) {
    echo $swiper;
    get_template_part('template-parts/code/css/clases');
    get_template_part('template-parts/code/css/gallery');
} elseif ( is_page('studio-info') ) {
    echo $swiper8;
} elseif ( is_page('coaches') ) {
    echo $swiper;
    get_template_part('template-parts/code/css/adv-1');
    get_template_part('template-parts/code/css/gallery');
} elseif ( is_page('preguntas-frecuentes') ){
    get_template_part('template-parts/code/css/faq');
} elseif ( is_page ('blog')){
    echo  $swiper8;
    get_template_part('template-parts/code/css/blog');
} elseif ( is_page ('clases-gratuitas')){
    echo $swiper;
    get_template_part('template-parts/code/css/gallery');
} elseif ( is_page ('franquicia')){
    get_template_part('template-parts/code/css/franquicia');
} elseif ( is_author() || is_tag() || is_category()){
    echo  $swiper8;
    get_template_part('template-parts/code/css/blog');
} elseif ( is_category() ){
    echo $swiper;
    get_template_part('template-parts/code/css/gallery');
} elseif ( is_singular( 'coach' ) ){
    echo $swiper;
    get_template_part('template-parts/code/css/gallery');
} elseif( is_single() ){
    get_template_part('template-parts/code/css/entrada');
}
?>