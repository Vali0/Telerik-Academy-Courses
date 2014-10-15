(function () {
    if (!document.querySelector) {
        document.querySelector = function (selector) {
            if (selector[0] === '#') {
                return document.getElementById(selector.substr(1));
            } else if (selector[0] === '.') {
                return document.getElementsByClassName(selector.substr(1))[0];
            } else {
                return document.getElementsByTagName(selector)[0];
            }
        }
    }

    if (!document.querySelectorAll) {
        document.querySelectorAll = function (selector) {
            if (selector[0] === '#') {
                return document.getElementById(selector.substr(1));
            } else if (selector[0] === '.') {
                return document.getElementsByClassName(selector.substr(1));
            } else {
                return document.getElementsByTagName(selector);
            }
        }
    }
}
)();

var singleDiv = document.querySelector('div');

console.log(singleDiv);

var divs = document.querySelectorAll('div');

for (var i = 0; i < divs.length; i++) {
    console.log(divs[i]);
}

var byId = document.querySelector('#wrapper');

console.log(byId);