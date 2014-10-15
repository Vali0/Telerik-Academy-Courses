var point1 = generatePoint(1, 2),
    point2 = generatePoint(2, 2),
    point3 = generatePoint(3, 1),
    line1 = generateLine(point1, point2),
    line2 = generateLine(point2, point3),
    line3 = generateLine(point1, point3),
    result = document.getElementById("result");

result.innerHTML = "Distance is: " + calculateDistance(point1, point2) + "<br />Is it posible to form a triangle: " + isPosibleToFormATriangle(line1, line2, line3);

function generatePoint(x, y) {
    return { xCoordinate: x, yCoordinate: y };
}

function generateLine(firstPoint, secondPoint) {
    return { pointA: firstPoint, pointB: secondPoint };
}

function calculateDistance(firstPoint, secondPoint) {
    return Math.sqrt((firstPoint.xCoordinate - secondPoint.xCoordinate) * (firstPoint.xCoordinate - secondPoint.xCoordinate) +
           (firstPoint.yCoordinate - secondPoint.yCoordinate) * (firstPoint.yCoordinate - secondPoint.yCoordinate));
}

function isPosibleToFormATriangle(firstLine, secondLine, thirdLine) {
    var sideA = calculateDistance(firstLine.pointA, firstLine.pointB),
        sideB = calculateDistance(secondLine.pointA, secondLine.pointB),
        sideC = calculateDistance(thirdLine.pointA, thirdLine.pointB);

    return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
}