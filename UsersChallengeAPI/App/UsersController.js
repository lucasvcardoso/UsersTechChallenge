var myApp = angular.module('UsersApp');

    myApp.controller("UsersController", ['$scope', '$http', '$location', '$routeParams', function ($scope, $http, $location, $routeParams) {
    $scope.ListOfUsers;
    $scope.Status;

        $scope.Close = function () {
            $location.path('/ListAllUsers')
        };

    //Get all users and binds them with an HTML table
    $http.get("Users")
        .then(function (data) {
            $scope.ListOfUsers = data;
        }, function (data) {
            $scope.Status = "Data not found";
        });

   //Add new user
        $scope.Add = function () {
            var userData = {
                UserId: $scope.UserId,
                Name: $scope.Name,
                Age: $scope.Age,
                Address: $scope.Address
            };
            $http.post("Users", userData)
                .then(function (data) {
                    $location.path('/ListAllUsers')
                }, function (data) {
                    $scope.error = "Error adding new user: " + data.ExceptionMessage;
                });
        };
        //Fill the user record for update
    if ($routeParams.userId) {
        $scope.UserId = $routeParams.userId

        $http.get('Users/' + $scope.UserId)
            .then(function (data) {
                $scope.UserId
                $scope.Name = data.data.Name;
                $scope.Age = data.data.Age;
                $scope.Address = data.data.Address;
            });
    }
    

    //Update the user record
        $scope.Update = function () {
            var userData = {
                UserId: $scope.UserId,
                Name: $scope.Name,
                Age: $scope.Age,
                Address: $scope.Address
            };
            if ($scope.UserId > 0) {

                $http.put("Users", userData)
                    .then(function (data) {
                        $location.path('/ListAllUsers');
                    }, function (data) {
                        console.log(data);
                        $scope.error = "Error updating user: " + data.ExceptionMessage;
                    });
            }
        };
}]);