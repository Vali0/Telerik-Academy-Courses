var htmlContent = "<html><head><title>Sample \
site</title></head><body><div>text<div>more \
text</div>and more...</div>in body</body></html>";

function extractContentFromHTML(htmlContent) {
    var result = "";
    result = htmlContent.replace(/<\w*>|<\/\w*>/gi, '');
    return result;
}

var result = extractContentFromHTML(htmlContent);

console.log(result);