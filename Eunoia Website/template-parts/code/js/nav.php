<script>
        window.onscroll = function(ev) {
            if (window.scrollY > 0) {
                document.getElementById('transparent-bg').style.opacity = "0.9";
            } else{
                document.getElementById('transparent-bg').style.opacity = "0.5";
            }
        };
        function openNav() {
            document.getElementById("myNav").style.width = "100%";
        }
        
        function closeNav() {
            document.getElementById("myNav").style.width = "0%";
        }
        function openSearch() {
            document.getElementById("searchOver").style.width = "100%";
        }
        function closeSearch() {
            document.getElementById("searchOver").style.width = "0%";
        }
</script>