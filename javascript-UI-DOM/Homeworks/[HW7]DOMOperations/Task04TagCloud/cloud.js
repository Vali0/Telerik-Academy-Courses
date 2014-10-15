(function () { 
    var tags = [
        "js", "cms", "cms", "cms", "js", "wp",
        "cms", "javascript", "js", "ASP.NET MVC", ".net", ".net", "css", "wordpress",
        "xaml", "js", "http", "web", "asp.net", "asp.net MVC", "ASP.NET MVC", "wp", "javascript",
        "js", "cms", "html", "javascript", "http", "http", "CMS"
    ];

    var uniqueTgas = new Array();

    for (var i = 0, len = tags.length; i < len; i++) {
        if (uniqueTgas.indexOf(tags[i].toLowerCase()) === -1) {
            uniqueTgas.push(tags[i].toLocaleLowerCase());
        }
    }

    var cloudTag = document.getElementById("tagsContainer");

    cloudTag.setAttribute("style", "border: 1px solid black; width: 200px;");

    generateTagCloud(tags, 17, 42);

    function generateTagCloud(tags, min, max) {
        var occurrences = new Array();

        for (var i = 0, len = uniqueTgas.length; i < len; i++) {
            var tempOccurrence = 0;
            for (var j = 0, bigLen = tags.length; j < bigLen; j++) {
                if (uniqueTgas[i] === tags[j].toLowerCase()) {
                    tempOccurrence++;
                }
            }

            occurrences.push(tempOccurrence);
        }

        var maxOccurrence = 0;
        for (i = 0; i < len; i++) {
            if (maxOccurrence < occurrences[i]) {
                maxOccurrence = occurrences[i];
            }
        }

        for (i = 0; i < len; i++) {
            var fontSize = occurrences[i] === 1 ? min
                           : (occurrences[i] / maxOccurrence) * (max - min) + min;
            cloudTag.innerHTML += "<font style=\"font-size: " + fontSize + "px;\">" + uniqueTgas[i] + "</font> ";
        }
    }
}());