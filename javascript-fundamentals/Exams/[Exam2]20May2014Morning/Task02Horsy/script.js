function Solve(params) {
    var matrixParameters = params[0].split(' ');
    var rows = matrixParameters[0] | 0;
    var cols = matrixParameters[1] | 0;
    var sumMatrix = [];
    for (var i = 0; i < rows; i++) {
        sumMatrix[i] = [];
        var counter = Math.pow(2, i);
        for (var j = 0; j < cols; j++) {
            sumMatrix[i][j] = counter;
            counter--;
        }
    }

    var pattern = params.slice(1);
    var currentRow = rows - 1;
    var currentCol = cols - 1;
    var sum = 0;
    var numOfJumps = 0;
   
    while (true) {
        sum += sumMatrix[currentRow][currentCol];
        numOfJumps++;
        var movement = pattern[currentRow][currentCol];
        sumMatrix[currentRow][currentCol] = '*';

        if (movement == 1) {
            currentRow -= 2;
            currentCol +=1;
        } else if (movement == 2) {
            currentRow -= 1;
            currentCol += 2;
        } else if (movement == 3) {
            currentRow += 1;
            currentCol += 2;
        } else if (movement == 4) {
            currentRow += 2;
            currentCol +=1
        } else if (movement == 5) {
            currentRow += 2;
            currentCol -= 1;
        } else if (movement == 6) {
            currentRow += 1;
            currentCol -= 2;
        } else if (movement == 7) {
            currentRow -= 1;
            currentCol -= 2;
        } else if (movement == 8) {
            currentRow -= 2;
            currentCol -= 1;
        }

        if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= cols) {
            return "Go go Horsy! Collected " + sum + " weeds";
        }
        if (sumMatrix[currentRow][currentCol] === '*') {
            return "Sadly the horse is doomed in " + numOfJumps + " jumps";
        }
    }
}

//args = [
//    '3 5',
//    '54561',
//    '43328',
//    '52388',
//];

args = [
  '3 5',
  '54361',
  '43326',
  '52188',
];


console.log(Solve(args));