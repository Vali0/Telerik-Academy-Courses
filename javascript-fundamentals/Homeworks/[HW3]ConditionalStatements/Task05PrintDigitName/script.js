function printDigitName() {
    var userInput,
        container;

    userInput = document.getElementsByClassName("user-input")[0].value - 0;
    container = document.getElementById("result");

    switch (userInput) {
        case 0:
            container.innerHTML = "Zero";
            break;
        case 1:
            container.innerHTML = "One";
            break
        case 2:
            container.innerHTML = "Two";
            break;
        case 3:
            container.innerHTML = "Three";
            break;
        case 4:
            container.innerHTML = "Four";
            break;
        case 5:
            container.innerHTML = "Five";
            break;
        case 6:
            container.innerHTML = "Six";
            break;
        case 7:
            container.innerHTML = "Seven";
            break;
        case 8:
            container.innerHTML = "Eight";
            break;
        case 9:
            break;
            container.innerHTML = "Nine";
            break;
        default:
            container.innerHTML = "You didn't entered a digit!";
    }
}