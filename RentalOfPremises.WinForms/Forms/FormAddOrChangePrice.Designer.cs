namespace RentalOfPremises.WinForms.Forms
{
    partial class FormAddOrChangePrice
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
            this.materialTextBox_electro = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_waretIn = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_waterOut = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_propuskHuman = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_propuskLegAvto = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBox_propuskGruzAvto = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
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
            this.materialButton_cancel.Location = new System.Drawing.Point(516, 327);
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
            this.materialButton_save.Location = new System.Drawing.Point(209, 327);
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
            this.materialLabel1.Location = new System.Drawing.Point(10, 111);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(133, 48);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Цена на электричество:";
            // 
            // materialTextBox_electro
            // 
            this.materialTextBox_electro.AnimateReadOnly = false;
            this.materialTextBox_electro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_electro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_electro.Depth = 0;
            this.materialTextBox_electro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_electro.HideSelection = true;
            this.materialTextBox_electro.Hint = "Введите цену";
            this.materialTextBox_electro.LeadingIcon = null;
            this.materialTextBox_electro.Location = new System.Drawing.Point(164, 111);
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
            this.materialTextBox_electro.TabIndex = 9;
            this.materialTextBox_electro.TabStop = false;
            this.materialTextBox_electro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_electro.TrailingIcon = null;
            this.materialTextBox_electro.UseAccent = false;
            this.materialTextBox_electro.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(10, 181);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(148, 48);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Цена на водопотребление:";
            // 
            // materialTextBox_waretIn
            // 
            this.materialTextBox_waretIn.AnimateReadOnly = false;
            this.materialTextBox_waretIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_waretIn.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_waretIn.Depth = 0;
            this.materialTextBox_waretIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_waretIn.HideSelection = true;
            this.materialTextBox_waretIn.Hint = "Введите цену";
            this.materialTextBox_waretIn.LeadingIcon = null;
            this.materialTextBox_waretIn.Location = new System.Drawing.Point(164, 181);
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
            this.materialTextBox_waretIn.TabIndex = 11;
            this.materialTextBox_waretIn.TabStop = false;
            this.materialTextBox_waretIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_waretIn.TrailingIcon = null;
            this.materialTextBox_waretIn.UseAccent = false;
            this.materialTextBox_waretIn.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(10, 251);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(133, 48);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Цена на водоотведение:";
            // 
            // materialTextBox_waterOut
            // 
            this.materialTextBox_waterOut.AnimateReadOnly = false;
            this.materialTextBox_waterOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_waterOut.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_waterOut.Depth = 0;
            this.materialTextBox_waterOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_waterOut.HideSelection = true;
            this.materialTextBox_waterOut.Hint = "Введите цену";
            this.materialTextBox_waterOut.LeadingIcon = null;
            this.materialTextBox_waterOut.Location = new System.Drawing.Point(164, 251);
            this.materialTextBox_waterOut.MaxLength = 100;
            this.materialTextBox_waterOut.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_waterOut.Name = "materialTextBox_waterOut";
            this.materialTextBox_waterOut.PasswordChar = '\0';
            this.materialTextBox_waterOut.PrefixSuffixText = null;
            this.materialTextBox_waterOut.ReadOnly = false;
            this.materialTextBox_waterOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_waterOut.SelectedText = "";
            this.materialTextBox_waterOut.SelectionLength = 0;
            this.materialTextBox_waterOut.SelectionStart = 0;
            this.materialTextBox_waterOut.ShortcutsEnabled = true;
            this.materialTextBox_waterOut.Size = new System.Drawing.Size(258, 48);
            this.materialTextBox_waterOut.TabIndex = 13;
            this.materialTextBox_waterOut.TabStop = false;
            this.materialTextBox_waterOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_waterOut.TrailingIcon = null;
            this.materialTextBox_waterOut.UseAccent = false;
            this.materialTextBox_waterOut.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(465, 115);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(118, 48);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Цена пропуска для человека:";
            // 
            // materialTextBox_propuskHuman
            // 
            this.materialTextBox_propuskHuman.AnimateReadOnly = false;
            this.materialTextBox_propuskHuman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_propuskHuman.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_propuskHuman.Depth = 0;
            this.materialTextBox_propuskHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_propuskHuman.HideSelection = true;
            this.materialTextBox_propuskHuman.Hint = "Введите цену";
            this.materialTextBox_propuskHuman.LeadingIcon = null;
            this.materialTextBox_propuskHuman.Location = new System.Drawing.Point(658, 111);
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
            this.materialTextBox_propuskHuman.TabIndex = 15;
            this.materialTextBox_propuskHuman.TabStop = false;
            this.materialTextBox_propuskHuman.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_propuskHuman.TrailingIcon = null;
            this.materialTextBox_propuskHuman.UseAccent = false;
            this.materialTextBox_propuskHuman.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(465, 181);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(155, 59);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "Цена пропуска для легкового авто:";
            // 
            // materialTextBox_propuskLegAvto
            // 
            this.materialTextBox_propuskLegAvto.AnimateReadOnly = false;
            this.materialTextBox_propuskLegAvto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_propuskLegAvto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_propuskLegAvto.Depth = 0;
            this.materialTextBox_propuskLegAvto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_propuskLegAvto.HideSelection = true;
            this.materialTextBox_propuskLegAvto.Hint = "Введите цену";
            this.materialTextBox_propuskLegAvto.LeadingIcon = null;
            this.materialTextBox_propuskLegAvto.Location = new System.Drawing.Point(658, 181);
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
            this.materialTextBox_propuskLegAvto.TabIndex = 17;
            this.materialTextBox_propuskLegAvto.TabStop = false;
            this.materialTextBox_propuskLegAvto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_propuskLegAvto.TrailingIcon = null;
            this.materialTextBox_propuskLegAvto.UseAccent = false;
            this.materialTextBox_propuskLegAvto.UseSystemPasswordChar = false;
            // 
            // materialTextBox_propuskGruzAvto
            // 
            this.materialTextBox_propuskGruzAvto.AnimateReadOnly = false;
            this.materialTextBox_propuskGruzAvto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_propuskGruzAvto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_propuskGruzAvto.Depth = 0;
            this.materialTextBox_propuskGruzAvto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_propuskGruzAvto.HideSelection = true;
            this.materialTextBox_propuskGruzAvto.Hint = "Введите цену";
            this.materialTextBox_propuskGruzAvto.LeadingIcon = null;
            this.materialTextBox_propuskGruzAvto.Location = new System.Drawing.Point(658, 251);
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
            this.materialTextBox_propuskGruzAvto.TabIndex = 19;
            this.materialTextBox_propuskGruzAvto.TabStop = false;
            this.materialTextBox_propuskGruzAvto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_propuskGruzAvto.TrailingIcon = null;
            this.materialTextBox_propuskGruzAvto.UseAccent = false;
            this.materialTextBox_propuskGruzAvto.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(465, 251);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(155, 59);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Цена пропуска для грузового авто:";
            // 
            // FormAddOrChangePrice
            // 
            this.AcceptButton = this.materialButton_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.materialButton_cancel;
            this.ClientSize = new System.Drawing.Size(985, 409);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialTextBox_propuskGruzAvto);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialTextBox_propuskLegAvto);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialTextBox_propuskHuman);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialTextBox_waterOut);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialTextBox_waretIn);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTextBox_electro);
            this.Controls.Add(this.materialButton_cancel);
            this.Controls.Add(this.materialButton_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.MaximizeBox = false;
            this.Name = "FormAddOrChangePrice";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового прейскуранта";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton_cancel;
        private MaterialSkin.Controls.MaterialButton materialButton_save;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_electro;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_waretIn;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_waterOut;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_propuskHuman;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_propuskLegAvto;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_propuskGruzAvto;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}