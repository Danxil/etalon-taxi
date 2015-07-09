using System;
using Newtonsoft.Json;
using ServerAppAPI.API;
using ServerAppAPI.API.Requests;
using ServerAppAPI.API.Responses;
using YTxCommon;

namespace CallAPI {
    internal partial class Program {
        //private const string _provider = "00000000-0000-0000-0000-000000000003";
        private const string _provider = "00000000-0000-0000-0000-000000000020";
        private const string _url = "http://localhost/YTxServerSOAP/Service";
        //private const string _url = "http://taxi.intelserv.com/YTaxiSOAP/Service";
        //private const string _url = "http://212.90.163.21/YTaxiSOAP/Service";

        private static readonly YTxWebService.YTxWebService service = new YTxWebService.YTxWebService {
            Url = _url,
            Timeout = 600000
        };

        private static void Main( string[] args ) {
            try {
                Version();
                //Registers();
                //AddressByGPS();
                //PointsByGPS();
                ProcessOrder();
            }
            catch( Exception ex ) {
                Console.WriteLine( ex );
            }
        }

        private static void Version() {
            var query = new RequestVersion();

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseVersion>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );
        }

        private static void Registers() {
            var query = new RequestRegistersQuery {
                Lang = SysLangs.RU,
                Requested = new[] {
                    RegisterTypes.Towns,
                    RegisterTypes.Streets,
                    RegisterTypes.ObjectPlaces,
                    RegisterTypes.Providers,
                    RegisterTypes.CarClasses,
                    RegisterTypes.OrderTypes,
                    RegisterTypes.OrderStatuses,
                    RegisterTypes.OrderSubStatuses,
                    RegisterTypes.ClientStatuses,
                    RegisterTypes.DriverShiftStatuses,
                    RegisterTypes.PayTypes,
                    RegisterTypes.Tariffs
                },
                TownId = 0
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseRegistersQuery>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );
        }

        private static void AddressByGPS() {
            var query = new RequestAddressByGPSQuery {
                Lang = SysLangs.RU,
                GPSLat = 50.48114,
                GPSLon = 30.48678,
                //GPSLat = 50.44892,
                //GPSLon = 30.52163,
                //GPSLat = 51.56671,
                //GPSLon = 46.02216,
                Radius = 100,
                QtPlaces = 10
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseAddressByGPSQuery>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );
        }

        private static void PointsByGPS() {
            //var query = new RequestPointsByGPSQuery {
            //    Lang = SysLangs.RU,
            //    CountryName = "Украина",
            //    TownName = "Киев",
            //    StreetName = "Крещатик",
            //    House = "26"
            //};
            //var query = new RequestPointsByGPSQuery {
            //    Lang = SysLangs.RU,
            //    CountryName = "Украина",
            //    TownId = 44,
            //    StreetId = 12529,
            //    House = "1"
            //};
            var query = new RequestPointsByGPSQuery {
                Lang = SysLangs.RU,
                CountryName = "Украина",
                TownId = 41,
                StreetId = 12342,
                House = "7"
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponsePointsByGPSQuery>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );
        }
    }
}
