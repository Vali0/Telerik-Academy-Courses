function Solve(params) {
    var field = params[0].split(' '),
        rows = field[0] | 0,
        cols = field[1] | 0,
        start = params[1].split(' '),
        rowStart = start[0] | 0,
        colStart = start[1] | 0,
        matrix = [],
        counter = 1;
        
    for (var i = 0; i < rows; i++) {
        matrix[i] = [];
        for (var j = 0; j < cols; j++) {
            matrix[i][j] = counter;
            counter++;
        }
    }

    var sum = 0;
    var jumps = params.slice(2);
    var k = 0;
    while (true){
        sum += matrix[rowStart][colStart];
        matrix[rowStart][colStart] = 0;

        var tokens = jumps[k % jumps.length].split(' ');
        k++;
        rowStart = rowStart + (tokens[0] | 0);
        colStart = colStart + (tokens[1] | 0);
        if (rowStart < 0 || rowStart >= rows || colStart < 0 || colStart >= cols) {
            return "escaped " + sum;
        }
        if (matrix[rowStart][colStart] === 0) {
            return "caught " + k;
        }
    }
}

//var params = [
//    "6 7 3",
//    "0 0",
//    "2 2",
//    "-2 2",
//    "3 -1"
//];

//console.log(Solve(params));