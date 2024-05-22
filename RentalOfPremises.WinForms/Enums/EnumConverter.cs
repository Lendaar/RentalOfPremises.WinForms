using System;

namespace RentalOfPremises.WinForms.Enums
{
    public class EnumConverter
    {
        public Enum Type { get; set; }

        public string DislplayValue { get; set; }

        public EnumConverter(Enum roleType)
        {
            this.Type = roleType;
            DislplayValue = roleType.PerevodDescription() ?? string.Empty;
        }
    }
}
