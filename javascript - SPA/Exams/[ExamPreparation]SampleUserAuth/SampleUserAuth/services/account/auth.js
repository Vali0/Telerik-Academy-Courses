app.factory('auth', function ($http, $q, identity) {
    var baseUrl = 'http://localhost:55713/';

    function signUp(user) {
        var deferred = $q.defer();

        $http.post(baseUrl + 'api/account/register', user)
            .success(function (response) {
                deferred.resolve(response);
            })
            .error(function (response) {
                deferred.reject();
            });

        return deferred.promise;
    }

    function signIn(user) {
        var deferred = $q.defer();

        $http.post(baseUrl + 'Token', 'username=' + user.email + '&password=' + user.password + '&grant_type=password', { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
            .success(function (response) {
                identity.logUser(response);
                deferred.resolve();
            })
            .error(function (response) {
                deferred.reject();
            });

        return deferred.promise;
    }

    function signOut() {
        var deferred = $q.defer();
        var currentUser = identity.getLoggedUser();

        if (currentUser) { // If there is logged user. Maybe put request into if statement for less requests to server
            var header = { 'Authorization': currentUser['token_type'] + ' ' + currentUser['access_token'] };
        }

        $http.post(baseUrl + 'api/account/logout', {}, { headers: header })
            .success(function (response) {
                identity.logOutUser();
                deferred.resolve();
            })
            .error(function (response) {
                deferred.reject();
            })

        return deferred.promise;
    }

    return {
        signup: signUp,
        signin: signIn,
        signout: signOut
    }
});