var firstArray = ['b', 'y', 'k', 'l'],
    secondArray = ['b', 'y', 'k', 'l'],
    result,
    len;

len = Math.min(firstArray.length, secondArray.length);
result = document.getElementById("result");

for (var i = 0; i < len; i++) {
    if (firstArray[i] > secondArray[i]) {
        result.innerHTML = "Lexicographically the " + secondArray + " array is first";
        break;
    } else if (firstArray[i] < secondArray[i]) {
        result.innerHTML = "Lexicographically the " + firstArray + " is first";
        break;
    } else if (i === len - 1) {
        if (firstArray[i] === secondArray[i] && firstArray.length === secondArray.length) {
            result.innerHTML = "Two arrays are equal"
        } else {
            result.innerHTML = "Lexicographically the " + (firstArray.length === len ? firstArray : secondArray) + " is first";
        }
    }
}