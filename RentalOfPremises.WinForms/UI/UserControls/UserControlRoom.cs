using MaterialSkin;
using RentalOfPremises.Api.Enums;
using RentalOfPremises.Api.Models;
using RentalOfPremises.WinForms.BL;
using RentalOfPremises.WinForms.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.UserControls
{
    public partial class UserControlRoom : UserControl
    {
        public List<RoomResponse> Rooms = new List<RoomResponse>();
        public UserControlRoom()
        {
            InitializeComponent();
            dataGridView1.Stylization();
            FillListBox();
        }

        private void materialButton_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ((Form)this.TopLevelControl).Close();
            }
        }

        private void materialButton_delete_Click(object sender, EventArgs e)
        {
            var record = (RoomResponse)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить помещение {record.Liter} - {record.NumberRoom}?", "Информация", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                HttpClient.DeleteData(record.Id, "Room/");
                UserControlRoom_Load(sender, e);
            }
        }

        private void materialButton_change_Click(object sender, EventArgs e)
        {
            var roomChange = (RoomResponse)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            var form = new FormAddOrChangeRoom(roomChange);
            form.ShowDialog();
            UserControlRoom_Load(sender, e);
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            var form = new FormAddOrChangeRoom();
            form.ShowDialog();
            UserControlRoom_Load(sender, e);
        }

        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            var data = HttpClient.GetData<RoomResponse>("Room/");
            dataGridView1.DataSource = data;
            Rooms = data;
            materialLabel_count.Text = "Количество записей: " + dataGridView1.Rows.Count;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "TypeRoom")
            {
                var myStatus = GetElementsFromEnum.ParseEnum<PremisesTypes>(e.Value.ToString());
                e.Value = myStatus.PerevodDescription();
            }
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "SquareRoom")
            {
                e.Value = e.Value + " м²";
            }
        }

        private void FillListBox()
        {
            materialListBox_filter.Items.Clear();
            materialListBox_filter.Items.Add(new MaterialListBoxItem("Все"));
            materialListBox_filter.Items.Add(new MaterialListBoxItem("Арендовано"));
            materialListBox_filter.Items.Add(new MaterialListBoxItem("Свободно"));
            materialListBox_filter.SelectedIndex = 0;
        }

        private void materialListBox_filter_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            WorkOnData();
        }

        private void materialTextBox_search_TextChanged(object sender, EventArgs e)
        {
            WorkOnData();
        }

        public void WorkOnData()
        {
            var index = materialListBox_filter.SelectedIndex;

            switch (materialListBox_filter.SelectedIndex)
            {
                case 0: dataGridView1.DataSource = Rooms.Where(x => x.Liter.ToLower().Contains(materialTextBox_search.Text.ToLower())).ToList(); break;
                case 1: dataGridView1.DataSource = Rooms.Where(x => x.Occupied == true && x.Liter.ToLower().Contains(materialTextBox_search.Text.ToLower())).ToList(); break;
                case 2: dataGridView1.DataSource = Rooms.Where(x => x.Occupied == false && x.Liter.ToLower().Contains(materialTextBox_search.Text.ToLower())).ToList(); break;
            }
            materialLabel_count.Text = "Количество записей: " + dataGridView1.Rows.Count;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            materialButton_change.Enabled = materialButton_delete.Enabled = dataGridView1.SelectedRows.Count > 0;
        }
    }
}
