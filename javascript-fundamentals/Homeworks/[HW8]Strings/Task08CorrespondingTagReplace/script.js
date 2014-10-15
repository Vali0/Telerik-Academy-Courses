var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

var result = replaceAnchorTags(text);
console.log(result);

function replaceAnchorTags(text) {
    text = text.replace(/<a href="/g, "[URL=");
    text = text.replace(/">/g, ']');
    text = text.replace(/<\/a>/g, "[/URL]");

    return text;
}