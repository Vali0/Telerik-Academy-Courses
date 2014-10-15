var result = document.getElementById("result");

function handleUserInput() {
    var userInput,
        userArray,
        numberToSearch,
        counter = 0,
        numbers = [];

    userInput = document.getElementsByClassName("user-input");
    userArray = userInput[0].value;
    numberToSearch = userInput[1].value | 0;
    
    numbers = toArrayOfNumbers(userArray.split(", "));
    counter = countAppearens(numbers, numberToSearch);
    result.innerHTML = "Number " + numberToSearch + " appears: " + counter + " times"; 
}

function countAppearens(numbers, numberToSearch) {
    var len = numbers.length,
        counter = 0;
    
    for (var i = 0; i < len; i++) {
        if (numbers[i] === numberToSearch) {
            counter++;
        }
    }

    return counter;
}

function toArrayOfNumbers(stringArray) {
    var len = stringArray.length;
    for (var i = 0; i < len; i++) {
        stringArray[i] = +stringArray[i]; // Converting string to number using unary operator
    }

    return stringArray;
}

function randomInput() {
    var len = getRandomNumber(10, 21);
    numbers = [],
    numberToSearch = getRandomNumber(0, 21);

    for (var i = 0; i < len; i++) {
        numbers.push(getRandomNumber(0, 31));
    }

    result.innerHTML = "Number " + numberToSearch + " appears: " + countAppearens(numbers, numberToSearch) + " times" +
                       "in array: " + numbers ;
}

function getRandomNumber(min, max) {
    return Math.floor(Math.random() * (max - min) + min);
}