var text = "wqdjkdjwqlw pesho@abv.bg dkq gosho@mail.bg mariika@gmail.com qkdwjlqwd hahahaha@yahoo.com";

var emails = parseEmails(text);
console.log(emails);

function parseEmails(text) {
    var pattern = /([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi;
    var emails = text.match(pattern);
    
    return emails;
}