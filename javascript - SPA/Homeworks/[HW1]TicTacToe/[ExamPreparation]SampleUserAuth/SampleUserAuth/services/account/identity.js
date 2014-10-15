app.factory('identity', function ($cookieStore) {
    var COOKIE_SOTRAGE_KEY = 'tic-tac-toe-user';
    var currentUser;

    function getLoggedUser() {
        var loggedUser = $cookieStore.get(COOKIE_SOTRAGE_KEY);
        if (loggedUser) {
            return loggedUser;
        }

        return currentUser;
    }

    function logUser(user) {
        if (user) {
            $cookieStore.put(COOKIE_SOTRAGE_KEY, user);
            currentUser = user;
        }
    }

    function logOutUser() {
        $cookieStore.remove(COOKIE_SOTRAGE_KEY);
        currentUser = undefined;
    }

    function isAuthenticated() {
        if (currentUser || $cookieStore.get(COOKIE_SOTRAGE_KEY)) {
            return true;
        }

        return false;
    }

    return {
        getLoggedUser: getLoggedUser,
        logUser: logUser,
        logOutUser: logOutUser,
        isAuthenticated: isAuthenticated
    }
});