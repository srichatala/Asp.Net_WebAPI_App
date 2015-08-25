var app = angular.module("mySPA", ["ngRoute"]);

app.config(['$routeProvider', function ($routeProvider, $httpprovider) {
    $routeProvider.
        when('/Home', {
            templateUrl: 'View/Home.html'
        }).
        when('/Profile', {
            templateUrl: 'View/Profile.html',
            controller: 'ProfileCtrl'
        }).
        when('/Article', {
            templateUrl: 'View/Article.html'
        }).
        otherwise({
            redirectTo:'/'
        });
}]);