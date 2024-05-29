using MaterialSkin.Controls;
using RentalOfPremises.WinForms.BL;
using RentalOfPremises.WinForms.General;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormAuthorization : MaterialForm
    {
        public FormAuthorization()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
        }

        private void materialButton2_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void materialButton1_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(materialTextBox_login.Text) && !string.IsNullOrWhiteSpace(materialTextBox_password.Text))
            {
                var result = HttpClient.SignIn(materialTextBox_login.Text, materialTextBox_password.Text);
                if (result)
                {
                    CloseForm.SystemClosing = false;
                    materialTextBox_login.Clear();
                    materialTextBox_password.Clear();
                    this.Hide();
                    FormMain form = new FormMain();
                    form.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
