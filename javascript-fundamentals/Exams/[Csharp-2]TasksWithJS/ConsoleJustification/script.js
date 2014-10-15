function Solve(params) {
    String.prototype.splice = function (idx, rem, s) {
        return (this.slice(0, idx) + s + this.slice(idx + Math.abs(rem)));
    };

    var lines = params[0] | 0,
        symbolsPerLine = params[1] | 0,
        text = '',
        justifiedText = [];

    for (var i = 2; i < lines + 2; i++) {
        text += params[i] + ' ';
    }

    text = text.replace(/\s+/g, ' ').trim().split(' ');

    var wordsOnLine = '';
    var currentWords = 0;
    for (var word = 0, len = text.length; word < len; word++) {
        wordsOnLine += text[word] + ' ';
        currentWords++;

        if (word === len - 1) {
            justifiedText.push(wordsOnLine.trim());
        } else if (wordsOnLine.trim().length === symbolsPerLine) {
            justifiedText.push(wordsOnLine.trim());
            wordsOnLine = ''
            currentWords = 0;
        } else if ((wordsOnLine.trim().length + text[word + 1].length) > symbolsPerLine) {
            wordsOnLine = wordsOnLine.trim();
            if (currentWords === 1) {
                justifiedText.push(wordsOnLine);
            } else {
                var neededSpaces = symbolsPerLine - wordsOnLine.length;
                var indexOfSpace = 0;
                while (neededSpaces !== 0) {
                    indexOfSpace = wordsOnLine.indexOf(' ', indexOfSpace + 1);
                    if (indexOfSpace === -1) {
                        indexOfSpace = wordsOnLine.indexOf(' ');
                    }
                    while (wordsOnLine[indexOfSpace] === ' ') {
                        indexOfSpace++;
                    }
                    wordsOnLine = wordsOnLine.splice(indexOfSpace, 0, ' ');
                    neededSpaces--;
                }
                justifiedText.push(wordsOnLine);
            }
            wordsOnLine = ''
            currentWords = 0;
        }
    }
    return justifiedText.join('\n');
}

//params = [
//    "5",
//    "20",
//    "We happy few        we band",
//    "of brothers for he who sheds",
//    "his blood",
//    "with",
//    "me shall be my brother"
//];

params = [
    "    10",
    "18",
    "Beer beer beer Im going for ",
    "   a",
    "beer",
    "Beer beer beer Im gonna",
    "drink some beer",
    "I love drinkiiiiiiiiing ",
    "beer",
    "lovely ",
    "lovely",
    "beer"
];

console.log(Solve(params));