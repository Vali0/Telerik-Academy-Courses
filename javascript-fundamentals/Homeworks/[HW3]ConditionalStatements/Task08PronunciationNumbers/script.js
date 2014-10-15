function printNumberName() {
    var number,
        numbersTillNineteen = [ "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" ],
        tensFromNumber = ["twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" ],
        container;
        
    number = document.getElementsByClassName("user-input")[0].value | 0;
    container = document.getElementById("result");

    // Tricky part starts here
    if (number < 20) // If the number pronunciation contains in the array by it self and don't need anything else
        container.innerHTML = numbersTillNineteen[number];
    else if (number > 19 && number < 100) // Between 20 and 99 inclusive
    {
        container.innerHTML = tensFromNumber[((number / 10) | 0) - 2]; // Getting first digit and decrease it with two (because our array starts from twenty which is '2')
        if (number % 10 !== 0) // If the second digit is diffrent by zero
            container.innerHTML += " " + numbersTillNineteen[number % 10]; // Getting that digit and printing it's name
    } else if (number > 99) // When our number is bigger than 100 inclusive
    {
        var realPart = number; // Variable for real part after dividing
        number = number / (Math.pow(10, 3 - 1) | 0); // Getting first digit. Need to perform type casting because Math.Pow
        realPart = realPart % (Math.pow(10, 3 - 1) | 0); // Getting last two digits, in one number
        container.innerHTML = numbersTillNineteen[number | 0] + " hundred "; // Printing first digit pronunciation

        if (realPart < 19 && realPart !== 0)
            container.innerHTML += "and " + numbersTillNineteen[realPart]; // If the number pronunciation contains in the array by it self and don't need anything else
        else if (realPart > 19 && realPart !== 0) {
            container.innerHTML += "and " + tensFromNumber[((realPart / 10) | 0) - 2]; // Printing second digit pronunciation (decrease by two because array size... I explain why little above)
            container.innerHTML += " " + numbersTillNineteen[(realPart % 10)]; // And finaly printing the last digit pronunciation
        }
    }
    /* And tricky part ends here
     * I've tried to explain it as good as I can
     * It's not too hard, just a lot of math and work with array's bounds
     */
}