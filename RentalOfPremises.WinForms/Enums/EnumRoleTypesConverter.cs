namespace RentalOfPremises.WinForms.Enums
{
    public class EnumRoleTypesConverter
    {
        public RoleTypes RoleType { get; set; }

        public string DislplayValue { get; set; }

        public EnumRoleTypesConverter(RoleTypes roleType)
        {
            this.RoleType = roleType;
            DislplayValue = roleType.PerevodDescription() ?? string.Empty;
        }
    }
}
