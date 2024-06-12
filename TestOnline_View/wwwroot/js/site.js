// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementsByClassName("mode")[0].addEventListener("click", () => {
    console.log("Dark mode");
    setDarkLightMode();
}
);


function setDarkLightMode() {
    if (document.body.getAttribute('data-bs-theme') === 'dark') {
        document.body.setAttribute('data-bs-theme', 'light');
        document.cookie = "theme=light";
    }
    else {
        document.body.setAttribute('data-bs-theme', 'dark');
        document.cookie = "theme=dark";
    }
}