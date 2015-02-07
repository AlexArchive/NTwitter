(function () {
    'use strict';

    angular
        .module('booksServices', ['ngResource'])
        .factory('Book', Book);

    Book.$inject = ['$resource'];

    function Book($resource) {
        return $resource('/api/books/:id');
    }
})();