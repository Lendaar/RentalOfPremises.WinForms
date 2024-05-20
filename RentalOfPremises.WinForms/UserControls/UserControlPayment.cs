﻿using RentalOfPremises.WinForms.Forms;
using System;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.UserControls
{
    public partial class UserControlPayment : UserControl
    {
        public UserControlPayment()
        {
            InitializeComponent();
            dataGridView1.Stylization();
        }

        private void materialButton_Exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ((Form)this.TopLevelControl).Close();
            }
        }

        private void materialButton_toPDF_Click(object sender, EventArgs e)
        {

        }

        private void materialButton_delete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void materialButton_change_Click(object sender, EventArgs e)
        {

        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            //var form = new FormAddUser();
            //form.ShowDialog();
            dataGridView1.Rows.Add("fsdfsd");
        }
    }
}
