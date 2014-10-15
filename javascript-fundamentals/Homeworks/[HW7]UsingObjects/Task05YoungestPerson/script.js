var persons = [
    { firstname: "Gosho", lastname: "Petrov", age: 32 },
    { firstname: "Bay", lastname: "Ivan", age: 81 },
    { firstname: "Pesho", lastname: "Kaspichanski", age: 17 },
    { firstname: "Mariika", lastname: "Ivanova", age: 20 }
];

var youngestPersonIndex = findYoungest(persons);
document.getElementById("result").innerHTML = persons[youngestPersonIndex].firstname + ' ' + persons[youngestPersonIndex].lastname;

function findYoungest(persons) {
    var minAge = 130,
        personIndex;

    for (var item in persons) {
        if (minAge > persons[item].age) {
            minAge = persons[item].age;
            personIndex = item;
        }
    }

    return personIndex;
}