using MaterialSkin.Controls;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormAuthorization : MaterialForm
    {
        public FormAuthorization()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
        }

        private void FormAuthorization_Load(object sender, System.EventArgs e)
        {
        }

        private void materialButton2_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void materialButton1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            var form = new FormMain();
            form.ShowDialog();
            this.Show();
        }
    }
}
