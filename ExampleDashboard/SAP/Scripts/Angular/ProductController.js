var App = angular.module('App', ['ngRoute']);

// configure our routes
App.config(function ($routeProvider) {
    $routeProvider

        // route for the home page
        .when('/', {
            templateUrl: 'Pages/auto.html',
            controller: 'autoController'
        })
});

// create the controller and inject Angular's $scope
App.controller('autoController', function ($scope, $http) {
    // create a message to display in our view
    $http({
        method: 'GET',
        url: 'http://localhost:50269/api/Auto'
    })
        .then(function (data) {

            $scope.autos = data;
        });

});


