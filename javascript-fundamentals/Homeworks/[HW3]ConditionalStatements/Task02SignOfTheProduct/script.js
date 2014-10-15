function checkProductSign() {
    var userInput,
        firstNumberSign,
        secondNumberSign,
        thirdNumberSign,
        container;

    userInput = document.getElementsByClassName("user-input");
    firstNumberSign = userInput[0].value > 0;
    secondNumberSign = userInput[1].value > 0;
    thirdNumberSign = userInput[2].value > 0;
    container = document.getElementById("result");
    
    if (firstNumberSign ^ secondNumberSign ^ thirdNumberSign) {
        container.innerHTML = "Product is positive";
    } else {
        container.innerHTML = "Product is negative";
    }
}