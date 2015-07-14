var soap = require('soap');
var url = 'http://taxi.intelserv.com/YTaxiSOAP/YTxWebService.asmx?WSDL';

describe('soap', function () {
    it('should return success', function (done) {
        soap.createClient(url, function(err, client) {
            var args = {
                provider: '00000000-0000-0000-0000-000000000115',


                request: {
                    Command: 'OrderInfoQuery',
                    Id: 40233
                }
                /*
                request: {
                    Command: 'OrderDriverSelection',
                    Id: 40205,
                    DriverId: 1
                }
                request: {
                    Command: 'OrderEstimatedDriversQuery',
                    Id: 40205
                }


                request: {
                    Command: 'OrderAutoSearchDrivers',
                    Id: 40206
                }

                request: {
                    Command: 'OrderStatusQuery',
                    Id: 40206
                }

                request: {
                    Command: 'RegistersQuery',
                    Requested: [
                        'Streets'
                    ]
                }

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