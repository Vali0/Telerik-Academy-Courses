/// <reference path="/raphaeljs-v2.1.2.js" />

var archimedesSpiral = (function () { 
    var paperS = new Raphael(10, 10, 400, 300);

    function drawSpiral(centerX, centerY, a, b) {
        var centralPoint = "M" + centerX + ' ' + centerY,
            spiralPoints = [centralPoint],
            angle = 0,
            COEFICIENT = -0.1,
            x = 0,
            y = 0;

        for (var i = 0; i < 300; i++) {
            angle = COEFICIENT * i;
            x = centerX + (a + b * angle) * Math.cos(angle); // 'a' sets the offset from the central point
            y = centerY + (a + b * angle) * Math.sin(angle); // 'b' sets the distance between turnings
            spiralPoints.push('L ' + x + ' ' + y);
        }
        
        paperS.path(spiralPoints);
    }

    return {
        draw: drawSpiral
    }
}());

archimedesSpiral.draw(250, 150, 0, 5);