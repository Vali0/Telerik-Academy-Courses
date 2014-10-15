define([], function () {
    var storage = (function () {
        function getData() {
            var data = {};

            for (var item in localStorage) {
                data[item] = localStorage[item];
            }

            return data;
        }

        function convertToString(dataItems) {
            var dataStr = '';

            for (var i = 0; i < dataItems.length; i++) {
                dataStr += dataItems[i][0] + ' - ' + dataItems[i][1] + '<br />';
            }

            return dataStr;
        }

        function sortHighscores(data) {
            var tuples = [];

            for (var item in data) {
                tuples.push([item, data[item]]);
            }

            tuples.sort(function (a, b) {
                return a[1] - b[1];
            });

            return tuples;
        }
        
        var scoresTable = []; // Creating an closure
        function saveScore(score) {
            var username = prompt('Your score is: ' + score + ' Please enter your name: ');
            username = username || 'unnamed';

            scoresTable.push({
                                 name: username,
                                 score: score
                             });

            localStorage['RamsAndSheeps'] = JSON.stringify(scoresTable);
        }

        function getHighscores() {
            var data = {},
                divContent = '';

            data = JSON.parse(localStorage['RamsAndSheeps']);
            
            for (var i = 0, len = data.length; i < len; i++) {
                divContent += data[i].name + ' - ' + data[i].score + '<br />';
            }

            return divContent;
        }

        return {
            saveScore: saveScore,
            getHighscores: getHighscores
        }
    }())

    return storage;
})