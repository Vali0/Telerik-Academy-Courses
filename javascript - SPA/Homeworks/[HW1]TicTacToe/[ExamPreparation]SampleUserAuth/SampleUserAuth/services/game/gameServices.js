app.factory('game', function ($http, $q) {
    var baseUrl = 'http://localhost:55713/';

    function createGame(currentUser) {
        var deferred = $q.defer();

        $http.post(baseUrl + 'api/game/create', {}, {
            headers: {
                'Authorization': currentUser['token_type'] + ' ' + currentUser['access_token']
            }
        })
            .success(function (response) {
                deferred.resolve();
            })
            .error(function (response) {
                deferred.reject();
            })

        return deferred.promise;
    }

    function joinGame(currentUser) {
        var deferred = $q.defer();

        $http.post(baseUrl + 'api/game/join', {}, {
            headers: {
                'Authorization': currentUser['token_type'] + ' ' + currentUser['access_token']
            }
        })
            .success(function (response) {
                deferred.resolve();
            })
            .error(function (response) {
                deferred.reject();
            })

        return deferred.promise;
    }

    function play(data, currentUser) {
        var deferred = $q.defer();

        $http.post(baseUrl + 'api/game/play', data, {
            headers: {
                'Authorization': currentUser['token_type'] + ' ' + currentUser['access_token']
            }
        })
            .success(function (response) {
                deferred.resolve();
            })
            .error(function (response) {
                deferred.reject();
            })

        return deferred.promise;
    }

    return {
        create: createGame,
        join: joinGame,
        play: play,
    }
});