function findGreatest() {
    var userInput,
        numbers = [],
        container;
    
    userInput = document.getElementsByClassName("user-input");
    for (var i = 0, len = userInput.length; i < len; i++) {
        numbers.push(userInput[i].value - 0);
    }
    container = document.getElementById("result");
    
    var result = Math.max.apply(null, numbers); // Using apply prototype. Read more: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Function/apply
    container.innerHTML = result;
}