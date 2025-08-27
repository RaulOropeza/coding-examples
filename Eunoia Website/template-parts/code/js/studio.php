<script>
const swiper = new Swiper('.swiper', {
        direction: 'horizontal',
        loop: true,
        grabCursor: true,
        speed: 800,
        spaceBetween: 20,
        slidesPerView: 'auto',
        freeMode: true,
        autoplay: {
            delay: 7000,
            disableOnInteraction: false,
        },
        // Responsive breakpoints
        breakpoints: {
            // when window width is >= 768px
            768: {
            spaceBetween: 24
            },
            // when window width is >= 1280px
            1280: {
            spaceBetween: 36
            },
        }
        });
</script>