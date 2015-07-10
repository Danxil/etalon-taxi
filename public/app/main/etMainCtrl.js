angular.module('app').controller('etMainCtrl', function ($scope, $http, regions, soapApi) {
    var orderInfo

    $scope.application = {
        Client: {},
        OrderPoints: [
            {}
        ],
        OrderTypes: []
    }

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

        soapApi.addNewOrder(createOrderInfo()).then(function(response) {
        })
    }

    $scope.$watch('application', function(newVal, oldVal) {
        if (toShowNumberFn() && newVal.Client.Phone && ((newVal.Client.Phone == oldVal.Client.Phone) || (!oldVal.Client.Phone && newVal.Client.Phone)))
            orderCalculateOnly()

    }, true)

    $scope.regions = _.map(regions.data, function(item) {
        return item.Name
    })

    $scope.map = {
        center: {latitude: 50.456712, longitude: 30.562216}
    };
});