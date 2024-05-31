using RentalOfPremises.WinForms.BusinessLogic;
using RentalOfPremises.WinForms.Context.Models;
using RentalOfPremises.WinForms.General;
using RentalOfPremises.WinForms.General.Styles;
using RentalOfPremises.WinForms.UI.Forms;
using System;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.UI.UserControls
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
            ((Form)this.TopLevelControl).Close();
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            var form = new FormAddOrChangePrice();
            form.ShowDialog();
            UserControlPrice_Load(sender, e);
        }

        public void UserControlPrice_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                var data = HttpClient.GetData<PriceResponse>("Price/");
                if (CloseForm.SystemClosing)
                {
                    return;
                }
                dataGridView1.DataSource = data;
                materialLabel_count.Text = "Количество записей: " + dataGridView1.Rows.Count;
            }
        }
    }
}
