function findMaxSequence() {
    var userInput,
        numbers = [],
        result;

    userInput = document.getElementsByClassName("user-input")[0].value;
    result = document.getElementById("result");

    numbers = toArrayOfNumbers(userInput.split(", "));

    var len = numbers.length;
    var sequence = [];
    var maxSequence = [];
    sequence.push(numbers[0]);
    for (var i = 1; i < len; i++) {
        if (sequence[0] === numbers[i]) {
            sequence.push(numbers[i]);
            if (i === len - 1 && maxSequence.length <= sequence.length) {
                maxSequence = sequence.slice(0); // Provide shallow copy.
            }
        } else {
            if (maxSequence.length <= sequence.length) {
                maxSequence = sequence.slice(0); // Provide shallow copy.
            }
            sequence.length = 0;
            sequence.push(numbers[i]);
        }
    }

    result.innerHTML = maxSequence;
}

function toArrayOfNumbers(stringArray) {
    var len = stringArray.length;
    for (var i = 0; i < len; i++) {
        stringArray[i] = +stringArray[i]; // Converting string to number using unary operator
    }

    return stringArray;
}