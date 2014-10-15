var result = document.getElementById("result");
var firstObject = {
    name: "pesho",
    age: 17
};

result.innerHTML = "Has property length - " + hasProperty(firstObject, "length") +
                   "<br />Has property name - " + hasProperty(firstObject, "name") +
                   "<br />Has property pesho - " + hasProperty(firstObject, "pesho");

function hasProperty(obj, property) {
    for (var item in obj) {
        if (item === property) {
            return true;
        }
    }

    return false;
}