function FindMinAndMax() {
    var userInput,
        numbers = [],
        minValue,
        maxValue,
        container;
        
    userInput = document.getElementsByClassName("user-input")[0].value;
    container = document.getElementById("result");
    numbers = userInput.split(", ");

    var len = numbers.length;
    for (var i = 0; i < len; i++) {
        numbers[i] = +numbers[i]; // Convert string array into numbers
    }

    // Get min and max value of array using min and max methods and prototype apply
    minValue = Math.min.apply(null, numbers);
    maxValue = Math.max.apply(null, numbers);

    container.innerHTML = "Min value is: " + minValue + "<br />" + "Max value is: " + maxValue;
}