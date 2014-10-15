String.prototype.countSubstring = countContainedString;
var str = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
    
var result = str.countSubstring("in");
console.log(result);

function countContainedString(target) {
    var pattern = new RegExp(target, 'gi'),
        matches = this.match(pattern);

    if (matches !== null) {
        return matches.length;
    }
    return "No such substring into text!";
}

