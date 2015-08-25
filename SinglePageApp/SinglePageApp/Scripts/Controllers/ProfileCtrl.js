app.controller("ProfileCtrl", function ($scope, $http) {
    $scope.name = "Hello world, Welcome to Single Page Application";

    $scope.renderProfileInfo = function (response) {
        console.log(response);
        $scope.ProfileData = response;
    };

    $scope.ProfileInfo = function () {
        $http.get("api/Profiles")
        .success($scope.renderProfileInfo);
    }

    $scope.ProfileInfo();


    $scope.add = function (Profile) {
        $http.post("api/Profiles", Profile)
        .success(function (response) {
            $scope.ProfileInfo();
        });
    }
});