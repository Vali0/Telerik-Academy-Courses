var correctMathExpression = "((a + b) / 5 - d)",
    incorrectMathExpression = ")(a+b))";
    
console.log(checkExpression(correctMathExpression));
console.log(checkExpression(incorrectMathExpression));

function checkExpression(expression) {
    var counter = 0,
        len = expression.length;

    for (var i = 0; i < len; i++) {
        if (expression[i] === '(') {
            counter++;
        } else if (expression[i] === ')') {
            counter--;
        }
        if (counter < 0) {
            return false;
        }
    }
    return !counter;
}