app.controller('phoneBookController', function ($scope) {
    var friends = [
        { name: 'John', phone: '555-1276' },
        { name: 'Mary', phone: '800-BIG-MARY' },
        { name: 'Mike', phone: '555-4321' },
        { name: 'Adam', phone: '555-5678' },
        { name: 'Julie', phone: '555-8765' },
        { name: 'Juliette', phone: '555-5678' }
    ];

    $scope.friends = friends;
});