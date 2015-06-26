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
        $scope.location = $location.$$path
        $scope.chooseAutoClassAvailable = $location.$$path == '/'
    })

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

    $scope.menu = [
        {
            name: 'Главная',
            link: '/',
            cssClass: 'home'

        },
        {
            name: 'Услуги',
            link: '/services',
            cssClass: 'services'
        },
        {
            name: 'Как оплатить',
            link: '/how-to-pay',
            cssClass: 'how-to-pay'
        },
        {
            name: 'Для предприятий',
            link: '/for-companies',
            cssClass: 'for-corps'
        },
        {
            name: 'Преимущества',
            link: '/advantages',
            cssClass: 'pros'
        },
        {
            name: 'Классы авто',
            link: '/auto-classes',
            cssClass: 'auto-classes'
        },
        {
            name: 'Контакты',
            link: '/contacts',
            cssClass: 'contacts'
        }
    ]
});