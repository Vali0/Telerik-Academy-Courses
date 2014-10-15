function selectionSort() {
    var userInput,
        numbers = [],
        result;

    userInput = document.getElementsByClassName("user-input")[0].value;
    result = document.getElementById("result");

    numbers = toArrayOfNumbers(userInput.split(", "));

    var frequency = {}; // Using associative array key:value
    var occurrence = 0;
    var frequentNumber

    for (var item in numbers) {
        frequency[numbers[item]] = (frequency[numbers[item]] || 0) + 1;

        if (frequency[numbers[item]] > occurrence) { // is this frequency > occurrence
            occurrence = frequency[numbers[item]];   // update occurrence.
            frequentNumber = numbers[item];          // update frequent number.
        }
    }

    result.innerHTML = "Most frequent number is: " + frequentNumber + " with occurrence: " + occurrence;
}

function toArrayOfNumbers(stringArray) {
    var len = stringArray.length;
    for (var i = 0; i < len; i++) {
        stringArray[i] = +stringArray[i]; // Converting string to number using unary operator
    }

    return stringArray;
}