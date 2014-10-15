/// <reference path="/libraries/jquery-2.1.1.min.js" />

(function ($) {
    $.fn.messageBox = function () {
        var $this = $(this);

        function successMessage(msg) {
            $this.text(msg)
                .css('background-color', 'green')
                .animate({ 'opacity': 1 }, 1000);
            setTimeout(function () {
                $this.animate({ 'opacity': 0 }, 1000)
            }, 3000);
        }

        function errorMessage(msg) {
            $this.text(msg)
                .css('background-color', 'red')
                .animate({ 'opacity': 1 }, 1000);
            setTimeout(function () {
                $this.animate({ 'opacity': 0 }, 1000)
            }, 3000);
        }

        return {
            success: successMessage,
            error: errorMessage
        }
    }
}(jQuery));

var msgBox = $('#message-box').messageBox();

function onButtonClickSuccessMessage() {
    msgBox.success('Success message!');
}
function onButtonClickErrorMessage() {
    msgBox.error('Error message!');
}