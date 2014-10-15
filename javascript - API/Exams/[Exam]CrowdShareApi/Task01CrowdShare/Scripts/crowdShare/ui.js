define(['controller', 'mustache', 'underscore'], function (Controller, Mustache, _) {
    var ui = (function () {
        var localController = new Controller('http://localhost:3000/');

        function isValidUser(username, password) {
            if (!(typeof username == 'string')) { // password could be string or number so not need to check
                return false;
            }

            if (username.length < 6 || username.length > 40) {
                return false;
            }

            if (password.length < 3 || password.length > 20) {
                return false;
            }

            return true;
        }

        function setEvents() {
            $('#wrapper').on('click', '#login-init-button', function () {
                window.location.href = '#/login';
            });

            $('#wrapper').on('click', '#register-init-button', function () {
                window.location.href = '#/register';
            });

            $('#wrapper').on('click', '#login-button', function () {
                var username = $('#username').val(),
                    password = $('#password').val();

                if (isValidUser(username, password)) {
                    localController.loginUser({
                        username: username,
                        password: password
                    }).then(function (result) {
                        window.location.href = '#/posts';
                    }, function (error) {
                        alert('Wrong username and password');
                    })
                } else {
                    alert('Invalid username or password!');
                }
            });

            $('#wrapper').on('click', '#logout-button', function () {
                localController.logoutUser().then(function (result) {
                    window.location.href = '#/home';
                });
            })

            $('#wrapper').on('click', '#register-button', function () {
                var username = $('#username').val(),
                    password = $('#password').val();
                if (isValidUser(username, password)) {
                    localController.registerUser({
                        username: username,
                        password: password
                    }).then(function (result) {
                        window.location.href = '#/login';
                    }, function (error) {
                        alert('Username is taken!');
                    })
                } else {
                    alert('Invalid username or password!');
                }
            });

            $('#wrapper').on('click', '#sendmsg-button', function () {
                var topicBox = $('#topic-title'),
                    messageBox = $('#topic-body'),
                    title = topicBox.val(),
                    message = messageBox.val();

                if (title.length > 0 && message.length > 0) {
                    localController.createPost({
                        title: title,
                        body: message
                    }).then(function (result) {
                        topicBox.val('');
                        messageBox.val('');
                        showTopics();
                    })
                } else {
                    alert('Please enter title and message');
                }
            });

            $('#wrapper').on('click', '#filter-username-button', function () {
                var username = $('#filter-text').val();

                showTopics('?user=' + username);
            });

            $('#wrapper').on('click', '#filter-pattern-button', function () {
                var pattern = $('#filter-pattern').val();

                showTopics('?pattern=' + pattern);
            });

            $('#wrapper').on('click', '#filter-both-button', function () {
                var username = $('#filter-text').val(),
                    pattern = $('#filter-pattern').val();

                showTopics('?pattern=' + pattern + '&user=' + username);
            });
        }

        function showTopics(searchStr) {
            localController.getPosts(searchStr).then(function (result) {
                var template = $('#topics-template').html();
                var $container = $('<ul/>');
                var $topicsContainer = $('#topics-container');
                Mustache.parse(template);

                // UNDERSCORE USAGE!
                _.each(result, function (element) {
                    var renderer = Mustache.render(template, element);
                    $container.append(renderer);
                });

                $topicsContainer.html($container);
            });
        }

        function showView(loadIn, viewSource, loadChat) {
            $(loadIn).load(viewSource, function () {
                if (loadChat) {
                    showTopics();
                }
            });
        }

        return {
            setEvents: setEvents,
            show: showView,
            showTopics: showTopics
        }
    }());

    return ui;
})