function Solve(params) {
    var path = params[0].split(", ").map(Number);
    var resetPath = path.slice(0);
    var maxRoute = 1;

    var pathLength = path.length;
    for (var startIndex = 0; startIndex < pathLength; startIndex++) {
        for (var step = 1; step < pathLength; step++) {
            var tempRoute = 1;
            var index = startIndex;
            var nextIndex = (index + step) % pathLength;

            while (path[index] < path[nextIndex]) {
                tempRoute++;
                index = nextIndex;
                nextIndex = (index + step) % pathLength;
            }
            maxRoute = Math.max(maxRoute, tempRoute);
        }
    }

    return maxRoute
}

//params = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0";
//console.log(Solve(params));