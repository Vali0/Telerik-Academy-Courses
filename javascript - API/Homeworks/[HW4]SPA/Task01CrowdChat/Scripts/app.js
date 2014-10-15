document.onload = (function () {
    require.config({
        paths: {
            'jquery': 'libs/jquery-2.1.1',
            'sammy': 'libs/sammy-0.7.4.min',
            'requester': 'chat/http-requester',
            'controller': 'chat/controller',
            'ui': 'chat/ui'
        }
    });

    require(['jquery' ,'ui', 'sammy'], function ($, ui, Sammy) {
        var app = Sammy('#wrapper', function () {
            ui.setEvents();
            var interval;

            this.get('#/login', function () {
                ui.show('#wrapper', 'views/login.html');
                clearInterval(interval);
            });

            this.get('#/chat', function () {
                ui.show('#wrapper', 'views/chat.html');
                interval = setInterval(ui.showChatContent, 500);
            });
        });

        app.run('#/login');
    });
}())