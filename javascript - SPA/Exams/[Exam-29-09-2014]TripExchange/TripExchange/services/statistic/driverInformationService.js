app.factory('additionalInformation', function ($http, $q) {
    var baseUrl = 'http://spa2014.bgcoder.com/api/';
    
    function showInformation(id, currentUser) {
        var deferred = $q.defer();

        if (currentUser) {
            var header = { 'Authorization': currentUser['token_type'] + ' ' + currentUser['access_token'] };
        }

        $http.get(baseUrl + 'drivers/' + id['id'], { headers: header })
            .success(function (response) {
                deferred.resolve(response);
            })
            .error(function (response) {
                deferred.reject(response);
            });

        return deferred.promise;
    }

    return {
        show: showInformation
    }
});