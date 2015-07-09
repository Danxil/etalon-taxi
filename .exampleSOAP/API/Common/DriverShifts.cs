namespace YTxCommon.App.Enums {
    /// <summary>
    ///     Виды статусов водителя на смене
    /// </summary>
    public enum DriverShiftStt {
        /// <summary>
        ///     Доступен для выполнения заказа
        /// </summary>
        Available = 0,

        /// <summary>
        ///     Занят на заказе
        /// </summary>
        OnOrder = 1,

        /// <summary>
        ///     Обед
        /// </summary>
        Dining = 2
    }

    /// <summary>
    ///     Ошибки назначения статуса водителя на смене
    /// </summary>
    public enum SetDriverShiftStatusErrors {
        /// <summary>
        ///     Автомобиль водителя уже задействован на смене
        /// </summary>
        CarAlreadyIsOnShift = 0,

        /// <summary>
        ///     Позывной водителя уже используется на смене
        /// </summary>
        DriverSignAlreadyUsed = 1,

        /// <summary>
        ///     Найдены несколько водителей с одинаковым позывным
        /// </summary>
        FoundSeveralDrivers = 2,

        /// <summary>
        ///     Автомобиль водителя не зарегистрирован
        /// </summary>
        CarIsNotRegistered = 3,

        /// <summary>
        ///     Присутствуют открытые заказы
        /// </summary>
        OpenedOrdersPresent = 4,

        /// <summary>
        ///     Водитель уже на смене на другом автомобиле
        /// </summary>
        DriverIsAlreadyOnShiftOnAnotherCar = 5
    }

    /// <summary>
    ///     Ошибки назначения заказа водителю
    /// </summary>
    public enum AppointDriverToOrderErrors {
        /// <summary>
        ///     Водитель отсутствует или не на смене
        /// </summary>
        DriverIsAbsentOnShift = 0,

        /// <summary>
        ///     На заказ назначен другой водитель
        /// </summary>
        AnotherDriverAssigned = 1,

        /// <summary>
        ///     Баланс водителя ниже порога отключения
        /// </summary>
        DriverBalanceIsTooLow = 2,

        /// <summary>
        ///     Водитель выполняет заказ
        /// </summary>
        DriverIsOnOrder = 3
    }

    /// <summary>
    ///     Ошибки назначения водителя на стоянку
    /// </summary>
    public enum SetDriverToStopErrors {
        /// <summary>
        ///     Водитель уже на стоянке
        /// </summary>
        DriverAlreadyOnStop = 0,

        /// <summary>
        ///     Водитель не на стоянке
        /// </summary>
        DriverIsNotOnStop = 1,

        /// <summary>
        ///     Присутствуют открытые заказы
        /// </summary>
        OpenedOrdersPresent = 2
    }
}
