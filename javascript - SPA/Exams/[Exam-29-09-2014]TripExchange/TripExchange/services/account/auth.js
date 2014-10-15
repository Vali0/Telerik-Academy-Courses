app.factory('auth', function ($http, $q, identity) {
    var baseUrl = 'http://spa2014.bgcoder.com/api/users/';

    function signUp(user) {
        var deferred = $q.defer();

        $http.post(baseUrl + 'register', user)
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

        $http.post(baseUrl + 'login', 'username=' + user.email + '&password=' + user.password + '&grant_type=password', { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
            .success(function (response) {
                identity.logUser(response);
                deferred.resolve();
            })
            .error(function (response) {
                deferred.reject();
            });

        return deferred.promise;
    }

    function signOut(currentUser) {
        var deferred = $q.defer();

        if (currentUser) { // If there is logged user. Maybe put request into if statement for less requests to server
            var header = { 'Authorization': currentUser['token_type'] + ' ' + currentUser['access_token'] };
        }

        $http.post(baseUrl + 'logout', {}, { headers: header })
            .success(function (response) {
                identity.logOutUser();
                deferred.resolve();
            })
            .error(function (response) {
                deferred.reject();
            })

        return deferred.promise;
    }

    function getInfo(currentUser) {
        var deferred = $q.defer();
        var header = { 'Authorization': currentUser['token_type'] + ' ' + currentUser['access_token'] };

        $http.get(baseUrl + 'userinfo', { headers: header })
            .success(function (response) {
                deferred.resolve(response);
            })
            .error(function (response) {
                deferred.reject(response);
            });

        return deferred.promise;
    }

    return {
        signup: signUp,
        signin: signIn,
        signout: signOut,
        info: getInfo
    }
});