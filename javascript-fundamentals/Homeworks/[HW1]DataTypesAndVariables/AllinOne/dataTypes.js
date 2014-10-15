console.log("Task01: Assign all the possible JavaScript literals to different variables.");

console.log("---Array Literal---");

var array = ["pesho", "gosho", 11, "mariika", 5];

for (var i = 0, len = array.length; i < len; i++) {
    console.log(array[i]);
}

console.log("---Boolean Literal---");

var flag = false;

console.log(flag);

console.log("---Integer Literal---");

var integerNumber = 123;

console.log(integerNumber);

console.log("---Float Literal---");

var floatNumber = 1.234;

console.log(floatNumber);

console.log("---Object Literal---");

var objVariable = {
    name: "Pesho",
    age: 17,
    spouse: "Mariika",
    getInfo: function() {
        return this.name + ' ' + this.age + ' ' + this.spouse
    }
};

console.log(objVariable.getInfo());

console.log("---String Literal---");

var stringVariable = "Pesho Kaspichanski";

console.log(stringVariable);

console.log("Task02: Create a string variable with quoted text in it.");
console.log('"How you doin\'?", Joey said');

console.log("Task03: Try typeof on all variables you created.");

console.log("---Array Literal---");
console.log(typeof (array));

console.log("---Boolean Literal---");
console.log(typeof (flag));

console.log("---Integer Literal---");
console.log(typeof (integerNumber));

console.log("---Float Literal---");
console.log(typeof (floatNumber));

console.log("---Object Literal---");
console.log(typeof (objVariable));

console.log("---String Literal---");
console.log(typeof (stringVariable));

console.log("Task04: Create null, undefined variables and try typeof on them.");

console.log("---Null Varialbe---")

var nullVariable = null;

console.log(typeof (nullVariable));

console.log("---Undefined Variable---");

var undefinedVariable;

console.log(typeof (undefinedVariable));