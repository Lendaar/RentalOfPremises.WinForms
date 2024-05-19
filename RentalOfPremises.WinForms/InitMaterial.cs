using MaterialSkin;
using MaterialSkin.Controls;

namespace RentalOfPremises.WinForms
{
    public static class InitMaterial
    {
        public static void GetUI(MaterialForm form)
        {
            var material = MaterialSkinManager.Instance;
            material.AddFormToManage(form);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Grey50, Primary.Grey600, Primary.Grey900, Accent.Blue100, TextShade.BLACK);
        }
    }
}
