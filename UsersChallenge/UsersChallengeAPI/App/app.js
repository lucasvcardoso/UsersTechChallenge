angular.module('UsersApp', ['ngRoute'])
    .config(['$locationProvider', '$routeProvider', function ($locationProvider, $routeProvider) {        

    $routeProvider.when('/ListAllUsers', { 
        templateUrl: 'UsersChallenge.API/App/Views/ListAllUsers.html',
        controller: 'UsersController'
    })
    .when('/AddUser', { 
        templateUrl: 'UsersChallenge.API/App/Views/AddUser.html',
        controller: 'UsersController'
    })
    .when('/EditUser/:userId', {
        templateUrl: 'UsersChallenge.API/App/Views/EditUser.html',
        controller: 'UsersController'
    })
    .otherwise({ 
        redirectTo: '/ListAllUsers'
    })
}]);