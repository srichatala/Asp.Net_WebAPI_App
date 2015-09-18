var app = angular.module("myWebAPI", [])

app.controller("myWebAPICtrl", function ($scope,$http) {
    $scope.name = "Hello World, Welcome to Web API Application";
    $scope.addSt = true;
    $scope.updateSt = false;
    $scope.renderStudentModels = function (response) {
        console.log(response);
        $scope.StData = response;
    };

    $scope.StudentInfo = function () {
        $http.get("/api/Students/")
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
        $http.get("/api/Students/" + StudentID)
            .success(function (response) {
                $scope.addSt = false;
                $scope.updateSt = true;
                $scope.clearSt = true;
                $scope.student = response;
            });
    };

    $scope.update = function (student) {
        $http.put("/api/Students/" + student.StudentID, student)
            .success(function (response) {
                $scope.StudentInfo();
            });
    };
    $scope.clear = function () {
        $scope.addSt = true;
        $scope.updateSt = false;
        $scope.clearSt = false;
        $scope.student = null;
    };
});