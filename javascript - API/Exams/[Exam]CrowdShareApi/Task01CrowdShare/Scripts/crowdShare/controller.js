define(['requester', 'crypto'], function (httpRequester, crypto) {
    var Controller = (function () {
        function Controller(url) {
            this.sourceUrl = url;
        }

        Controller.prototype.registerUser = function (data) {
            var username = data.username,
                password = data.password,
                authCode = username + password,
                hash;

            hash = CryptoJS.SHA1(authCode).toString();

            return httpRequester.post(this.sourceUrl + 'user/', JSON.stringify({
                username: username,
                authCode: hash
            }));
        }

        Controller.prototype.loginUser = function (data) {
            var username = data.username,
                password = data.password,
                authCode = username + password,
                hash;

            hash = CryptoJS.SHA1(authCode).toString();
            return httpRequester.post(this.sourceUrl + 'auth/', JSON.stringify({
                username: username,
                authCode: hash
            })).then(function (result) {
                localStorage.setItem('sessionKey', result.sessionKey);
            });
        }

        Controller.prototype.logoutUser = function () {
            var sessionKey = localStorage['sessionKey'];
            return httpRequester.put(this.sourceUrl + 'user/', sessionKey)
                .then(function (result) {
                    localStorage['sessionKey'] = '';
                });
        }

        Controller.prototype.createPost = function (data) {
            var sessionKey = localStorage['sessionKey'];

            return httpRequester.post(this.sourceUrl + 'post/', JSON.stringify(data), sessionKey);
        }

        Controller.prototype.getPosts = function (searchStr) {
            searchStr = searchStr || '';
            return httpRequester.get(this.sourceUrl + 'post/' + searchStr);
        }

        return Controller;
    }());

    return Controller;
})