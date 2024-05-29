using System.Collections.Generic;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.General
{
    public static class CloseForm
    {
        public static bool SystemClosing = false;
        public static void Close()
        {
            SystemClosing = true;
            List<Form> openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
            {
                openForms.Add(f);
            }
            foreach (Form f in openForms)
            {
                if (f.Name != "FormAuthorization")
                    f.Close();
            }
        }
    }
}
