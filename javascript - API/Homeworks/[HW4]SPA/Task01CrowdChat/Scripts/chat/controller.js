define(['requester'], function (httpRequester) {
    var Controller = (function () {
        function Controller(url) {
            this.sourceUrl = url;
        }

        Controller.prototype.getMsg = function () {
            return httpRequester.get(this.sourceUrl);
        }

        Controller.prototype.sendMsg = function (data) {
            return httpRequester.post(this.sourceUrl, data);
        }

        Controller.prototype.loadView = function (loadIn, url) {
            $(loadIn).load(url);
        }

        return Controller;
    }());

    return Controller
})