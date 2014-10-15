var result = document.getElementById("result");

getMinMaxProperty([document, window, navigator]);

function getMinMaxProperty(objectsArray) {
    var len = objectsArray.length;

    for (var i = 0; i < len; i++) {
        var propertyArray = [];
        for (var item in objectsArray[i]) {
            propertyArray.push(item); // Get properties and save them into array
        }

        propertyArray.sort(); // Sorting the array
        result.innerHTML += objectsArray[i] + "<br />Smallest property: " + propertyArray[0] + "<br />Largest property: " + propertyArray[propertyArray.length - 1] + "<br />";
    }
}