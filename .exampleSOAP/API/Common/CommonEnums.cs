namespace YTxCommon {
    /// <summary>
    ///     Языки системы
    /// </summary>
    public enum SysLangs {
        /// <summary>
        ///     Русский
        /// </summary>
        RU = 0,

        /// <summary>
        ///     Украинский
        /// </summary>
        UK = 1
    }

    /// <summary>
    ///     Режим выборки данных
    /// </summary>
    public enum DataSelectionMode {
        /// <summary>
        ///     Все записи
        /// </summary>
        All,

        /// <summary>
        ///     Активные записи
        /// </summary>
        Active,

        /// <summary>
        ///     Неактивные записи
        /// </summary>
        Inactive,

        /// <summary>
        ///     Для выборки значений
        /// </summary>
        ForSelection
    }
}
