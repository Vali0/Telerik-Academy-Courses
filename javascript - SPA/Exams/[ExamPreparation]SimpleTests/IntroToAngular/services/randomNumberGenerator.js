myApp.factory('generateRandomNumbersService', function () {
    function generateRandomNumbers(min, max) {
        var numbers = [];

        for (var i = 0; i < 10; i++) {
            numbers.push((Math.random() * (max - min + 1) + min) | 0);
        }

        return numbers;
    }
    
    return {
        generate: generateRandomNumbers
    }
});