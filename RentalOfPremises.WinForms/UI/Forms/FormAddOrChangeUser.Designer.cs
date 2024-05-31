namespace RentalOfPremises.WinForms.UI.Forms
{
    partial class FormAddOrChangeUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialButton_cancel = new MaterialSkin.Controls.MaterialButton();
            this.materialButton_save = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_name = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_surname = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_patronomic = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_login = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_password = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox_role = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // materialButton_cancel
            // 
            this.materialButton_cancel.AutoSize = false;
            this.materialButton_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton_cancel.Depth = 0;
            this.materialButton_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialButton_cancel.HighEmphasis = true;
            this.materialButton_cancel.Icon = null;
            this.materialButton_cancel.Location = new System.Drawing.Point(632, 331);
            this.materialButton_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_cancel.Name = "materialButton_cancel";
            this.materialButton_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_cancel.Size = new System.Drawing.Size(266, 49);
            this.materialButton_cancel.TabIndex = 8;
            this.materialButton_cancel.Text = "Отмена";
            this.materialButton_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_cancel.UseAccentColor = false;
            this.materialButton_cancel.UseVisualStyleBackColor = true;
            this.materialButton_cancel.Click += new System.EventHandler(this.materialButton_cancel_Click);
            // 
            // materialButton_save
            // 
            this.materialButton_save.AutoSize = false;
            this.materialButton_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_save.Depth = 0;
            this.materialButton_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.materialButton_save.HighEmphasis = true;
            this.materialButton_save.Icon = null;
            this.materialButton_save.Location = new System.Drawing.Point(234, 331);
            this.materialButton_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_save.Name = "materialButton_save";
            this.materialButton_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_save.Size = new System.Drawing.Size(266, 49);
            this.materialButton_save.TabIndex = 7;
            this.materialButton_save.Text = "Создать";
            this.materialButton_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_save.UseAccentColor = false;
            this.materialButton_save.UseVisualStyleBackColor = true;
            this.materialButton_save.Click += new System.EventHandler(this.materialButton_save_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 125);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(37, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Имя:";
            // 
            // materialTextBox_name
            // 
            this.materialTextBox_name.AnimateReadOnly = false;
            this.materialTextBox_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_name.Depth = 0;
            this.materialTextBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_name.HideSelection = true;
            this.materialTextBox_name.Hint = "Введите имя";
            this.materialTextBox_name.LeadingIcon = null;
            this.materialTextBox_name.Location = new System.Drawing.Point(125, 111);
            this.materialTextBox_name.MaxLength = 100;
            this.materialTextBox_name.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_name.Name = "materialTextBox_name";
            this.materialTextBox_name.PasswordChar = '\0';
            this.materialTextBox_name.PrefixSuffixText = null;
            this.materialTextBox_name.ReadOnly = false;
            this.materialTextBox_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_name.SelectedText = "";
            this.materialTextBox_name.SelectionLength = 0;
            this.materialTextBox_name.SelectionStart = 0;
            this.materialTextBox_name.ShortcutsEnabled = true;
            this.materialTextBox_name.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox_name.TabIndex = 9;
            this.materialTextBox_name.TabStop = false;
            this.materialTextBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_name.TrailingIcon = null;
            this.materialTextBox_name.UseAccent = false;
            this.materialTextBox_name.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 195);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(74, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Фамилия:";
            // 
            // materialTextBox_surname
            // 
            this.materialTextBox_surname.AnimateReadOnly = false;
            this.materialTextBox_surname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_surname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_surname.Depth = 0;
            this.materialTextBox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_surname.HideSelection = true;
            this.materialTextBox_surname.Hint = "Введите фамилию";
            this.materialTextBox_surname.LeadingIcon = null;
            this.materialTextBox_surname.Location = new System.Drawing.Point(125, 181);
            this.materialTextBox_surname.MaxLength = 100;
            this.materialTextBox_surname.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_surname.Name = "materialTextBox_surname";
            this.materialTextBox_surname.PasswordChar = '\0';
            this.materialTextBox_surname.PrefixSuffixText = null;
            this.materialTextBox_surname.ReadOnly = false;
            this.materialTextBox_surname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_surname.SelectedText = "";
            this.materialTextBox_surname.SelectionLength = 0;
            this.materialTextBox_surname.SelectionStart = 0;
            this.materialTextBox_surname.ShortcutsEnabled = true;
            this.materialTextBox_surname.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox_surname.TabIndex = 11;
            this.materialTextBox_surname.TabStop = false;
            this.materialTextBox_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_surname.TrailingIcon = null;
            this.materialTextBox_surname.UseAccent = false;
            this.materialTextBox_surname.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(28, 265);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Отчество:";
            // 
            // materialTextBox_patronomic
            // 
            this.materialTextBox_patronomic.AnimateReadOnly = false;
            this.materialTextBox_patronomic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_patronomic.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_patronomic.Depth = 0;
            this.materialTextBox_patronomic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_patronomic.HideSelection = true;
            this.materialTextBox_patronomic.Hint = "Введите отчество";
            this.materialTextBox_patronomic.LeadingIcon = null;
            this.materialTextBox_patronomic.Location = new System.Drawing.Point(125, 251);
            this.materialTextBox_patronomic.MaxLength = 100;
            this.materialTextBox_patronomic.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_patronomic.Name = "materialTextBox_patronomic";
            this.materialTextBox_patronomic.PasswordChar = '\0';
            this.materialTextBox_patronomic.PrefixSuffixText = null;
            this.materialTextBox_patronomic.ReadOnly = false;
            this.materialTextBox_patronomic.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_patronomic.SelectedText = "";
            this.materialTextBox_patronomic.SelectionLength = 0;
            this.materialTextBox_patronomic.SelectionStart = 0;
            this.materialTextBox_patronomic.ShortcutsEnabled = true;
            this.materialTextBox_patronomic.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox_patronomic.TabIndex = 13;
            this.materialTextBox_patronomic.TabStop = false;
            this.materialTextBox_patronomic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_patronomic.TrailingIcon = null;
            this.materialTextBox_patronomic.UseAccent = false;
            this.materialTextBox_patronomic.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(562, 125);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(50, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Логин:";
            // 
            // materialTextBox_login
            // 
            this.materialTextBox_login.AnimateReadOnly = false;
            this.materialTextBox_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_login.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_login.Depth = 0;
            this.materialTextBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_login.HideSelection = true;
            this.materialTextBox_login.Hint = "Введите логин";
            this.materialTextBox_login.LeadingIcon = null;
            this.materialTextBox_login.Location = new System.Drawing.Point(659, 111);
            this.materialTextBox_login.MaxLength = 100;
            this.materialTextBox_login.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_login.Name = "materialTextBox_login";
            this.materialTextBox_login.PasswordChar = '\0';
            this.materialTextBox_login.PrefixSuffixText = null;
            this.materialTextBox_login.ReadOnly = false;
            this.materialTextBox_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_login.SelectedText = "";
            this.materialTextBox_login.SelectionLength = 0;
            this.materialTextBox_login.SelectionStart = 0;
            this.materialTextBox_login.ShortcutsEnabled = true;
            this.materialTextBox_login.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox_login.TabIndex = 15;
            this.materialTextBox_login.TabStop = false;
            this.materialTextBox_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_login.TrailingIcon = null;
            this.materialTextBox_login.UseAccent = false;
            this.materialTextBox_login.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(562, 195);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(61, 19);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "Пароль:";
            // 
            // materialTextBox_password
            // 
            this.materialTextBox_password.AnimateReadOnly = false;
            this.materialTextBox_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_password.Depth = 0;
            this.materialTextBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_password.HideSelection = true;
            this.materialTextBox_password.Hint = "Введите пароль";
            this.materialTextBox_password.LeadingIcon = null;
            this.materialTextBox_password.Location = new System.Drawing.Point(659, 181);
            this.materialTextBox_password.MaxLength = 100;
            this.materialTextBox_password.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_password.Name = "materialTextBox_password";
            this.materialTextBox_password.PasswordChar = '\0';
            this.materialTextBox_password.PrefixSuffixText = null;
            this.materialTextBox_password.ReadOnly = false;
            this.materialTextBox_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_password.SelectedText = "";
            this.materialTextBox_password.SelectionLength = 0;
            this.materialTextBox_password.SelectionStart = 0;
            this.materialTextBox_password.ShortcutsEnabled = true;
            this.materialTextBox_password.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox_password.TabIndex = 17;
            this.materialTextBox_password.TabStop = false;
            this.materialTextBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_password.TrailingIcon = null;
            this.materialTextBox_password.UseAccent = false;
            this.materialTextBox_password.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(562, 265);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(42, 19);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Роль:";
            // 
            // materialComboBox_role
            // 
            this.materialComboBox_role.AutoResize = false;
            this.materialComboBox_role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox_role.Depth = 0;
            this.materialComboBox_role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox_role.DropDownHeight = 174;
            this.materialComboBox_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox_role.DropDownWidth = 121;
            this.materialComboBox_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox_role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox_role.FormattingEnabled = true;
            this.materialComboBox_role.IntegralHeight = false;
            this.materialComboBox_role.ItemHeight = 43;
            this.materialComboBox_role.Items.AddRange(new object[] {
            "Сотрудник",
            "Ст. Сотрудник",
            "Администратор"});
            this.materialComboBox_role.Location = new System.Drawing.Point(659, 251);
            this.materialComboBox_role.MaxDropDownItems = 4;
            this.materialComboBox_role.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox_role.Name = "materialComboBox_role";
            this.materialComboBox_role.Size = new System.Drawing.Size(407, 49);
            this.materialComboBox_role.StartIndex = 0;
            this.materialComboBox_role.TabIndex = 21;
            this.materialComboBox_role.UseAccent = false;
            // 
            // FormAddOrChangeUser
            // 
            this.AcceptButton = this.materialButton_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.materialButton_cancel;
            this.ClientSize = new System.Drawing.Size(1075, 361);
            this.Controls.Add(this.materialComboBox_role);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialTextBox_password);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialTextBox_login);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialTextBox_patronomic);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialTextBox_surname);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTextBox_name);
            this.Controls.Add(this.materialButton_cancel);
            this.Controls.Add(this.materialButton_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.MaximizeBox = false;
            this.Name = "FormAddOrChangeUser";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton_cancel;
        private MaterialSkin.Controls.MaterialButton materialButton_save;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_surname;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_patronomic;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_login;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_password;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox_role;
    }
}