define(function () {
    var Course = (function () {

        function sortStudentsBy(sortBy, count) {
            var sortedStudents = this;
            sortedStudents.sort(function (first, second) {
                return second[sortBy] - first[sortBy];
            });

            return sortedStudents.slice(0, count);
        }

        function Course(name, formula) {
            this._name = name;
            this._formula = formula;
            this._students = [];
        }

        Course.prototype.addStudent = function (student) {
            this._students.push(student);
        }

        Course.prototype.calculateResults = function () {
            for (var i = 0, len = this._students.length; i < len; i++) {
                this._students[i].totalScore = this._formula(this._students[i]);
            }
        }

        Course.prototype.getTopStudentsByExam = function (count) {
            return sortStudentsBy.call(this._students, 'exam', count);
        }

        Course.prototype.getTopStudentsByTotalScore = function (count) {
            return sortStudentsBy.call(this._students, 'totalScore', count);
        }

        return Course;
    }());

    return Course;
});