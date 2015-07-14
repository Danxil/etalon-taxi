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
        .when('/:lang', {
            templateUrl: '/partials/main/main',
            controller: 'etMainCtrl'
        })
        .when('/:lang/contacts', {templateUrl: '/partials/contacts/contacts', controller: 'etContactsCtrl'})
        .when('/:lang/for-companies', {templateUrl: '/partials/for-companies/for-companies', controller: 'etForCompaniesCtrl'})
        .when('/:lang/how-to-pay', {templateUrl: '/partials/how-to-pay/how-to-pay', controller: 'etHowToPayCtrl'})
        .when('/:lang/auto-classes', {templateUrl: '/partials/auto-classes/auto-classes', controller: 'etAutoClassesCtrl'})
        .when('/:lang/advantages', {templateUrl: '/partials/advantages/advantages', controller: 'etAdvantagesCtrl'})
        .when('/:lang/services', {templateUrl: '/partials/services/services', controller: 'etServicesCtrl'})
        .otherwise('/ru')
});