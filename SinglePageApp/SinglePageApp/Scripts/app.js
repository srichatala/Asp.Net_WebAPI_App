var app = angular.module("mySPA", ["ngRoute"]);

app.config(['$routeProvider', function ($routeProvider, $httpprovider) {
    $routeProvider.
        when('/Home', {
            templateUrl: 'Profile/Index.html',
            controller: 'Homectrl'
        }).
        when('/Profile', {
            templateUrl: 'Profile/Profile.html',
            controller: 'ProfileCtrl'
        }).
        when('/Article', {
            templateUrl: 'Profile/Article.html'
        }).
        otherwise({
            redirectTo:'/'
        });
}]);