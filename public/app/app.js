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
        .when('/main', {templateUrl: '/partials/main/main', controller: 'etMainCtrl'})
        .when('/contacts', {templateUrl: '/partials/contacts/contacts', controller: 'etContactsCtrl'})
        .when('/for-companies', {templateUrl: '/partials/for-companies/for-companies', controller: 'etForCompaniesCtrl'})
        .when('/how-to-pay', {templateUrl: '/partials/how-to-pay/how-to-pay', controller: 'etHowToPayCtrl'})
        .when('/auto-classes', {templateUrl: '/partials/auto-classes/auto-classes', controller: 'etAutoClassesCtrl'})
        .when('/advantages', {templateUrl: '/partials/advantages/advantages', controller: 'etAdvantagesCtrl'})
        .when('/services', {templateUrl: '/partials/services/services', controller: 'etServicesCtrl'})
});