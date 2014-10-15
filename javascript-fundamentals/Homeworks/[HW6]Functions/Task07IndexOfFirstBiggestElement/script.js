function handleUserInput() {
    var userInput = document.getElementsByClassName("user-input"),
        numbers = [],
        result = document.getElementById("result");

    numbers = toArrayOfNumbers((userInput[0].value).split(", "));

    result.innerHTML = checkNeighbors(numbers);
}

function checkNeighbors(numbers) {
    var len = numbers.length-1;
    
    for (var i = 1; i < len; i++) {
        if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
        {
            return i;
        }
    }
    return -1;
}

function toArrayOfNumbers(stringArray) {
    var len = stringArray.length;
    for (var i = 0; i < len; i++) {
        stringArray[i] = +stringArray[i]; // Converting string to number using unary operator
    }

    return stringArray;
}