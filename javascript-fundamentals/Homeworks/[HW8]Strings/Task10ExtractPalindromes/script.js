var text = "My favorite group is ABBA ther are lamal and their exe songs are awesome!";
var palindromes = getPalindromes(text);
console.log(palindromes);

function getPalindromes(text) {
    var tokens = text.split(' ');
    var palindromes = [];
    
    for (var item in tokens) {
        if (isPalindrome(tokens[item])) {
            palindromes.push(tokens[item]);
        }
    }
    
    return palindromes;
}

function isPalindrome(item) {
    var len = item.length
    for (var i = 0; i < len; i++) {
        if (item[i] !== item[len - i - 1]) {
            return false;
        }
    }

    return true;
}