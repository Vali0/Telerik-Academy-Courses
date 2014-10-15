var userInput,
    word,
    result;

word = document.getElementById("search-word").value;
text = document.getElementById("content").innerHTML;
result = document.getElementById("result");

countWord();

function countWord() {
    var pattern,
        flag,
        matches;

    if (document.getElementById("sensitiveFlag").checked) {
        flag = "gi";
    } else {
        flag = 'g';
    }

    pattern = new RegExp("\\b" + word + "\\b", flag);
    matches = text.match(pattern)

    if (matches !== null) {
        result.innerHTML = matches.length;
    } else {
        result.innerHTML = "No such word in text!";
    }
}

function changeWord() {
    word = document.getElementById("search-word").value;
    countWord();
}