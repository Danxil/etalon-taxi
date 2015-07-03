var soap = require('soap');
var url = 'http://taxi.intelserv.com/YTaxiSOAP/Service';

describe('soap', function () {
    it('should return success', function (done) {
        soap.createClient(url, function(err, client) {
            console.log(err)
            client.RegistersQuery(function(err, result) {
                console.log(result);

                done();
            });
        });
    });
});