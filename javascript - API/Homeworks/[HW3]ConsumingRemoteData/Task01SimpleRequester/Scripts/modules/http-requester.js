/// <reference path="../libs/jquery-2.1.1.js" />
define(['jquery'], function () {
    var httpRequester = (function () {
        var httpRequester = function (url, type, contentType, data) {
            var deferred = $.Deferred();

            $.ajax({
                url: url,
                type: type,
                contentType: contentType,
                data: JSON.stringify(data), // if type is 'GET' it skips that so it's not need to check it explicitly
                success: function (resultData) {
                    deferred.resolve(resultData);
                },
                error: function (errorMsg) {
                    deferred.reject(errorMsg);
                }
            })

            return deferred.promise();
        }

        var getJSON = function (url, contentType) {
            return httpRequester(url, 'GET', contentType);
        }

        var postJSON = function (url, contentType, data) {
            return httpRequester(url, 'POST', contentType, data);
        }

        return {
            get: getJSON,
            post: postJSON
        }
    }());

    return httpRequester;
})