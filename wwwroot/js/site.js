
/* ------------------------------------------------------------ Animations ------------------------------------------------------------ */

const observer = new IntersectionObserver((entries) => {
    entries.forEach((entry) => {
        if (entry.isIntersecting) {
            entry.target.classList.add('show_slide_right');
            entry.target.classList.add('show_slide_up');
        }
        else {
            entry.target.classList.remove('show_slide_right');
            
        }

    });
});

const hiddenElements = document.querySelectorAll('.slide_right');
hiddenElements.forEach((el) => observer.observe(el));

const hiddenElements1 = document.querySelectorAll('.slide_up');
hiddenElements1.forEach((el) => observer.observe(el));

  
  
  
  
  