using MaterialSkin;
using RentalOfPremises.WinForms.BL;
using RentalOfPremises.WinForms.Enums;
using RentalOfPremises.WinForms.Forms;
using RentalOfPremises.WinForms.General;
using RentalOfPremises.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.UserControls
{
    public partial class UserControlUser : UserControl
    {
        public List<UserResponse> Users = new List<UserResponse>();
        public UserControlUser()
        {
            InitializeComponent();
            dataGridView1.Stylization();
        }

        private void materialButton_exit_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }

        private void materialButton_delete_Click(object sender, EventArgs e)
        {
            var record = (UserResponse)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить {record.FIO}?", "Информация", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                HttpClient.DeleteData(record.Id, "User/");
                UserControlUser_Load(sender, e);
            }
        }

        private void materialButton_change_Click(object sender, EventArgs e)
        {
            var userChange = (UserResponse)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            var form = new FormAddOrChangeUser(userChange);
            form.ShowDialog();
            UserControlUser_Load(sender, e);
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            var form = new FormAddOrChangeUser();
            form.ShowDialog();
            UserControlUser_Load(sender, e);
        }

        public void UserControlUser_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                var data = HttpClient.GetData<UserResponse>("User/");
                if (CloseForm.SystemClosing)
                {
                    return;
                }
                data.ForEach(x => x.InitFio());
                dataGridView1.DataSource = data;
                Users = data;
                FillListBox();
                materialLabel_count.Text = $"Количество записей: {dataGridView1.Rows.Count} из {Users.Count}";
            }
        }

        private void FillListBox()
        {
            materialListBox_filter.Items.Clear();
            materialListBox_filter.Items.Add(new MaterialListBoxItem("Все"));
            foreach (RoleTypes dir in Enum.GetValues(typeof(RoleTypes)))
            {
                var materialSkikItem = new MaterialListBoxItem();
                materialSkikItem.Text = dir.PerevodDescription();
                materialSkikItem.Tag = dir;
                materialListBox_filter.Items.Add(materialSkikItem);
            }
            materialListBox_filter.SelectedIndex = 0;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "RoleUser")
            {
                var myStatus = GetElementsFromEnum.ParseEnum<RoleTypes>(e.Value.ToString());
                e.Value = myStatus.PerevodDescription();
            }
        }

        private void materialListBox_filter_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            WorkWithData();
        }

        private void materialTextBox_search_TextChanged(object sender, EventArgs e)
        {
            WorkWithData();
        }

        public void WorkWithData()
        {
            var data = materialListBox_filter.SelectedItem;
            if (data.Tag is RoleTypes employee)
            {
                var result = Users.Where(x => x.RoleUser == employee.ToString() && x.FIO.ToLower().Contains(materialTextBox_search.Text.ToLower())).ToList();
                dataGridView1.DataSource = result;
            }
            else
            {
                dataGridView1.DataSource = Users.Where(x => x.FIO.ToLower().Contains(materialTextBox_search.Text.ToLower())).ToList();
            }
            materialLabel_count.Text = $"Количество записей: {dataGridView1.Rows.Count} из {Users.Count}";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            materialButton_change.Enabled = materialButton_delete.Enabled = dataGridView1.SelectedRows.Count > 0;
        }
    }
}
