var app = angular.module("myWebAPI", [])

app.controller("myWebAPICtrl", function ($scope,$http) {
    $scope.name = "Hello World, Welcome to Web API Application";

    $http.get("/api/Students")
       .success(function (response) {
           $scope.data = response;
       });
    $scope.add = function (student) {
        console.log(student);
        $http.post("/api/Students/", student)
            .success(function (response) {
                $scope.data = response;
            });

    }
});