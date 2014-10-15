function findBiggest() {
    var userInput,
        firstNumber,
        secondNumber,
        thirdNumber,
        container;

    userInput = document.getElementsByClassName("user-input");
    firstNumber = userInput[0].value | 0;
    secondNumber = userInput[1].value | 0;
    thirdNumber = userInput[2].value | 0;
    container = document.getElementById("result");
    
    if (firstNumber >= secondNumber && firstNumber >= thirdNumber) {
        container.innerHTML = firstNumber;
    } else if (secondNumber >= firstNumber && secondNumber >= thirdNumber) {
        container.innerHTML = secondNumber;
    } else {
        container.innerHTML = thirdNumber;
    }
}