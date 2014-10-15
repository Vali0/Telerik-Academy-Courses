var movingShapes = (function () {
    var circleX = 200,
        circleY = 200,
        radiusA = 100,
        radiusB = 200,
        rectangleX = 850,
        rectangleY = 200,
        rectangleWidth = 200,
        rectangleHeight = 200,
        circleDivs = [],
        rectangleDivs = [];
    
    function addShape(shape) {
        var div = document.createElement('div');
        div.innerHTML = 'div';
        styleDiv(div);

        if (shape === 'ellipse') {
            div.style.borderRadius = '50%';
            circleDivs.push(div);
        } else {
            rectangleDivs.push(div);
        }

        document.body.appendChild(div);
    }

    var div = document.createElement('div');
    styleDiv(div);
    function styleDiv(div) {
        div.style.backgroundColor = randomColor();
        div.style.color = randomColor();
        div.style.border = getRandomInt() + 'px solid ' + randomColor();
        div.style.fontSize = getRandomInt(16, 40) + 'px';
        div.style.width = '70px';
        div.style.height = '70px';
    }

    function setEllipsePosition(div, angle) {
        var theta = angle * Math.PI / 180;

        div.style.top = (circleY + radiusA * Math.sin(theta)) + "px";
        div.style.left = (circleX + radiusB * Math.cos(theta)) + "px";
    }

    function setRectanglePosition(div, angle) {
        var theta = angle * Math.PI / 180;
        var cosTheta = Math.cos(theta);
        var sinTheta = Math.sin(theta);

        div.style.top = (rectangleY + rectangleHeight * (cosTheta * Math.abs(cosTheta) - sinTheta * Math.abs(sinTheta))) + "px";
        div.style.left = (rectangleX + rectangleWidth * (cosTheta * Math.abs(cosTheta) + sinTheta * Math.abs(sinTheta))) + "px";
    }

    function randomColor() {
        var red = (Math.random() * 256) | 0;
        var green = (Math.random() * 256) | 0;
        var blue = (Math.random() * 256) | 0;
        return "rgb(" + red + "," + green + "," + blue + ")";
    }

    function getRandomInt(min, max) {
        min = min || 1;
        max = max || 10;

        return Math.floor(Math.random() * (max - min + 1)) + min;
    }

    var angle = 5;
    setInterval(function () {
        for (var i = 0, len = circleDivs.length; i < len; i++) {
            setEllipsePosition(circleDivs[i], 360 / len * i + angle);
        }
        for (var j = 0; j < rectangleDivs.length; j++) {
            setRectanglePosition(rectangleDivs[j], 360 / rectangleDivs.length * j + angle);
        }
        angle += 5;
    }, 100)
    
    return {
        add: addShape
    }
}());