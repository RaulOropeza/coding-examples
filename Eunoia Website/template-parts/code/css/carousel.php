<style>
    .carousel-home{
        height: 100vh;
        overflow: hidden;
    }    
    .swiper-pagination {
      bottom: 30px;
    left: 50%;
}
    .swiper-pagination-bullet{
      margin: 5px;
    }
    .swiper-pagination-bullet-active {
        background-color: #fff;
    }
    /* Degradado del fondo de los slides */
    .heroBackground{
        background: rgb(16,21,29); background: linear-gradient(90deg, rgba(16,21,29,1) 0%, rgba(16,21,29,0.75) 84%);
    }
    .swiper-button-next, .swiper-button-prev {
      color: #fff !important;
    position: absolute;
    top: 50%;
    width: calc(var(--swiper-navigation-size)/ 44 * 27);
    height: var(--swiper-navigation-size);
    margin-top: calc(0px - (var(--swiper-navigation-size)/ 2));
    z-index: 10;
    cursor: pointer;
    display: flex;
    align-items: center;
    justify-content: center;
    color: var(--swiper-navigation-color,var(--swiper-theme-color));
}

    @media only screen and (min-width: 1024px){
        .heroBackground{
            background: rgb(16,21,29); background: linear-gradient(90deg, rgba(16,21,29,1) 0%, rgba(16,21,29,0.6) 84%);
        }
    }
    @media only screen and (min-height: 768px){
        .carousel-home{
            height: 768px;
        }
    }
</style>