var app = angular.module('app', ['ngRoute', 'ngResource', 'ngCookies', 'ngRoute'])
    .config(function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'views/home.html',
                controller: 'homeController'
            })
            .when('/signin', {
                templateUrl: 'views/login.html',
                controller: 'signInController'
            })
            .when('/signup', {
                templateUrl: 'views/register.html',
                controller: 'signUpController'
            })
            .when('/signout', {
                templateUrl: 'views/home.html',
                controller: 'signOutController'
            })
            .when('/trips', {
                templateUrl: 'views/trips.html',
                controller: 'tripsController'
            })
            .when('/createTrip',
            {
                templateUrl: 'views/createTrip.html',
                controller: 'createTripController'
            })
            .when('/drivers', {
                templateUrl: 'views/drivers.html',
                controller: 'driversController'
            })
            .when('/driver/:id', {
                templateUrl: 'views/additionalInfo.html',
                controller: 'driverInformationController'
            })
            .otherwise({
                redirectTo: '/'
            });
    });