var app = angular.module("mySPA", [])
app.controller("mySPACtrl", function ($scope,$http) {
    $scope.name = "Hello world, Welcome to Single Page Application";

    $scope.renderProfileInfo = function (response) {
        console.log(response);
        $scope.ProfileData = response;
    };
     
    $scope.ProfileInfo = function () {
        $http.get("api/Profiles")
        .sucess($scope.renderProfileInfo);
    }

    $scope.ProfileInfo();


    $scope.add = function (Profile) {
        $http.post("api/Profiles",Profile)
        .sucess(function (response) {
            $scope.ProfileInfo();
        });
    }
});