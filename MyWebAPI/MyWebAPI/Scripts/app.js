var app = angular.module("myWebAPI", [])

app.controller("myWebAPICtrl", function ($scope,$http) {
    $scope.name = "Hello World, Welcome to Web API Application";

    $scope.renderStudentModels = function (response) {
        $scope.StData = response;
    };

    $scope.StudentInfo = function () {
        $http.get("api/Students/")
            .success($scope.renderStudentModels);
    }

    $scope.StudentInfo();

    $scope.add = function (student) {
        $http.post("/api/Students/", student)
            .success(function (response) {
                $scope.StudentInfo();
            });

    };
    $scope.remove = function (StudentID) {
        $http.delete("/api/Students/" + StudentID)
            .success(function (response) {
                $scope.StudentInfo();
            });
    };

    $scope.select = function (StudentID) {
        $http.get("api/Students/" + StudentID)
            .success(function (response) {
                $scope.student = response;
            });
    };

    $scope.update = function (student) {
        $http.put("/api/Students/" + student.StudentID, student)
            .success(function (response) {
                $scope.StudentInfo();
            });
    };
});