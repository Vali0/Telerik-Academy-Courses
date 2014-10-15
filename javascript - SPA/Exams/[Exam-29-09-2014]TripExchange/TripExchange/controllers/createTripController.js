app.controller('createTripController', function ($scope, identity, stats, createTripService) {
    var currentUser = identity.getLoggedUser();
    $scope.createTrip = createTrip;

    stats.cities()
        .then(function (data) {
            $scope.fromTowns = data;
            $scope.toTowns = data;
        },
              function (error) {
                  console.log(error);
              });
    
    function createTrip(data) {
        createTripService.createTrip(currentUser, data)
            .then(function (data) {
                console.log('created!');
            },
                  function (error) {
                      console.log(error);
                  })
    }
});