﻿(function () {
    'use strict';

    angular
        .module('app')
        .controller('booksController', booksController);

    booksController.$inject = ['$scope', 'Books']; 

    function booksController($scope, Books) {
        $scope.books = Books.query();
    }
})();
