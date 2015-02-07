(function () {
    'use strict';

    var bookService = angular.module('booksServices', ['ngResource']);

    bookService.factory('Books', ['$resource',
    function bookService($resource) {
        return $resource('api/books/', {}, {
            query: { method: 'GET', params: {}, isArray: true }
        });
    }]);

})();