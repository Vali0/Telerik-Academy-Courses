/// <reference path="jquery-1.11.1.min.js" />
var originalObject = {
    firstName: "Pesho",
    lastName: "Geshov",
    age: 17,
    obj: { gname: "meaningful text" }
};
var copyObject;

copyObject = deepCopy(originalObject);
console.log("Original object");
console.log(originalObject);
console.log("Copied object");
console.log(copyObject);
copyObject.obj.gname = "changed text";
copyObject.age = "99999";
copyObject.firstName = "Gosho";
console.log("After chaning copy object");
console.log(copyObject);
console.log("Original object" + originalObject);
console.log(originalObject);

function deepCopy(target, copy) {
    var copy = copy || {};
    for (var i in target) {
        if (typeof target[i] === "object") {
            copy[i] = (target[i].constructor === Array) ? [] : {};
            deepCopy(target[i], copy[i]);
        } else
            copy[i] = target[i];
    }
    return copy;
}

var copyObj = $.extend(true, {}, originalObject); // Solution with jQuery