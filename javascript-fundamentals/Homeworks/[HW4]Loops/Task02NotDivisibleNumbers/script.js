function printNumbers() {
    var userInput,
        container;

    userInput = document.getElementsByClassName("user-input")[0].value | 0;
    container = document.getElementById("result");

    container.innerHTML = "";

    for (var i = 1; i <= userInput; i++) {
        if (i % 21 !== 0) {
            container.innerHTML += i + ' ';
        }
    }
}