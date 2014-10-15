var drawingModule = (function () {
    var canvas =  document.getElementById('canvas-container'),
    ctx = canvas.getContext('2d');

    function drawLine(startX, startY, endX, endY) {
        ctx.beginPath();
        ctx.moveTo(startX, startY);
        ctx.lineTo(endX, endY);
        ctx.stroke();
    }

    function drawRect(coordinateX, coordinateY, width, height) {
        ctx.strokeRect(coordinateX, coordinateY, width, height);
    }

    function drawCircle(coordinateX, coordinateY, radius) {
        ctx.beginPath();
        ctx.arc(coordinateX, coordinateY, radius, 0, Math.PI * 2);
        ctx.stroke();
    }

    return {
        drawRect: drawRect,
        drawCircle: drawCircle,
        drawLine: drawLine
    }
}());