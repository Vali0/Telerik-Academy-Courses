function Solve(params) {
    var numbers = {
        "CHU": 0,
        "TEL": 1,
        "OFT": 2,
        "IVA": 3,
        "EMY": 4,
        "VNB": 5,
        "POQ": 6,
        "ERI": 7,
        "CAD": 8,
        "K-A": 9,
        "IIA": 10,
        "YLO": 11,
        "PLA": 12
    };

    if (params.length === 3) {
        return numbers[params];
    }

    var multiverseNumbers = [];
    while (params !== "") {
        multiverseNumbers.push(numbers[params.substr(0, 3)]);
        params = params.slice(3);
    }

    var result = 0;
    for (var i = 0, len = multiverseNumbers.length; i < len; i++) {
        result += multiverseNumbers[i] * Math.pow(13, len - i - 1);
    }

    return result;
}
//var params = "TELERIK-ACADEMY";
//console.log(Solve(params));