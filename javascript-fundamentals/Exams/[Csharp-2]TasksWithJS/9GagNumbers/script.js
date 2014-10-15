function Solve(params) {
    var numbers = {
        "-!": 0,
        "**": 1,
        "!!!": 2,
        "&&": 3,
        "&-": 4,
        "!-": 5,
        "*!!!": 6,
        "&*!": 7,
        "!!**!-": 8
    };

    var fraction = '';
    var nineGagDigits = [];
    for (var i = 0, len = params[0].length; i < len; i++) {
        fraction += params[0][i];
        if (numbers[fraction] !== undefined) {
            nineGagDigits.push(numbers[fraction]);
            fraction = '';
        }
    }

    var result = 0;
    for (var j = 0, digitsLength = nineGagDigits.length; j < digitsLength; j++) {
        result += nineGagDigits[j] * myPow(9, digitsLength-j-1);
    }
    function myPow(number, degree) {
        var powNumber = 1;
        for (var i = 0; i < degree; i++) {
            powNumber *= number;
        }
        return powNumber;
    }
    return result;
}


//params = ["!!**!--!!-"];
//console.log(Solve(params));