using MaterialSkin.Controls;
using RentalOfPremises.Api.Enums;
using RentalOfPremises.Api.Models;
using RentalOfPremises.Api.ModelsRequest.Room;
using RentalOfPremises.WinForms.BL;
using RentalOfPremises.WinForms.Enums;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormAddOrChangeRoom : MaterialForm
    {
        private readonly RoomRequest Room;

        private bool IsEdit = false;

        private DialogResult Dialog = DialogResult.None;

        public FormAddOrChangeRoom()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
            Room = new RoomRequest();

            materialComboBox_type.Items.Clear();
            foreach (PremisesTypes dir in Enum.GetValues(typeof(PremisesTypes)))
            {
                materialComboBox_type.Items.Add(new EnumConverter(dir));
            }
            materialComboBox_type.DisplayMember = nameof(EnumConverter.DislplayValue);
            materialComboBox_type.SelectedIndex = 0;
        }

        public FormAddOrChangeRoom(RoomResponse roomForChange) : this()
        {
            materialMaskedTextBox_liter.Text = roomForChange.Liter;
            materialTextBox_number.Text = roomForChange.NumberRoom.ToString();
            materialTextBox_area.Text = roomForChange.SquareRoom.ToString();
            materialComboBox_type.SelectedItem = materialComboBox_type.Items.Cast<EnumConverter>().FirstOrDefault(x => x.Type.ToString() == roomForChange.TypeRoom);
            Room.Id = roomForChange.Id;
            IsEdit = true;
            this.Text = "Изменение помещения";
            this.materialButton_save.Text = "Изменить";
        }

        private async void materialButton_save_Click(object sender, EventArgs e)
        {
            Room.Liter = materialMaskedTextBox_liter.Text.Trim();
            Room.NumberRoom = Convert.ToInt32(materialTextBox_number.Text);
            Room.SquareRoom = Math.Round(Convert.ToDouble(materialTextBox_area.Text), 2);
            Room.TypeRoom = (PremisesTypes)((EnumConverter)materialComboBox_type.SelectedItem).Type;
            if (!IsEdit)
            {
                Dialog = await HttpClient.CreateData(Room, "Room/");
            }
            else
            {
                Dialog = await HttpClient.UpdateData(Room, "Room/");
            }
            if (Dialog == DialogResult.OK)
            {
                Close();
            }
        }

        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialTextBox_area_KeyPress(object sender, KeyPressEventArgs e)
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

        private void materialTextBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
