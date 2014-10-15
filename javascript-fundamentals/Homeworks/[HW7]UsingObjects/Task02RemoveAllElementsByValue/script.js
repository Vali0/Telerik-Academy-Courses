Array.prototype.remove = removeAllValues;

function handleUserInput() {
    var userInput = document.getElementsByClassName("user-input"),
        userArray,
        numberToRemove,
        numbers = [],
        result = document.getElementById("result");

    userArray = userInput[0].value;
    numberToRemove = userInput[1].value | 0;

    numbers = toArrayOfNumbers(userArray.split(", "));

    result.innerHTML = numbers.remove(numberToRemove);
}

function removeAllValues(element) {
    var filteredArray = [];

    filteredArray = this.filter(function (x) {
        return x !== element;
    });

    return filteredArray;
}

function toArrayOfNumbers(numbers) {
    var len = numbers.length;
    for (var i = 0; i < len; i++) {
        numbers[i] = +numbers[i]; // Converting string to number using unary operator
    }

    return numbers;
}