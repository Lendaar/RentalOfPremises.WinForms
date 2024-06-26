﻿using System.ComponentModel;

namespace RentalOfPremises.WinForms.Context.Enums
{
    /// <summary>
    /// Тип организации
    /// </summary>
    public enum TenantTypes
    {
        /// <summary>
        /// Юр лицо
        /// </summary>
        [Description("Юридическое лицо")]
        Legal,

        /// <summary>
        /// ИП
        /// </summary>
        [Description("Индивидуальный предприниматель")]
        Individual
    }
}
