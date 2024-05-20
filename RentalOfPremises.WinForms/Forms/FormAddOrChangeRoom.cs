using MaterialSkin.Controls;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormAddOrChangeRoom : MaterialForm
    {
        public FormAddOrChangeRoom()
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
