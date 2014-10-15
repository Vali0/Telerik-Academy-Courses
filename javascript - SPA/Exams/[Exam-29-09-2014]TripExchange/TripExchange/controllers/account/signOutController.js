app.controller('signOutController', function ($scope, $location, auth, identity) {
    var currentUser = identity.getLoggedUser();

    auth.signout(currentUser)
        .then(function (data) {
            console.log('Successfully logout!');
            $location.path('/');
        }, function (error) {
            console.log('You are already logout!');
        });
});