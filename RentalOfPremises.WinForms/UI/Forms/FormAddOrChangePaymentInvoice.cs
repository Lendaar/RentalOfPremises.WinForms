using MaterialSkin.Controls;
using RentalOfPremises.Api.Models;
using RentalOfPremises.Api.ModelsRequest.PaymentInvoice;
using RentalOfPremises.WinForms.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormAddOrChangePaymentInvoice : MaterialForm
    {
        private PaymentInvoiceRequest PaymentInvoice = new PaymentInvoiceRequest();
        private List<ContractResponse> Contracts = new List<ContractResponse>();

        private DialogResult Dialog = DialogResult.None;

        public FormAddOrChangePaymentInvoice()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);

            var data = HttpClient.GetData<ContractResponse>("Contract/");
            if (data.Count != 0)
            {
                foreach (var num in data.GroupBy(x => x.Number))
                {
                    Contracts.Add(data.FirstOrDefault(x => x.Number == num.Key));
                }
                materialComboBox_dogovorNumber.DataSource = Contracts;
                materialComboBox_dogovorNumber.DisplayMember = "Number";
                materialComboBox_dogovorNumber.ValueMember = "Number";

                FillComboBoxPeriods(data.First());
            }
        }

        private void materialButton_save_Click(object sender, EventArgs e)
        {
            PaymentInvoice.Electricity = int.TryParse(materialTextBox_electro.Text, out var value) ? value : 0;
            PaymentInvoice.WaterPl = int.TryParse(materialTextBox_waretIn.Text, out value) ? value : 0;
            PaymentInvoice.WaterMi = PaymentInvoice.WaterPl;
            PaymentInvoice.PassPerson = int.TryParse(materialTextBox_propuskHuman.Text, out value) ? value : 0;
            PaymentInvoice.PassLegСar = int.TryParse(materialTextBox_propuskLegAvto.Text, out value) ? value : 0;
            PaymentInvoice.PassGrСar = int.TryParse(materialTextBox_propuskGruzAvto.Text, out value) ? value : 0;

            PaymentInvoice.NumberContract = ((ContractResponse)materialComboBox_dogovorNumber.SelectedItem).Number;
            PaymentInvoice.PeriodPayment = (int)materialComboBox_period.SelectedValue;

            Dialog = HttpClient.CreateData(PaymentInvoice, "PaymentInvoice/");
            if (Dialog == DialogResult.OK)
            {
                Close();
            }
        }

        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialTextBox_electro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void materialComboBox_dogovorNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            var data = Contracts.FirstOrDefault(x => x.Number == ((ContractResponse)materialComboBox_dogovorNumber.SelectedItem).Number);
            materialLabel_dateStart.Text = data.DateStart.Date.ToShortDateString();
            materialLabel_dateEnd.Text = data.DateEnd.Date.ToShortDateString();
            materialLabel_tenantTitle.Text = data.TenantTitle;
            FillComboBoxPeriods(data);
        }

        private void FillComboBoxPeriods(ContractResponse contract)
        {
            var period = contract.DateEnd.Month - contract.DateStart.Month;
            var periods = new List<Tuple<int, string>>();
            for (int i = 1; i <= period; i++)
            {
                var number = contract.DateStart.Month + i;
                periods.Add(new Tuple<int, string>(number, $"{number} месяц"));
            }
            materialComboBox_period.DataSource = periods;
            materialComboBox_period.DisplayMember = "Item2";
            materialComboBox_period.ValueMember = "Item1";

            materialComboBox_period.SelectedIndex = 0;
            materialComboBox_period.Enabled = true;
        }
    }
}
