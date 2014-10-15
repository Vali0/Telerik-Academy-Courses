function checkNumber(number) {
    var number,
        container;

    number = document.getElementById("user-input").value;
    container = document.getElementById("result");
    container.innerHTML = (((number / 100) | 0) % 10) === 7; // | operator convert the number to integer, because after that it is float
}