angular.module('UsersApp', ['ngRoute'])
    .config(['$locationProvider', '$routeProvider', function ($locationProvider, $routeProvider) {        

    $routeProvider.when('/ListAllUsers', { 
        templateUrl: 'App/Views/ListAllUsers.html',
        controller: 'UsersController'
    })
    .when('/AddUser', { 
        templateUrl: 'App/Views/AddUser.html',
        controller: 'UsersController'
    })
    .when('/EditUser/:userId', {
        templateUrl: 'App/Views/EditUser.html',
        controller: 'UsersController'
    })
    .otherwise({ 
        redirectTo: '/ListAllUsers'
    })
}]);