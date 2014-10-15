function findIndex() {
    var userInput,
        arr,
        searchElement,
        numbers = [],
        index,
        result;

    userInput = document.getElementsByClassName("user-input");
    arr = userInput[0].value;
    searchElement = userInput[1].value;
    result = document.getElementById("result");

    numbers = toArrayOfNumbers(arr.split(", "));
    numbers.sort(function (a, b) { // Sorting the array
        return a - b;
    });
    
    index = binarySearch(numbers, searchElement);

    result.innerHTML = index;
}

function binarySearch(numbers, searchElement) {
    var minIndex = 0,
        maxIndex = numbers.length - 1,
        currentIndex,
        currentElement;
    
    while (minIndex <= maxIndex) {
        currentIndex = ((minIndex + maxIndex) / 2) | 0; // Precision (simple converting to integer needed by dividing)
        currentElement = numbers[currentIndex];

        if (currentElement < searchElement) {
            minIndex = currentIndex + 1;
        } else if (currentElement > searchElement) {
            maxIndex = currentIndex - 1;
        } else {
            return currentIndex;
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