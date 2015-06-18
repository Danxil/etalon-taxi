angular.module('app', [
    'ngResource',
    'ngRoute',
    'ngAnimate',
    'ngSanitize',
    'uiGmapgoogle-maps',
    'angular-jquery-maskedinput',
    'ui.bootstrap'
]);

angular.module('app').config(function ($routeProvider, $locationProvider) {
    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });

    $routeProvider
        .when('/', {templateUrl: '/partials/main/main', controller: 'etMainCtrl'})
        .when('/:page', {templateUrl: '/partials/main/main', controller: 'etMainCtrl'})
});