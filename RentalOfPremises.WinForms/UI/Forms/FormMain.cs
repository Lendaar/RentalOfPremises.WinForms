using MaterialSkin.Controls;
using RentalOfPremises.WinForms.Context.Enums;
using RentalOfPremises.WinForms.Context.General;
using RentalOfPremises.WinForms.General;
using RentalOfPremises.WinForms.General.Styles;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.UI.Forms
{
    public partial class FormMain : MaterialForm
    {
        public FormMain()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
            materialTabControl1.SelectedIndex = 0;

            if (DataFromToken.RoleUser != RoleTypes.Administrator)
            {
                tabPage6.Dispose();
            }
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.Text = materialTabControl1.SelectedTab.Tag.ToString();
            if (CloseForm.SystemClosing)
            {
                return;
            }
            switch (materialTabControl1.SelectedIndex)
            {
                case 0:
                    userControlContract1.UserControlContract_Load(sender, e);
                    break;
                case 1:
                    userControlPayment1.UserControlPayment_Load(sender, e);
                    break;
                case 2:
                    userControlRoom1.UserControlRoom_Load(sender, e);
                    break;
                case 3:
                    userControlTenant1.UserControlTenant_Load(sender, e);
                    break;
                case 4:
                    userControlPrice1.UserControlPrice_Load(sender, e);
                    break;
                case 5:
                    userControlUser3.UserControlUser_Load(sender, e);
                    break;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CloseForm.SystemClosing)
            {
                var dialogResult = MessageBox.Show("Вы действительно хотите выйти из учетной записи?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
