/// <reference path="libs/underscore-min.js" />
(function () {
    var Animal = (function () {
        function Animal(species, legs) {
            this.species = species,
            this.legs = legs
        }

        return Animal;
    }());

    var animals = [
        new Animal('mammal', 4),
        new Animal('reptiles', 2),
        new Animal('insect', 100),
        new Animal('mammal', 2),
        new Animal('insect', 8),
        new Animal('reptiles', 4)
    ];

    // Task 4
    var groupedAnimals = groupAnimalsBy(animals, 'species');
    var sortedAnimals = sortAnimalsBy(groupedAnimals, 'legs');
    console.log(sortedAnimals);

    function groupAnimalsBy(animals, groupBy) {
        groupBy = groupBy || 'species';

        var result = _.groupBy(animals, groupBy);

        return result;
    }

    function sortAnimalsBy(grouped, sortBy) {
        sortBy = sortBy || 'legs';
        var result = {};

        for (var item in grouped) {
            result[item] = _.sortBy(grouped[item], sortBy);
        }

        return result;
    }

    // Task 5
    var totalNumberOfLegs = countAnimalsLegs(animals);
    console.log('Animals legs: ' + totalNumberOfLegs);

    function countAnimalsLegs(animals) {
        var legsCounter = 0;

        _.each(animals, function (animal) {
            legsCounter += animal.legs;
        });

        return legsCounter
    }
}());