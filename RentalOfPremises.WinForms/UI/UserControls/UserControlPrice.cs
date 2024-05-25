using RentalOfPremises.Api.Models;
using RentalOfPremises.WinForms.BL;
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
        private void materialButton_exit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ((Form)this.TopLevelControl).Close();
            }
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            var form = new FormAddOrChangePrice();
            form.ShowDialog();
            UserControlPrice_Load(sender, e);
        }

        private void UserControlPrice_Load(object sender, EventArgs e)
        {
            var data = HttpClient.GetData<PriceResponse>("Price/");
            dataGridView1.DataSource = data;
            materialLabel_count.Text = "Количество записей: " + dataGridView1.Rows.Count;
        }
    }
}
