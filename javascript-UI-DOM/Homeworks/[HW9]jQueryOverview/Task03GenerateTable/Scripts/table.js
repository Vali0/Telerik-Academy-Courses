/// <reference path="/Scripts/jquery-2.1.1.min.js" />

var students = [{
        firstName: 'Peter',
        lastName: 'Ivanov',
        grade: 3
    }, {
        firstName: 'Milena',
        lastName: 'Grigorova',
        grade: 6
    }, {
        firstName: 'Gergana',
        lastName: 'Borisova',
        grade: 12
    }, {
        firstName: 'Boyko',
        lastName: 'Petrov',
        grade: 7
    }
];

(function () {
    var $table = $('<table>')
        .appendTo('body');
    var $thead = $('<thead>').appendTo($table);
    var $tr = $('<tr>')
        .appendTo($thead);
    $tr.append($('<th>').text('First name'));
    $tr.append($('<th>').text('Last name'));
    $tr.append($('<th>').text('Grade'));
    var $tbody = $('<tbody>').appendTo($table);

    for (var i = 0; i < students.length; i++) {
        var $currRow = $('<tr>');
        $currRow.append($('<td>').text(students[i].firstName));
        $currRow.append($('<td>').text(students[i].lastName));
        $currRow.append($('<td>').text(students[i].grade));
        $currRow.appendTo($tbody);
    }
}());