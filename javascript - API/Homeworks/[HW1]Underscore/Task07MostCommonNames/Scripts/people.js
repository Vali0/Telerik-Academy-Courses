/// <reference path="libs/underscore-min.js" />
(function () {
    var Person = (function () {
        function Person(firstName, lastName) {
            this.firstName = firstName,
            this.lastName = lastName
        }

        return Person;
    }());

    var people = [
        new Person('Ivan', 'Ivanov'),
        new Person('Pesho', 'Ivanov'),
        new Person('Mariika', 'Gesheva'),
        new Person('Pesho', 'Kaspichanski'),
        new Person('Zorbas', 'Kaspichanski')
    ];

    console.log('People with most frequent first name: ' + findMostFrequentName(people, 'firstName'));
    console.log('People with most frequent last name: ' + findMostFrequentName(people, 'lastName'));

    function findMostFrequentName(people, searchName) {
        var mostFrequentName = {},
            maxNameOccurence = 0,
            peopleWithMostFrequentName = [];

        mostFrequentName = _.countBy(people, function (person) {
            return person[searchName];
        });

        maxNameOccurence = _.max(mostFrequentName);

        for (var item in mostFrequentName) {
            if (mostFrequentName[item] === maxNameOccurence) {
                peopleWithMostFrequentName.push(item);
            }
        }

        return peopleWithMostFrequentName;
    }
}())