using MaterialSkin.Controls;
using RentalOfPremises.WinForms.BL;
using RentalOfPremises.WinForms.Enums;
using RentalOfPremises.WinForms.Models;
using RentalOfPremises.WinForms.ModelsRequest.User;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.Forms
{
    public partial class FormAddOrChangeUser : MaterialForm
    {
        private readonly UserRequest user;
        public UserRequest User => user;

        private bool IsEdit = false;

        private DialogResult Dialog = DialogResult.None;

        public FormAddOrChangeUser()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
            user = new UserRequest();

            materialComboBox_role.Items.Clear();
            foreach (RoleTypes dir in Enum.GetValues(typeof(RoleTypes)))
            {
                materialComboBox_role.Items.Add(new EnumRoleTypesConverter(dir));
            }
            materialComboBox_role.DisplayMember = nameof(EnumRoleTypesConverter.DislplayValue);
            materialComboBox_role.SelectedIndex = 0;
        }

        public FormAddOrChangeUser(UserResponse userForChange) : this()
        {
            materialTextBox_name.Text = userForChange.Name;
            materialTextBox_surname.Text = userForChange.Surname;
            materialTextBox_patronomic.Text = userForChange.Patronymic;
            materialTextBox_login.Text = userForChange.LoginUser;
            materialComboBox_role.SelectedItem = materialComboBox_role.Items.Cast<EnumRoleTypesConverter>().FirstOrDefault(x => x.RoleType.ToString() == userForChange.RoleUser);
            user.Id = userForChange.Id;
            IsEdit = true;
            this.Text = "Изменение пользователя";
            this.materialButton_save.Text = "Изменить";
        }

        private async void materialButton_save_Click(object sender, System.EventArgs e)
        {
            user.Name = materialTextBox_name.Text;
            user.Surname = materialTextBox_surname.Text;
            user.Patronymic = materialTextBox_patronomic.Text;
            user.LoginUser = materialTextBox_login.Text;
            user.PasswordUser = materialTextBox_password.Text;
            user.RoleUser = ((EnumRoleTypesConverter)materialComboBox_role.SelectedItem).RoleType;
            if (!IsEdit)
            {
                Dialog = await UserHttpClient.CreateUser(user);
            }
            else
            {
                Dialog = await UserHttpClient.UpdateUser(user);
            }
            if(Dialog == DialogResult.OK)
            {
                Close(); 
            }
        }

        private void materialButton_cancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
