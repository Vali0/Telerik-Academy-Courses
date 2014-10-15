//args = [
//    "5 8",
//    "0 0",
//    "rrrrrrrd",
//    "rludulrd",
//    "durlddud",
//    "urrrldud",
//    "ulllllll"
//];

//console.log(labyrinthPath(args));

function labyrinthPath(params) {
    var size = params[0].split(' ');
    var rows = +size[0];
    var cols = +size[1];

    var startPositions = params[1].split(' ');
    var currentRow = +startPositions[0];
    var currentCol = +startPositions[1];

    var matrix = [];
    var counter = 1;

    for (var i = 0; i < rows; i++) {
        matrix[i] = [];
        for (var j = 0; j < cols; j++) {
            matrix[i][j] = counter;
            counter++;
        }
    }

    var matrixPattern = [];

    for (var inputs = 0; inputs < rows; inputs++) {
        matrixPattern[inputs] = [];

        for (var j = 0; j < cols; j++) {
            matrixPattern[inputs][j] = params[inputs + 2][j];
        }
    }
    var steps = 0;
    var sum = 0;
    while (true) {
        sum += matrix[currentRow][currentCol];
        steps++;
        matrix[currentRow][currentCol] = 0;

        if (matrixPattern[currentRow][currentCol] === 'l') {
            currentCol--;
        } else if (matrixPattern[currentRow][currentCol] === 'r') {
            currentCol++;
        } else if (matrixPattern[currentRow][currentCol] === 'u') {
            currentRow--;
        } else if (matrixPattern[currentRow][currentCol] === 'd') {
            currentRow++;
        }

        if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols) {
            return "out " + sum;
        }
        if (matrix[currentRow][currentCol] === 0) {
            return "lost " + steps;
        }
    }
}