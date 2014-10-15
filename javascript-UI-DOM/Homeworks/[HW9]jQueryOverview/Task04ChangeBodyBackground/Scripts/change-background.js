/// <reference path="/Scripts/jquery-2.1.1.min.js" />

$('#color-picker').on('change', function () {
    $('body').css('background', $(this).val());
});