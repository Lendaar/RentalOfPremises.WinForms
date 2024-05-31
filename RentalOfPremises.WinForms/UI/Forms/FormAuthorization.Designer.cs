namespace RentalOfPremises.WinForms.UI.Forms
{
    partial class FormAuthorization
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
            this.materialTextBox_login = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_password = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton_auth = new MaterialSkin.Controls.MaterialButton();
            this.materialButton_exit = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
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
            this.materialTextBox_login.Location = new System.Drawing.Point(132, 142);
            this.materialTextBox_login.MaxLength = 20;
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
            this.materialTextBox_login.TabIndex = 1;
            this.materialTextBox_login.TabStop = false;
            this.materialTextBox_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_login.TrailingIcon = null;
            this.materialTextBox_login.UseAccent = false;
            this.materialTextBox_login.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(35, 156);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Логин:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(35, 235);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Пароль:";
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
            this.materialTextBox_password.Location = new System.Drawing.Point(132, 216);
            this.materialTextBox_password.MaxLength = 20;
            this.materialTextBox_password.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_password.Name = "materialTextBox_password";
            this.materialTextBox_password.PasswordChar = '●';
            this.materialTextBox_password.PrefixSuffixText = null;
            this.materialTextBox_password.ReadOnly = false;
            this.materialTextBox_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_password.SelectedText = "";
            this.materialTextBox_password.SelectionLength = 0;
            this.materialTextBox_password.SelectionStart = 0;
            this.materialTextBox_password.ShortcutsEnabled = true;
            this.materialTextBox_password.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox_password.TabIndex = 4;
            this.materialTextBox_password.TabStop = false;
            this.materialTextBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_password.TrailingIcon = null;
            this.materialTextBox_password.UseAccent = false;
            this.materialTextBox_password.UseSystemPasswordChar = true;
            // 
            // materialButton_auth
            // 
            this.materialButton_auth.AutoSize = false;
            this.materialButton_auth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_auth.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_auth.Depth = 0;
            this.materialButton_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.materialButton_auth.HighEmphasis = true;
            this.materialButton_auth.Icon = null;
            this.materialButton_auth.Location = new System.Drawing.Point(51, 299);
            this.materialButton_auth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_auth.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_auth.Name = "materialButton_auth";
            this.materialButton_auth.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_auth.Size = new System.Drawing.Size(181, 49);
            this.materialButton_auth.TabIndex = 5;
            this.materialButton_auth.Text = "Авторизоваться";
            this.materialButton_auth.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_auth.UseAccentColor = false;
            this.materialButton_auth.UseVisualStyleBackColor = true;
            this.materialButton_auth.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton_exit
            // 
            this.materialButton_exit.AutoSize = false;
            this.materialButton_exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_exit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton_exit.Depth = 0;
            this.materialButton_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialButton_exit.HighEmphasis = true;
            this.materialButton_exit.Icon = null;
            this.materialButton_exit.Location = new System.Drawing.Point(339, 299);
            this.materialButton_exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_exit.Name = "materialButton_exit";
            this.materialButton_exit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_exit.Size = new System.Drawing.Size(181, 49);
            this.materialButton_exit.TabIndex = 6;
            this.materialButton_exit.Text = "Выход";
            this.materialButton_exit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_exit.UseAccentColor = false;
            this.materialButton_exit.UseVisualStyleBackColor = true;
            this.materialButton_exit.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // FormAuthorization
            // 
            this.AcceptButton = this.materialButton_auth;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.materialButton_exit;
            this.ClientSize = new System.Drawing.Size(586, 335);
            this.Controls.Add(this.materialButton_exit);
            this.Controls.Add(this.materialButton_auth);
            this.Controls.Add(this.materialTextBox_password);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTextBox_login);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.MaximizeBox = false;
            this.Name = "FormAuthorization";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_login;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_password;
        private MaterialSkin.Controls.MaterialButton materialButton_auth;
        private MaterialSkin.Controls.MaterialButton materialButton_exit;
    }
}