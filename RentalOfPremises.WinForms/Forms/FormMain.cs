using MaterialSkin.Controls;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormMain : MaterialForm
    {
        public FormMain()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
            materialTabControl1.SelectedIndex = 0;
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.Text = materialTabControl1.SelectedTab.Tag.ToString();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
        }
    }
}
