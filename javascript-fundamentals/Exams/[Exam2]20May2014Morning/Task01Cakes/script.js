function Solve(params) {
    var s = params[0],
        c1 = params[1],
        c2 = params[2],
        c3 = params[3],
        i, j, k;
    var answer = 0;

    var tempSum = 0;
    if (c1 === s || c2 === s || c3 === s) {
        return s;
    }
    for (var i = 0; i < 50; i++) {
        for (var j = 0; j < 50; j++) {
            for (var k = 0; k < 50; k++) {
                tempSum = i * c1 + j * c2 + k * c3;
                if (tempSum <= s) {
                    answer = Math.max(answer, tempSum);
                } else {
                    break;
                }
            }
        }
    }
    return answer;
}

var params = [
    110,
    13,
    15,
    17
]

//var params = [
//    20,
//    11,
//    200,
//    300,

//];

//var params = [
//110,
//19,
//29,
//39,

//]

console.log(Solve(params));