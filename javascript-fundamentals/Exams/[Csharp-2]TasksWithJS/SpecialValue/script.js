function Solve(params) {
    var rows = params[0],
        matrix = [];
    for (var i = 1; i <= rows; i++) {
        matrix[i - 1] = params[i].split(", ").map(Number);
    }

    var visitedPath = [];
    var numberOfPassedCells = 0,
        maxSpecialValue = 0;
    for (i = 0, len = matrix[0].length; i < len; i++) {
        var currentRow = 0;
        var currentCol = i;
        numberOfPassedCells = 1;

        while (matrix[currentRow][currentCol] >= 0) {
            if (visitedPath.indexOf(currentRow + ',' + currentCol) !== -1) {
                numberOfPassedCells = -999;
                break;
            }
            visitedPath.push(currentRow + ',' + currentCol);
            currentCol = matrix[currentRow][currentCol];
            currentRow = (currentRow + 1) % rows;
            numberOfPassedCells++;
        }

        visitedPath.length = 0;
        var currentSpecialValue = numberOfPassedCells + Math.abs(matrix[currentRow][currentCol]);
        maxSpecialValue = Math.max(maxSpecialValue, currentSpecialValue);
    }

    return maxSpecialValue;
}

//var params = [
//    "6",
//    "5, -4, 8, -5, 0",
//    "1, -2, -1, 1, 0, -1, -1, -2, 1",
//    "3, -5",
//    "4, -9, -4, 4, 0, 7",
//    "1, -2, -8, 4, -8, 7, -5, -4, -4",
//    "4, -1, 0, -3, 2, 4, -4, 1"
//];

//var params = [
//    "2",
//    "0, -3, 0, 3",
//    "0, 3, 0, 2, 0"
//]

//var params = [
//    "2",
//    "0, -3, 0, 3",
//    "-3, 3, 0, 2, 0"
//];

//console.log(Solve(params));