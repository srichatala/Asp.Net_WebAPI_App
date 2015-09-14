var app = angular.module("mySPA", ["ngRoute"]);

app.config(['$routeProvider', function ($routeProvider, $httpprovider) {
    $routeProvider.
        when('/Home', {
            templateUrl: 'Views/Home.html'
        }).
        when('/Profile', {
            templateUrl: 'Views/Profile.html',
            controller: 'ProfileCtrl'
        }).
        when('/Article', {
            templateUrl: 'Views/Article.html'
        }).
        otherwise({
            redirectTo:'/'
        });
}]);