function printNumbers() {
    var userInput,
        container;

    userInput = document.getElementsByClassName("user-input")[0].value | 0; // Get and convert input into integer
    container = document.getElementById("result");

    container.innerHTML = "";

    for (var i = 1; i <= userInput; i++) {
        container.innerHTML += i + ' ';
    }
}