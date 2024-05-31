using MaterialSkin;
using MaterialSkin.Controls;

namespace RentalOfPremises.WinForms.General.Styles
{
    public static class InitMaterial
    {
        public static void GetUI(MaterialForm form)
        {
            var material = MaterialSkinManager.Instance;
            material.AddFormToManage(form);
            material.Theme = MaterialSkinManager.Themes.LIGHT;
            material.ColorScheme = new ColorScheme(Primary.Blue200, Primary.LightBlue300, Primary.Blue500, Accent.Blue100, TextShade.BLACK);
        }
    }
}
