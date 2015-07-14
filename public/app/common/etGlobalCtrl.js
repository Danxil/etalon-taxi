angular.module('app').controller('etGlobalCtrl', function ($scope, $rootScope, $document, $location, sendPhone) {
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
});