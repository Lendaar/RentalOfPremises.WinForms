﻿using MaterialSkin;
using RentalOfPremises.Api.Models;
using RentalOfPremises.WinForms.BL;
using RentalOfPremises.WinForms.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.UserControls
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
            var result = MessageBox.Show("Вы действительно хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ((Form)this.TopLevelControl).Close();
            }
        }

        private void materialButton_toPDF_Click(object sender, EventArgs e)
        {
            var number = ((ContractResponse)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem).Number;
            var data = HttpClient.GetDocument($"Contract/Document?id={number}");
            saveFileDialog.FileName = $"Договор аренды №{number}";
            saveFileDialog.Filter = "PDF-файл (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog.FileName, data);
                MessageBox.Show("Документ создан", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void materialButton_delete_Click(object sender, EventArgs e)
        {
            var listContractResponse = new List<ContractResponse>();
            var number = (int)dataGridView1.CurrentRow.Cells[0].Value;
            foreach (var contract in Contracts.Where(x => x.Number == number))
            {
                listContractResponse.Add(contract);
            }
            if (MessageBox.Show($"Вы действительно хотите удалить договор №{number}?", "Информация", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                foreach (var contract in listContractResponse)
                {
                    HttpClient.DeleteData(contract.Id, "Contract/");
                }
                UserControlContract_Load(sender, e);
            }
        }

        private void materialButton_change_Click(object sender, EventArgs e)
        {
            var listContractResponse = new List<ContractResponse>();
            var number = (int)dataGridView1.CurrentRow.Cells[0].Value;
            foreach (var contract in Contracts.Where(x => x.Number == number))
            {
                listContractResponse.Add(contract);
            }
            var form = new FormAddOrChangeContract(listContractResponse);
            form.ShowDialog();
            UserControlContract_Load(sender, e);
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
            materialButton_change.Enabled = materialButton_delete.Enabled = materialButton_toPDF.Enabled = dataGridView1.SelectedRows.Count > 0;
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
            if(materialTextBox_search.Text != string.Empty)
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
