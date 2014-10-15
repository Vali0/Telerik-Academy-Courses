/// <reference path="/Scripts/jquery-2.1.1.min.js" />

var $divider = $('hr');

$('#beforeBtn').on('click', function () {
    var value = '<strong>' + $('#input').val() + '</strong>';
    $divider.before(value);
});

$('#afterBtn').on('click', function () {
    var value = '<strong>' + $('#input').val() + '</strong>';
    $divider.after(value);
});