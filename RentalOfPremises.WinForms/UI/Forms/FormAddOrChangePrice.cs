using MaterialSkin.Controls;
using RentalOfPremises.Api.ModelsRequest.Price;
using RentalOfPremises.WinForms.BL;
using System;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormAddOrChangePrice : MaterialForm
    {
        private readonly PriceRequest Price;

        private DialogResult Dialog = DialogResult.None;

        public FormAddOrChangePrice()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
            Price = new PriceRequest();
        }

        private async void materialButton_save_Click(object sender, System.EventArgs e)
        {
            Price.Electricity = Convert.ToDecimal(materialTextBox_electro.Text);
            Price.WaterPl = Convert.ToDecimal(materialTextBox_waretIn.Text);
            Price.WaterMi = Convert.ToDecimal(materialTextBox_waterOut.Text);
            Price.PassPerson = Convert.ToDecimal(materialTextBox_propuskHuman.Text);
            Price.PassLegСar = Convert.ToDecimal(materialTextBox_propuskLegAvto.Text);
            Price.PassGrСar = Convert.ToDecimal(materialTextBox_propuskGruzAvto.Text);
            Dialog = await HttpClient.CreateData(Price, "Price/");
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
