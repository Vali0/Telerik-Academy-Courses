(function () {
    var canvas = document.getElementById('the-canvas'),
        width = canvas.width,
        height = canvas.height,
        ctx = canvas.getContext('2d');

    drawField(width, height, ctx);
    moveBall(width, height, ctx);
})();

function moveBall(width, height, ctx) {
    var radius = 20,
        xCoordinate = radius,
        yCoordinate = radius,
        xDiversion = 1,
        yDiversion = 1;
    setInterval(function () {
        ctx.clearRect(1, 1, width - 2, height - 2);
        ctx.beginPath();
        ctx.arc(xCoordinate, yCoordinate, radius, 0, 2 * Math.PI, false);
        ctx.fillStyle = 'green';
        ctx.fill();
        ctx.stroke();

        xCoordinate += xDiversion;
        yCoordinate += yDiversion;
        
        if (xCoordinate <= radius || xCoordinate >= width-radius) {
            xDiversion *= -1;
        }
        if (yCoordinate <= radius || yCoordinate >= height-radius) {
            yDiversion *= -1;
        }
    }, 1);
}

function drawField(width, height, ctx) {
    ctx.strokeRect(0, 0, width, height);
}