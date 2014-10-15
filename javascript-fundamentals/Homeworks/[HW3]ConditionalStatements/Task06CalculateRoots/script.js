function calculatingRoots() {
    var userInput,
        coefA,
        coefB,
        coefC,
        firstRoot,
        secondRoot,
        discriminant,
        container;
    
    userInput = document.getElementsByClassName("user-input");
    coefA = userInput[0].value - 0;
    coefB = userInput[1].value - 0;
    coefC = userInput[2].value - 0;
    container = document.getElementById("result");

    discriminant = coefB * coefB - 4 * coefA * coefC;
    
    if (discriminant > 0) {
        firstRoot = ((-coefB) + Math.sqrt(discriminant)) / (2 * coefA); 
        secondRoot = ((-coefB) - Math.sqrt(discriminant)) / (2 * coefA);
        container.innerHTML = "Roots are: " + firstRoot + ' ' + secondRoot;
    } else if (discriminant === 0) {
        firstRoot = (-coefB) / (2 * coefA);
        container.innerHTML = "First and second roots are equal to: " + firstRoot;
    } else {
        container.innerHTML = "Quadratic equation has imaginary roots";
    }
}