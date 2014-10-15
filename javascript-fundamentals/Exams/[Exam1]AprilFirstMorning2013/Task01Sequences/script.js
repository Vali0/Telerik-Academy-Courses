function Solve(params) {
    var len = params[0] | 0,
        previousElement = params[1] | 0;
        answer = 1;

    for (var i = 2; i < len+1; i++) {
        params[i] = params[i] | 0;
        if (previousElement > params[i]) {
            answer++;
        }

        previousElement = params[i];
    }

    return answer;
}

var params = [
    "7",
    "1",
    "2",
    "-3",
    "4",
    "4",
    "0",
    "1"
];

console.log(Solve(params));