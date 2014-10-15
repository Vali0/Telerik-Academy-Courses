document.onload = (function () {
    require.config({
        paths: {
            'jquery': 'libs/jquery-2.1.1.min',
            'requester': 'modules/http-requester'
        }
    })

    require(['requester'], function (httpRequester) {
        var DATA_SOURCE = 'Scripts/data.js',
            CONTENT_TYPE = 'application/json';

        httpRequester.get(DATA_SOURCE, CONTENT_TYPE) // Can't perform post because browser can't save data to filesystem
            .then(function (result) {
                renderStudents(JSON.parse(result));
            }, function (error) {
                alert('error to get data')
            });

        function renderStudents(data) {
            var list = $("<ul />");

            list.append('<li><strong>Students</strong></li>')

            for (var i = 0, len = data.length; i < len; i++) {
                list.append('<li>' + data[i].fname + ' ' + data[i].lname + ':' + ' ' + data[i].marks + '</li>');
            }

            $('#students-container').html(list);
        }
    })
}())