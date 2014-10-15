function checkNumber() {
    var number,
        container;

    number = document.getElementById("user-input").value;
    container = document.getElementById("result");
    container.innerHTML = (number % 35 === 0);
}