var url = "http://www.devbg.org/forum/index.php",
    parsedURL = parseURL(url);

console.log(parsedURL);

function parseURL(url) {
    var index,
        endIndex,
        protocol,
        server,
        resource;

    index = url.indexOf("://");
    protocol = url.substring(0, index);
    server = url.substring(url);
    index += 3;
    endIndex = url.indexOf('/', index);
    server = url.substring(index, endIndex);
    resource = url.substring(endIndex);

    return {
        protocol: protocol,
        server: server,
        resource: resource
    }
}