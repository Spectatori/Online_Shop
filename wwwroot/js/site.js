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