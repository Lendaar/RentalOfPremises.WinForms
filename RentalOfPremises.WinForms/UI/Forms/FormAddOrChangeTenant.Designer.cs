namespace RentalOfPremises.WinForms.UI.Forms
{
    partial class FormAddOrChangeTenant
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
            this.materialComboBox_type = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_bank = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_email = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_name = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton_cancel = new MaterialSkin.Controls.MaterialButton();
            this.materialButton_save = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_patronomic = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_surname = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_title = new MaterialSkin.Controls.MaterialTextBox2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialMaskedTextBox_telephone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialMaskedTextBox_bik = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialMaskedTextBox_ogrn = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialMaskedTextBox_okpo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialMaskedTextBox_ks = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialMaskedTextBox_rs = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialMaskedTextBox_KPP = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialMaskedTextBox_INN = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialMultiLineTextBox_address = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialComboBox_type
            // 
            this.materialComboBox_type.AutoResize = false;
            this.materialComboBox_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox_type.Depth = 0;
            this.materialComboBox_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox_type.DropDownHeight = 174;
            this.materialComboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox_type.DropDownWidth = 121;
            this.materialComboBox_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox_type.FormattingEnabled = true;
            this.materialComboBox_type.IntegralHeight = false;
            this.materialComboBox_type.ItemHeight = 43;
            this.materialComboBox_type.Items.AddRange(new object[] {
            "Сотрудник",
            "Ст. Сотрудник",
            "Администратор"});
            this.materialComboBox_type.Location = new System.Drawing.Point(158, 435);
            this.materialComboBox_type.MaxDropDownItems = 4;
            this.materialComboBox_type.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox_type.Name = "materialComboBox_type";
            this.materialComboBox_type.Size = new System.Drawing.Size(407, 49);
            this.materialComboBox_type.StartIndex = 0;
            this.materialComboBox_type.TabIndex = 5;
            this.materialComboBox_type.UseAccent = false;
            this.materialComboBox_type.SelectedIndexChanged += new System.EventHandler(this.materialComboBox_type_SelectedIndexChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(30, 450);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(126, 19);
            this.materialLabel6.TabIndex = 34;
            this.materialLabel6.Text = "Тип арендатора:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(6, 399);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(42, 19);
            this.materialLabel5.TabIndex = 33;
            this.materialLabel5.Text = "Банк:";
            // 
            // materialTextBox_bank
            // 
            this.materialTextBox_bank.AnimateReadOnly = false;
            this.materialTextBox_bank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_bank.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_bank.Depth = 0;
            this.materialTextBox_bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_bank.HideSelection = true;
            this.materialTextBox_bank.Hint = "Введите банк";
            this.materialTextBox_bank.LeadingIcon = null;
            this.materialTextBox_bank.Location = new System.Drawing.Point(90, 386);
            this.materialTextBox_bank.MaxLength = 100;
            this.materialTextBox_bank.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_bank.Name = "materialTextBox_bank";
            this.materialTextBox_bank.PasswordChar = '\0';
            this.materialTextBox_bank.PrefixSuffixText = null;
            this.materialTextBox_bank.ReadOnly = false;
            this.materialTextBox_bank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_bank.SelectedText = "";
            this.materialTextBox_bank.SelectionLength = 0;
            this.materialTextBox_bank.SelectionStart = 0;
            this.materialTextBox_bank.ShortcutsEnabled = true;
            this.materialTextBox_bank.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox_bank.TabIndex = 15;
            this.materialTextBox_bank.TabStop = false;
            this.materialTextBox_bank.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_bank.TrailingIcon = null;
            this.materialTextBox_bank.UseAccent = false;
            this.materialTextBox_bank.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(6, 336);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(36, 19);
            this.materialLabel4.TabIndex = 31;
            this.materialLabel4.Text = "БИК:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(31, 583);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(45, 19);
            this.materialLabel3.TabIndex = 29;
            this.materialLabel3.Text = "Email:";
            // 
            // materialTextBox_email
            // 
            this.materialTextBox_email.AnimateReadOnly = false;
            this.materialTextBox_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_email.Depth = 0;
            this.materialTextBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_email.HideSelection = true;
            this.materialTextBox_email.Hint = "Введите email";
            this.materialTextBox_email.LeadingIcon = null;
            this.materialTextBox_email.Location = new System.Drawing.Point(158, 570);
            this.materialTextBox_email.MaxLength = 100;
            this.materialTextBox_email.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_email.Name = "materialTextBox_email";
            this.materialTextBox_email.PasswordChar = '\0';
            this.materialTextBox_email.PrefixSuffixText = null;
            this.materialTextBox_email.ReadOnly = false;
            this.materialTextBox_email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_email.SelectedText = "";
            this.materialTextBox_email.SelectionLength = 0;
            this.materialTextBox_email.SelectionStart = 0;
            this.materialTextBox_email.ShortcutsEnabled = true;
            this.materialTextBox_email.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox_email.TabIndex = 7;
            this.materialTextBox_email.TabStop = false;
            this.materialTextBox_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_email.TrailingIcon = null;
            this.materialTextBox_email.UseAccent = false;
            this.materialTextBox_email.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(30, 516);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 27;
            this.materialLabel2.Text = "Телефон:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 128);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(37, 19);
            this.materialLabel1.TabIndex = 25;
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
            this.materialTextBox_name.Location = new System.Drawing.Point(133, 110);
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
            this.materialTextBox_name.TabIndex = 2;
            this.materialTextBox_name.TabStop = false;
            this.materialTextBox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_name.TrailingIcon = null;
            this.materialTextBox_name.UseAccent = false;
            this.materialTextBox_name.UseSystemPasswordChar = false;
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
            this.materialButton_cancel.Location = new System.Drawing.Point(710, 734);
            this.materialButton_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_cancel.Name = "materialButton_cancel";
            this.materialButton_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_cancel.Size = new System.Drawing.Size(285, 67);
            this.materialButton_cancel.TabIndex = 19;
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
            this.materialButton_save.Enabled = false;
            this.materialButton_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.materialButton_save.HighEmphasis = true;
            this.materialButton_save.Icon = null;
            this.materialButton_save.Location = new System.Drawing.Point(280, 734);
            this.materialButton_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_save.Name = "materialButton_save";
            this.materialButton_save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_save.Size = new System.Drawing.Size(285, 67);
            this.materialButton_save.TabIndex = 18;
            this.materialButton_save.Text = "Создать";
            this.materialButton_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_save.UseAccentColor = false;
            this.materialButton_save.UseVisualStyleBackColor = true;
            this.materialButton_save.Click += new System.EventHandler(this.materialButton_save_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(5, 201);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(75, 19);
            this.materialLabel7.TabIndex = 41;
            this.materialLabel7.Text = "Отчество:";
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
            this.materialTextBox_patronomic.Location = new System.Drawing.Point(133, 188);
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
            this.materialTextBox_patronomic.TabIndex = 3;
            this.materialTextBox_patronomic.TabStop = false;
            this.materialTextBox_patronomic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_patronomic.TrailingIcon = null;
            this.materialTextBox_patronomic.UseAccent = false;
            this.materialTextBox_patronomic.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(5, 52);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(74, 19);
            this.materialLabel8.TabIndex = 39;
            this.materialLabel8.Text = "Фамилия:";
            // 
            // materialTextBox_surname
            // 
            this.materialTextBox_surname.AnimateReadOnly = false;
            this.materialTextBox_surname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_surname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_surname.Depth = 0;
            this.materialTextBox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_surname.HideSelection = true;
            this.materialTextBox_surname.Hint = "Введите фимилию";
            this.materialTextBox_surname.LeadingIcon = null;
            this.materialTextBox_surname.Location = new System.Drawing.Point(133, 40);
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
            this.materialTextBox_surname.TabIndex = 1;
            this.materialTextBox_surname.TabStop = false;
            this.materialTextBox_surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_surname.TrailingIcon = null;
            this.materialTextBox_surname.UseAccent = false;
            this.materialTextBox_surname.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(30, 371);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(107, 50);
            this.materialLabel9.TabIndex = 37;
            this.materialLabel9.Text = "Наменование арендатора:";
            // 
            // materialTextBox_title
            // 
            this.materialTextBox_title.AnimateReadOnly = false;
            this.materialTextBox_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_title.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_title.Depth = 0;
            this.materialTextBox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_title.HideSelection = true;
            this.materialTextBox_title.Hint = "Введите наименование арендатора";
            this.materialTextBox_title.LeadingIcon = null;
            this.materialTextBox_title.Location = new System.Drawing.Point(158, 369);
            this.materialTextBox_title.MaxLength = 100;
            this.materialTextBox_title.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_title.Name = "materialTextBox_title";
            this.materialTextBox_title.PasswordChar = '\0';
            this.materialTextBox_title.PrefixSuffixText = null;
            this.materialTextBox_title.ReadOnly = false;
            this.materialTextBox_title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_title.SelectedText = "";
            this.materialTextBox_title.SelectionLength = 0;
            this.materialTextBox_title.SelectionStart = 0;
            this.materialTextBox_title.ShortcutsEnabled = true;
            this.materialTextBox_title.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox_title.TabIndex = 4;
            this.materialTextBox_title.TabStop = false;
            this.materialTextBox_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_title.TrailingIcon = null;
            this.materialTextBox_title.UseAccent = false;
            this.materialTextBox_title.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialTextBox_surname);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.materialTextBox_name);
            this.groupBox1.Controls.Add(this.materialTextBox_patronomic);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(25, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ФИО генерального директора";
            // 
            // materialMaskedTextBox_telephone
            // 
            this.materialMaskedTextBox_telephone.AllowPromptAsInput = true;
            this.materialMaskedTextBox_telephone.AnimateReadOnly = false;
            this.materialMaskedTextBox_telephone.AsciiOnly = false;
            this.materialMaskedTextBox_telephone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox_telephone.BeepOnError = false;
            this.materialMaskedTextBox_telephone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox_telephone.Depth = 0;
            this.materialMaskedTextBox_telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox_telephone.HidePromptOnLeave = false;
            this.materialMaskedTextBox_telephone.HideSelection = true;
            this.materialMaskedTextBox_telephone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox_telephone.LeadingIcon = null;
            this.materialMaskedTextBox_telephone.Location = new System.Drawing.Point(158, 502);
            this.materialMaskedTextBox_telephone.Mask = "+7 (000) 000-00-00";
            this.materialMaskedTextBox_telephone.MaxLength = 32767;
            this.materialMaskedTextBox_telephone.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox_telephone.Name = "materialMaskedTextBox_telephone";
            this.materialMaskedTextBox_telephone.PasswordChar = '\0';
            this.materialMaskedTextBox_telephone.PrefixSuffixText = null;
            this.materialMaskedTextBox_telephone.PromptChar = '_';
            this.materialMaskedTextBox_telephone.ReadOnly = false;
            this.materialMaskedTextBox_telephone.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox_telephone.ResetOnPrompt = true;
            this.materialMaskedTextBox_telephone.ResetOnSpace = true;
            this.materialMaskedTextBox_telephone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox_telephone.SelectedText = "";
            this.materialMaskedTextBox_telephone.SelectionLength = 0;
            this.materialMaskedTextBox_telephone.SelectionStart = 0;
            this.materialMaskedTextBox_telephone.ShortcutsEnabled = true;
            this.materialMaskedTextBox_telephone.Size = new System.Drawing.Size(407, 48);
            this.materialMaskedTextBox_telephone.SkipLiterals = true;
            this.materialMaskedTextBox_telephone.TabIndex = 6;
            this.materialMaskedTextBox_telephone.TabStop = false;
            this.materialMaskedTextBox_telephone.Text = "+7 (___) ___-__-__";
            this.materialMaskedTextBox_telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox_telephone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.materialMaskedTextBox_telephone.TrailingIcon = null;
            this.materialMaskedTextBox_telephone.UseSystemPasswordChar = false;
            this.materialMaskedTextBox_telephone.ValidatingType = null;
            this.materialMaskedTextBox_telephone.TextChanged += new System.EventHandler(this.materialMaskedTextBox_ogrn_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialMaskedTextBox_bik);
            this.groupBox2.Controls.Add(this.materialMaskedTextBox_ogrn);
            this.groupBox2.Controls.Add(this.materialMaskedTextBox_okpo);
            this.groupBox2.Controls.Add(this.materialMaskedTextBox_ks);
            this.groupBox2.Controls.Add(this.materialMaskedTextBox_rs);
            this.groupBox2.Controls.Add(this.materialMaskedTextBox_KPP);
            this.groupBox2.Controls.Add(this.materialMaskedTextBox_INN);
            this.groupBox2.Controls.Add(this.materialLabel15);
            this.groupBox2.Controls.Add(this.materialLabel16);
            this.groupBox2.Controls.Add(this.materialLabel13);
            this.groupBox2.Controls.Add(this.materialLabel10);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.materialTextBox_bank);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.materialLabel11);
            this.groupBox2.Controls.Add(this.materialLabel12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Location = new System.Drawing.Point(620, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 597);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Банковские реквизиты";
            // 
            // materialMaskedTextBox_bik
            // 
            this.materialMaskedTextBox_bik.AllowPromptAsInput = true;
            this.materialMaskedTextBox_bik.AnimateReadOnly = false;
            this.materialMaskedTextBox_bik.AsciiOnly = false;
            this.materialMaskedTextBox_bik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox_bik.BeepOnError = false;
            this.materialMaskedTextBox_bik.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox_bik.Depth = 0;
            this.materialMaskedTextBox_bik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox_bik.HidePromptOnLeave = false;
            this.materialMaskedTextBox_bik.HideSelection = true;
            this.materialMaskedTextBox_bik.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox_bik.LeadingIcon = null;
            this.materialMaskedTextBox_bik.Location = new System.Drawing.Point(90, 320);
            this.materialMaskedTextBox_bik.Mask = "00000000";
            this.materialMaskedTextBox_bik.MaxLength = 32767;
            this.materialMaskedTextBox_bik.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox_bik.Name = "materialMaskedTextBox_bik";
            this.materialMaskedTextBox_bik.PasswordChar = '\0';
            this.materialMaskedTextBox_bik.PrefixSuffixText = null;
            this.materialMaskedTextBox_bik.PromptChar = '_';
            this.materialMaskedTextBox_bik.ReadOnly = false;
            this.materialMaskedTextBox_bik.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox_bik.ResetOnPrompt = true;
            this.materialMaskedTextBox_bik.ResetOnSpace = true;
            this.materialMaskedTextBox_bik.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox_bik.SelectedText = "";
            this.materialMaskedTextBox_bik.SelectionLength = 0;
            this.materialMaskedTextBox_bik.SelectionStart = 0;
            this.materialMaskedTextBox_bik.ShortcutsEnabled = true;
            this.materialMaskedTextBox_bik.Size = new System.Drawing.Size(407, 48);
            this.materialMaskedTextBox_bik.SkipLiterals = true;
            this.materialMaskedTextBox_bik.TabIndex = 14;
            this.materialMaskedTextBox_bik.TabStop = false;
            this.materialMaskedTextBox_bik.Text = "________";
            this.materialMaskedTextBox_bik.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox_bik.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.materialMaskedTextBox_bik.TrailingIcon = null;
            this.materialMaskedTextBox_bik.UseSystemPasswordChar = false;
            this.materialMaskedTextBox_bik.ValidatingType = null;
            // 
            // materialMaskedTextBox_ogrn
            // 
            this.materialMaskedTextBox_ogrn.AllowPromptAsInput = true;
            this.materialMaskedTextBox_ogrn.AnimateReadOnly = false;
            this.materialMaskedTextBox_ogrn.AsciiOnly = false;
            this.materialMaskedTextBox_ogrn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox_ogrn.BeepOnError = false;
            this.materialMaskedTextBox_ogrn.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox_ogrn.Depth = 0;
            this.materialMaskedTextBox_ogrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox_ogrn.HidePromptOnLeave = false;
            this.materialMaskedTextBox_ogrn.HideSelection = true;
            this.materialMaskedTextBox_ogrn.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox_ogrn.LeadingIcon = null;
            this.materialMaskedTextBox_ogrn.Location = new System.Drawing.Point(90, 526);
            this.materialMaskedTextBox_ogrn.Mask = "0000000000000";
            this.materialMaskedTextBox_ogrn.MaxLength = 32767;
            this.materialMaskedTextBox_ogrn.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox_ogrn.Name = "materialMaskedTextBox_ogrn";
            this.materialMaskedTextBox_ogrn.PasswordChar = '\0';
            this.materialMaskedTextBox_ogrn.PrefixSuffixText = null;
            this.materialMaskedTextBox_ogrn.PromptChar = '_';
            this.materialMaskedTextBox_ogrn.ReadOnly = false;
            this.materialMaskedTextBox_ogrn.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox_ogrn.ResetOnPrompt = true;
            this.materialMaskedTextBox_ogrn.ResetOnSpace = true;
            this.materialMaskedTextBox_ogrn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox_ogrn.SelectedText = "";
            this.materialMaskedTextBox_ogrn.SelectionLength = 0;
            this.materialMaskedTextBox_ogrn.SelectionStart = 0;
            this.materialMaskedTextBox_ogrn.ShortcutsEnabled = true;
            this.materialMaskedTextBox_ogrn.Size = new System.Drawing.Size(407, 48);
            this.materialMaskedTextBox_ogrn.SkipLiterals = true;
            this.materialMaskedTextBox_ogrn.TabIndex = 17;
            this.materialMaskedTextBox_ogrn.TabStop = false;
            this.materialMaskedTextBox_ogrn.Text = "_____________";
            this.materialMaskedTextBox_ogrn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox_ogrn.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.materialMaskedTextBox_ogrn.TrailingIcon = null;
            this.materialMaskedTextBox_ogrn.UseSystemPasswordChar = false;
            this.materialMaskedTextBox_ogrn.ValidatingType = null;
            this.materialMaskedTextBox_ogrn.TextChanged += new System.EventHandler(this.materialMaskedTextBox_ogrn_TextChanged);
            // 
            // materialMaskedTextBox_okpo
            // 
            this.materialMaskedTextBox_okpo.AllowPromptAsInput = true;
            this.materialMaskedTextBox_okpo.AnimateReadOnly = false;
            this.materialMaskedTextBox_okpo.AsciiOnly = false;
            this.materialMaskedTextBox_okpo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox_okpo.BeepOnError = false;
            this.materialMaskedTextBox_okpo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox_okpo.Depth = 0;
            this.materialMaskedTextBox_okpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox_okpo.HidePromptOnLeave = false;
            this.materialMaskedTextBox_okpo.HideSelection = true;
            this.materialMaskedTextBox_okpo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox_okpo.LeadingIcon = null;
            this.materialMaskedTextBox_okpo.Location = new System.Drawing.Point(90, 454);
            this.materialMaskedTextBox_okpo.Mask = "00000000";
            this.materialMaskedTextBox_okpo.MaxLength = 32767;
            this.materialMaskedTextBox_okpo.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox_okpo.Name = "materialMaskedTextBox_okpo";
            this.materialMaskedTextBox_okpo.PasswordChar = '\0';
            this.materialMaskedTextBox_okpo.PrefixSuffixText = null;
            this.materialMaskedTextBox_okpo.PromptChar = '_';
            this.materialMaskedTextBox_okpo.ReadOnly = false;
            this.materialMaskedTextBox_okpo.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox_okpo.ResetOnPrompt = true;
            this.materialMaskedTextBox_okpo.ResetOnSpace = true;
            this.materialMaskedTextBox_okpo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox_okpo.SelectedText = "";
            this.materialMaskedTextBox_okpo.SelectionLength = 0;
            this.materialMaskedTextBox_okpo.SelectionStart = 0;
            this.materialMaskedTextBox_okpo.ShortcutsEnabled = true;
            this.materialMaskedTextBox_okpo.Size = new System.Drawing.Size(407, 48);
            this.materialMaskedTextBox_okpo.SkipLiterals = true;
            this.materialMaskedTextBox_okpo.TabIndex = 16;
            this.materialMaskedTextBox_okpo.TabStop = false;
            this.materialMaskedTextBox_okpo.Text = "________";
            this.materialMaskedTextBox_okpo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox_okpo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.materialMaskedTextBox_okpo.TrailingIcon = null;
            this.materialMaskedTextBox_okpo.UseSystemPasswordChar = false;
            this.materialMaskedTextBox_okpo.ValidatingType = null;
            this.materialMaskedTextBox_okpo.TextChanged += new System.EventHandler(this.materialMaskedTextBox_ogrn_TextChanged);
            // 
            // materialMaskedTextBox_ks
            // 
            this.materialMaskedTextBox_ks.AllowPromptAsInput = true;
            this.materialMaskedTextBox_ks.AnimateReadOnly = false;
            this.materialMaskedTextBox_ks.AsciiOnly = false;
            this.materialMaskedTextBox_ks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox_ks.BeepOnError = false;
            this.materialMaskedTextBox_ks.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox_ks.Depth = 0;
            this.materialMaskedTextBox_ks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox_ks.HidePromptOnLeave = false;
            this.materialMaskedTextBox_ks.HideSelection = true;
            this.materialMaskedTextBox_ks.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox_ks.LeadingIcon = null;
            this.materialMaskedTextBox_ks.Location = new System.Drawing.Point(90, 257);
            this.materialMaskedTextBox_ks.Mask = "00000000000000000000";
            this.materialMaskedTextBox_ks.MaxLength = 32767;
            this.materialMaskedTextBox_ks.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox_ks.Name = "materialMaskedTextBox_ks";
            this.materialMaskedTextBox_ks.PasswordChar = '\0';
            this.materialMaskedTextBox_ks.PrefixSuffixText = null;
            this.materialMaskedTextBox_ks.PromptChar = '_';
            this.materialMaskedTextBox_ks.ReadOnly = false;
            this.materialMaskedTextBox_ks.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox_ks.ResetOnPrompt = true;
            this.materialMaskedTextBox_ks.ResetOnSpace = true;
            this.materialMaskedTextBox_ks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox_ks.SelectedText = "";
            this.materialMaskedTextBox_ks.SelectionLength = 0;
            this.materialMaskedTextBox_ks.SelectionStart = 0;
            this.materialMaskedTextBox_ks.ShortcutsEnabled = true;
            this.materialMaskedTextBox_ks.Size = new System.Drawing.Size(407, 48);
            this.materialMaskedTextBox_ks.SkipLiterals = true;
            this.materialMaskedTextBox_ks.TabIndex = 13;
            this.materialMaskedTextBox_ks.TabStop = false;
            this.materialMaskedTextBox_ks.Text = "____________________";
            this.materialMaskedTextBox_ks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox_ks.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.materialMaskedTextBox_ks.TrailingIcon = null;
            this.materialMaskedTextBox_ks.UseSystemPasswordChar = false;
            this.materialMaskedTextBox_ks.ValidatingType = null;
            this.materialMaskedTextBox_ks.TextChanged += new System.EventHandler(this.materialMaskedTextBox_ogrn_TextChanged);
            // 
            // materialMaskedTextBox_rs
            // 
            this.materialMaskedTextBox_rs.AllowPromptAsInput = true;
            this.materialMaskedTextBox_rs.AnimateReadOnly = false;
            this.materialMaskedTextBox_rs.AsciiOnly = false;
            this.materialMaskedTextBox_rs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox_rs.BeepOnError = false;
            this.materialMaskedTextBox_rs.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox_rs.Depth = 0;
            this.materialMaskedTextBox_rs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox_rs.HidePromptOnLeave = false;
            this.materialMaskedTextBox_rs.HideSelection = true;
            this.materialMaskedTextBox_rs.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox_rs.LeadingIcon = null;
            this.materialMaskedTextBox_rs.Location = new System.Drawing.Point(90, 188);
            this.materialMaskedTextBox_rs.Mask = "00000000000000000000";
            this.materialMaskedTextBox_rs.MaxLength = 32767;
            this.materialMaskedTextBox_rs.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox_rs.Name = "materialMaskedTextBox_rs";
            this.materialMaskedTextBox_rs.PasswordChar = '\0';
            this.materialMaskedTextBox_rs.PrefixSuffixText = null;
            this.materialMaskedTextBox_rs.PromptChar = '_';
            this.materialMaskedTextBox_rs.ReadOnly = false;
            this.materialMaskedTextBox_rs.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox_rs.ResetOnPrompt = true;
            this.materialMaskedTextBox_rs.ResetOnSpace = true;
            this.materialMaskedTextBox_rs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox_rs.SelectedText = "";
            this.materialMaskedTextBox_rs.SelectionLength = 0;
            this.materialMaskedTextBox_rs.SelectionStart = 0;
            this.materialMaskedTextBox_rs.ShortcutsEnabled = true;
            this.materialMaskedTextBox_rs.Size = new System.Drawing.Size(407, 48);
            this.materialMaskedTextBox_rs.SkipLiterals = true;
            this.materialMaskedTextBox_rs.TabIndex = 12;
            this.materialMaskedTextBox_rs.TabStop = false;
            this.materialMaskedTextBox_rs.Text = "____________________";
            this.materialMaskedTextBox_rs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox_rs.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.materialMaskedTextBox_rs.TrailingIcon = null;
            this.materialMaskedTextBox_rs.UseSystemPasswordChar = false;
            this.materialMaskedTextBox_rs.ValidatingType = null;
            this.materialMaskedTextBox_rs.TextChanged += new System.EventHandler(this.materialMaskedTextBox_ogrn_TextChanged);
            // 
            // materialMaskedTextBox_KPP
            // 
            this.materialMaskedTextBox_KPP.AllowPromptAsInput = true;
            this.materialMaskedTextBox_KPP.AnimateReadOnly = false;
            this.materialMaskedTextBox_KPP.AsciiOnly = false;
            this.materialMaskedTextBox_KPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox_KPP.BeepOnError = false;
            this.materialMaskedTextBox_KPP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox_KPP.Depth = 0;
            this.materialMaskedTextBox_KPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox_KPP.HidePromptOnLeave = false;
            this.materialMaskedTextBox_KPP.HideSelection = true;
            this.materialMaskedTextBox_KPP.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox_KPP.LeadingIcon = null;
            this.materialMaskedTextBox_KPP.Location = new System.Drawing.Point(90, 110);
            this.materialMaskedTextBox_KPP.Mask = "000000000";
            this.materialMaskedTextBox_KPP.MaxLength = 32767;
            this.materialMaskedTextBox_KPP.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox_KPP.Name = "materialMaskedTextBox_KPP";
            this.materialMaskedTextBox_KPP.PasswordChar = '\0';
            this.materialMaskedTextBox_KPP.PrefixSuffixText = null;
            this.materialMaskedTextBox_KPP.PromptChar = '_';
            this.materialMaskedTextBox_KPP.ReadOnly = false;
            this.materialMaskedTextBox_KPP.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox_KPP.ResetOnPrompt = true;
            this.materialMaskedTextBox_KPP.ResetOnSpace = true;
            this.materialMaskedTextBox_KPP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox_KPP.SelectedText = "";
            this.materialMaskedTextBox_KPP.SelectionLength = 0;
            this.materialMaskedTextBox_KPP.SelectionStart = 0;
            this.materialMaskedTextBox_KPP.ShortcutsEnabled = true;
            this.materialMaskedTextBox_KPP.Size = new System.Drawing.Size(407, 48);
            this.materialMaskedTextBox_KPP.SkipLiterals = true;
            this.materialMaskedTextBox_KPP.TabIndex = 11;
            this.materialMaskedTextBox_KPP.TabStop = false;
            this.materialMaskedTextBox_KPP.Text = "_________";
            this.materialMaskedTextBox_KPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox_KPP.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.materialMaskedTextBox_KPP.TrailingIcon = null;
            this.materialMaskedTextBox_KPP.UseSystemPasswordChar = false;
            this.materialMaskedTextBox_KPP.ValidatingType = null;
            this.materialMaskedTextBox_KPP.TextChanged += new System.EventHandler(this.materialMaskedTextBox_ogrn_TextChanged);
            // 
            // materialMaskedTextBox_INN
            // 
            this.materialMaskedTextBox_INN.AllowPromptAsInput = true;
            this.materialMaskedTextBox_INN.AnimateReadOnly = false;
            this.materialMaskedTextBox_INN.AsciiOnly = false;
            this.materialMaskedTextBox_INN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox_INN.BeepOnError = false;
            this.materialMaskedTextBox_INN.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox_INN.Depth = 0;
            this.materialMaskedTextBox_INN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox_INN.HidePromptOnLeave = false;
            this.materialMaskedTextBox_INN.HideSelection = true;
            this.materialMaskedTextBox_INN.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox_INN.LeadingIcon = null;
            this.materialMaskedTextBox_INN.Location = new System.Drawing.Point(90, 40);
            this.materialMaskedTextBox_INN.Mask = "000000000000";
            this.materialMaskedTextBox_INN.MaxLength = 32767;
            this.materialMaskedTextBox_INN.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox_INN.Name = "materialMaskedTextBox_INN";
            this.materialMaskedTextBox_INN.PasswordChar = '\0';
            this.materialMaskedTextBox_INN.PrefixSuffixText = null;
            this.materialMaskedTextBox_INN.PromptChar = '_';
            this.materialMaskedTextBox_INN.ReadOnly = false;
            this.materialMaskedTextBox_INN.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox_INN.ResetOnPrompt = true;
            this.materialMaskedTextBox_INN.ResetOnSpace = true;
            this.materialMaskedTextBox_INN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox_INN.SelectedText = "";
            this.materialMaskedTextBox_INN.SelectionLength = 0;
            this.materialMaskedTextBox_INN.SelectionStart = 0;
            this.materialMaskedTextBox_INN.ShortcutsEnabled = true;
            this.materialMaskedTextBox_INN.Size = new System.Drawing.Size(407, 48);
            this.materialMaskedTextBox_INN.SkipLiterals = true;
            this.materialMaskedTextBox_INN.TabIndex = 10;
            this.materialMaskedTextBox_INN.TabStop = false;
            this.materialMaskedTextBox_INN.Text = "____________";
            this.materialMaskedTextBox_INN.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox_INN.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.materialMaskedTextBox_INN.TrailingIcon = null;
            this.materialMaskedTextBox_INN.UseSystemPasswordChar = false;
            this.materialMaskedTextBox_INN.ValidatingType = null;
            this.materialMaskedTextBox_INN.TextChanged += new System.EventHandler(this.materialMaskedTextBox_ogrn_TextChanged);
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.Location = new System.Drawing.Point(6, 543);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(46, 19);
            this.materialLabel15.TabIndex = 49;
            this.materialLabel15.Text = "ОГРН:";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.Location = new System.Drawing.Point(6, 470);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(48, 19);
            this.materialLabel16.TabIndex = 47;
            this.materialLabel16.Text = "ОКПО:";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(6, 274);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(32, 19);
            this.materialLabel13.TabIndex = 45;
            this.materialLabel13.Text = "К/С:";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(6, 126);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(37, 19);
            this.materialLabel10.TabIndex = 41;
            this.materialLabel10.Text = "КПП:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(6, 206);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(32, 19);
            this.materialLabel11.TabIndex = 25;
            this.materialLabel11.Text = "Р/C:";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(6, 57);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(38, 19);
            this.materialLabel12.TabIndex = 39;
            this.materialLabel12.Text = "ИНН:";
            // 
            // materialMultiLineTextBox_address
            // 
            this.materialMultiLineTextBox_address.AnimateReadOnly = false;
            this.materialMultiLineTextBox_address.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMultiLineTextBox_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialMultiLineTextBox_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialMultiLineTextBox_address.Depth = 0;
            this.materialMultiLineTextBox_address.HideSelection = true;
            this.materialMultiLineTextBox_address.Hint = "Введите юридический адрес";
            this.materialMultiLineTextBox_address.Location = new System.Drawing.Point(158, 642);
            this.materialMultiLineTextBox_address.MaxLength = 150;
            this.materialMultiLineTextBox_address.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMultiLineTextBox_address.Name = "materialMultiLineTextBox_address";
            this.materialMultiLineTextBox_address.PasswordChar = '\0';
            this.materialMultiLineTextBox_address.ReadOnly = false;
            this.materialMultiLineTextBox_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.materialMultiLineTextBox_address.SelectedText = "";
            this.materialMultiLineTextBox_address.SelectionLength = 0;
            this.materialMultiLineTextBox_address.SelectionStart = 0;
            this.materialMultiLineTextBox_address.ShortcutsEnabled = true;
            this.materialMultiLineTextBox_address.Size = new System.Drawing.Size(407, 71);
            this.materialMultiLineTextBox_address.TabIndex = 8;
            this.materialMultiLineTextBox_address.TabStop = false;
            this.materialMultiLineTextBox_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMultiLineTextBox_address.UseSystemPasswordChar = false;
            // 
            // materialLabel17
            // 
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.Location = new System.Drawing.Point(30, 649);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(122, 64);
            this.materialLabel17.TabIndex = 46;
            this.materialLabel17.Text = "Юридический адрес:";
            // 
            // FormAddOrChangeTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 783);
            this.Controls.Add(this.materialLabel17);
            this.Controls.Add(this.materialMultiLineTextBox_address);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.materialMaskedTextBox_telephone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialTextBox_title);
            this.Controls.Add(this.materialComboBox_type);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialTextBox_email);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialButton_cancel);
            this.Controls.Add(this.materialButton_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.MaximizeBox = false;
            this.Name = "FormAddOrChangeTenant";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового арендатора";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox materialComboBox_type;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_bank;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_email;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_name;
        private MaterialSkin.Controls.MaterialButton materialButton_cancel;
        private MaterialSkin.Controls.MaterialButton materialButton_save;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_patronomic;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_surname;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox_telephone;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBox_address;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox_ogrn;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox_okpo;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox_ks;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox_rs;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox_KPP;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox_INN;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox_bik;
    }
}