(function () {
    var ctx = document.getElementById('the-canvas').getContext('2d');
    ctx.lineWidth = 2;

    drawHuman(ctx);
    drawBike(ctx);
    drawHouse(ctx);
})();

function drawHouse(ctx) {
    ctx.strokeStyle = 'black';
    // house
    ctx.fillStyle = '#975B5B';
    ctx.fillRect(500, 180, 400, 300);
    ctx.strokeRect(500, 180, 400, 300);

    // roof
    ctx.beginPath();
    ctx.moveTo(500, 180);
    ctx.lineTo(700, 0);
    ctx.lineTo(900, 180);
    ctx.fill();
    ctx.stroke();

    // door
    ctx.beginPath();
    ctx.moveTo(540, 480);
    ctx.lineTo(540, 360);
    ctx.stroke();

    ctx.beginPath();
    ctx.save();
    ctx.scale(1, 0.5);
    ctx.arc(595, 720, 55, 0, Math.PI, true);
    ctx.restore();
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(650, 480);
    ctx.lineTo(650, 360);
    ctx.stroke();

    // doors
    ctx.beginPath();
    ctx.moveTo(595, 480);
    ctx.lineTo(595, 333);
    ctx.stroke();

    // handles
    ctx.beginPath();
    ctx.arc(580, 430, 5, 0, 2 * Math.PI, false);
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(610, 430, 5, 0, 2 * Math.PI, false);
    ctx.stroke();

    // windows
    function createWindow(x, y) {
        ctx.fillRect(x, y, 70, 50);
        ctx.fillRect(x + 75, y, 70, 50);
        ctx.fillRect(x, y + 55, 70, 50);
        ctx.fillRect(x+75, y + 55, 70, 50);
    }

    ctx.fillStyle = 'black';
    createWindow(525, 200);
    createWindow(730, 200);
    createWindow(730, 330);

    // chimney
    ctx.fillStyle = '#975B5B';
    ctx.beginPath();
    ctx.moveTo(800, 150);
    ctx.lineTo(800, 50);
    ctx.lineTo(840, 50);
    ctx.lineTo(840, 150);
    ctx.fill();
    ctx.stroke();
    ctx.beginPath();
    ctx.save();
    ctx.scale(1, 0.2);
    ctx.arc(820, 250, 20, 0, 2 * Math.PI, false);
    ctx.fill();
    ctx.stroke();
    ctx.restore();

}

function drawBike(ctx) {
    // wheels
    ctx.strokeStyle = '#245661';
    ctx.beginPath();
    ctx.fillStyle = '#90CAD7';
    ctx.arc(100, 500, 50, 0, 2 * Math.PI, false);
    ctx.fill();
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(330, 500, 50, 0, 2 * Math.PI, false);
    ctx.fill();
    ctx.stroke();

    // rudder
    ctx.beginPath();
    ctx.moveTo(330, 500);
    ctx.lineTo(300, 380);
    ctx.lineTo(260, 400);
    ctx.moveTo(300, 380);
    ctx.lineTo(320, 340);
    ctx.stroke();

    // seat
    ctx.beginPath();
    ctx.moveTo(200, 500);
    ctx.lineTo(150, 400);
    ctx.moveTo(125, 400);
    ctx.lineTo(180, 400);
    ctx.stroke();

    // frame
    ctx.beginPath();
    ctx.moveTo(100, 500);
    ctx.lineTo(200, 500);
    ctx.lineTo(313, 430);
    ctx.lineTo(165, 430);
    ctx.closePath();
    ctx.stroke();

    // chain
    ctx.beginPath();
    ctx.arc(200, 500, 15, 0, 2 * Math.PI, false);
    ctx.stroke();

    // pedals
    ctx.beginPath();
    ctx.moveTo(190, 490);
    ctx.lineTo(175, 475);
    ctx.moveTo(213, 507);
    ctx.lineTo(230, 520);
    ctx.stroke();
}

function drawHuman(ctx) {
    // head
    ctx.beginPath();
    ctx.save();
    ctx.fillStyle = '#90CAD7';
    ctx.scale(1, 0.85);
    ctx.arc(95, 170, 75, 0, 2 * Math.PI, false);
    ctx.fill();
    ctx.restore();

    // hat
    ctx.beginPath();
    ctx.fillStyle = '#396693';
    ctx.save();
    ctx.scale(1, 0.2);
    ctx.arc(95, 460, 80, 0, 2 * Math.PI, false);
    ctx.fill();
    ctx.stroke();

    // cylinder
    ctx.beginPath();
    ctx.arc(95, 400, 40, 0, Math.PI, false);
    ctx.restore();
    ctx.lineTo(55, 15);
    ctx.lineTo(135, 15);
    ctx.lineTo(135, 80);
    ctx.fill();
    ctx.stroke();

    ctx.beginPath();
    ctx.save();
    ctx.scale(1, 0.3);
    ctx.arc(95, 45, 40, 0, 2 * Math.PI, false);
    ctx.fill();
    ctx.stroke();
    ctx.restore();

    // eyes
    ctx.beginPath();
    ctx.save();
    ctx.scale(1, 0.6);
    ctx.arc(50, 220, 13, 0, 2 * Math.PI, false);
    ctx.stroke();
    ctx.beginPath();
    ctx.arc(100, 220, 13, 0, 2 * Math.PI, false);
    ctx.stroke();
    ctx.restore();

    // eyebows
    ctx.beginPath();
    ctx.save();
    ctx.scale(0.7, 0.9);
    ctx.arc(65, 147, 7, 0, 2 * Math.PI, false);
    ctx.arc(137, 147, 7, 0, 2 * Math.PI, false);
    ctx.fillStyle = '#22545F';
    ctx.fill();
    ctx.restore();

    // coke in my nose https://www.youtube.com/watch?v=5TDhbJMLvQc
    ctx.beginPath();
    ctx.moveTo(75, 133);
    ctx.lineTo(60, 160);
    ctx.lineTo(75, 160);
    ctx.stroke();

    // mouth
    ctx.beginPath();
    ctx.save();
    ctx.rotate(10 * Math.PI / 180);
    ctx.scale(1, 0.4);
    ctx.arc(100, 410, 25, 0, 2 * Math.PI, false);
    ctx.stroke();
    ctx.restore();
}