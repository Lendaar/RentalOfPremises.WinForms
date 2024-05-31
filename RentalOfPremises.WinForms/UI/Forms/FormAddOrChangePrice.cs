using MaterialSkin.Controls;
using RentalOfPremises.WinForms.BusinessLogic;
using RentalOfPremises.WinForms.Context.ModelsRequest;
using RentalOfPremises.WinForms.General.Styles;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.UI.Forms
{
    public partial class FormAddOrChangePrice : MaterialForm
    {
        private readonly PriceRequest Price = new PriceRequest();

        private DialogResult Dialog = DialogResult.None;

        public FormAddOrChangePrice()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
        }

        private void materialButton_save_Click(object sender, System.EventArgs e)
        {
            Price.Electricity = decimal.TryParse(materialTextBox_electro.Text, out var value) ? value : 0;
            Price.WaterPl = decimal.TryParse(materialTextBox_waretIn.Text, out value) ? value : 0;
            Price.WaterMi = decimal.TryParse(materialTextBox_waterOut.Text, out value) ? value : 0;
            Price.PassPerson = decimal.TryParse(materialTextBox_propuskHuman.Text, out value) ? value : 0;
            Price.PassLegСar = decimal.TryParse(materialTextBox_propuskLegAvto.Text, out value) ? value : 0;
            Price.PassGrСar = decimal.TryParse(materialTextBox_propuskGruzAvto.Text, out value) ? value : 0;
            Dialog = HttpClient.CreateData(Price, "Price/");
            if (Dialog == DialogResult.OK)
            {
                Close();
            }
        }

        private void materialButton_cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void materialTextBox_electro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
