angular.module('app').controller('etMainCtrl', function ($scope, $http, $rootScope) {
    $scope.map = {
        center: {latitude: 47.181485, longitude: 8.519028}
    };

    $scope.price = {
        firstDigit: 0,
        secondDigit: 1,
        thirdDigit: 2
    };

    $scope.toShowNumber = function () {
        return ($scope.whereFromStreet && $scope.whereFromHouse) && ($scope.withoutFinalPoint || ($scope.whereToStreet && whereToHouse))
    }
});