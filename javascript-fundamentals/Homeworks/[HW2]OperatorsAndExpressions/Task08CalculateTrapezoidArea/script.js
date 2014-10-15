function calculateTrapezoidArea() {
    var sideA,
        sideB,
        height,
        userInput, 
        container;

    userInput = document.getElementsByClassName("input");
    // Need to convert. Because .value gets them as strings and when sum them we get concatination of strings. 
    // By substraction we convert them to numbers. Can't use | 0 or ~~ because they convert it to integer.
    sideA = userInput[0].value - 0;
    sideB = userInput[1].value - 0;
    height = userInput[2].value - 0;

    container = document.getElementById("result");
    container.innerHTML = (sideA + sideB) * height / 2;
}