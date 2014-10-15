function Solve(params) {
    var variables = {};
    for (var i = 0, len = params.length; i < len; i++) {
        params[i] = params[i].replace(/\s+/g, ' ').trim();
        var indexOfBracket = params[i].indexOf('[');
        var command = "";
        if (params[i].search(/\bsum\b/) !== -1) {
            command = "sum";
        } else if (params[i].search(/\bmin\b/) !== -1) {
            command = "min";
        } else if (params[i].search(/\bmax\b/) !== -1) {
            command = "max";
        } else if (params[i].search(/\bavg\b/) !== -1) {
            command = "avg";
        }

        var valuesOfCommand = params[i].substring(indexOfBracket + 1, params[i].length - 1).replace(/\s*/g, '').trim().split(',');

        for (var element in valuesOfCommand) {
            valuesOfCommand[element] = valuesOfCommand[element].trim();
        }
        var variableName;
        if (params[i].search(/\bdef\b/) !== -1) {
            var tempVariable = (params[i].split(' '))[1];
            if (tempVariable.indexOf('[') === -1) {
                variableName = tempVariable;
            } else {
                variableName = tempVariable.substring(0, tempVariable.indexOf('['));
            }
        } else {
            variableName = "finalResult";
        }
        for (var item in valuesOfCommand) {
            if (!isNaN(valuesOfCommand[item])) {
                variables[variableName] = variables[variableName] || [];
                variables[variableName].push(+valuesOfCommand[item]);
            } else {
                variables[variableName] = variables[variableName] || [];
                
                if (Array.isArray(variables[valuesOfCommand[item]])) {
                    for (var num in variables[valuesOfCommand[item]]) { // loop for numbers in the other array
                        variables[variableName].push(variables[valuesOfCommand[item]][num]); // Push numbers from other array into that one
                    }
                } else {
                    variables[variableName].push(variables[valuesOfCommand[item]]);
                }
            }
        }
        if (command === "sum") {
            variables[variableName] = (function () {
                var result = 0;
                var numbersLength = variables[variableName].length;
                for (var index = 0; index < numbersLength; index++) {
                    result += variables[variableName][index];
                }
                return result;
            }());
        } else if (command === "min") {
            variables[variableName] = Math.min.apply(null, variables[variableName]);
        } else if (command === "max") {
            variables[variableName] = Math.max.apply(null, variables[variableName]);
        } else if (command === "avg") {
            variables[variableName] = (function () {
                var result = 0;
                var numbersLength = variables[variableName].length;
                for (var index = 0; index < numbersLength; index++) {
                    result += variables[variableName][index];
                }
                return (result / numbersLength) | 0;
            }());
        }
        if (variableName === "finalResult") {
            if (variables["finalResult"][0]) {
                return variables["finalResult"][0];
            }
            return variables["finalResult"];
        }
    }
}

//var params = [
//    "   def     func   sum  [        -    56,   3,   7, 2, 6, 3]",
//    " def    func2    [5, 3, 7, 2 ,   6, 3]",
//    "def        func3   min [     func2   ]",
//    "def func4      max  [   5, 3, 7, 2,   6,   3]",
//    "def func5    avg[5, 3,  7,   2,   6,  3  ]",
//    " def    func6    sum    [ func2 ,      func3       ,    func4  ]",
//    "             sum   [               func6                ,                func4]"
//];
//var params = [
//    "def var1[1, 2, 3 ,4]",
//    "def var2 sum[var1, 20, 70]", 
//    "def var3 min[var1]",
//    "avg[var2, var3]"

//];

//var params = [
//    "def func sum[1,   2, 3, -6]",
//    "def newList [func, 10, 1]",
//    "def newFunc sum[func, 100, newList]",
//    "[newFunc]"
//];

//var params = [
//    "def     varName   sum   [    2,3,12 ,            4,   1         ]  ",
//    "[varName]"
//];

//var params = [
//    "def var1 [1, 2, 6, 8] ",
//    "def var2 sum[1, 5, -10, 20]",
//    "def var3 max[5, 2, 4, var2, 2]",
//    "def var4 min[var1, 6, 50] ",
//    "def var5 avg[var1] ",
//    "def var6 sum[var1, var1, 1]",
//    "[var1]"
//];

//var params = [
//    "def    definition[-100, -100, -100]",
//    "def definitionResult sum[definition]",
//    "def defTest sum[definitionResult, 6457457, 2345234, -234546]",
//    "avg[defTest, 1, 2, 3]"
//];

//var params = [
//    "    def maxy max[100]",
//    "def summary [0]",
//    "combo [maxy, maxy,maxy,maxy, 5,6]",
//    "summary sum[combo, maxy, -18000]",
//    "def pe6o avg[summary,maxy]",
//    "sum[7, pe6o]"

//]

//console.log(Solve(params));