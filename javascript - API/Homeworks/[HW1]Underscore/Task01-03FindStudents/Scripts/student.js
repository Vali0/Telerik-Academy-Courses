/// <reference path="libs/underscore-min.js" />
(function () {
    var Student,
        students = [],
        filteredStudents = [],
        sortedStudents = [];

    Student = (function () {
        function Student(firstName, lastName, age, grade) {
            this.firstName = firstName,
            this.lastName = lastName,
            this.age = age,
            this.grade = grade
        }

        Student.prototype.toString = function () {
            return this.firstName + ' ' + this.lastName + ' Age: ' + this.age + ' Grade: ' + this.grade;
        }

        return Student;
    }());
    
    students = [
        new Student('Anna', 'Stoeva', 55, 5),
        new Student('Ivan', 'Petrov', 20, 2),
        new Student('Pesho', 'Geshov', 17, Number.POSITIVE_INFINITY),
        new Student('Zdravko', 'Ahilesov', 21, 99999)
    ];

    // Task 1
    filteredStudents = findStudentsWhichFirstNameIsBeforeLast(students);
    sortedStudents = sortStudentsByFullName(filteredStudents);
    console.log('Sorted students: '+ sortedStudents.toString());

    function findStudentsWhichFirstNameIsBeforeLast(students) {
        var result = _.filter(students, function (stud) {
            return stud.firstName < stud.lastName;
        });

        return result;
    }

    function sortStudentsByFullName(students) {
        var result = _.sortBy(students, function (stud) {
            return stud.toString();
        });

        return result.reverse();
    }

    // Task 2
    filteredStudents = findStudentsByAge(students, 18, 24);
    console.log('Students in given age: ' + filteredStudents.toString());

    function findStudentsByAge(students, minAge, maxAge) {
        minAge = minAge || 1; // Rich people sign in their childrens in universities when they've born.
        maxAge = maxAge || 200; 

        var result = _.filter(students, function(stud) {
            return stud.age > minAge && stud.age < maxAge;
        });

        return result;
    }

    // Task 3
    var bestStudent = findStudentWithMaxGrade(students);
    console.log('Student with highest grade: ' + bestStudent.toString());

    function findStudentWithMaxGrade(students) {
        var result = _.max(students, function (stud) {
            return stud.grade;
        });

        return result;
    }
}());