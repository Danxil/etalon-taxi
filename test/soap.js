var soap = require('soap');
var url = 'http://taxi.intelserv.com/YTaxiSOAP/YTxWebService.asmx?WSDL';

describe('soap', function () {
    it('should return success', function (done) {
        soap.createClient(url, function(err, client) {
            var args = {
                provider: '00000000-0000-0000-0000-000000000115',
                request: {
                    Command: 'RegistersQuery',
                    Requested: [
                        'Streets'
                    ]
                }
                /*
                request: {
                    Command: 'OrderCalculateOnly',
                    OrderInfo: {
                        Client: {
                            Phone: "0674050505",
                            Name: "Александр Петрович Михайлов",
                            Birthdate: '8/18/2010 12:00:00 AM',
                            NoSMS: false
                        },
                        CarClass: 0,
                        Passenger: "=== Тест API клиента:==",
                        Address: "Офис",
                        TownName: "Киев",
                        StreetName: "Новоконстантиновская ул.",
                        House: "9",
                        Meet: "Встречайте меня",
                        PayType: 0,
                        OrderPoints: [
                            {
                                Number: 1,
                                Address: "Цирк",
                                StreetName: "Победы пл.",
                                House: "2"
                            }
                        ]
                    }
                }
                */
            }
            args.request = JSON.stringify(args.request)
            console.log(args)
            client.Execute(args, function(err, result) {
                console.log(err);
                console.log(result);

                if (client)
                    done()
                else
                    done('error')
            });
        });
    });
});