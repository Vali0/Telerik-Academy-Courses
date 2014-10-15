function digitName() {
    var number,
        result;

    number = document.getElementsByClassName("user-input")[0].value | 0;
    result = document.getElementById("result");

    result.innerHTML = getLastDigit(number);
}

function getLastDigit(number) {
    var result;
    
    if ((number / 10 | 0) === 0) { // If the the number is a digit just print its name
        result = getName(number);
    } else {
        result = getName(number % 10);
    }
    return result;
}

function getName(digit) {
    var name;

    switch (digit) {
        case 0:
            name = "zero";
            break;
        case 1:
            name = "one";
            break;
        case 2:
            name = "two";
            break;
        case 3:
            name = "three";
            break;
        case 4:
            name = "four";
            break;
        case 5:
            name = "five";
            break;
        case 6:
            name = "six"
            break;
        case 7:
            name = "seven";
            break;
        case 8:
            name = "eight";
            break;
        case 9:
            name = "nine";
            break;
        default:
            name = "Something terribly went wrong!"
            break;
    }
    return name;
}