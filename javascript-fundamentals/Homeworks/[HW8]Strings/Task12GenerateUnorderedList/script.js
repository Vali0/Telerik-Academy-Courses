var people = [
    { name: "Peter", age: 14 },
    { name: "Gosho", age: 17 },
    { name: "Mariika", age: 31 },
    { name: "Not valid age property", aaaaage: 44 },
    { nnnnnname: "HAHAHHA", age: "Not valid name property"}
];

var template = document.getElementById("list-item").innerHTML,
    peopleList = generateList(people, template);

document.body.appendChild(peopleList);

function generateList(people, template) {
    var result = document.createElement("ul");

    for (var person in people) {
        var placeholderStartIndex = template.indexOf("-{"),
            placeholderEndIndex = 0,
            property;
        
        var singleListItem = document.createElement("li");
        singleListItem.innerHTML = template;
        while (placeholderStartIndex !== -1) {
            placeholderEndIndex = template.indexOf("}-", placeholderStartIndex);
            property = template.substring(placeholderStartIndex + 2, placeholderEndIndex);
            placeholderStartIndex = template.indexOf("-{", placeholderEndIndex);
            
            if (hasProperty(people[person], property)) {
                var pattern = new RegExp("-{" + property + "}-", 'g');
                singleListItem.innerHTML = singleListItem.innerHTML.replace(pattern, people[person][property]);
            }
        }

        result.appendChild(singleListItem);
    }

    return result;
}

function hasProperty(obj, property) {
    for (var item in obj) {
        if (item === property) {
            return property;
        }
    }

    return false;
}