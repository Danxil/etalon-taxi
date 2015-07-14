angular.module('app').controller('etMainCtrl', function ($scope, $http, soapApi, $rootScope, $timeout) {
    var orderInfo

    $scope.toggleOrderType = function(type) {
        var index = $scope.application.OrderTypes.indexOf(type)

        if (index == -1)
            return $scope.application.OrderTypes.push(type)

        $scope.application.OrderTypes.splice(index, 1)
    }

    var createOrderInfo = function () {
        orderInfo = _.clone($scope.application)

        if ($scope.application.withoutFinalPoint)
            orderInfo.OrderPoints = []

        return orderInfo
    }

    var orderCalculateOnly = function () {
        soapApi.orderCalculateOnly(createOrderInfo()).then(function(response) {
            $scope.orderData = response.data.OrderInfo
            $scope.orderData.price = ($scope.orderData.PlannedPayment / 100).toString()
        })
    }

    function toShowNumberFn () {
        var whereTo = _.filter($scope.application.OrderPoints, function(item) {
            return item.StreetName && item.House
        })

        return $scope.toShowNumber = ($scope.application.StreetName && $scope.application.House) && ($scope.application.withoutFinalPoint || whereTo.length)
    }

    $scope.addNewPoint = function () {
        $scope.application.OrderPoints.push({})
    }

    $scope.order = function () {
        if (!$scope.toShowNumber || !$scope.application.Client.Phone)
            return

        $rootScope.loading.searchAuto = true

        soapApi.addNewOrder(createOrderInfo()).then(function(response) {
            (function checkStatus(id) {
                soapApi.orderStatusQuery({id: id}).then(function(resopnse) {
                    if (resopnse.data.Status != 'CarOnRoad') {
                        return $timeout(function() {
                            checkStatus(id)
                        }, 1000)
                    }

                    soapApi.orderInfoQuery({id: id}).then(function(resopnse) {
                        $rootScope.loading.searchAuto = false
                        $rootScope.orderSuccess = resopnse.data.OrderInfo

                        var created
                        var supply

                        created = $rootScope.orderSuccess.Created.split('T')
                        supply = $rootScope.orderSuccess.PlannedSupply.split('T')

                        created[0] = created[0].split('-')
                        created[1] = created[1].split(':')

                        supply[0] = supply[0].split('-')
                        supply[1] = supply[1].split(':')

                        created = new Date(created[0][0], created[0][1], created[0][2], created[1][0], created[1][1], created[1][2]).getTime()
                        supply = new Date(supply[0][0], supply[0][1], supply[0][2], supply[1][0], supply[1][1], supply[1][2]).getTime()

                        $rootScope.orderSuccess.PlannedPending = ((supply - created) * 0.001 / 60).toFixed(2).toString()

                        if ($rootScope.orderSuccess.PlannedPending.length < 5)
                            $rootScope.orderSuccess.PlannedPending = 0 + $rootScope.orderSuccess.PlannedPending
                    })
                })
            })(response.data.Id)
        })
    }

    $scope.$watch('application', function(newVal, oldVal) {
        if (toShowNumberFn() && newVal.Client.Phone && ((newVal.Client.Phone == oldVal.Client.Phone) || (!oldVal.Client.Phone && newVal.Client.Phone)))
            orderCalculateOnly()

    }, true)

    $scope.map = {
        center: {latitude: 50.456712, longitude: 30.562216}
    };

    $rootScope.loading.firstLoad = true

    soapApi.getPlaces().then(function(regions) {
        $scope.regions = _.map(regions.data, function(item) {
            $rootScope.loading.firstLoad = false

            return item.Name
        })
    })

    $rootScope.orderSuccess = null
});