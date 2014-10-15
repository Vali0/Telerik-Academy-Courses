function selectDirectDivsByQuery() {
    var selectedDivs = document.querySelectorAll('div>div');
    return selectedDivs;
}

function selectDirectDivsByTagName() {
    var divs = document.getElementsByTagName('div');
    var selectedDivs = [];
    for (var i = 0, len = divs.length; i < len; i++) {
        if (divs[i].parentNode.nodeName === 'DIV') {
            selectedDivs.push(divs[i]);
        }
    }
    return selectedDivs;
}

function printSelectedDivs(divs) {
    for (var i = 0, len = divs.length; i < len; i++) {
        console.log(divs[i].innerHTML);
    }
}

(function() {
    var byTagName = selectDirectDivsByTagName();

    console.log('---By tag name---');
    printSelectedDivs(byTagName);

    var byQuery = selectDirectDivsByQuery();

    console.log('---By query---');
    printSelectedDivs(byQuery);
})();