<script>
        const swiper1 = new Swiper('.swiper-container-1', {
        direction: 'horizontal',
        loop: false,
        grabCursor: true,
        speed: 400,
        spaceBetween: 16,
        slidesOffsetAfter: 32,
        slidesPerView: 'auto',
        freeMode: true,
        autoplay: false,
        // Responsive breakpoints
        breakpoints: {
            // when window width is >= 768px
            768: {
            spaceBetween: 18
            },
            // when window width is >= 1280px
            1280: {
            spaceBetween: 24
            },
        }
        });

        const swiper2 = new Swiper('.swiper-container-2', {
        direction: 'horizontal',
        loop: false,
        grabCursor: true,
        speed: 400,
        spaceBetween: 14,
        slidesOffsetAfter: 32,
        slidesPerView: 'auto',
        freeMode: true,
        autoplay: false,
        // Responsive breakpoints
        breakpoints: {
            // when window width is >= 768px
            768: {
            spaceBetween: 16
            },
            // when window width is >= 1280px
            1280: {
            spaceBetween: 18
            },
        }
        });
        function orderPopup() {
            let ordenar_popup = document.getElementsByClassName("ordenar-popup");
            ordenar_popup[0].classList.toggle('hidden');
        }
    </script>