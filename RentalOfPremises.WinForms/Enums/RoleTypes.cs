using System.ComponentModel;

namespace RentalOfPremises.WinForms.Enums
{
    /// <summary>
    /// Роли пользователей
    /// </summary>
    public enum RoleTypes
    {
        /// <summary>
        /// Работник
        /// </summary>
        [Description("Работник")]
        Employee,

        /// <summary>
        /// Старший сотрудник
        /// </summary>
        [Description("Ст. работник")]
        SeniorEmployee,

        /// <summary>
        /// Администратор
        /// </summary>
        [Description("Администратор")]
        Administrator
    }
}
