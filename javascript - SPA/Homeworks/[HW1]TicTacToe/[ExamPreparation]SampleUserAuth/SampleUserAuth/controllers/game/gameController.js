app.controller('gameController', function ($scope, identity, game) {
    $scope.createGame = createGame;
    $scope.joinGame = joinGame;
    $scope.play = play;

    function createGame() {
        var currentUser = identity.getLoggedUser();

        game.create(currentUser)
            .then(function (data) {
                console.log("Successsfully created game!");
            }, function (error) {
                console.log("Cannot create game!");
            });
    }

    function joinGame() {
        var currentUser = identity.getLoggedUser();

        game.join(currentUser)
            .then(function (data) {
                console.log("Successsfully joined at game!");
            }, function (error) {
                console.log("Cannot join game!");
            });
    }

    function play(id, row, col) {
        var currentUser = identity.getLoggedUser();
        var inputData = {
            GameId: id,
            Row: row,
            Col: col,
        };

        game.play(inputData, currentUser)
            .then(function (data) {
                console.log("Successsfully played move!");
            }, function (error) {
                console.log("Cannot make that move!");
            });
    }
});