namespace RentalOfPremises.WinForms.UI.Forms
{
    partial class FormAddOrChangePaymentInvoice
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
            this.materialTextBox_propuskLegAvto = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox_propuskGruzAvto = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_electro = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_waretIn = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox_propuskHuman = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox_dogovorNumber = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox_period = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel_tenantTitle = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_dateEnd = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_dateStart = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
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
            this.materialButton_cancel.Location = new System.Drawing.Point(599, 522);
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
            this.materialButton_save.Location = new System.Drawing.Point(206, 522);
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
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(534, 315);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(146, 60);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Количество пропускков для легковых авто:";
            // 
            // materialTextBox_propuskLegAvto
            // 
            this.materialTextBox_propuskLegAvto.AnimateReadOnly = false;
            this.materialTextBox_propuskLegAvto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_propuskLegAvto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_propuskLegAvto.Depth = 0;
            this.materialTextBox_propuskLegAvto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_propuskLegAvto.HideSelection = true;
            this.materialTextBox_propuskLegAvto.Hint = "Введите количество";
            this.materialTextBox_propuskLegAvto.LeadingIcon = null;
            this.materialTextBox_propuskLegAvto.Location = new System.Drawing.Point(727, 315);
            this.materialTextBox_propuskLegAvto.MaxLength = 100;
            this.materialTextBox_propuskLegAvto.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_propuskLegAvto.Name = "materialTextBox_propuskLegAvto";
            this.materialTextBox_propuskLegAvto.PasswordChar = '\0';
            this.materialTextBox_propuskLegAvto.PrefixSuffixText = null;
            this.materialTextBox_propuskLegAvto.ReadOnly = false;
            this.materialTextBox_propuskLegAvto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_propuskLegAvto.SelectedText = "";
            this.materialTextBox_propuskLegAvto.SelectionLength = 0;
            this.materialTextBox_propuskLegAvto.SelectionStart = 0;
            this.materialTextBox_propuskLegAvto.ShortcutsEnabled = true;
            this.materialTextBox_propuskLegAvto.Size = new System.Drawing.Size(258, 48);
            this.materialTextBox_propuskLegAvto.TabIndex = 6;
            this.materialTextBox_propuskLegAvto.TabStop = false;
            this.materialTextBox_propuskLegAvto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_propuskLegAvto.TrailingIcon = null;
            this.materialTextBox_propuskLegAvto.UseAccent = false;
            this.materialTextBox_propuskLegAvto.UseSystemPasswordChar = false;
            this.materialTextBox_propuskLegAvto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox_electro_KeyPress);
            // 
            // materialTextBox_propuskGruzAvto
            // 
            this.materialTextBox_propuskGruzAvto.AnimateReadOnly = false;
            this.materialTextBox_propuskGruzAvto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_propuskGruzAvto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_propuskGruzAvto.Depth = 0;
            this.materialTextBox_propuskGruzAvto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_propuskGruzAvto.HideSelection = true;
            this.materialTextBox_propuskGruzAvto.Hint = "Введите количество";
            this.materialTextBox_propuskGruzAvto.LeadingIcon = null;
            this.materialTextBox_propuskGruzAvto.Location = new System.Drawing.Point(727, 385);
            this.materialTextBox_propuskGruzAvto.MaxLength = 100;
            this.materialTextBox_propuskGruzAvto.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_propuskGruzAvto.Name = "materialTextBox_propuskGruzAvto";
            this.materialTextBox_propuskGruzAvto.PasswordChar = '\0';
            this.materialTextBox_propuskGruzAvto.PrefixSuffixText = null;
            this.materialTextBox_propuskGruzAvto.ReadOnly = false;
            this.materialTextBox_propuskGruzAvto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_propuskGruzAvto.SelectedText = "";
            this.materialTextBox_propuskGruzAvto.SelectionLength = 0;
            this.materialTextBox_propuskGruzAvto.SelectionStart = 0;
            this.materialTextBox_propuskGruzAvto.ShortcutsEnabled = true;
            this.materialTextBox_propuskGruzAvto.Size = new System.Drawing.Size(258, 48);
            this.materialTextBox_propuskGruzAvto.TabIndex = 7;
            this.materialTextBox_propuskGruzAvto.TabStop = false;
            this.materialTextBox_propuskGruzAvto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_propuskGruzAvto.TrailingIcon = null;
            this.materialTextBox_propuskGruzAvto.UseAccent = false;
            this.materialTextBox_propuskGruzAvto.UseSystemPasswordChar = false;
            this.materialTextBox_propuskGruzAvto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox_electro_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(534, 119);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(172, 48);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Показания электропотребления:";
            // 
            // materialTextBox_electro
            // 
            this.materialTextBox_electro.AnimateReadOnly = false;
            this.materialTextBox_electro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_electro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_electro.Depth = 0;
            this.materialTextBox_electro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_electro.HideSelection = true;
            this.materialTextBox_electro.Hint = "Введите показания";
            this.materialTextBox_electro.LeadingIcon = null;
            this.materialTextBox_electro.Location = new System.Drawing.Point(727, 115);
            this.materialTextBox_electro.MaxLength = 100;
            this.materialTextBox_electro.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_electro.Name = "materialTextBox_electro";
            this.materialTextBox_electro.PasswordChar = '\0';
            this.materialTextBox_electro.PrefixSuffixText = null;
            this.materialTextBox_electro.ReadOnly = false;
            this.materialTextBox_electro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_electro.SelectedText = "";
            this.materialTextBox_electro.SelectionLength = 0;
            this.materialTextBox_electro.SelectionStart = 0;
            this.materialTextBox_electro.ShortcutsEnabled = true;
            this.materialTextBox_electro.Size = new System.Drawing.Size(258, 48);
            this.materialTextBox_electro.TabIndex = 3;
            this.materialTextBox_electro.TabStop = false;
            this.materialTextBox_electro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_electro.TrailingIcon = null;
            this.materialTextBox_electro.UseAccent = false;
            this.materialTextBox_electro.UseSystemPasswordChar = false;
            this.materialTextBox_electro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox_electro_KeyPress);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(534, 185);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(155, 59);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "Показания водопотребления:";
            // 
            // materialTextBox_waretIn
            // 
            this.materialTextBox_waretIn.AnimateReadOnly = false;
            this.materialTextBox_waretIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_waretIn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_waretIn.Depth = 0;
            this.materialTextBox_waretIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_waretIn.HideSelection = true;
            this.materialTextBox_waretIn.Hint = "Введите показания";
            this.materialTextBox_waretIn.LeadingIcon = null;
            this.materialTextBox_waretIn.Location = new System.Drawing.Point(727, 185);
            this.materialTextBox_waretIn.MaxLength = 100;
            this.materialTextBox_waretIn.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_waretIn.Name = "materialTextBox_waretIn";
            this.materialTextBox_waretIn.PasswordChar = '\0';
            this.materialTextBox_waretIn.PrefixSuffixText = null;
            this.materialTextBox_waretIn.ReadOnly = false;
            this.materialTextBox_waretIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_waretIn.SelectedText = "";
            this.materialTextBox_waretIn.SelectionLength = 0;
            this.materialTextBox_waretIn.SelectionStart = 0;
            this.materialTextBox_waretIn.ShortcutsEnabled = true;
            this.materialTextBox_waretIn.Size = new System.Drawing.Size(258, 48);
            this.materialTextBox_waretIn.TabIndex = 4;
            this.materialTextBox_waretIn.TabStop = false;
            this.materialTextBox_waretIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_waretIn.TrailingIcon = null;
            this.materialTextBox_waretIn.UseAccent = false;
            this.materialTextBox_waretIn.UseSystemPasswordChar = false;
            this.materialTextBox_waretIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox_electro_KeyPress);
            // 
            // materialTextBox_propuskHuman
            // 
            this.materialTextBox_propuskHuman.AnimateReadOnly = false;
            this.materialTextBox_propuskHuman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_propuskHuman.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_propuskHuman.Depth = 0;
            this.materialTextBox_propuskHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_propuskHuman.HideSelection = true;
            this.materialTextBox_propuskHuman.Hint = "Введите количество";
            this.materialTextBox_propuskHuman.LeadingIcon = null;
            this.materialTextBox_propuskHuman.Location = new System.Drawing.Point(727, 255);
            this.materialTextBox_propuskHuman.MaxLength = 100;
            this.materialTextBox_propuskHuman.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_propuskHuman.Name = "materialTextBox_propuskHuman";
            this.materialTextBox_propuskHuman.PasswordChar = '\0';
            this.materialTextBox_propuskHuman.PrefixSuffixText = null;
            this.materialTextBox_propuskHuman.ReadOnly = false;
            this.materialTextBox_propuskHuman.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_propuskHuman.SelectedText = "";
            this.materialTextBox_propuskHuman.SelectionLength = 0;
            this.materialTextBox_propuskHuman.SelectionStart = 0;
            this.materialTextBox_propuskHuman.ShortcutsEnabled = true;
            this.materialTextBox_propuskHuman.Size = new System.Drawing.Size(258, 48);
            this.materialTextBox_propuskHuman.TabIndex = 5;
            this.materialTextBox_propuskHuman.TabStop = false;
            this.materialTextBox_propuskHuman.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_propuskHuman.TrailingIcon = null;
            this.materialTextBox_propuskHuman.UseAccent = false;
            this.materialTextBox_propuskHuman.UseSystemPasswordChar = false;
            this.materialTextBox_propuskHuman.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox_electro_KeyPress);
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(534, 244);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(155, 59);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Количество пропусков для людей:";
            // 
            // materialComboBox_dogovorNumber
            // 
            this.materialComboBox_dogovorNumber.AutoResize = false;
            this.materialComboBox_dogovorNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox_dogovorNumber.Depth = 0;
            this.materialComboBox_dogovorNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox_dogovorNumber.DropDownHeight = 174;
            this.materialComboBox_dogovorNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox_dogovorNumber.DropDownWidth = 121;
            this.materialComboBox_dogovorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox_dogovorNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox_dogovorNumber.FormattingEnabled = true;
            this.materialComboBox_dogovorNumber.IntegralHeight = false;
            this.materialComboBox_dogovorNumber.ItemHeight = 43;
            this.materialComboBox_dogovorNumber.Location = new System.Drawing.Point(185, 116);
            this.materialComboBox_dogovorNumber.MaxDropDownItems = 4;
            this.materialComboBox_dogovorNumber.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox_dogovorNumber.Name = "materialComboBox_dogovorNumber";
            this.materialComboBox_dogovorNumber.Size = new System.Drawing.Size(287, 49);
            this.materialComboBox_dogovorNumber.StartIndex = 0;
            this.materialComboBox_dogovorNumber.TabIndex = 1;
            this.materialComboBox_dogovorNumber.SelectedIndexChanged += new System.EventHandler(this.materialComboBox_dogovorNumber_SelectedIndexChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(21, 116);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(158, 48);
            this.materialLabel7.TabIndex = 22;
            this.materialLabel7.Text = "Номер договора аренды:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(21, 188);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(158, 48);
            this.materialLabel8.TabIndex = 24;
            this.materialLabel8.Text = "Период для оплаты:";
            // 
            // materialComboBox_period
            // 
            this.materialComboBox_period.AutoResize = false;
            this.materialComboBox_period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox_period.Depth = 0;
            this.materialComboBox_period.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox_period.DropDownHeight = 174;
            this.materialComboBox_period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox_period.DropDownWidth = 121;
            this.materialComboBox_period.Enabled = false;
            this.materialComboBox_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox_period.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox_period.FormattingEnabled = true;
            this.materialComboBox_period.IntegralHeight = false;
            this.materialComboBox_period.ItemHeight = 43;
            this.materialComboBox_period.Location = new System.Drawing.Point(185, 184);
            this.materialComboBox_period.MaxDropDownItems = 4;
            this.materialComboBox_period.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox_period.Name = "materialComboBox_period";
            this.materialComboBox_period.Size = new System.Drawing.Size(287, 49);
            this.materialComboBox_period.StartIndex = 0;
            this.materialComboBox_period.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel_tenantTitle);
            this.groupBox1.Controls.Add(this.materialLabel_dateEnd);
            this.groupBox1.Controls.Add(this.materialLabel_dateStart);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.materialLabel10);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(24, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 247);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация по договору";
            // 
            // materialLabel_tenantTitle
            // 
            this.materialLabel_tenantTitle.AutoSize = true;
            this.materialLabel_tenantTitle.Depth = 0;
            this.materialLabel_tenantTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_tenantTitle.Location = new System.Drawing.Point(197, 201);
            this.materialLabel_tenantTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_tenantTitle.Name = "materialLabel_tenantTitle";
            this.materialLabel_tenantTitle.Size = new System.Drawing.Size(82, 19);
            this.materialLabel_tenantTitle.TabIndex = 44;
            this.materialLabel_tenantTitle.Text = "Арендатор";
            // 
            // materialLabel_dateEnd
            // 
            this.materialLabel_dateEnd.AutoSize = true;
            this.materialLabel_dateEnd.Depth = 0;
            this.materialLabel_dateEnd.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_dateEnd.Location = new System.Drawing.Point(197, 128);
            this.materialLabel_dateEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_dateEnd.Name = "materialLabel_dateEnd";
            this.materialLabel_dateEnd.Size = new System.Drawing.Size(124, 19);
            this.materialLabel_dateEnd.TabIndex = 43;
            this.materialLabel_dateEnd.Text = "Дата окончания";
            // 
            // materialLabel_dateStart
            // 
            this.materialLabel_dateStart.AutoSize = true;
            this.materialLabel_dateStart.Depth = 0;
            this.materialLabel_dateStart.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_dateStart.Location = new System.Drawing.Point(197, 52);
            this.materialLabel_dateStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_dateStart.Name = "materialLabel_dateStart";
            this.materialLabel_dateStart.Size = new System.Drawing.Size(97, 19);
            this.materialLabel_dateStart.TabIndex = 42;
            this.materialLabel_dateStart.Text = "Дата начала";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(5, 201);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(86, 19);
            this.materialLabel9.TabIndex = 41;
            this.materialLabel9.Text = "Арендатор:";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(6, 128);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(128, 19);
            this.materialLabel10.TabIndex = 25;
            this.materialLabel10.Text = "Дата окончания:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(5, 52);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(101, 19);
            this.materialLabel11.TabIndex = 39;
            this.materialLabel11.Text = "Дата начала:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(534, 384);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(146, 60);
            this.materialLabel2.TabIndex = 26;
            this.materialLabel2.Text = "Количество пропускков для грузовых авто:";
            // 
            // FormAddOrChangePaymentInvoice
            // 
            this.AcceptButton = this.materialButton_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.materialButton_cancel;
            this.ClientSize = new System.Drawing.Size(1030, 548);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialComboBox_period);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialComboBox_dogovorNumber);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialTextBox_propuskHuman);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialTextBox_waretIn);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialTextBox_electro);
            this.Controls.Add(this.materialTextBox_propuskGruzAvto);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTextBox_propuskLegAvto);
            this.Controls.Add(this.materialButton_cancel);
            this.Controls.Add(this.materialButton_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.MaximizeBox = false;
            this.Name = "FormAddOrChangePaymentInvoice";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового счета на оплату аренды";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton_cancel;
        private MaterialSkin.Controls.MaterialButton materialButton_save;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_propuskLegAvto;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_propuskGruzAvto;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_electro;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_waretIn;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_propuskHuman;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox_dogovorNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox_period;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel_tenantTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel_dateEnd;
        private MaterialSkin.Controls.MaterialLabel materialLabel_dateStart;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}