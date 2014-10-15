function Solve(params) {
    var kaspichan = (function () {
        var numbers = [];

        for (var i = 0; i < 256; i++) {
            if (i < 26) {
                numbers.push(String.fromCharCode(65 + i));
            } else if (i < 2 * 26) {
                numbers.push('a' + numbers[i - 26]);
            } else if (i < 3 * 26) {
                numbers.push('b' + numbers[i - 2 * 26]);
            } else if (i < 4 * 26) {
                numbers.push('c' + numbers[i - 3 * 26]);
            } else if (i < 5 * 26) {
                numbers.push('d' + numbers[i - 4 * 26]);
            } else if (i < 6 * 26) {
                numbers.push('e' + numbers[i - 5 * 26]);
            } else if (i < 7 * 26) {
                numbers.push('f' + numbers[i - 6 * 26]);
            } else if (i < 8 * 26) {
                numbers.push('g' + numbers[i - 7 * 26]);
            } else if (i < 9 * 26) {
                numbers.push('h' + numbers[i - 8 * 26]);
            } else if (i < 10 * 26) {
                numbers.push('i' + numbers[i - 9 * 26]);
            }
        }
        return numbers;
    }());

    var result = '';

    if (params === 0) {
        return kaspichan[0];
    }
    while (params !== 0) {
        result = kaspichan[params % 256] + result;
        params = params / 256 | 0;
    }
    return result;
}

//console.log(Solve(1000));