app.controller('signInController', function ($scope, $location, auth) {
    $scope.signin = function (user) {
        auth.signin(user)
            .then(function (data) {
                console.log("Successsfully login!");
                $location.path('/')
            }, function (error) {
                console.log("Cannot login!");
            });
    }
});