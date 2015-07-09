angular.module('app').controller('etMainCtrl', function ($scope, $http, $rootScope) {
    $scope.map = {
        center: {latitude: 50.456712, longitude: 30.562216}
    };

    $scope.price = {
        firstDigit: 0,
        secondDigit: 1,
        thirdDigit: 2
    };

    $scope.toShowNumber = function () {
        return ($scope.whereFromStreet && $scope.whereFromHouse) && ($scope.withoutFinalPoint || ($scope.whereToStreet && whereToHouse))
    }

    $http.get('/api/places').success(function(response) {
        $scope.regions = _.map(response, function(item) {
            return item.Name
        })
    })
});