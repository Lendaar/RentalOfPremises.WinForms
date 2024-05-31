using RentalOfPremises.WinForms.Context.Enums;

namespace RentalOfPremises.WinForms.Context.General
{
    public static class DataFromToken
    {
        /// <summary>
        /// Роль пользователя
        /// </summary>
        public static RoleTypes RoleUser { get; set; } = RoleTypes.Employee;

        /// <summary>
        /// Токен
        /// </summary>
        public static string Token { get; set; } = string.Empty;
    }
}
