using RentalOfPremises.WinForms.Forms;
using System;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.UserControls
{
    public partial class UserControlPrice : UserControl
    {
        public UserControlPrice()
        {
            InitializeComponent();
            dataGridView1.Stylization();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            //var form = new FormAddUser();
            //form.ShowDialog();
            dataGridView1.Rows.Add("fsdfsd");
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ((Form)this.TopLevelControl).Close();
            }
        }
    }
}
