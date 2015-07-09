namespace YTxCommon.App.Enums {
    /// <summary>
    ///     Типы заказа
    /// </summary>
    public enum OrderTypes {
        /// <summary>
        ///     Кондиционер
        /// </summary>
        Conditioner = 0,

        /// <summary>
        ///     Багаж в салоне
        /// </summary>
        Baggage = 1,

        /// <summary>
        ///     Можно курить
        /// </summary>
        Smoking = 2,

        /// <summary>
        ///     Встреча с табличкой
        /// </summary>
        MeetingSign = 3,

        /// <summary>
        ///     Машина с тросом
        /// </summary>
        WithRope = 4,

        /// <summary>
        ///     Машина с прикуривателем
        /// </summary>
        WithLighter = 5,

        /// <summary>
        ///     Буксировка
        /// </summary>
        Towing = 6,

        /// <summary>
        ///     Курьер
        /// </summary>
        Courier = 7,

        /// <summary>
        ///     WiFi
        /// </summary>
        WiFi = 8,

        /// <summary>
        ///     Детское кресло
        /// </summary>
        BabySeat = 9,

        /// <summary>
        ///     Домашнее животное до 5 кг
        /// </summary>
        PetTo5 = 10,

        /// <summary>
        ///     Домашнее животное более 5 кг
        /// </summary>
        PetMore5 = 11,

        /// <summary>
        ///     Багаж из дома\офиса
        /// </summary>
        TakeOut = 12,

        /// <summary>
        ///     Багаж в дом\офис
        /// </summary>
        Skid = 13,

        /// <summary>
        ///     Автоняня
        /// </summary>
        BabySitter = 14,

        /// <summary>
        ///     Английский язык
        /// </summary>
        English = 15,

        /// <summary>
        ///     Курьерская доставка
        /// </summary>
        CourierDelivery = 16,

        /// <summary>
        ///     Требуется документ на оплату заказа
        /// </summary>
        BillRequired = 17,

        /// <summary>
        ///     Требуется платёжный терминал для оплаты заказа
        /// </summary>
        TerminalRequired = 18,

        /// <summary>
        ///     4 и более человек в машине
        /// </summary>
        PassengersNumber4OrMore = 19,

        /// <summary>
        ///     Эвакуатор - Тележка 1шт
        /// </summary>
        TowTruck0 = 1000,

        /// <summary>
        ///     Эвакуатор - Тележки 2шт
        /// </summary>
        TowTruck1 = 1001,

        /// <summary>
        ///     Эвакуатор - Тележки 3шт
        /// </summary>
        TowTruck2 = 1002,

        /// <summary>
        ///     Эвакуатор - Тележки 4шт
        /// </summary>
        TowTruck3 = 1003,

        /// <summary>
        ///     Эвакуатор - Повторная погрузка
        /// </summary>
        TowTruck4 = 1004,

        /// <summary>
        ///     Эвакуатор - Заблокирован руль
        /// </summary>
        TowTruck5 = 1005,

        /// <summary>
        ///     Эвакуатор - Заблокирована коробка
        /// </summary>
        TowTruck6 = 1006,

        /// <summary>
        ///     Эвакуатор - На крыше
        /// </summary>
        TowTruck7 = 1007,

        /// <summary>
        ///     Эвакуатор - На боку
        /// </summary>
        TowTruck8 = 1008,

        /// <summary>
        ///     Эвакуатор - Вытягивание из паркинга
        /// </summary>
        TowTruck9 = 1009,

        /// <summary>
        ///     Эвакуатор - Вытягивание из бездорожья
        /// </summary>
        TowTruck10 = 1010,

        /// <summary>
        ///     Кювет
        /// </summary>
        TowTruck11 = 1011,

        /// <summary>
        ///     Жесткая сцепка
        /// </summary>
        TowTruck12 = 1012,

        /// <summary>
        ///     Негабарит
        /// </summary>
        TowTruck13 = 1013,

        /// <summary>
        ///     Разблокировка коробки
        /// </summary>
        TowTruck14 = 1014,

        /// <summary>
        ///     Загрузка с рампы
        /// </summary>
        TowTruck15 = 1015,

        /// <summary>
        ///     Выгрузка на рампу
        /// </summary>
        TowTruck16 = 1016,

        /// <summary>
        ///     Загрузка на фуру
        /// </summary>
        TowTruck17 = 1017,

        /// <summary>
        ///     Выгрузка с фуры
        /// </summary>
        TowTruck18 = 1018,

        /// <summary>
        ///     Перевозка МАФов
        /// </summary>
        TowTruck19 = 1019,

        /// <summary>
        ///     Манипулятор
        /// </summary>
        TowTruck20 = 1020,

        /// <summary>
        ///     Борта
        /// </summary>
        TowTruck21 = 1021,

        /// <summary>
        ///     Фаркоп шарик
        /// </summary>
        TowTruck22 = 1022,

        /// <summary>
        ///     Фаркоп америка
        /// </summary>
        TowTruck23 = 1023,

        /// <summary>
        ///     Фаркоп
        /// </summary>
        TowTruck24 = 1024,

        /// <summary>
        ///     Вытяжка Фуры
        /// </summary>
        TowTruck25 = 1025,

        /// <summary>
        ///     Переворот Фуры
        /// </summary>
        TowTruck26 = 1026,

        /// <summary>
        ///     Перевозка Фуры
        /// </summary>
        TowTruck27 = 1027,

        /// <summary>
        ///     Гидравлика
        /// </summary>
        TowTruck28 = 1028,

        /// <summary>
        ///     Высота платформы до 80см
        /// </summary>
        TowTruck29 = 1029,

        /// <summary>
        ///     Высота платформы до 1м
        /// </summary>
        TowTruck30 = 1030,

        /// <summary>
        ///     Ровная платформа 5м
        /// </summary>
        TowTruck31 = 1031,

        /// <summary>
        ///     Ровная платформа 6м
        /// </summary>
        TowTruck32 = 1032,

        /// <summary>
        ///     Ровная платформа 6,5м
        /// </summary>
        TowTruck33 = 1033,

        /// <summary>
        ///     Ровная платформа 7м
        /// </summary>
        TowTruck34 = 1034,

        /// <summary>
        ///     Ровная платформа 7,5м
        /// </summary>
        TowTruck35 = 1035,

        /// <summary>
        ///     Ровная платформа 8м
        /// </summary>
        TowTruck36 = 1036,

        /// <summary>
        ///     Дать воздух
        /// </summary>
        TowTruck37 = 1037,

        /// <summary>
        ///     Трал
        /// </summary>
        TowTruck38 = 1038,

        /// <summary>
        ///     Маленькую маш.
        /// </summary>
        TowTruck39 = 1039,

        /// <summary>
        ///     Сложный заезд
        /// </summary>
        TowTruck40 = 1040,

        /// <summary>
        ///     Узкий заезд
        /// </summary>
        TowTruck41 = 1041,

        /// <summary>
        ///     Низкий заезд
        /// </summary>
        TowTruck42 = 1042,

        /// <summary>
        ///     Широкая ТАТА
        /// </summary>
        TowTruck43 = 1043,

        /// <summary>
        ///     Сдвигающиеся лапы
        /// </summary>
        TowTruck44 = 1044,

        /// <summary>
        ///     Дернуть (Завести)
        /// </summary>
        TowTruck45 = 1045,

        /// <summary>
        ///     Догруз
        /// </summary>
        TowTruck46 = 1046,

        /// <summary>
        ///     Умного водителя
        /// </summary>
        TowTruck47 = 1047,

        /// <summary>
        ///     Техпомощь
        /// </summary>
        TowTruck48 = 1048,

        /// <summary>
        ///     Техпомощь на дороге
        /// </summary>
        TowTruck49 = 1049,

        /// <summary>
        ///     Снятие кардана
        /// </summary>
        TowTruck50 = 1050,

        /// <summary>
        ///     Снятие энергоаккумуляторов
        /// </summary>
        TowTruck51 = 1051,

        /// <summary>
        ///     Переставить автокраном
        /// </summary>
        TowTruck52 = 1052,

        /// <summary>
        ///     Достать авто из ямы
        /// </summary>
        TowTruck53 = 1053,

        /// <summary>
        ///     Мощный кран
        /// </summary>
        TowTruck54 = 1054,

        /// <summary>
        ///     Прикурка
        /// </summary>
        TowTruck55 = 1055,

        /// <summary>
        ///     Открытие авто
        /// </summary>
        TowTruck56 = 1056,

        /// <summary>
        ///     Открытие КВ.
        /// </summary>
        TowTruck57 = 1057,

        /// <summary>
        ///     Замена кол.
        /// </summary>
        TowTruck58 = 1058,

        /// <summary>
        ///     Подвоз АКБ
        /// </summary>
        TowTruck59 = 1059,

        /// <summary>
        ///     Замена АКБ
        /// </summary>
        TowTruck60 = 1060,

        /// <summary>
        ///     Рем. замка зажигания
        /// </summary>
        TowTruck61 = 1061,

        /// <summary>
        ///     Установка замков
        /// </summary>
        TowTruck62 = 1062,

        /// <summary>
        ///     Вскрытие сейфа
        /// </summary>
        TowTruck63 = 1063,

        /// <summary>
        ///     Откл. сигнализацию
        /// </summary>
        TowTruck64 = 1064,

        /// <summary>
        ///     Сделать ключи
        /// </summary>
        TowTruck65 = 1065,

        /// <summary>
        ///     Перепрошить брелок
        /// </summary>
        TowTruck66 = 1066,

        /// <summary>
        ///     Подвоз топлива
        /// </summary>
        TowTruck67 = 1067,

        /// <summary>
        ///     Разблокировка руля
        /// </summary>
        TowTruck68 = 1068,

        /// <summary>
        ///     Зам. кол. на фуре
        /// </summary>
        TowTruck69 = 1069,

        /// <summary>
        ///     Грузчики
        /// </summary>
        TowTruck70 = 1070,

        /// <summary>
        ///     Стропальщик
        /// </summary>
        TowTruck71 = 1071,

        /// <summary>
        ///     Другие услуги
        /// </summary>
        TowTruck72 = 1072,

        /// <summary>
        ///     Встреча с клиентом в Киеве
        /// </summary>
        TowTruck73 = 1073,

        /// <summary>
        ///     Подкачка кол.
        /// </summary>
        TowTruck74 = 1074,

        /// <summary>
        ///     По дороге забрать клиента
        /// </summary>
        TowTruck75 = 1075,

        /// <summary>
        ///     Экспедиторские Услуги
        /// </summary>
        TowTruck76 = 1076,

        /// <summary>
        ///     Прицеп 1+1
        /// </summary>
        TowTruck77 = 1077,

        /// <summary>
        ///     Прицеп 1+2
        /// </summary>
        TowTruck78 = 1078,

        /// <summary>
        ///     Прицеп 1+3
        /// </summary>
        TowTruck79 = 1079,

        /// <summary>
        ///     Прицеп 2+2
        /// </summary>
        TowTruck80 = 1080,

        /// <summary>
        ///     Прицеп 2+3
        /// </summary>
        TowTruck81 = 1081,

        /// <summary>
        ///     Много ремней
        /// </summary>
        TowTruck82 = 1082,

        /// <summary>
        ///     Дополнительные тросы
        /// </summary>
        TowTruck83 = 1083,

        /// <summary>
        ///     Мотоцикл 2-х кол.
        /// </summary>
        TowTruck84 = 1084,

        /// <summary>
        ///     Мотоцикл 3-х кол.
        /// </summary>
        TowTruck85 = 1085,

        /// <summary>
        ///     Больше 2-х чел.
        /// </summary>
        TowTruck86 = 1086,

        /// <summary>
        ///     Частичная погрузка
        /// </summary>
        TowTruck87 = 1087,

        /// <summary>
        ///     Колеса оторваны
        /// </summary>
        TowTruck88 = 1088,

        /// <summary>
        ///     Колеса заблокированы
        /// </summary>
        TowTruck89 = 1089,

        /// <summary>
        ///     Негабарит, решаем мы
        /// </summary>
        TowTruck90 = 1090,

        /// <summary>
        ///     Негабарит, решает клиент
        /// </summary>
        TowTruck91 = 1091
    }

    /// <summary>
    ///     Виды статусов заказа
    /// </summary>
    public enum OrderStt {
        /// <summary>
        ///     Создан
        /// </summary>
        Created = 0,

        /// <summary>
        ///     Поиск машины
        /// </summary>
        CarSearch = 1,

        /// <summary>
        ///     Подача машины
        /// </summary>
        CarOnRoad = 2,

        /// <summary>
        ///     Машина ожидает клиента
        /// </summary>
        CarWaiting = 3,

        /// <summary>
        ///     Заказ выполняется
        /// </summary>
        InProgress = 4,

        /// <summary>
        ///     Заказ завершён
        /// </summary>
        Complete = 5,

        /// <summary>
        ///     Заказ отменён
        /// </summary>
        Cancelled = 6,

        /// <summary>
        ///     Заказ завершён успешно
        /// </summary>
        CompleteSuccessfully = 100,

        /// <summary>
        ///     Заказ завершён неуспешно
        /// </summary>
        CompleteUnsuccessfully = 101
    }

    /// <summary>
    ///     Виды подчинённых статусов заказа
    ///     Структура: OrderStt-N знаков, OrderSubStt-3 знака
    /// </summary>
    public enum OrderSubStt {
        /// <summary>
        ///     Создан - Заказ создан
        /// </summary>
        CreatedCreated = 0,

        /// <summary>
        ///     Создан - Выполняется расчёт
        /// </summary>
        CreatedCalculating = 1,

        /// <summary>
        ///     Создан - Ожидается подтверждение клиента
        /// </summary>
        CreatedClientConfirmation = 2,

        /// <summary>
        ///     Поиск машины - Оценка вероятности выполнения заказа
        /// </summary>
        CarSearchEstimate = 1001,

        /// <summary>
        ///     Поиск машины - Автоматический поиск
        /// </summary>
        CarSearchAuto = 1002,

        /// <summary>
        ///     Поиск машины - Клиент выбирает автомобили из предложенных
        /// </summary>
        CarSearchClientSelect = 1003,

        /// <summary>
        ///     Поиск машины - Клиент ожидает ответ водителя (подтверждение или отказ)
        /// </summary>
        CarSearchClientWaitingAnswer = 1004,

        /// <summary>
        ///     Поиск машины - Диспетчер ищет машину вручную
        /// </summary>
        CarSearchByDispatcher = 1005,

        /// <summary>
        ///     Поиск машины - Заказ передан в "Свободный эфир"
        /// </summary>
        CarSearchBroadcast = 1006,

        /// <summary>
        ///     Подача машины - Водитель подтвердил приём заказа в работу
        /// </summary>
        CarOnRoadDriverConfirmed = 2001,

        /// <summary>
        ///     Подача машины - Водитель начал выполнение заказа
        /// </summary>
        CarOnRoadDriverStarts = 2002,

        /// <summary>
        ///     Подача машины - Водитель опаздывает
        /// </summary>
        CarOnRoadDriverIsLate = 2003,

        /// <summary>
        ///     Ожидание клиента - Машина прибыла в исходный пункт
        /// </summary>
        CarWaitingDriverArrived = 3001,

        /// <summary>
        ///     Ожидание клиента - Клиент уведомлён о прибытии машины
        /// </summary>
        CarWaitingClientNotified = 3002,

        /// <summary>
        ///     Ожидание клиента - Запуск таксометра для начисления простоя
        /// </summary>
        CarWaitingIdleCharges = 3003,

        /// <summary>
        ///     Заказ выполняется - Посадка клиента
        /// </summary>
        InProgressWithClient = 4001,

        /// <summary>
        ///     Заказ выполняется - Запуск таксометра и начало движения по маршруту
        /// </summary>
        InProgressStartTaximeter = 4002,

        /// <summary>
        ///     Заказ завершён - Остановка таксометра. Ожидается оплата
        /// </summary>
        CompleteWaitPay = 5001,

        /// <summary>
        ///     Заказ отменён - Машина не найдена
        /// </summary>
        CancelledCarNotFound = 6001,

        /// <summary>
        ///     Заказ отменён - Клиент не вышел
        /// </summary>
        CancelledClientNotOut = 6002,

        /// <summary>
        ///     Заказ отменён - Отказ водителя
        /// </summary>
        CancelledDriverRejection = 6003,

        /// <summary>
        ///     Заказ завершён неуспешно - Отказ клиента
        /// </summary>
        CancelledClientRejection = 6004,

        /// <summary>
        ///     Заказ завершён успешно - Клиент оплатил заказ
        /// </summary>
        CompleteSuccessfullyPayed = 100001,

        /// <summary>
        ///     Заказ завершён неуспешно - Оплата подачи машины
        /// </summary>
        CompleteSuccessfullyFilingFeesCar = 100002,

        /// <summary>
        ///     Заказ завершён неуспешно - Машина не найдена
        /// </summary>
        CompleteUnsuccessfullyCarNotFound = 101001,

        /// <summary>
        ///     Заказ завершён неуспешно - Отказ клиента
        /// </summary>
        CompleteUnsuccessfullyClientRejection = 101002,

        /// <summary>
        ///     Заказ завершён неуспешно - Просчёт тарифа
        /// </summary>
        CompleteUnsuccessfullyInvalidCalculation = 101003,

        /// <summary>
        ///     Заказ завершён неуспешно - Вина оператора
        /// </summary>
        CompleteUnsuccessfullyOperatorGuilty = 101004,

        /// <summary>
        ///     Заказ завершён неуспешно - Вина водителя
        /// </summary>
        CompleteUnsuccessfullyDriverGuilty = 101005
    }

    /// <summary>
    ///     Источники заказа
    /// </summary>
    public enum OrderSources {
        /// <summary>
        ///     Телефон (зарегистрирован оператором)
        /// </summary>
        Phone = 0,

        /// <summary>
        ///     Программа (зарегистрирован программно)
        /// </summary>
        Software = 1,

        /// <summary>
        ///     Свободный заказ (зарегистрирован водителем)
        /// </summary>
        Driver = 2
    }

    /// <summary>
    ///     События заказа
    /// </summary>
    public enum OrderEvents {
        /// <summary>
        ///     Создание
        /// </summary>
        Create = 0,

        /// <summary>
        ///     Изменение статуса
        /// </summary>
        Change = 1,

        /// <summary>
        ///     Закрытие
        /// </summary>
        Closure = 2,

        /// <summary>
        ///     Восстановление
        /// </summary>
        Restore = 3,

        /// <summary>
        ///     Назначение водителя на заказ
        /// </summary>
        DriverAppointment = 4,

        /// <summary>
        ///     Снятие водителя с заказа
        /// </summary>
        DriverDisappointment = 5,

        /// <summary>
        ///     Сброс времени заказа
        /// </summary>
        TimeReset = 6,

        /// <summary>
        ///     Редактирование
        /// </summary>
        Modify = 7,

        /// <summary>
        ///     Редактирование архивной записи
        /// </summary>
        ModifyArchived = 8,

        /// <summary>
        ///     Заказ отправлен на обмен
        /// </summary>
        XchgProcessing = 9,

        /// <summary>
        ///     Заказ принят к исполнению по обмену
        /// </summary>
        XchgTaken = 10,

        /// <summary>
        ///     Заказ возвращён из обмена
        /// </summary>
        XchgRecovered = 11,

        /// <summary>
        ///     Сообщение для заказа по обмену
        /// </summary>
        XchgMessage = 12
    }

    /// <summary>
    ///     Статус назначения заказа водителю
    /// </summary>
    public enum OrderAssignmentToDriverStt {
        /// <summary>
        ///     Не назначен
        /// </summary>
        None = 0,

        /// <summary>
        ///     Предложен
        /// </summary>
        Proposed = 1,

        /// <summary>
        ///     Отказ водителя
        /// </summary>
        Rejected = 2
    }

    /// <summary>
    ///     Ошибки назначения статуса заказа
    /// </summary>
    public enum SetOrderStatusErrors {
        /// <summary>
        ///     На заказ не назначен водитель
        /// </summary>
        DriverIsUndefined = 0,

        /// <summary>
        ///     Водитель отсутствует или не на смене
        /// </summary>
        DriverIsAbsentOnShift = 1
    }

    /// <summary>
    ///     Операции программы обработки событий заказа
    /// </summary>
    public enum OrderEventProgramActions {
        /// <summary>
        ///     Получить следующий статус заказа
        /// </summary>
        NextOrderStatusRequest = 0,

        /// <summary>
        ///     Статус заказа установлен
        /// </summary>
        OrderStatusEstablished = 1,

        /// <summary>
        ///     Заказ ожидает следующее событие
        /// </summary>
        OrderIsWaitingInStatus = 2,

        /// <summary>
        ///     Отправить SMS-сообщение водителю
        /// </summary>
        SendSMSToDriver = 3
    }

    /// <summary>
    ///     Виды статусов заказа в системе обмена
    /// </summary>
    public enum OrderXchgStt {
        /// <summary>
        ///     Не передан в систему обмена
        /// </summary>
        None = 0,

        /// <summary>
        ///     Определяется исполнитель в системе обмена
        /// </summary>
        Processing = 1,

        /// <summary>
        ///     Исполнитель определён
        /// </summary>
        ExecutorDefined = 2
    }

    #region Helpers

    public static class OrdersHelper {
        public static OrderEvents EventType( this OrderStt status ) {
            switch( status ) {
            case OrderStt.Created:
                return OrderEvents.Create;
            case OrderStt.CompleteSuccessfully:
            case OrderStt.CompleteUnsuccessfully:
                return OrderEvents.Closure;
            default:
                return OrderEvents.Change;
            }
        }
    }

    #endregion
}
