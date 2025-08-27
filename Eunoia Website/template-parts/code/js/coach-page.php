<script>
        
        let lastKnownScrollPosition = 0;
        let ticking = false;
        const info = document.getElementById('information');
        let infoHeight = info.offsetHeight;
        let mini = false;

        const scroll = e => {
            let profile = document.getElementById('profile');
            let name = document.getElementById('name');
            profile.className = "col-span-3  hidden lg:block";
           // name.classList.remove('hidden');
            let mini = true;
        }
        const scrollUp = e => {
            let profile = document.getElementById('profile');
            let name = document.getElementById('name');
            profile.className = "col-span-4  hidden lg:block";
          //  name.classList.add('hidden');
            let mini = false;
        }
      
        function doSomething(scrollPos) { 
            if (!(lastKnownScrollPosition > infoHeight)) {
                scrollUp();
            }
            else { scroll();
            }
        }

        document.addEventListener('scroll', function(e) {
        lastKnownScrollPosition = window.scrollY;
        
        if (!ticking) {
            window.requestAnimationFrame(function() {
            doSomething(lastKnownScrollPosition);
            ticking = false;
            });

            ticking = true;
        }
        
        });
    </script>