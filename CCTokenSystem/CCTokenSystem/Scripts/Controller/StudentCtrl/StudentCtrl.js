var app = angular.module("myWebAPI", [])
app.controller("StudentCtrl", function ($scope, $http) {

    //Get all stundet details
    $scope.renderStudentModels = function (response) {
        $scope.addSt = true;
        $scope.updateSt = false;
        $scope.StData = response;
    };

    $scope.StudentInfo = function () {
        $http.get("/api/Students/")
            .success($scope.renderStudentModels);
    }

    $scope.StudentInfo();


    //Add student record into database
    $scope.Create = function (student) {
        console.log(student);
        $http.post("/api/students", student)
            .success(function (response) {
                $scope.StudentInfo();
            })
    };

    $scope.Remove = function (StudentID) {
        $http.delete("/api/Students/" + StudentID)
            .success(function (response) {
                $scope.StudentInfo();
            });
    };

    $scope.Select = function (StudentID) {
        $http.get("/api/Students/" + StudentID)
            .success(function (response) {
                $scope.addSt = false;
                $scope.updateSt = true;
                $scope.clearSt = true;
                $scope.student = response;
            });
    };

    $scope.Update = function (student) {
        $http.put("/api/Students/" + student.Id, student)
            .success(function (response) {
                $scope.addSt = false;
                $scope.updateSt = true;
                $scope.StudentInfo();
            });
    };

    $scope.Clear = function () {
        $scope.addSt = true;
        $scope.updateSt = false;
        $scope.clearSt = false;
        $scope.student = null;
    };
})

