// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
let text = document.getElementsByClassName('tooltip');
window.onmousemove = function (e) {
    let x = e.clientX,
        y = e.clientY;
    for (let i = 0; i < text.length; i++) {
        text[i].style.top = (y + 20) + 'px';
        text[i].style.left = (x + 20) + 'px';
    }
}
