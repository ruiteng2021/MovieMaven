// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
let searchText = document.getElementById("searchText");
searchText.focus();

let text = document.getElementsByClassName('tooltip');
window.onmousemove = function (e) {
    let x = e.clientX,
        y = e.clientY;
    for (let i = 0; i < text.length; i++) {
        text[i].style.top = (y + 20) + 'px';
        text[i].style.left = (x + 20) + 'px';
    }
}


$('.carousel[data-type="multi"] .item').each(function () {
    var next = $(this).next();
    if (!next.length) {
        next = $(this).siblings(':first');
    }
    next.children(':first-child').clone().appendTo($(this));
    
    for (var i = 0; i < 4; i++) {
        next = next.next();
        if (!next.length) {
            next = $(this).siblings(':first');
        }
        next.children(':first-child').clone().appendTo($(this));
    }
});
