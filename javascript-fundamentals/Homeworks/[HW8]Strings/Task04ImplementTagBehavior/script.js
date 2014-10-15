var html = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

var result = transformHtml(html);

console.log(result);

function transformHtml(html) {
    return html.replace(/<mixcase>(.*?)<\/mixcase>/g, function (group) {
        return generateRandomCaseString(group);
    })
        .replace(/<upcase>(.*?)<\/upcase>/g, function (group) {
            return group.toUpperCase();
        })
        .replace(/<lowcase>(.*?)<\/lowcase>/g, function (group) {
            return group.toLowerCase();
        })
        .replace(/<(.*?)>/g, "");
}

function generateRandomCaseString(str) {
    var generated = "",
        randomNumber;

    for (var item in str) {
        randomNumber = Math.floor(Math.random() * 2); // generates 0 or 1

        if (randomNumber === 1) {
            generated += str[item].toUpperCase();
        } else {
            generated += str[item].toLowerCase();
        }
    }

    return generated;
}