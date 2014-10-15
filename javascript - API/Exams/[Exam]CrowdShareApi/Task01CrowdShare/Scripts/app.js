(function () {
    require.config({
        paths: {
            'jquery': 'libs/jquery-2.1.1.min',
            'underscore': 'libs/underscore-min',
            'mustache': 'libs/mustache',
            'crypto': 'libs/crypto-js-sha1',
            'sammy': 'libs/sammy-0.7.4.min',
            'requester': 'crowdShare/http-requester',
            'controller': 'crowdShare/controller',
            'ui': 'crowdShare/ui'
        }
    });

    require(['jquery', 'sammy', 'ui'], function ($, Sammy, uiController) {
        var app = Sammy('#wrapper', function () {
            uiController.setEvents();

            this.get('#/home', function () {
                uiController.show('#wrapper', 'views/home.html');
            });

            this.get('#/login', function () {
                uiController.show('#wrapper', 'views/login.html');
            });

            this.get('#/register', function () {
                uiController.show('#wrapper', 'views/register.html');
            });

            this.get('#/posts', function () {
                uiController.show('#wrapper', 'views/posts.html', true);
            });
        });

        app.run('#/home');
    });
}())