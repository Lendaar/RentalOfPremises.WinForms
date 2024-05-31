using MaterialSkin.Controls;
using RentalOfPremises.WinForms.BusinessLogic;
using RentalOfPremises.WinForms.Context.Models;
using RentalOfPremises.WinForms.Context.ModelsRequest;
using RentalOfPremises.WinForms.General.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.UI.Forms
{
    public partial class FormAddOrChangeContract : MaterialForm
    {
        private readonly ContractRequest Contract = new ContractRequest();

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

        private void materialButton_save_Click(object sender, System.EventArgs e)
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
                return;
            }
            if (materialComboBox_arendator.SelectedValue == null)
            {
                MessageBox.Show("Для составления договора не выбрано ни одного арендатора!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (materialTextBox_period.Text == string.Empty)
            {
                MessageBox.Show("Для составления договора не указан период аренды!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

            if (Dialog == DialogResult.OK)
            {
                Close();
            }
        }

        private void materialButton_cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void FillTenants()
        {
            var tenants = HttpClient.GetData<TenantResponse>("Tenant/");
            materialComboBox_arendator.DataSource = tenants;
            materialComboBox_arendator.ValueMember = "Id";
            materialComboBox_arendator.DisplayMember = "Title";
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
