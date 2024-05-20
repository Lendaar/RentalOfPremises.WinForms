using MaterialSkin.Controls;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormAddOrChangeTenant : MaterialForm
    {
        public FormAddOrChangeTenant()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
        }

        private void materialButton2_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void materialButton1_Click_2(object sender, System.EventArgs e)
        {
            materialMaskedTextBox1.Mask = "000";
        }
    }
}
