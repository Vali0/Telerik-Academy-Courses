var divs = document.getElementsByClassName("circle");
var divContainer = document.getElementById("container");
var timer;
var centerX = 200;
var centerY = 200;
var radius = 100;

generateDivs();

function generateDivs() {
    for (var i = 0; i < 5; i++) {
        createDiv(360 / 5 * i);
    }
}

function createDiv(angle) {
    var div = document.createElement("div");
    div.className = "circle";
    setPosition(div, angle);
    divContainer.appendChild(div);
}

var addAngle = 5;

function startCycling() {
    timer = setInterval(function () {
        for (var i = 0, len = divs.length; i < len; i++) {
            setPosition(divs[i], 360 / len * i + addAngle);
        }
        addAngle += 5;
    }
                        , 100);
}

function setPosition(div, angle) {
		var theta = angle * Math.PI / 180;
        div.style.top = (centerY + radius * Math.sin(theta)) + "px";
        div.style.left = (centerX + radius * Math.cos(theta)) + "px";
}

function stopCycling() {
    clearInterval(timer);
}