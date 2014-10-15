var persons = [
    { firstname: "Gosho", lastname: "Petrov", age: 32 },
    { firstname: "Bay", lastname: "Ivan", age: 81 },
    { firstname: "Bay", lastname: "Ivan", age: 40 },
    { firstname: "Bay", lastname: "Ivan", age: 33 },
    { firstname: "Mariika", lastname: "Ivanova", age: 32 },
    { firstname: "Goshooooo", lastname: "Petrov", age: 32 },
    { firstname: "Stamat", lastname: "Spiridonov", age: 80 }
];

group(persons, "firstname");
group(persons, "lastname");
group(persons, "age");

function group(persons, groupBy) {
    var groupedPersons = {},
        item;

    if (groupBy === "firstname") {
        for (item in persons) {
            groupedPersons[persons[item].firstname] = (groupedPersons[persons[item].firstname] || 0) + 1;
        }
    } else if (groupBy === "lastname") {
        for (item in persons) {
            groupedPersons[persons[item].lastname] = (groupedPersons[persons[item].lastname] || 0) + 1;
        }
    } else if (groupBy === "age") {
        for (item in persons) {
            groupedPersons[persons[item].age] = (groupedPersons[persons[item].age] || 0) + 1;
        }
    } else {
        console.log("Wrong group by parameter!");
    }
    
    console.log(groupedPersons);
}