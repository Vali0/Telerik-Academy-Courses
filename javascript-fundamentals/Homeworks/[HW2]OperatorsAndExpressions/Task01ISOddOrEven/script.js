function checkNumber() {
    var number,
        container;

    number = document.getElementById("user-input").value;
    container = document.getElementById("result");
    
    if (number % 2 === 0) {
        container.innerHTML = "Even";
    } else {
        container.innerHTML = "Odd";
    }
}