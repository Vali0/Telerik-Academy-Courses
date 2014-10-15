function handleUserInput() {
    var userInput = document.getElementsByClassName("user-input"),
        indexOfNumber,
        numbers = [],
        result = document.getElementById("result");

    numbers = toArrayOfNumbers((userInput[0].value).split(", "));
    indexOfNumber = userInput[1].value | 0;

    result.innerHTML = checkNeighbors(numbers, indexOfNumber);
}

function checkNeighbors(numbers, index) {
    var len = numbers.length;
    
    if (index <= 0 || index >= len - 1) {
        return "Index is out of range or can't have neighbors";
    }

    if (numbers[index] > numbers[index - 1] && numbers[index] > numbers[index + 1]) {
        return "Element " + numbers[index] + " at index " + index + " is bigger than its neighbors";
    } else {
        return "Element " + numbers[index] + " at index " + index + " is NOT bigger than its neighbors";
    }
}

function toArrayOfNumbers(stringArray) {
    var len = stringArray.length;
    for (var i = 0; i < len; i++) {
        stringArray[i] = +stringArray[i]; // Converting string to number using unary operator
    }

    return stringArray;
}