using MaterialSkin;
using RentalOfPremises.WinForms.BusinessLogic;
using RentalOfPremises.WinForms.Context.Enums;
using RentalOfPremises.WinForms.Context.Models;
using RentalOfPremises.WinForms.General;
using RentalOfPremises.WinForms.General.Styles;
using RentalOfPremises.WinForms.UI.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.UI.UserControls
{
    public partial class UserControlPayment : UserControl
    {
        public List<PaymentInvoiceResponse> PaymentInvoices = new List<PaymentInvoiceResponse>();
        public UserControlPayment()
        {
            InitializeComponent();
            dataGridView1.Stylization();
        }

        private void materialButton_Exit_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void materialButton_toPDF_Click(object sender, EventArgs e)
        {
            try
            {
                var number = ((PaymentInvoiceResponse)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem).Number;
                var data = HttpClient.GetDocument($"PaymentInvoice/Payment?id={number}");
                if (CloseForm.SystemClosing)
                {
                    return;
                }
                saveFileDialog.FileName = $"Счет на оплату №{number}";
                saveFileDialog.Filter = "PDF-файл (*.pdf)|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, data);
                    MessageBox.Show("Документ создан", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        private void materialButton_delete_Click(object sender, EventArgs e)
        {
            var record = (PaymentInvoiceResponse)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить счет №{record.Number}?", "Информация", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                HttpClient.DeleteData(record.Id, "User/");
                UserControlPayment_Load(sender, e);
            }
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            var form = new FormAddOrChangePaymentInvoice();
            form.ShowDialog();
            UserControlPayment_Load(sender, e);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            materialButton_delete.Enabled = materialButton_toPDF.Enabled = dataGridView1.SelectedRows.Count > 0;
            FillArendRooms();
        }

        public void UserControlPayment_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                var data = HttpClient.GetData<PaymentInvoiceResponse>("PaymentInvoice/");
                if (CloseForm.SystemClosing)
                {
                    return;
                }
                dataGridView1.DataSource = data;
                PaymentInvoices = data;
                materialLabel_count.Text = $"Количество записей: {dataGridView1.Rows.Count} из {PaymentInvoices.Count}";
                FillArendRooms();
            }
        }

        private void materialTextBox21_TextChanged(object sender, EventArgs e)
        {
            if (materialTextBox_search.Text != string.Empty)
            {
                var result = PaymentInvoices.Where(x => x.NumberContract.ToString().Contains(materialTextBox_search.Text)).ToList();
                dataGridView1.DataSource = result;
                materialLabel_count.Text = $"Количество записей: {dataGridView1.Rows.Count} из {PaymentInvoices.Count}";
            }
            else
            {
                UserControlPayment_Load(sender, e);
            }
        }

        private void FillArendRooms()
        {
            materialListBox_Info.Items.Clear();
            if (dataGridView1.Rows.Count != 0 && dataGridView1.SelectedRows.Count != 0)
            {
                var number = (int)dataGridView1.SelectedRows[0].Cells[1].Value;
                var contracts = HttpClient.GetData<ContractResponse>("Contract/");
                var contract = contracts.FirstOrDefault(x => x.Number == number);
                materialListBox_Info.Items.Add(new MaterialListBoxItem($"Арендатор: {contract.TenantTitle}"));
                materialListBox_Info.Items.Add(new MaterialListBoxItem($"ИНН Арендатора: {contract.TenantInn}"));
                materialListBox_Info.Items.Add(new MaterialListBoxItem($"Дата начала договора: {contract.DateStart.Date.ToShortDateString()}"));
                materialListBox_Info.Items.Add(new MaterialListBoxItem($"Дата окончания договора: {contract.DateEnd.Date.ToShortDateString()}"));
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "PeriodPayment")
            {
                var myStatus = GetElementsFromEnum.ParseEnum<Months>(e.Value.ToString());
                e.Value = myStatus.PerevodDescription();
            }
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Electricity")
            {
                e.Value = e.Value + " кВт/ч";
            }
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "WaterPl")
            {
                e.Value = e.Value + " м³";
            }
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "PassPerson" ||
                dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "PassLegСar" ||
                dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "PassGrСar")
            {
                e.Value = e.Value + " шт";
            }
        }
    }
}
