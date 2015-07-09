using System;
using System.Linq;
using System.Threading;
using Newtonsoft.Json;
using ServerAppAPI.API;
using ServerAppAPI.API.Common;
using ServerAppAPI.API.Requests;
using ServerAppAPI.API.Responses;
using YTxCommon;
using YTxCommon.App.Enums;

namespace CallAPI {
    internal partial class Program {
        private static int _orderId;
        private static OrderStt _orderStt;
        private static bool _sentToXchg;
        private static OrderSubStt _orderSubStt;
        private static OrderInfo _orderInfo;
        private static OrderEstimatedDriver[] _drivers;

        private static void ProcessOrder() {
            try {
                Cleanup();
                OrderCalculateOnly();
                AddNewOrder();
                OrderStatusQuery();
                for( var i = 0; i < 30 && _orderStt != OrderStt.CarSearch; i++ ) {
                    Thread.Sleep( 1000 );
                    OrderStatusQuery();
                }
                if( _orderStt != OrderStt.CarSearch ) {
                    throw new Exception( _orderStt.ToString() );
                }
                OrderInfoQuery();

                //for( var i = 0; i < 30 && _drivers == null; i++ ) {
                //    Thread.Sleep( 1000 );
                //    OrderEstimatedDriversQuery();
                //    //if( _drivers != null ) {
                //    //    foreach( var driver in _drivers ) {
                //    //        OrderDriverPhoto( driver.DriverId );
                //    //        OrderCarPhoto( driver.DriverId );
                //    //    }
                //    //}
                //}
                //if( _drivers != null ) {
                //    //OrderDriverSelection();
                //}
                //else {
                //    OrderClientRejection();
                //    return;
                //}

                for( var i = 0; i < 30 && !(_sentToXchg && _orderSubStt != OrderSubStt.CarSearchClientSelect); i++ ) {
                    Thread.Sleep( 1000 );
                    OrderStatusQuery();
                }
                if( _sentToXchg && _orderSubStt == OrderSubStt.CarSearchClientSelect ) {
                    Thread.Sleep( 15000 );
                    OrderAutoSearchDrivers();
                    OrderStatusQuery();
                    for( var i = 0; i < 30 && _orderStt != OrderStt.CarOnRoad; i++ ) {
                        Thread.Sleep( 1000 );
                        OrderStatusQuery();
                    }
                }
                OrderClientRejection();

                //Thread.Sleep( 10000 );
                //OrderRestartProcess();
                //for( var i = 0; i < 30 && _orderStt != OrderStt.CarSearch; i++ ) {
                //    Thread.Sleep( 1000 );
                //    OrderStatusQuery();
                //}
                //if( _orderStt != OrderStt.CarSearch ) {
                //    throw new Exception( _orderStt.ToString() );
                //}
                //OrderInfoQuery();
                //for( var i = 0; i < 30 && _drivers == null; i++ ) {
                //    Thread.Sleep( 1000 );
                //    OrderEstimatedDriversQuery();
                //}
            }
            catch( Exception ex ) {
                Console.WriteLine( ex );
            }
        }

        private static void Cleanup() {
            _orderId = 0;
            _orderStt = OrderStt.Created;
            _orderSubStt = OrderSubStt.CreatedCreated;
            _drivers = null;
        }

        private static void OrderCalculateOnly() {
            var clientInfo = new ClientInfo {
                Phone = "0674050505",
                Name = "Александр Петрович Михайлов",
                Birthdate = new DateTime( 1958, 2, 17 ),
                NoSMS = false
            };


            var orderTypes = new[] {
                OrderTypes.Conditioner
            };

            var orderPoints = new[] {
                new OrderPointInfo {
                    Number = 1,
                    Address = "Цирк",
                    StreetName = "Победы пл.",
                    House = "2"
                }
            };

            var orderInfo = new OrderInfo {
                Client = clientInfo,
                CarClass = CarClasses.Standard,
                Passenger = "=== Тест API клиента ===",
                Address = "Офис",
                TownName = "Киев",
                StreetName = "Новоконстантиновская ул.",
                House = "9",
                Meet = "Встречайте меня",
                PayType = PayTypes.Currency,
                //Preorder = true,
                //PlannedSupply = DateTime.Now.AddHours( 2 ),
                //OrderTypes = orderTypes,
                OrderPoints = orderPoints
            };

            var query = new RequestOrderCalculateOnly {
                Lang = SysLangs.RU,
                OrderInfo = orderInfo
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseOrderCalculateOnly>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );

            if( result.Result == ResultCodes.Success ) {
            }
            else {
                throw new Exception( result.Result.ToString() );
            }
        }

        private static void AddNewOrder() {
            var clientInfo = new ClientInfo {
                Phone = "0674050505",
                Name = "Александр Петрович Михайлов",
                Birthdate = new DateTime( 1958, 2, 17 ),
                NoSMS = false
            };

            var orderTypes = new[] {
                OrderTypes.Conditioner
            };

            var orderPoints = new[] {
                new OrderPointInfo {
                    Number = 1,
                    Address = "Цирк",
                    StreetName = "Победы пл.",
                    House = "2"
                }
            };

            var orderInfo = new OrderInfo {
                Client = clientInfo,
                CarClass = CarClasses.Standard,
                Passenger = "=== Тест API клиента ===",
                Address = "Офис",
                TownName = "Киев",
                StreetName = "Новоконстантиновская ул.",
                House = "9",
                Meet = "Встречайте меня",
                PayType = PayTypes.Currency,
                //Preorder = true,
                //PlannedSupply = DateTime.Now.AddHours( 2 ),
                //OrderTypes = orderTypes,
                OrderPoints = orderPoints
            };

            var query = new RequestAddNewOrder {
                Lang = SysLangs.RU,
                OrderInfo = orderInfo
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseAddNewOrder>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );

            if( result.Result == ResultCodes.Success ) {
                _orderId = result.Id;
            }
            else {
                throw new Exception( result.Result.ToString() );
            }
        }

        private static void OrderStatusQuery() {
            var query = new RequestOrderStatusQuery {
                Lang = SysLangs.RU,
                Id = _orderId
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseOrderStatusQuery>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );

            if( result.Result == ResultCodes.Success ) {
                _orderStt = result.Status;
                _orderSubStt = result.SubStatus;
                _sentToXchg = result.SentToXchg;
            }
            else {
                throw new Exception( result.Result.ToString() );
            }
        }

        private static void OrderInfoQuery() {
            var query = new RequestOrderInfoQuery {
                Lang = SysLangs.RU,
                Id = _orderId,
                IncludeRoute = true,
                IncludeCalcLog = true
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseOrderInfoQuery>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );

            if( result.Result == ResultCodes.Success ) {
                _orderInfo = result.OrderInfo;
            }
            else {
                throw new Exception( result.Result.ToString() );
            }
        }

        private static void OrderEstimatedDriversQuery() {
            var query = new RequestOrderEstimatedDriversQuery {
                Lang = SysLangs.RU,
                Id = _orderId
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseOrderEstimatedDriversQuery>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );

            if( result.Result == ResultCodes.Success ) {
                _drivers = result.Drivers;
                _orderStt = result.Status;
                _orderSubStt = result.SubStatus;
            }
            else {
                throw new Exception( result.Result.ToString() );
            }
        }

        private static void OrderClientRejection() {
            var query = new RequestOrderClientRejection {
                Id = _orderId,
                Cause = "Автомобили не найдены"
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseOrderClientRejection>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );

            if( result.Result == ResultCodes.Success ) {
                _orderStt = result.Status;
                _orderSubStt = result.SubStatus;
            }
            else {
                throw new Exception( result.Result.ToString() );
            }
        }

        private static void OrderDriverSelection() {
            var query = new RequestOrderDriverSelection {
                Id = _orderId,
                DriverId = _drivers.First().DriverId
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseOrderDriverSelection>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );

            if( result.Result == ResultCodes.Success ) {
                _orderStt = result.Status;
                _orderSubStt = result.SubStatus;
            }
            else {
                throw new Exception( result.Result.ToString() );
            }
        }

        private static void OrderDriverPhoto( int driverId ) {
            var query = new RequestOrderDriverPhotoQuery {
                Id = _orderId,
                DriverId = driverId
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseOrderDriverPhotoQuery>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );
        }

        private static void OrderCarPhoto( int driverId ) {
            var query = new RequestOrderCarPhotoQuery {
                Id = _orderId,
                DriverId = driverId,
                CarView = CarPhotoViews.SideView
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseOrderCarPhotoQuery>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );
        }

        private static void OrderRestartProcess() {
            var query = new RequestOrderRestartProcess {
                Id = _orderId
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseOrderRestartProcess>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );

            if( result.Result == ResultCodes.Success ) {
                _orderStt = result.Status;
                _orderSubStt = result.SubStatus;
            }
            else {
                throw new Exception( result.Result.ToString() );
            }
        }

        private static void OrderAutoSearchDrivers() {
            var query = new RequestOrderAutoSearchDrivers {
                Id = _orderId
            };

            var request = JsonConvert.SerializeObject( query );

            var response = service.Execute( _provider, request );

            var result = JsonConvert.DeserializeObject<ResponseOrderAutoSearchDrivers>( response );

            Console.WriteLine( response );
            Console.WriteLine( result );

            if( result.Result == ResultCodes.Success ) {
                _orderStt = result.Status;
                _orderSubStt = result.SubStatus;
            }
            else {
                throw new Exception( result.Result.ToString() );
            }
        }
    }
}
