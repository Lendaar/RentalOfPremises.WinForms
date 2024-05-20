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
            switch (materialTabControl1.SelectedIndex)
            {
                case 5:
                    userControlUser3.UserControlUser_Load(sender, e); break;
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
        }
    }
}
