app.controller('signOutController', function ($scope, $location , auth) {
    auth.signout()
        .then(function (data) {
            console.log('Successfully logout!');
            $location.path('/');
        }, function (error) {
            console.log('You are already logout!');
        });
});