function sortDescending() {
    var userInput,
        numbers = [],
        container;

    userInput = document.getElementsByClassName("user-input");
    container = document.getElementById("result");

    for (var i = 0, len = userInput.length; i < len ; i++) {
        numbers.push(userInput[i].value - 0);
    }

    if (numbers[0] >= numbers[1] && numbers[0] >= numbers[2]) {
        if (numbers[1] >= numbers[2]) {
            container.innerHTML = numbers[0] + " " + numbers[1] + " " + numbers[2];
        } else {
            container.innerHTML = numbers[0] + " " + numbers[2] + " " + numbers[1];
        }
    } else if (numbers[1] >= numbers[0] && numbers[1] >= numbers[2]) {
        if (numbers[0] >= numbers[2]) {
            container.innerHTML = numbers[1] + " " + numbers[0] + " " + numbers[2];
        } else {
            container.innerHTML = numbers[1] + " " + numbers[2] + " " + numbers[0];
        }
    } else if (numbers[2] >= numbers[0] && numbers[2] >= numbers[1]) {
        if (numbers[0] >= numbers[1]) {
            container.innerHTML = numbers[2] + " " + numbers[0] + " " + numbers[1];
        } else {
            container.innerHTML = numbers[2] + " " + numbers[1] + " " + numbers[0];
        }
    }
}