myApp.controller("randomNumberController", function ($scope, generateRandomNumbersService) {
    $scope.numbers = generateRandomNumbersService.generate(5, 1000);
});