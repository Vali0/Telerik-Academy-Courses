var area = document.getElementById("coloredArea");

function setFontColor() {
    var fontColor = document.getElementById("fontColor");
    area.style.color = fontColor.value;
}

function setBackgroundColor() {
    var backgroundColor = document.getElementById("backgroundColor");
    area.style.backgroundColor = backgroundColor.value;
}