<script>
    const swiper_12 = new Swiper('.carousel-home', {
        direction: 'horizontal',
        loop: true,
        grabCursor: true,
        speed: 500,
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
        },
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev',
        },
        autoplay: {
            delay: 10000,
            disableOnInteraction: false,
        },
    });
</script>