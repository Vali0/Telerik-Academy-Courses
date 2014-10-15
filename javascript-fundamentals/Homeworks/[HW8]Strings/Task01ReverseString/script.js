String.prototype.reverse = reverseString;

str = "What kind of sorcery is this?";

var reversed = str.reverse();

console.log(reversed);

function reverseString() {
    var splitted = this.split('');
    splitted.reverse();

    return splitted.join('');
}