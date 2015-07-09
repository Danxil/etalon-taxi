namespace YTxCommon.App.Enums {
    /// <summary>
    ///     Классы автомобилей
    /// </summary>
    public enum CarClasses {
        /// <summary>
        ///     Стандарт
        /// </summary>
        Standard = 0,

        /// <summary>
        ///     Эконом
        /// </summary>
        Economy = 1,

        /// <summary>
        ///     Комфорт
        /// </summary>
        Comfort = 2,

        /// <summary>
        ///     Бизнес
        /// </summary>
        Business = 3,

        /// <summary>
        ///     VIP
        /// </summary>
        VIP = 4,

        /// <summary>
        ///     Универсал
        /// </summary>
        Universal = 5,

        /// <summary>
        ///     Лимузин
        /// </summary>
        Limo = 6,

        /// <summary>
        ///     Минивен
        /// </summary>
        Miniwan = 7,

        /// <summary>
        ///     Микроавтобус
        /// </summary>
        MicroBus = 8,

        /// <summary>
        ///     Газель
        /// </summary>
        Gazelle = 9,

        /// <summary>
        ///     Эвакуатор
        /// </summary>
        Evacuator = 10,

        /// <summary>
        ///     Автобус
        /// </summary>
        Bus = 11
    }

    /// <summary>
    ///     Типы владения автомобилем
    /// </summary>
    public enum CarOwnTypes {
        /// <summary>
        ///     Собственный
        /// </summary>
        Private = 0,

        /// <summary>
        ///     Предприятие
        /// </summary>
        Company = 1,

        /// <summary>
        ///     Аренда
        /// </summary>
        Rent = 2
    }

    /// <summary>
    ///     Виды статусов автомобиля
    /// </summary>
    public enum CarStt {
        /// <summary>
        ///     В эксплуатации
        /// </summary>
        Active = 0,

        /// <summary>
        ///     Заблокирован
        /// </summary>
        Inactive = 1,

        /// <summary>
        ///     Ремонт
        /// </summary>
        Repair = 2
    }

    /// <summary>
    ///     Виды фотографий автомобиля
    /// </summary>
    public enum CarPhotoViews {
        /// <summary>
        ///     Вид сбоку
        /// </summary>
        SideView = 0,

        /// <summary>
        ///     Вид спереди
        /// </summary>
        FrontView = 1,

        /// <summary>
        ///     Вид салона
        /// </summary>
        CabinView = 2
    }
}
