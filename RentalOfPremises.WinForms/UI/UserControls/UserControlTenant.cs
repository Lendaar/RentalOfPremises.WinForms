﻿using MaterialSkin;
using RentalOfPremises.WinForms.BusinessLogic;
using RentalOfPremises.WinForms.Context.Enums;
using RentalOfPremises.WinForms.Context.General;
using RentalOfPremises.WinForms.Context.Models;
using RentalOfPremises.WinForms.General;
using RentalOfPremises.WinForms.General.Styles;
using RentalOfPremises.WinForms.UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.UI.UserControls
{
    public partial class UserControlTenant : UserControl
    {
        public List<TenantResponse> Tenants = new List<TenantResponse>();
        public UserControlTenant()
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
            var record = (TenantResponse)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить арендатора \"{record.Title}\"?", "Информация", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                HttpClient.DeleteData(record.Id, "Tenant/");
                UserControlTenant_Load(sender, e);
            }
        }

        private void materialButton_change_Click(object sender, EventArgs e)
        {
            var tenantChange = (TenantResponse)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            var form = new FormAddOrChangeTenant(tenantChange);
            form.ShowDialog();
            UserControlTenant_Load(sender, e);
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            var form = new FormAddOrChangeTenant();
            form.ShowDialog();
            UserControlTenant_Load(sender, e);
        }

        public void UserControlTenant_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                var data = HttpClient.GetData<TenantResponse>("Tenant/");
                if (CloseForm.SystemClosing)
                {
                    return;
                }
                dataGridView1.DataSource = data;
                Tenants = data;

                materialButton_change.Enabled = materialButton_delete.Enabled = dataGridView1.Rows.Count > 0 && DataFromToken.RoleUser != RoleTypes.Employee;
                materialButton_allInfo.Enabled = dataGridView1.Rows.Count > 0;
                materialButton_add.Enabled = DataFromToken.RoleUser != RoleTypes.Employee;

                materialLabel_count.Text = $"Количество записей: {dataGridView1.Rows.Count} из {Tenants.Count}";
                FillListBox();
            }
        }

        private void FillListBox()
        {
            materialListBox_filter.Items.Clear();
            materialListBox_filter.Items.Add(new MaterialListBoxItem("Все"));
            foreach (TenantTypes dir in Enum.GetValues(typeof(TenantTypes)))
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
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Type")
            {
                var myStatus = GetElementsFromEnum.ParseEnum<TenantTypes>(e.Value.ToString());
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
            if (data.Tag is TenantTypes type)
            {
                var result = Tenants.Where(x => x.Type == type.ToString() && x.Title.ToLower().Contains(materialTextBox_search.Text.ToLower())).ToList();
                dataGridView1.DataSource = result;
            }
            else
            {
                dataGridView1.DataSource = Tenants.Where(x => x.Title.ToLower().Contains(materialTextBox_search.Text.ToLower())).ToList();
            }
            materialLabel_count.Text = $"Количество записей: {dataGridView1.Rows.Count} из {Tenants.Count}";
        }

        private void materialButton_allInfo_Click(object sender, EventArgs e)
        {
            var tenantChange = (TenantResponse)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
            var form = new FormAddOrChangeTenant(tenantChange, false);
            form.ShowDialog();
            UserControlTenant_Load(sender, e);
        }
    }
}
