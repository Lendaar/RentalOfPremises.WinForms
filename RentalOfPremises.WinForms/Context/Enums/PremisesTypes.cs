using System.ComponentModel;

namespace RentalOfPremises.WinForms.Context.Enums
{
    /// <summary>
    /// Типы помещений
    /// </summary>
    public enum PremisesTypes
    {
        /// <summary>
        /// Cобственное нежилое помещение
        /// </summary>
        [Description("Cобственное нежилое помещение")]
        OwnNonResidentialPremises,

        /// <summary>
        /// Временное бытовое помещение
        /// </summary>
        [Description("Временное бытовое помещение")]
        TemporaryLivingPremises
    }
}
