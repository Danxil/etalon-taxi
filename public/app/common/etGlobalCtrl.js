angular.module('app').controller('etGlobalCtrl', function ($scope, $rootScope, $document) {
    $scope.autoTypes = [
        {
            type: 'standard',
            label: 'Стандарт'
        },
        {
            type: 'business',
            label: 'Бизнес'
        },
        {
            type: 'premium',
            label: 'Премиум'
        },
    ]

    $scope.application = {
        autoClass: $scope.autoTypes[0].type,
        from: {

        },
        to: [
            {

            }
        ]
    }


    $scope.addNewPoint = function () {
        $scope.application.to.push({})
    }
});