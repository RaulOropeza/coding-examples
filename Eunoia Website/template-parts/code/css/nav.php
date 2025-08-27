<style>
    @media screen and (min-width: 1024px){
        #transparent-bg{
            position: absolute;
            width: 100%;
            height: 4rem;
            content: '';
            top: 0px;
            right: 0px;
            bottom: 0px;
            left: 0px;
            background: rgb(132,138,148);
            background: linear-gradient(135deg, rgba(132,138,148,1) 0%, rgba(55,62,68,1) 50%, rgba(18,20,30,1) 100%);
            opacity: 0.5;
        }
    }
/* LA IMAGEN */
    @media screen and (max-width: 1023px){
        .background-mobile{
            background-image: url('<?php echo bloginfo('url') . "/wp-content/uploads/2021/08/menu-curve-color.png" ?> ');
            background-size: 100% 100%;
        }
    }

                        
</style>