app.controller('driversController', function ($scope, identity, stats) {
    var currentUser = identity.getLoggedUser();
    $scope.isLogged = identity.isAuthenticated;
    $scope.filterDrivers = filterDrivers;

    stats.showDrivers(currentUser)
        .then(function (data) {
            $scope.drivers = data;
        },
              function (error) {
                  console.log(error);
              });

    function filterDrivers(filter) {
        //filter.page = filter.page || 1;
        filter.username = filter.username || '';

        var filters = '?page=' + filter.page + '&username=' + filter.username;

        stats.showDriversFiltered(currentUser, filters)
            .then(function (data) {
                console.log(data);
                if (data.length !== 0) {
                    $scope.noResults = ''
                    $scope.drivers = data;
                } else {
                    $scope.noResults = 'No results!';
                    $scope.drivers = [];
                }
            },
                  function (error) {
                      console.log(error);
                  })
    }
});