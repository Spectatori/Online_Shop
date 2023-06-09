/*Vanishing header js part(there are css and js parts) start*/
var prevScrollPos = window.pageYOffset;

window.onscroll = function () {
    var currentScrollPos = window.pageYOffset;

    if (prevScrollPos > currentScrollPos) {
        // Scrolling up
        document.getElementById("header").style.opacity = "1";
    } else {
        // Scrolling down
        document.getElementById("header").style.opacity = "0";
    }

    prevScrollPos = currentScrollPos;
};
//Vanishing header js part(there are css and js parts)end

//To the top of the page button
const toTop = () => window.scrollTo({ top: 0, behavior: 'smooth' });

//checks if the browser is in dark mode or not
const isDarkMode = () => {
    return window.matchMedia('(prefers-color-scheme: dark)').matches;
}
//checks if the page is scrollable to make the back-to-top button visible or not
window.addEventListener('scroll', function () {
    var button = document.querySelector('.back-to-top');
    if (window.pageYOffset > 0) {
        button.style.display = 'block';
    } else {
        button.style.display = 'none';
    }
});
/* When the user clicks on the button,
toggle between hiding and showing the dropdown content */
function myFunction() {
    document.getElementById("myDropdown").classList.toggle("show");
}

// Close the dropdown menu if the user clicks outside of it
window.onclick = function (event) {
    if (!event.target.matches('.dropbtn')) {
        var dropdowns = document.getElementsByClassName("dropdown-content");
        var i;
        for (i = 0; i < dropdowns.length; i++) {
            var openDropdown = dropdowns[i];
            if (openDropdown.classList.contains('show')) {
                openDropdown.classList.remove('show');
            }
        }
    }
}
$(document).ready(function () {
    $('#productTypeDropdown').change(function () {
        var selectedValue = $(this).val();
        $('#shirtFields').toggle(selectedValue === 'Shirt');
        $('#pantsFields').toggle(selectedValue === 'Pants');
    });
});