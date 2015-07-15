angular.module('app').controller('etGlobalCtrl', function ($scope, $rootScope, $document, $location, sendPhone, authorisation, soapApi) {
    $scope.sendPhone = {
        send: function() {
            sendPhone(this.number).then((function() {
                this.success = true
            }).bind(this), (function() {
                this.error = true
            }).bind(this))
        },
        success: false,
        error: false
    }

    $rootScope.loading = {}


    $scope.application = {
        Client: {},
        OrderPoints: [
            {}
        ],
        OrderTypes: [],
        CarClass: 0
    }

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
            return item.StreetName && item.House && $scope.regions.indexOf(item.StreetName) != -1
        })

        var whereFrom = $scope.application.StreetName && $scope.application.House &&
            $scope.regions.indexOf($scope.application.StreetName) != -1

        return $scope.toShowNumber = whereFrom && ($scope.application.withoutFinalPoint || whereTo.length)
    }

    $scope.addNewPoint = function () {
        $scope.application.OrderPoints.push({})
    }

    $scope.cancelOrder = function () {
        $rootScope.loading.cancelOrder = true
        soapApi.orderClientRejection({id: $rootScope.orderId}).then(function(resopnse) {
            $rootScope.orderStatus = 'canceled'
            $rootScope.loading.cancelOrder = false
            $rootScope.loading.searchAuto = false
        })
    }


    $scope.order = function () {
        if (!$scope.toShowNumber || !$scope.application.Client.Phone)
            return

        $rootScope.loading.searchAuto = true

        soapApi.addNewOrder(createOrderInfo()).then(function(response) {
            $rootScope.orderId = response.data.Id

            (function checkStatus(id) {
                soapApi.orderStatusQuery({id: id}).then(function(resopnse) {
                    if (resopnse.data.Status != 'CarOnRoad' && resopnse.data.Status != 'Cancelled') {
                        return $timeout(function() {
                            checkStatus(id)
                        }, 1000)
                    } else if (resopnse.data.Status == 'Cancelled') {
                        $rootScope.orderStatus = 'sorry'
                        return $rootScope.loading.searchAuto = false
                    }

                    soapApi.orderInfoQuery({id: id}).then(function(resopnse) {
                        $rootScope.loading.searchAuto = false
                        $rootScope.orderSuccess = resopnse.data.OrderInfo
                        $rootScope.orderStatus = 'success'

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

    $scope.autoTypes = [
        {
            type: '0',
            label: 'Стандарт'
        },
        {
            type: '3',
            label: 'Бизнес'
        },
        {
            type: '4',
            label: 'Премиум'
        },
    ]

    $scope.$on('$locationChangeSuccess', function(){
        $scope.location = $location.$$path
        $scope.chooseAutoClassAvailable = $location.$$path == '/ru' || $location.$$path == '/en' || $location.$$path == '/ua'
    })

    $scope.menu = [
        {
            name: {
                ru: 'Главная',
                ua: 'Головна',
                en: 'Main'
            },
            link: '/',
            cssClass: 'home'

        },
        {
            name: {
                ru: 'Услуги',
                ua: 'Послуги',
                en: 'Service'
            },
            link: '/services',
            cssClass: 'services'
        },
        {
            name: {
                ru: 'Как оплатить',
                ua: 'Як сплатити',
                en: 'How to pay'
            },
            link: '/how-to-pay',
            cssClass: 'how-to-pay'
        },
        {
            name: {
                ru: 'Для предприятий',
                ua: 'Для підприємств',
                en: 'For business'
            },
            link: '/for-companies',
            cssClass: 'for-corps'
        },
        {
            name: {
                ru: 'Преимущества',
                ua: 'Переваги',
                en: 'Our bebefits'
            },
            link: '/advantages',
            cssClass: 'pros'
        },
        {
            name: {
                ru: 'Классы авто',
                ua: 'Класи авто',
                en: 'Class cars'
            },
            link: '/auto-classes',
            cssClass: 'auto-classes'
        },
        {
            name: {
                ru: 'Контакты',
                ua: 'Контакти',
                en: 'Contacts'
            },
            link: '/contacts',
            cssClass: 'contacts'
        }
    ]

    $rootScope.loading.firstLoad = true

    soapApi.getPlaces().then(function(regions) {
        $scope.regions = _.map(regions.data, function(item) {
            $rootScope.loading.firstLoad = false

            return item.Name
        })
    })

    $rootScope.orderSuccess = null


    $scope.$watch('application', function(newVal, oldVal) {
        if (toShowNumberFn() && newVal.Client.Phone && ((newVal.Client.Phone == oldVal.Client.Phone) || (!oldVal.Client.Phone && newVal.Client.Phone)))
            orderCalculateOnly()

    }, true)

    authorisation.getUserData().then(function(userData) {
        $scope.userData = userData
    }, function() {
    })
});