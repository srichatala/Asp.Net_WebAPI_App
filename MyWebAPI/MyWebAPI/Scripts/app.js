var app = angular.module("myWebAPI", [])

app.controller("myWebAPICtrl", function ($scope,$http) {
    $scope.name = "Hello World, Welcome to Web API Application";

    $scope.renderStudentInfo = function (response) {
        $scope.data = response;
    };
    $scope.StudentInfo = function () {
        $http.get("/api/Students")
        .success($scope.renderStudentInfo);
    }
    $scope.StudentInfo();
    $scope.add = function (student) {
        console.log(student);
        $http.post("/api/Students/", student)
            .success(function (response) {
                $scope.data = response;
            });

    }
});