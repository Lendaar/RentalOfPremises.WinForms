﻿using MaterialSkin.Controls;
using RentalOfPremises.WinForms.BusinessLogic;
using RentalOfPremises.WinForms.Context.Enums;
using RentalOfPremises.WinForms.Context.Models;
using RentalOfPremises.WinForms.Context.ModelsRequest;
using RentalOfPremises.WinForms.General.Styles;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RentalOfPremises.WinForms.UI.Forms
{
    public partial class FormAddOrChangeUser : MaterialForm
    {
        private readonly UserRequest User = new UserRequest();

        private bool IsEdit = false;

        private DialogResult Dialog = DialogResult.None;

        public FormAddOrChangeUser()
        {
            InitializeComponent();
            InitMaterial.GetUI(this);
            User = new UserRequest();

            materialComboBox_role.Items.Clear();
            foreach (RoleTypes dir in Enum.GetValues(typeof(RoleTypes)))
            {
                materialComboBox_role.Items.Add(new EnumConverter(dir));
            }
            materialComboBox_role.DisplayMember = nameof(EnumConverter.DislplayValue);
            materialComboBox_role.SelectedIndex = 0;
        }

        public FormAddOrChangeUser(UserResponse userForChange) : this()
        {
            materialTextBox_name.Text = userForChange.Name;
            materialTextBox_surname.Text = userForChange.Surname;
            materialTextBox_patronomic.Text = userForChange.Patronymic;
            materialTextBox_login.Text = userForChange.LoginUser;
            materialComboBox_role.SelectedItem = materialComboBox_role.Items.Cast<EnumConverter>().FirstOrDefault(x => x.Type.ToString() == userForChange.RoleUser);
            User.Id = userForChange.Id;
            IsEdit = true;
            this.Text = "Изменение пользователя";
            this.materialButton_save.Text = "Изменить";
        }

        private void materialButton_save_Click(object sender, System.EventArgs e)
        {
            User.Name = materialTextBox_name.Text.Trim();
            User.Surname = materialTextBox_surname.Text.Trim();
            User.Patronymic = materialTextBox_patronomic.Text.Trim();
            User.LoginUser = materialTextBox_login.Text.Trim();
            User.PasswordUser = materialTextBox_password.Text.Trim();
            User.RoleUser = (RoleTypes)((EnumConverter)materialComboBox_role.SelectedItem).Type;
            if (!IsEdit)
            {
                Dialog = HttpClient.CreateData(User, "User/");
            }
            else
            {
                Dialog = HttpClient.UpdateData(User, "User/");
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
    }
}
