angular.module('app').factory('soapApi', function ($http, $q) {
    _places = {}

    return {
        getPlaces: function() {
            if (_places.data) {
                var def = $q.defer()
                var promise = def.promise
                def.resolve(_places)
            }
            else {
                var promise = $http.get('/api/places')

                promise.then(function(response) {
                    _places = response
                })
            }

            return promise
        },
        orderCalculateOnly: function(data) {
            return $http.post('/api/order-calculate-only', data)
        },
        addNewOrder: function(data) {
            return $http.post('/api/add-new-order', data)
        },
        orderStatusQuery: function(data) {
            return $http.post('/api/order-status-query', data)
        },
        orderInfoQuery: function(data) {
            return $http.post('/api/order-info-query', data)
        },
        orderClientRejection: function(data) {
            return $http.post('/api/order-client-rejection', data)
        }
    }
})