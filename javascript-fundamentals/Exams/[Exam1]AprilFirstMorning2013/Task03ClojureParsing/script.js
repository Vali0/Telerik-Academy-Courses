function Solve(params) {
    var variables = {};
    for (var i = 0; i < params.length; i++) {
        params[i] = params[i].replace(/\s+/g, ' ').trim();
        var variableName = "",
            content;

        if (params[i].search(/\bdef\b/g) !== -1) {
            variableName = params[i].split(' ')[1];
            content = params[i].substring(params[i].indexOf(variableName) + variableName.length);
        } else {
            variableName = "finalResult";
            content = params[i];
        }
        
        operator = "",
        indexOfOperator = 0;

        if (content.indexOf('+') !== -1) {
            indexOfOperator = content.indexOf('+');
            operator = '+';
        } else if (content.indexOf('-') !== -1) {
            indexOfOperator = content.indexOf('-');
            operator = '-';
        } else if (content.indexOf('*') !== -1) {
            indexOfOperator = content.indexOf('*');
            operator = '*'
        } else if (content.indexOf('/') !== -1) {
            indexOfOperator = content.indexOf('/');
            operator = '/';
        }

        var valuesOfCommand = (content.substring(indexOfOperator + 1, content.indexOf(')'))).trim().split(' ');
        
        for (var item in valuesOfCommand) {
            variables[variableName] = variables[variableName] || [];
            if (isNaN(valuesOfCommand[item])) {
                if (Array.isArray(variables[valuesOfCommand[item]])) {
                    for (var value in variables[valuesOfCommand[item]]) {
                        variables[variableName].push(variables[valuesOfCommand[item]][value]);
                    }
                } else {
                    variables[variableName].push(variables[valuesOfCommand[item]]);
                }
            } else {
                variables[variableName].push(+valuesOfCommand[item]);
            }
        }

        if (operator === '+') {
            variables[variableName] = (function () {
                var sum = 0;
                for (var index = 0; index < variables[variableName].length; index++) {
                    sum += variables[variableName][index];
                }
                return sum;
            }());
        } else if (operator === '-') {
            variables[variableName] = (function () {
                var result = variables[variableName][0];
                for (var index = 1; index < variables[variableName].length; index++) {
                    result -= variables[variableName][index];
                }
                return result;
            }());
        } else if (operator === '*') {
            variables[variableName] = (function () {
                var result = variables[variableName][0];
                for (var index = 1; index < variables[variableName].length; index++) {
                    result *= variables[variableName][index];
                }
                return result;
            }());
        } else if (operator === '/') {
            variables[variableName] = (function () {
                var result = variables[variableName][0];
                for (var index = 1; index < variables[variableName].length; index++) {
                    if (variables[variableName][index] === 0) {
                        return "Division by zero! At Line:" + (i+1); // return of main cycle not that...
                    }
                    result = (result / variables[variableName][index]) | 0;
                }
                return result;
            }());

            if (variables[variableName][0] === 'D') { // there is no chance to return other letter here except dividing by zero
                return variables[variableName];
            }
        }
    }
    if (variableName === "finalResult") {
        return variables["finalResult"];
    }
}

//var params = [
//    "(def func  10 )",
//    "(def newFunc (+  func 2))",
//    "(def sumFunc (+ func func newFunc 0 0 0))",
//    "(* sumFunc 2)"
//];

//var params = [
//    "(def func (+ 5 2))",
//    "(def func2 (/  func 5 2 1 0))",
//    "(def func3 (/ func 2))",
//    "(+ func3 func)"
//];

//console.log(Solve(params));