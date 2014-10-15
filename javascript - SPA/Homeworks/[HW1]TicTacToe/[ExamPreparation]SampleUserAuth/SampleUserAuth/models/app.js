var app = angular.module('app', ['ngRoute', 'ngResource', 'ngCookies'])
    .config(function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'views/home.html',
                controller: 'gameController'
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
            .otherwise({
                redirectTo: '/'
            });
    });