app.controller('driverInformationController', function ($scope, $routeParams, identity, additionalInformation) {
    var currentUser = identity.getLoggedUser();

    additionalInformation.show($routeParams, currentUser) 
        .then(function (data) {
            $scope.driver = data;
        },
              function (error) {
                  console.log(error);
              })
});