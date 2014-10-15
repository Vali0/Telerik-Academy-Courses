define(['controller'], function (Controller) {
    var ui = (function () {
        var localController = new Controller('http://crowd-chat.herokuapp.com/posts'),
            STORAGE_NAME = 'chatUser';

        function setEvents() {
            $('#wrapper').on('click', '#login-button', function () {
                var userName = $('#login-name').val();
                userName = userName || '';
                if (userName.length > 3) {
                    localStorage.setItem(STORAGE_NAME, userName);
                    window.location.href = '#/chat';
                } else {
                    alert('Enter username with more than 3 symbols');
                }
            });

            // $('#wrapper').on('click', '#send-msg', function () {
                var userName = localStorage.getItem(STORAGE_NAME),
                    msg = $('#user-msg').val(),
                    userObj = {};

                userObj = {
                    user: userName,
                    text: msg
                }

                //$('#user-msg').val(''); // I actually prefer to do it after response like line bellow
                localController.sendMsg(userObj)
                    .then(function (result) {
                        $('#user-msg').val('');
                    }, function (error) {
                        console.log(error);
                    });
            });

            $('#wrapper').on('click', '#logout-button', function () {
                localStorage[STORAGE_NAME] = '';
                window.location.href = '#/login';
            });
        }

        function showView(loadIn, url) {
            localController.loadView(loadIn, url);
        }

        function showChatContent() {
            localController.getMsg()
                .then(function (result) {
                    var len = result.length,
                        $ul = $('<ul />').attr('id', 'chat-messages');

                    $('#chat-box').html('');

                    for (var i = 1; i <= len; i++) { // if there is no spammer would be work...
                        var currentUser = result[len - i];
                        var $li = $('<li />');

                        $li.html(currentUser['text'] + '&nbsp;|&nbsp;by:&nbsp;' + currentUser['by']);
                        $ul.append($li);
                    }

                    $('#chat-box').append($ul);
                }, function (error) {
                    console.log(error);
                })
        }

        return {
            setEvents: setEvents,
            show: showView,
            showChatContent: showChatContent
        }
    }());

    return ui;
})