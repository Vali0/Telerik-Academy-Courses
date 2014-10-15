define(['controller'], function (Controller) {
    var uiController = (function () {
        var localController = new Controller('http://localhost:3000/');

        function showStudents() {
            localController.getStudents()
                .then(function (result) {
                    var $ul = $('<ul/>');
                    for (var i = 0, len = result['count']; i < len; i++) {
                        var student = result['students'][i];
                        var $li = $('<li/>');

                        for (var item in student) {
                            $li.append(item + ': ' + student[item] + ' ');
                        }

                        $ul.append($li);
                    }

                    $('#students-container').html($ul);
                }, function (error) {
                    console.log(error);
                })
        }

        function addStudent() {
            var $studentNameBox = $('#student-name'),
                $studentGradeBox = $('#student-grade'),
                name = $studentNameBox.val(),
                grade = $studentGradeBox.val();

            localController.addStudent({
                name: name,
                grade: grade
            }); //TODO: then for info that if student is added or not

            $studentNameBox.val('');
            $studentGradeBox.val('');
        }

        function removeStudent() {
            var $studentIdBox = $('#student-id');
            var studentId = $studentIdBox.val();

            localController.removeStudent(studentId); // TODO: then...
            $studentIdBox.val('');
        }

        return {
            show: showStudents,
            add: addStudent,
            remove: removeStudent
        }
    }());

    return uiController;
})