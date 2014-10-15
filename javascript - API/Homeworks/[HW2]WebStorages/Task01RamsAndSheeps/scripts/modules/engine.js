define(['jquery', 'game', 'storage'], function (jQuery, game, storage) {
    var engine = (function () {
        $('#newGame').on('click', startGame);

        function startGame() {
            var score = 0,
                randomNumber = game.generateRandomNumber(),
                checkedNumber;

            $('#checkNumber').off('click').on('click', function () {
                score++;
                isGuessed = game.checkNumber(randomNumber, score);

                // return true if number is guessed and string if it is not. So because string is true like must use ===
                if (isGuessed === true) {
                    storage.saveScore(score);
                    startGame();
                } else {
                    $('#info').html(isGuessed);
                }
            });

            $('#highscores').off('click').on('click', function () {
                var $highscoresContainer = $('#hcTable'),
                    divContent = '';

                divContent = storage.getHighscores();

                $highscoresContainer.html(divContent);
                $highscoresContainer.toggle();
            });

            $('#clearHighscores').off('click').on('click', function () {
                localStorage.clear();
                $('#hcTable').html('');
            });
        }

        return {
            startGame: startGame
        }
    }());

    return engine;
})