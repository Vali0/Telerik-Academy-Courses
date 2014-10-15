define(['jquery'], function (jQuery) {
    var httpRequester = (function () {
        var makeHttpRequest = function (url, type, data, header) {
            var deferred = $.Deferred();

            $.ajax({
                url: url,
                type: type,
                contentType: 'application/json',
                headers: { 'x-sessionKey': header },
                data: data,
                success: function (resultData) {
                    deferred.resolve(resultData);
                },
                error: function (errorMsg) {
                    deferred.reject(errorMsg);
                }
            })

            return deferred.promise();
        }

        var getJSON = function (url) {
            return makeHttpRequest(url, 'GET');
        };
        var postJSON = function (url, data, header) {
            return makeHttpRequest(url, 'POST', data, header);
        };

        var putJSON = function (url, sessionKey) {
            var deferred = $.Deferred();

            $.ajax({
                url: url,
                type: 'PUT',
                contentType: 'application/data',
                headers: { 'x-sessionKey': sessionKey },
                success: function (resultData) {
                    deferred.resolve(resultData);
                },
                error: function (errorMsg) {
                    deferred.reject(errorMsg);
                }
            })

            return deferred.promise();
        }

        return {
            get: getJSON,
            post: postJSON,
            put: putJSON
        }
    }());

    return httpRequester;
})