﻿using MaterialSkin.Controls;
using RentalOfPremises.Api.Models;
using RentalOfPremises.Api.ModelsRequest.Contract;
using RentalOfPremises.WinForms.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormAddOrChangeContract : MaterialForm
    {
        private readonly ContractRequest Contract = new ContractRequest();

        private bool IsEdit = false;

        private DialogResult Dialog = DialogResult.None;
        public FormAddOrChangeContract()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
            dataGridView1.Stylization();
            FillTenants();
            FillRooms();
            dateTimePicker_dateStart.MinDate = DateTime.Now.Date;
        }

        public FormAddOrChangeContract(List<ContractResponse> contractResponses) : this() 
        {
            FillTenants(contractResponses[0]);
            materialTextBox_period.Text = (contractResponses[0].DateEnd.Month - contractResponses[0].DateStart.Month).ToString();
            dateTimePicker_dateStart.Value = contractResponses[0].DateStart.Date;
            IsEdit = true;
        }


        private void materialButton_save_Click(object sender, System.EventArgs e)
        {
            if (!IsEdit)
            {
                var roomsForArenda = new List<DataGridViewRow>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    object value = row.Cells[1].Value;
                    if (value != null && (Boolean)value)
                    {
                        roomsForArenda.Add(row);
                    }
                }
                if (roomsForArenda.Count == 0)
                {
                    MessageBox.Show("Для составления договора не выбрано ни одного помещения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Validation(roomsForArenda))
                {
                    var number = HttpClient.GetNumber("Contract/MaxNumber");
                    foreach (DataGridViewRow row in roomsForArenda)
                    {
                        Contract.Payment = Convert.ToDecimal(row.Cells[2].Value);
                        Contract.Room = ((RoomResponse)row.DataBoundItem).Id;
                        Contract.Tenant = (Guid)materialComboBox_arendator.SelectedValue;
                        Contract.DateStart = dateTimePicker_dateStart.Value.ToUniversalTime();
                        Contract.DateEnd = dateTimePicker_dateStart.Value.AddMonths(Convert.ToInt32(materialTextBox_period.Text)).ToUniversalTime();
                        Contract.Number = number;

                        Dialog = HttpClient.CreateData(Contract, "Contract/");
                    }
                }
            }
            else
            {

            }
            if (Dialog == DialogResult.OK)
            {
                Close();
            }
        }

        private void materialButton_cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void FillTenants(ContractResponse contract = null)
        {
            var tenants = HttpClient.GetData<TenantResponse>("Tenant/");
            materialComboBox_arendator.DataSource = tenants;
            materialComboBox_arendator.ValueMember = "Id";
            materialComboBox_arendator.DisplayMember = "Title";
            if (contract == null)
            {
                materialComboBox_arendator.SelectedIndex = 0;
            }
            else
            {
                materialComboBox_arendator.SelectedItem = materialComboBox_arendator.Items.Cast<TenantResponse>().FirstOrDefault(x => x.Inn == contract.TenantInn);
            }
        }

        private void FillRooms()
        {
            var rooms = HttpClient.GetData<RoomResponse>("Room/");
            var noOccupiedRooms = rooms.Where(x => x.Occupied == false).ToList();
            noOccupiedRooms.ForEach(x => x.InitLiterNumber());
            dataGridView1.DataSource = noOccupiedRooms;
        }

        private bool Validation(List<DataGridViewRow> listRows)
        {
            foreach (DataGridViewRow row in listRows)
            {
                if (row.Cells[2].Value == null)
                {
                    MessageBox.Show("Укажите цену аренды для выбранных помещений!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void materialTextBox21_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 2)
            {
                e.Control.KeyPress += new KeyPressEventHandler(DGV_KeyPress);
            }
        }

        private void DGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}