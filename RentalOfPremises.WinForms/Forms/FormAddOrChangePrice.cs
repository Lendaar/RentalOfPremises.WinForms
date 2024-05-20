using MaterialSkin.Controls;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormAddOrChangePrice : MaterialForm
    {
        public FormAddOrChangePrice()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);

        }

        private void materialButton_save_Click(object sender, System.EventArgs e)
        {
           
        }

        private void materialButton_cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
