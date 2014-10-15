function compareNumbers() {
    var numbers = [],
        userInput,
        container;

    userInput = document.getElementsByClassName("user-input");
    container = document.getElementById("result");

    for (var i = 0, len = userInput.length; i < len ; i++) {
        numbers.push(userInput[i].value - 0);
    }

    if (numbers[0] > numbers[1]) {
        // I use bitwise operations for better speed and less memory
        numbers[0] ^= numbers[1];
        numbers[1] ^= numbers[0];
        numbers[0] ^= numbers[1];
        container.innerHTML = "First number: " + numbers[0] + ' ' + "Second number: " + numbers[1];
    } else if (numbers[0] === numbers[1]) {
        container.innerHTML = "The numbers are equal: " + numbers[0];
    } else {
        container.innerHTML = "There is no need to make swap, so first number is: " + numbers[0] + ' ' + "and the second is: " + numbers[1];
    }
}