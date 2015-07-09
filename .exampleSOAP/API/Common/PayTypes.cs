namespace YTxCommon.App.Enums {
    /// <summary>
    ///     Типы оплаты
    /// </summary>
    public enum PayTypes {
        /// <summary>
        ///     Наличные
        /// </summary>
        Currency = 0,

        /// <summary>
        ///     Банковская карточка
        /// </summary>
        BankCard = 1,

        /// <summary>
        ///     Безналичный расчёт
        /// </summary>
        NonCash = 2
    }
}
