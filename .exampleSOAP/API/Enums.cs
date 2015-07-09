namespace ServerAppAPI.API {
    /// <summary>
    ///     Команды API
    /// </summary>
    public enum Commands {
        /// <summary>
        ///     Версия системы
        /// </summary>
        Version,

        /// <summary>
        ///     Запрос реестров
        /// </summary>
        RegistersQuery,

        /// <summary>
        ///     Запрос адреса по координатам
        /// </summary>
        AddressByGPSQuery,

        /// <summary>
        ///     Запрос координат по адресу
        /// </summary>
        PointsByGPSQuery,

        /// <summary>
        ///     Добавление нового заказа
        /// </summary>
        AddNewOrder,

        /// <summary>
        ///     Получение информации по заказу
        /// </summary>
        OrderInfoQuery,

        /// <summary>
        ///     Получение статуса заказза
        /// </summary>
        OrderStatusQuery,

        /// <summary>
        ///     Отказ клиента
        /// </summary>
        OrderClientRejection,

        /// <summary>
        ///     Получение перечня предложенных водителей
        /// </summary>
        OrderEstimatedDriversQuery,

        /// <summary>
        ///     Выбор водителя
        /// </summary>
        OrderDriverSelection,

        /// <summary>
        ///     Перезапуск процесса обработки заказа (поиска водителей)
        /// </summary>
        OrderRestartProcess,

        /// <summary>
        ///     Перевод заказа в режим автоматического поиска водителей
        /// </summary>
        OrderAutoSearchDrivers,

        /// <summary>
        ///     Получение фото водителя
        /// </summary>
        OrderDriverPhotoQuery,

        /// <summary>
        ///     Получение фото автомобиля
        /// </summary>
        OrderCarPhotoQuery,

        /// <summary>
        ///     Расчёт заказа (без создания записи заказа)
        /// </summary>
        OrderCalculateOnly
    }

    /// <summary>
    ///     Виды реестров
    /// </summary>
    public enum RegisterTypes {
        Towns,
        Streets,
        ObjectPlaces,
        Providers,
        CarClasses,
        OrderTypes,
        OrderStatuses,
        OrderSubStatuses,
        ClientStatuses,
        DriverShiftStatuses,
        PayTypes,
        Tariffs
    }

    /// <summary>
    ///     Коды результата выполнения команды
    /// </summary>
    public enum ResultCodes {
        /// <summary>
        ///     Успешно
        /// </summary>
        Success,

        /// <summary>
        ///     Ошибка сервера
        /// </summary>
        ServerError,

        /// <summary>
        ///     Ошибка аутентификации
        /// </summary>
        AuthenticationError,

        /// <summary>
        ///     Некорректные параметры
        /// </summary>
        InvalidParameters
    }
}
