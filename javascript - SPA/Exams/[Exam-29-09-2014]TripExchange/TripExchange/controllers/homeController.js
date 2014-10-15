app.controller('homeController', function ($scope, identity, stats) {
    var currentUser = identity.getLoggedUser();

    stats.stats()
        .then(function (data) {
            $scope.stats = data;
        },
              function (error) {
                  console.log(error);
              })

    stats.showTrips(currentUser)
        .then(function (data) {
            $scope.trips = data;
        },
              function (error) {
                  console.log(error);
              });

    stats.showDrivers(currentUser)
        .then(function (data) {
            $scope.drivers = data;
        },
              function (error) {
                  console.log(error);
              });
});