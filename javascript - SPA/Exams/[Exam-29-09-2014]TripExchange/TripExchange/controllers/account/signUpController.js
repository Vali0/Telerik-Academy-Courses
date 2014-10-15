app.controller('signUpController', function ($scope, $location, auth) {
    $scope.signup = function (user) {
        auth.signup(user)
            .then(function (resolve) {
                console.log('Successfully registered!');
                $location.path('/');
            }, function (reject) {
                console.log('Cannot register!');
            });
    }
});