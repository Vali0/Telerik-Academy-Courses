function Solve(params) {
    var valley = params[0].split(", ").map(Number);
    var resetValley = valley.slice(0);
    var numOfPatterns = (params[1] | 0) + 2;
    var coinsStack = [];
    for (var i = 2; i < numOfPatterns; i++) {
        var pattern = params[i];
        pattern = (pattern.split(", ")).map(Number);
        var position = 0;
        var coins = 0;
        var key = 0
        while (true) {
            coins += valley[position];
            valley[position] = '*';
            position += pattern[key % pattern.length];
            key++;
            if (valley[position] === '*') {
                valley = resetValley.slice(0);
                coinsStack.push(coins);
                break;
            }
            if (position >= valley.length || position < 0) {
                valley = resetValley.slice(0);
                coinsStack.push(coins);
                break;
            }
        }
    }
    return Math.max.apply(null,coinsStack);
}

//var params = [
//    "1, 3, -6, 7, 4, 1, 12",
//    "3",
//    "1, 2, -3",
//    "1, 3, -2",
//    "1, -1"
//];

//console.log(Solve(params));