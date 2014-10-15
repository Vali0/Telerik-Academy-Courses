app.factory('stats', function ($http, $q) {
    var baseUrl = 'http://spa2014.bgcoder.com/api/';

    function stats() {
        var deferred = $q.defer();

        $http.get(baseUrl + 'stats')
            .success(function (response) {
                deferred.resolve(response);
            })
            .error(function (response) {
                deferred.reject(response);
            });

        return deferred.promise;
    }

    function getCities() {
        var deferred = $q.defer();

        $http.get(baseUrl + 'cities', {})
            .success(function (response) {
                deferred.resolve(response);
            })
            .error(function (response) {
                deferred.reject(response);
            });
        
        return deferred.promise;
    }

    function showTrips(currentUser) {
        var deferred = $q.defer();

        if (currentUser) {
            var header = { 'Authorization': currentUser['token_type'] + ' ' + currentUser['access_token'] };
        }

        $http.get(baseUrl + 'trips', { headers: header })
            .success(function (response) {
                deferred.resolve(response);
            })
            .error(function (response) {
                deferred.reject(response);
            });

        return deferred.promise;
    }

    function showTripsFiltered(currentUser, filters) {
        var deferred = $q.defer();

        if (currentUser) {
            var header = { 'Authorization': currentUser['token_type'] + ' ' + currentUser['access_token'] };
        }

        $http.get(baseUrl + 'trips' + filters, { headers: header })
            .success(function (response) {
                deferred.resolve(response);
            })
            .error(function (response) {
                deferred.reject(response);
            });

        return deferred.promise;
    }

    function showDrivers(currentUser) {
        var deferred = $q.defer();

        if (currentUser) {
            var header = { 'Authorization': currentUser['token_type'] + ' ' + currentUser['access_token'] };
        }

        $http.get(baseUrl + 'drivers', { headers: header })
            .success(function (response) {
                deferred.resolve(response);
            })
            .error(function (response) {
                deferred.reject(response);
            });

        return deferred.promise;
    }

    function showDriversFiltered(currentUser, filters) {
        var deferred = $q.defer();

        if (currentUser) {
            var header = { 'Authorization': currentUser['token_type'] + ' ' + currentUser['access_token'] };
        }

        $http.get(baseUrl + 'drivers' + filters, { headers: header })
            .success(function (response) {
                deferred.resolve(response);
            })
            .error(function (response) {
                deferred.reject(response);
            });

        return deferred.promise;
    }

    return {
        stats: stats,
        cities: getCities,
        showTrips: showTrips,
        showTripsFiltered: showTripsFiltered,
        showDrivers: showDrivers,
        showDriversFiltered: showDriversFiltered
    }
});