/// <reference path="libs/require.js" />

(function () {
    require.config({
                       paths: {
            'jquery': 'libs/jquery-2.1.1.min',
            'engine': 'modules/engine',
            'game': 'modules/game',
            'storage': 'modules/storage'
        }
                   });

    require(['engine'], function (engine) {
        engine.startGame();
    });
}())