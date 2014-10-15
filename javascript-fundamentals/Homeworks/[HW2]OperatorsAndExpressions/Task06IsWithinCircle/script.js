function checkPoint() {
    var xCoordinate,
        yCoordinate,
        pointRadiusVector,
        circleRadius = 5,
        container;

    xCoordinate = document.getElementById("x-coordinate").value;
    yCoordinate = document.getElementById("y-coordinate").value;
    container = document.getElementById("result");

    pointRadiusVector = Math.sqrt(xCoordinate * xCoordinate + yCoordinate * yCoordinate);

    if (pointRadiusVector > circleRadius) {
        container.innerHTML = "Point is not within the circle.";
    } else {
        container.innerHTML = "Point is within the circle.";
    }
}