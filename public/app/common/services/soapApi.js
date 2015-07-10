angular.module('app').factory('soapApi', function ($http) {
    return {
        getPlaces: function() {
            return $http.get('/api/places')
        },
        orderCalculateOnly: function(data) {
            return $http.post('/api/order-calculate-only', data)
        },
        addNewOrder: function(data) {
            return $http.post('/api/add-new-order', data)
        }
    }
})