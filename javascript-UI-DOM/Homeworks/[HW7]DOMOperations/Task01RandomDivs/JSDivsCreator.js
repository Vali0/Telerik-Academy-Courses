function createRandomDiv() {
    var contentDiv = document.getElementById("content");
    var count = document.getElementById("divsCount").value | 0;
    var docFragment = document.createDocumentFragment();

    while (contentDiv.firstChild) {
        contentDiv.removeChild(contentDiv.firstChild);
    }

    
    var div = document.createElement("div");
    for (var i = 0; i < count; i++) {
        div = div.cloneNode(false);
        div.innerHTML = "<strong>div</strong>";
        div.setAttribute("style", "width: " + randomDimensions() + "px; height: " + randomDimensions() + "px;"
                                  + "background-color: " + randomColor() + ';' + "color: " + randomColor() + ';'
                                  + "border-style: solid;" + "border-color: " + randomColor() + ';' + "border-width: " + randomNumber() + "px;" + "border-radius: " + randomNumber() + "px;"
            );
        divPosition(div);
        docFragment.appendChild(div);
    }
    
    contentDiv.appendChild(docFragment);
}

function randomDimensions() {
    return Math.floor(Math.random() * (100 - 20 - 1) + 20);
}

function randomColor() {
    var red = (Math.random() * 256) | 0;
    var green = (Math.random() * 256) | 0;
    var blue = (Math.random() * 256) | 0;
    return "rgb(" + red + "," + green + "," + blue + ")";
}

function randomNumber() {
    return Math.floor(Math.random() * 10 + 1);
}

var maxWidth = screen.width - 100;
var maxHeight = screen.height - 300;

function divPosition(tempDiv) {
    var topPos = (Math.random() * (maxHeight - 40)) | 0;
    tempDiv.style.top = topPos + "px";
    var left = (Math.random() * (maxWidth - 40)) | 0;
    tempDiv.style.left = left + "px";
}