using MaterialSkin;
using RentalOfPremises.WinForms.BusinessLogic;
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
    public partial class UserControlContract : UserControl
    {
        public List<ContractResponse> Contracts = new List<ContractResponse>();

        public List<ContractResponse> ContractsOnView = new List<ContractResponse>();
        public UserControlContract()
        {
            InitializeComponent();
            dataGridView1.Stylization();
        }

        private void materialButton_exit_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void materialButton_toPDF_Click(object sender, EventArgs e)
        {
            try
            {
                var number = ((ContractResponse)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem).Number;
                var data = HttpClient.GetDocument($"Contract/Document?id={number}");
                if (CloseForm.SystemClosing)
                {
                    return;
                }
                saveFileDialog.FileName = $"Договор аренды №{number}";
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
            var listIdContractResponse = new List<Guid>();
            var number = (int)dataGridView1.CurrentRow.Cells[0].Value;
            foreach (var contract in Contracts.Where(x => x.Number == number))
            {
                listIdContractResponse.Add(contract.Id);
            }
            if (MessageBox.Show($"Вы действительно хотите удалить договор №{number}?", "Информация", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                HttpClient.DeleteDataList(listIdContractResponse, "Contract/");
                UserControlContract_Load(sender, e);
            }
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            var form = new FormAddOrChangeContract();
            form.ShowDialog();
            UserControlContract_Load(sender, e);
        }

        public void UserControlContract_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                var data = HttpClient.GetData<ContractResponse>("Contract/");
                if (CloseForm.SystemClosing)
                {
                    return;
                }
                Contracts = data;
                ContractsOnView.Clear();
                foreach (var num in data.GroupBy(x => x.Number))
                {
                    ContractsOnView.Add(data.FirstOrDefault(x => x.Number == num.Key));
                }
                dataGridView1.DataSource = ContractsOnView;

                CurrencyManager cm = (CurrencyManager)this.dataGridView1.BindingContext[ContractsOnView];
                if (cm != null)
                {
                    cm.Refresh();
                }

                FillArendRooms();
                materialLabel_count.Text = $"Количество записей: {dataGridView1.Rows.Count} из {ContractsOnView.Count}";
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "DateStart")
            {
                var date = (DateTimeOffset)e.Value;
                e.Value = date.Date.ToShortDateString();
            }
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "DateEnd")
            {
                var date = (DateTimeOffset)e.Value;
                e.Value = date.Date.ToShortDateString();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            materialButton_delete.Enabled = materialButton_toPDF.Enabled = dataGridView1.SelectedRows.Count > 0;
            FillArendRooms();
        }

        private void FillArendRooms()
        {
            materialListBox_roomInArend.Items.Clear();
            if (dataGridView1.Rows.Count != 0 && dataGridView1.SelectedRows.Count != 0)
            {
                var number = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                foreach (var contract in Contracts.Where(x => x.Number == number))
                {
                    materialListBox_roomInArend.Items.Add(new MaterialListBoxItem($"{contract.Payment} ₽ | {contract.RoomLiter} | {contract.RoomNumber}"));
                }
            }
        }

        private void materialTextBox_search_TextChanged(object sender, EventArgs e)
        {
            if (materialTextBox_search.Text != string.Empty)
            {
                var result = ContractsOnView.Where(x => x.TenantTitle.ToLower().Contains(materialTextBox_search.Text.ToLower())).ToList();
                dataGridView1.DataSource = result;
                materialLabel_count.Text = $"Количество записей: {dataGridView1.Rows.Count} из {ContractsOnView.Count}";
            }
            else
            {
                UserControlContract_Load(sender, e);
            }
        }
    }
}
