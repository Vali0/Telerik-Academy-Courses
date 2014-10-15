app.controller('homeController', function ($scope, identity) {
    $scope.isLogged = identity.isAuthenticated;
});