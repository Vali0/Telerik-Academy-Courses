function checkNumber() {
    var number,
        container;

    number = document.getElementById("user-input").value;
    container = document.getElementById("result");

    if (number > 100) {
        container.innerHTML = "Your number is less than greater than 100!";
    } else {
        for (var i = 2, len = Math.sqrt(number) ; i < len; i++) {
            if (number % i === 0) {
                container.innerHTML = "Number isn't prime";
                return;
            }
        }
        
        container.innerHTML = "Number is prime";
    }
}