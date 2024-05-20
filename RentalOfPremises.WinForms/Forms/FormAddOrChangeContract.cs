using MaterialSkin.Controls;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormAddOrChangeContract : MaterialForm
    {
        public FormAddOrChangeContract()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
            dataGridView1.Stylization();
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
