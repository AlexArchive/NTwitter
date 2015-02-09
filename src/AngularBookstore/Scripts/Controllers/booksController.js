(function () {
    'use strict';

    angular
        .module('app')
        .controller('BooksListController', BooksListController)
        .controller('BooksAddController', BooksAddController)
        .controller('BooksEditController', BooksEditController)
        .controller('BooksDeleteController', BooksDeleteController);

    BooksListController.$inject = ['$scope', 'Book','canEdit'];

    function BooksListController($scope, Book, canEdit) {
        $scope.canEdit = canEdit;
        $scope.books = Book.query();
    }

    BooksAddController.$inject = ['$scope', '$location', 'Book'];

    function BooksAddController($scope, $location, Book) {
        $scope.book = new Book();
        $scope.add = function () {
            $scope.book.$save(
                // success
                function () {
                    $location.path('/');
                },
                // error
                function (error) {
                    $scope.error = 'Could not add book';
                });
        };
    }
    BooksEditController.$inject = ['$scope', '$routeParams', '$location', 'Book'];

    function BooksEditController($scope, $routeParams, $location, Book) {
        $scope.book = Book.get({ id: $routeParams.id });
        $scope.edit = function () {
            $scope.book.$save(
                // success
                function () {
                    $location.path('/');
                },
                // error
                function (error) {
                    $scope.error = 'Could not add book';
                });
        };
    }

    BooksDeleteController.$inject = ['$scope', '$routeParams', '$location', 'Book'];

    function BooksDeleteController($scope, $routeParams, $location, Book) {
        $scope.book = Book.get({ id: $routeParams.id });
        $scope.remove = function () {
            $scope.book.$remove({ id: $scope.book.Id }, function () {
                $location.path('/');
            });
        };
    }
})();