var app = angular.module("myWebAPI", [])

app.controller("myWebAPICtrl", function ($scope,$http) {
    $scope.name = "Hello World, Welcome to Web API Application";

    $scope.StudentInfo = function () {
        $http.get("api/Students")
        .success(function (response) {
            $scope.StData = response;
        });
    };
    
    $scope.add = function (student) {
        $http.post("/api/Students/", student)
            .success(function (response) {
                $scope.StData = response;
            });

    };
    $scope.remove = function (StudentID) {
        $http.delete("/api/Students/" + StudentID)
            .success(function (response) {
                $scope.StData = response;
            });
    };
    $scope.StudentInfo();
});