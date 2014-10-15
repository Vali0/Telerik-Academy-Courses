function checkPoint() {
    var circleX,
        circleY,
        circleRadius,
        rectangleTop,
        rectangleLeft,
        rectangleWidth,
        rectangleHeight,
        pointX,
        pointY,
        container;

    circleX = 1;
    circleY = 1;
    circleRadius = 3;
    rectangleTop = 1;
    rectangleLeft = -1;
    rectangleWidth = 6;
    rectangleHeight = 2;

    //Convert them to numbers just for sure.
    pointX = document.getElementById("x-coordinate").value - 0;
    pointY = document.getElementById("y-coordinate").value - 0;

    container = document.getElementById("result");

    if (Math.pow((pointX - circleX), 2) + Math.pow((pointY - circleY), 2) <= Math.pow(circleRadius, 2))
        // If point radius vector is <= circle radius
    {
        container.innerHTML = "The point is within the circle!<br />";
        if (pointX < rectangleLeft || pointX > rectangleWidth - 1) {
            container.innerHTML += "The point is out of the rectangle!";
        } else if (pointY > rectangleTop || pointY < rectangleTop - rectangleHeight) {
            container.innerHTML += "The point is out of the rectangle!";
        } else {
            container.innerHTML += "The point is in the rectangle!";
        }
    } else {
        container.innerHTML = "Point is not within the circle!<br />";
        if (pointX < rectangleLeft || pointX > rectangleWidth - 1) {
            container.innerHTML += "The point is out of the rectangle!";
        } else if (pointY > rectangleTop || pointY < rectangleTop - rectangleHeight) {
            container.innerHTML += "The point is out of the rectangle!";
        } else {
            container.innerHTML += "The point is in the rectangle!";
        }
    }
}