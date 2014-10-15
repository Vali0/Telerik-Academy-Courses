require.config({
    paths: {
        'jquery': 'libs/jquery-2.1.1.min',
        'requester': 'modules/http-requester',
        'controller': 'modules/controller',
        'ui': 'modules/ui',
    }
});

require(['ui'], function (uiController) {
    setInterval(function () {
        uiController.show();
    }, 1000);

    $('#add-student').on('click', function () {
        uiController.add();
    });

    $('#remove-student').on('click', function () {
        uiController.remove();
    });
});