function reverseNumber() {
    var number,
        reversedNumber = "",
        result;

    number = document.getElementsByClassName("user-input")[0].value | 0;
    result = document.getElementById("result");
   
    //result.innerHTML = number.split('').reverse().join(''); // One row solution. !!!Remove " | 0 " at parsing to work!!! Split it to get array of digits (can split because this is string value. Reverse it and print it with no space.
    
    while (number !== 0) {
        reversedNumber += number % 10;
        number = number / 10 | 0;
    }

    result.innerHTML = reversedNumber;
}