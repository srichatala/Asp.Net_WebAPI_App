var app = angular.module("myWebAPI", [])
app.controller("StudentCtrl", function ($scope, $http) {

    //Get all stundet details
    $scope.renderStudentModels = function (response) {
        console.log(response);
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
})

