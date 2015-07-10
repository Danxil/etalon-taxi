var soap = require('soap');
var vow = require('vow');
var _ = require('underscore');

module.exports = function(config) {
    function requestGenerator(method, options) {
        var request = {
            Command: method
        }

        switch (method) {
            case 'RegistersQuery': {
                request.Requested = ['Streets', 'ObjectPlaces']

                break;
            }
            case 'OrderCalculateOnly': {
                request.OrderInfo = options
                request.OrderInfo.TownName = 'Киев'

                break;
            }
            case 'AddNewOrder': {
                request.OrderInfo = options
                request.OrderInfo.TownName = 'Киев'

                break;
            }
        }
        console.log(request)
        return JSON.stringify(request)
    }

    function responseGenerator(method, response) {
        response = JSON.parse(response.ExecuteResult)

        switch (method) {
            case 'RegistersQuery': {
                response = _.union(response['Streets'], response['ObjectPlaces'])

                break;
            }
            case 'OrderCalculateOnly': {

                break;
            }
            case 'AddNewOrder': {

                break;
            }
        }

        return response
    }

    function execute(method, options) {
        var def = vow.defer()

        var args = {
            provider: config.soapProvider,
            request: requestGenerator(method, options)
        }

        this.client.Execute(args, function(error, result) {
            if (error)
                return def.reject(error)

            result = responseGenerator(method, result)
            def.resolve(result)
        });

        return def.promise()
    }

    return {
        createClient: function() {
            var def = vow.defer()

            soap.createClient(config.soapUrl, (function(error, client) {
                if (error)
                    return def.reject(error)

                this.client = client

                def.resolve({execute: (execute).bind(this)})
            }).bind(this))

            return def.promise()
        }
    }
}