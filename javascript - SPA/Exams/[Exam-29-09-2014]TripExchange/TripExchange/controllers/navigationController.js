app.controller('navigationController', function ($scope, $route, auth, identity) {
    $scope.isLogged = identity.isAuthenticated;
    $scope.showUser = showUser

    $scope.isUserShown = false;
    $scope.showHideBtn = 'Show';

    function showUser() {
        var currentUser = identity.getLoggedUser();

        if (!$scope.isUserShown) {
            auth.info(currentUser)
                .then(function (data) {
                    $scope.userInfo = data
                    $scope.showHideBtn = 'Hide';
                    $scope.isUserShown = true;
                });
        } else {
            $scope.showHideBtn = 'Show';
            $scope.isUserShown = false;
        }
    }
});