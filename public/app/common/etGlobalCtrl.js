angular.module('app').controller('etGlobalCtrl', function ($scope, $rootScope, $document, $location) {
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

    $scope.$on('$locationChangeSuccess', function(){
        $scope.chooseAutoClassAvailable = $location.$$path == '/'
    })

    console.log($scope.chooseAutoClassAvailable)
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