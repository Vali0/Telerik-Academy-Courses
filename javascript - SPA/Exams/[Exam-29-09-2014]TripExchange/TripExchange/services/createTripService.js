app.service('createTripService', function ($http, $q) {
    var baseUrl = 'http://spa2014.bgcoder.com/api/';

    function createTrip(currentUser, data) {
        var deferred = $q.defer();

        if (currentUser) {
            var header = { 'Authorization': currentUser['token_type'] + ' ' + currentUser['access_token'] };
        }
        
        console.log(data);
        $http.post(baseUrl + 'trips', data, { headers: header })
            .success(function (response) {
                deferred.resolve(response);
            })
            .error(function (response) {
                deferred.reject(response);
            });

        return deferred.promise;
    }

    return {
        createTrip: createTrip
    }
});