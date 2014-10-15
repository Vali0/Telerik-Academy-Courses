define([], function () {
    var game = (function () {
        function isValidNumber(number) {
            if (number[0] == 0) {
                return false;
            }

            if (!isFinite(number)) {
                return false;
            }

            if (!isInteger(number)) {
                return false;
            }

            if (number.length !== 4) {
                return false;
            }

            return true;
        }

        function isInteger(number) {
            if (number % 1 === 0) {
                return true;
            }

            return false;
        }

        function setCharAt(str, index, chr) {
            if (index > str.length - 1) {
                return str;
            }
            return str.substr(0, index) + chr + str.substr(index + 1);
        }

        function checkNumber(randomNumber, score) {
            var guesNumber = '',
                rams = 0,
                sheeps = 0,
                gameNumber = randomNumber;

            try {
                guesNumber = getUserNumber();
            } catch (err) {
                alert(err.message);
            }

            if (randomNumber === guesNumber) {
                return true;
            }

            for (var i = 0; i < 4; i++) {
                if (guesNumber[i] === gameNumber[i]) {
                    rams++;
                    gameNumber = setCharAt(gameNumber, i, '*');
                }
            }

            for (var i = 0; i < 4; i++) {
                for (var j = 0; j < 4; j++) {
                    if (guesNumber[i] === gameNumber[j]) {
                        sheeps++;
                        gameNumber = setCharAt(gameNumber, j, '*');
                        break;
                    }
                }
            }
            
            return sheeps + ' sheeps ' + rams + ' rams';
        }

        function generateRandomNumber() {
            var MIN = 1000,
                MAX = 9999,
                randomNumber = 0;

            randomNumber = Math.floor(Math.random() * (MAX - MIN + 1) + MIN);

            return randomNumber.toString();
        }

        function getUserNumber() {
            var number = document.getElementById('userInput').value;

            if (!isValidNumber(number)) {
                throw TypeError('Wrong number input!')
            }

            return number;
        }

        return {
            checkNumber: checkNumber,
            generateRandomNumber: generateRandomNumber,
            getUserNumber: getUserNumber
        }
    }());

    return game;
})