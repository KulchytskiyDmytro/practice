function readMore() {

    var more = document.getElementById("more");
    var bth = document.getElementById("bth");

    if (more.style.display === "none") {
        bth.style.display = "flex";
        more.style.display = "none";
    } else {
        more.style.display = "flex";
        bth.style.display = "none";
    }
}