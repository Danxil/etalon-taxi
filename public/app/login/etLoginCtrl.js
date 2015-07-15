angular.module('app').controller('etLoginCtrl', function ($scope, $http, $rootScope, authorisation, $location) {
    $scope.authorisation = {}

    $scope.submit = function() {
        authorisation.login($scope.authorisation.login, $scope.authorisation.password).then(function() {
            location.href  = '/cabinet'
        }, function() {
            $scope.authorisation.error = true
        })
    }
});