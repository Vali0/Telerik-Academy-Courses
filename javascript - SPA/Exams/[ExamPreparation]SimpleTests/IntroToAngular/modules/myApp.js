/// <reference path="../libs/angular.js" />

var myApp = angular.module('myApp', ['ngRoute'])
    .config(function ($routeProvider) {
        $routeProvider.when('/home', {
            templateUrl: 'views/home.html'
        });

        $routeProvider.when('/news', {
            templateUrl: 'views/news.html'
        });

        $routeProvider.when('/about', {
            templateUrl: 'views/about.html',
            controller: 'randomNumberController'
        });

        $routeProvider.otherwise({
            redirectTo:'/home'
        });
    });