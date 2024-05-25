using MaterialSkin.Controls;
using RentalOfPremises.Api.Enums;
using RentalOfPremises.Api.Models;
using RentalOfPremises.Api.ModelsRequest.Tenant;
using RentalOfPremises.WinForms.BL;
using RentalOfPremises.WinForms.Enums;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormAddOrChangeTenant : MaterialForm
    {

        private readonly TenantRequest Tenant;

        private bool IsEdit = false;

        private DialogResult Dialog = DialogResult.None;

        public FormAddOrChangeTenant()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
            Tenant = new TenantRequest();

            materialComboBox_type.Items.Clear();
            foreach (TenantTypes dir in Enum.GetValues(typeof(TenantTypes)))
            {
                materialComboBox_type.Items.Add(new EnumConverter(dir));
            }
            materialComboBox_type.DisplayMember = nameof(EnumConverter.DislplayValue);
            materialComboBox_type.SelectedIndex = 0;
        }

        public FormAddOrChangeTenant(TenantResponse tenantForChange) : this()
        {
            materialTextBox_name.Text = tenantForChange.Name;
            materialTextBox_surname.Text = tenantForChange.Surname;
            materialTextBox_patronomic.Text = tenantForChange.Patronymic;
            materialTextBox_title.Text = tenantForChange.Title;
            materialComboBox_type.SelectedItem = materialComboBox_type.Items.Cast<EnumConverter>().FirstOrDefault(x => x.Type.ToString() == tenantForChange.Type);
            materialMaskedTextBox_telephone.Text = tenantForChange.Telephone;
            materialTextBox_email.Text = tenantForChange.Email;
            materialMultiLineTextBox_address.Text = tenantForChange.Address;

            materialMaskedTextBox_INN.Text = tenantForChange.Inn;
            materialMaskedTextBox_KPP.Text = tenantForChange.Kpp;
            materialMaskedTextBox_rs.Text = tenantForChange.Rs;
            materialMaskedTextBox_ks.Text = tenantForChange.Ks;
            materialMaskedTextBox_bik.Text = tenantForChange.Bik;
            materialTextBox_bank.Text = tenantForChange.Bank;
            materialMaskedTextBox_okpo.Text = tenantForChange.Okpo;
            materialMaskedTextBox_ogrn.Text = tenantForChange.Ogrn;

            Tenant.Id = tenantForChange.Id;
            IsEdit = true;
            this.Text = "Изменение арендатора";
            this.materialButton_save.Text = "Изменить";
        }

        public FormAddOrChangeTenant(TenantResponse tenantForChange, bool view) : this(tenantForChange)
        {
            materialButton_cancel.Text = "Назад";
            this.Text = "Информация об арендаторе";
            materialButton_save.Visible = view;
            BlockAllControls(this);
        }

        private void materialButton_save_Click(object sender, System.EventArgs e)
        {
            Tenant.Name = materialTextBox_name.Text.Trim();
            Tenant.Surname = materialTextBox_surname.Text.Trim();
            Tenant.Patronymic = materialTextBox_patronomic.Text.Trim();
            Tenant.Title = materialTextBox_title.Text.Trim();
            Tenant.Type = (TenantTypes)((EnumConverter)materialComboBox_type.SelectedItem).Type;
            Tenant.Telephone = materialMaskedTextBox_telephone.Text.Trim();
            Tenant.Email = materialTextBox_email.Text.Trim();
            Tenant.Address = materialMultiLineTextBox_address.Text.Trim();

            Tenant.Inn = materialMaskedTextBox_INN.Text;
            Tenant.Kpp = materialMaskedTextBox_KPP.Enabled ? materialMaskedTextBox_KPP.Text : "";
            Tenant.Rs = materialMaskedTextBox_rs.Text;
            Tenant.Ks = materialMaskedTextBox_ks.Text;
            Tenant.Bik = materialMaskedTextBox_bik.Text;
            Tenant.Bank = materialTextBox_bank.Text.Trim();
            Tenant.Okpo = materialMaskedTextBox_okpo.Text;
            Tenant.Ogrn = materialMaskedTextBox_ogrn.Text;

            if (!IsEdit)
            {
                Dialog = HttpClient.CreateData(Tenant, "Tenant/");
            }
            else
            {
                Dialog = HttpClient.UpdateData(Tenant, "Tenant/");
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

        private void materialMaskedTextBox_ogrn_TextChanged(object sender, EventArgs e)
        {
                materialButton_save.Enabled = Validations();
        }

        private bool Validations()
        {
            if (materialMaskedTextBox_telephone.Text.Contains("_"))
            {
                return false;
            }
            foreach (var control in groupBox2.Controls.OfType<MaterialMaskedTextBox>())
            {
                if (materialComboBox_type.SelectedItem == materialComboBox_type.Items.Cast<EnumConverter>().FirstOrDefault(x => x.Type.ToString() == "Individual") && control.Name == "materialMaskedTextBox_KPP")
                {
                    continue;
                }
                if (control.Text.Contains("_"))
                {
                    return false;
                }
            }
            return true;
        }

        private void materialComboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(materialComboBox_type.SelectedItem == materialComboBox_type.Items.Cast<EnumConverter>().FirstOrDefault(x => x.Type.ToString() == "Individual"))
            {
                materialMaskedTextBox_INN.Mask = "0000000000";
                materialMaskedTextBox_KPP.Enabled = false;
                materialMaskedTextBox_okpo.Mask = "0000000000";
                materialMaskedTextBox_ogrn.Mask = "000000000000000";
            }
            else
            {
                materialMaskedTextBox_INN.Mask = "000000000000";
                materialMaskedTextBox_KPP.Enabled = true;
                materialMaskedTextBox_okpo.Mask = "00000000";
                materialMaskedTextBox_ogrn.Mask = "0000000000";
            }
        }

        private void BlockAllControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(MaterialTextBox2) || c.GetType() == typeof(MaterialMaskedTextBox) ||
                    c.GetType() == typeof(MaterialComboBox) || c.GetType() == typeof(MaterialMultiLineTextBox2))
                {
                    c.Enabled = false;
                }
                else
                {
                    BlockAllControls(c);
                }
            }
        }
    }
}
