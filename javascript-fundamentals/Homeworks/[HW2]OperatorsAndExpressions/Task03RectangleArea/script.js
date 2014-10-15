function checkArea() {
    var width,
        height,
        container;
    width = document.getElementById("rectangle-width").value;
    height = document.getElementById("rectangle-height").value;
    container = document.getElementById("result");
    container.innerHTML = width * height;
}