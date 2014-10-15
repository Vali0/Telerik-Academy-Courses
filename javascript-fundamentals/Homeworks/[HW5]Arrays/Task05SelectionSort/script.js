function selectionSort() {
    var userInput,
        numbers = [],
        result;

    userInput = document.getElementsByClassName("user-input")[0].value;
    result = document.getElementById("result");

    numbers = toArrayOfNumbers(userInput.split(", "));

    var len = numbers.length;
    for (var i = 0; i < len - 1; i++) {
        for (var j = i + 1; j < len; j++) {
            if (numbers[i] > numbers[j]) {
                //Using bitwise operations for better speed and less memory (don't need temp variable)
                numbers[i] ^= numbers[j];
                numbers[j] ^= numbers[i];
                numbers[i] ^= numbers[j];
            }
        }
    }

    result.innerHTML = numbers;
}

function toArrayOfNumbers(stringArray) {
    var len = stringArray.length;
    for (var i = 0; i < len; i++) {
        stringArray[i] = +stringArray[i]; // Converting string to number using unary operator
    }

    return stringArray;
}