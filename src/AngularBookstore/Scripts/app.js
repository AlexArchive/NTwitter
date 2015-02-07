(function () {
    'use strict';

    config.$inject = ['$routeProvider', '$locationProvider'];

    angular.module('app', [
        'ngRoute',
        'booksServices'
    ]).config(config);

    function config($routeProvider, $locationProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '/Views/list.html',
                controller: 'BooksListController'
            })
            .when('/books/add', {
                templateUrl: '/Views/add.html',
                controller: 'BooksAddController'
            })
            .when('/books/edit/:id', {
                templateUrl: '/Views/edit.html',
                controller: 'BooksEditController'
            })
            .when('/books/delete/:id', {
                templateUrl: '/Views/delete.html',
                controller: 'BooksDeleteController'
            });

        $locationProvider.html5Mode(true);
    }
})();