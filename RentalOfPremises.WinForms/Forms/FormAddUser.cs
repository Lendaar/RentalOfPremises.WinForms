using MaterialSkin.Controls;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormAddUser : MaterialForm
    {
        public FormAddUser()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
        }

        private void materialButton1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void materialButton2_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
