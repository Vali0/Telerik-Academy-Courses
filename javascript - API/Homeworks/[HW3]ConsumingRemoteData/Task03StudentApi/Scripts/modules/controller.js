define(['requester'], function (httpRequester) {
    var Controller = (function () {
        function Controller(url) {
            this.resourceUrl = url + 'students/';
        }

        Controller.prototype.getStudents = function () {
            return httpRequester.get(this.resourceUrl);
        }
        
        Controller.prototype.addStudent = function (data) {
            return httpRequester.post(this.resourceUrl, data);
        }

        Controller.prototype.removeStudent = function (studentId) {
            return httpRequester.post(this.resourceUrl + studentId, {
                _method: 'delete'
            })
        }

        return Controller;
    }());

    return Controller;
})