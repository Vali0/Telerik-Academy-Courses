app.controller('tripsController', function ($scope, identity, stats) {
    var currentUser = identity.getLoggedUser();
    $scope.isLogged = identity.isAuthenticated;
    $scope.filterTrips = filterTrips;

    stats.cities()
        .then(function (data) {
            $scope.fromTowns = data;
            $scope.toTowns = data;
        },
              function (error) {
                  console.log(error);
              });

    stats.showTrips(currentUser)
        .then(function (data) {
            $scope.trips = data;
        },
              function (error) {
                  console.log(error);
              });

    function filterTrips(filter) {
        filter.page = filter.page || 1;
        filter.by = filter.by || 'date';
        filter.type = filter.type || 'asc';
        filter.fromTown = filter.fromTown || '';
        filter.toTown = filter.toTown || '';
        filter.finished = filter.finished || false;
        filter.onlyMine = filter.onlyMine || false;

        var filters = '?page=' + filter.page + '&orderBy=' + filter.by + '&orderType=' + filter.type + '&from=' + filter.fromTown + '&to=' + filter.toTown + '&finished=' + filter.finished + '&onlyMine=' + filter.onlyMine;

        stats.showTripsFiltered(currentUser, filters)
            .then(function (data) {
                if (data.length !== 0) {
                    $scope.noResults = ''
                    $scope.trips = data;
                } else {
                    $scope.noResults = 'No results!';
                    $scope.trips = [];
                }
            },
                  function (error) {
                      console.log(error);
                  })
    }
});