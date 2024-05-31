using System.Drawing;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.General.Styles
{
    public static class DataGridVeiwStyle
    {
        public static void Stylization(this DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.FromArgb(255, 230, 230, 230);
            dgv.EnableHeadersVisualStyles = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;

            dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 200);
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 130, 177, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(126, 126, 126);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = false;
        }
    }
}
