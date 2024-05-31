namespace RentalOfPremises.WinForms.UI.Forms
{
    partial class FormAddOrChangeRoom
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_number = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox_type = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBox_area = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialMaskedTextBox_liter = new MaterialSkin.Controls.MaterialMaskedTextBox();
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
            this.materialButton_cancel.Location = new System.Drawing.Point(321, 402);
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
            this.materialButton_save.Location = new System.Drawing.Point(31, 402);
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
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Литер:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 195);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(144, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Номер помещения:";
            // 
            // materialTextBox_number
            // 
            this.materialTextBox_number.AnimateReadOnly = false;
            this.materialTextBox_number.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_number.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_number.Depth = 0;
            this.materialTextBox_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_number.HideSelection = true;
            this.materialTextBox_number.Hint = "Введите номер помещения";
            this.materialTextBox_number.LeadingIcon = null;
            this.materialTextBox_number.Location = new System.Drawing.Point(180, 181);
            this.materialTextBox_number.MaxLength = 20;
            this.materialTextBox_number.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_number.Name = "materialTextBox_number";
            this.materialTextBox_number.PasswordChar = '\0';
            this.materialTextBox_number.PrefixSuffixText = null;
            this.materialTextBox_number.ReadOnly = false;
            this.materialTextBox_number.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_number.SelectedText = "";
            this.materialTextBox_number.SelectionLength = 0;
            this.materialTextBox_number.SelectionStart = 0;
            this.materialTextBox_number.ShortcutsEnabled = true;
            this.materialTextBox_number.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox_number.TabIndex = 11;
            this.materialTextBox_number.TabStop = false;
            this.materialTextBox_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_number.TrailingIcon = null;
            this.materialTextBox_number.UseAccent = false;
            this.materialTextBox_number.UseSystemPasswordChar = false;
            this.materialTextBox_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox_number_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(28, 267);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Площадь:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(28, 331);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(123, 19);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Тип помещения:";
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
            this.materialComboBox_type.Location = new System.Drawing.Point(180, 312);
            this.materialComboBox_type.MaxDropDownItems = 4;
            this.materialComboBox_type.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox_type.Name = "materialComboBox_type";
            this.materialComboBox_type.Size = new System.Drawing.Size(407, 49);
            this.materialComboBox_type.StartIndex = 0;
            this.materialComboBox_type.TabIndex = 21;
            this.materialComboBox_type.UseAccent = false;
            // 
            // materialTextBox_area
            // 
            this.materialTextBox_area.AnimateReadOnly = false;
            this.materialTextBox_area.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_area.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_area.Depth = 0;
            this.materialTextBox_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_area.HideSelection = true;
            this.materialTextBox_area.Hint = "Введите площадь";
            this.materialTextBox_area.LeadingIcon = null;
            this.materialTextBox_area.Location = new System.Drawing.Point(180, 251);
            this.materialTextBox_area.MaxLength = 20;
            this.materialTextBox_area.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_area.Name = "materialTextBox_area";
            this.materialTextBox_area.PasswordChar = '\0';
            this.materialTextBox_area.PrefixSuffixText = null;
            this.materialTextBox_area.ReadOnly = false;
            this.materialTextBox_area.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_area.SelectedText = "";
            this.materialTextBox_area.SelectionLength = 0;
            this.materialTextBox_area.SelectionStart = 0;
            this.materialTextBox_area.ShortcutsEnabled = true;
            this.materialTextBox_area.Size = new System.Drawing.Size(407, 48);
            this.materialTextBox_area.TabIndex = 13;
            this.materialTextBox_area.TabStop = false;
            this.materialTextBox_area.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_area.TrailingIcon = null;
            this.materialTextBox_area.UseAccent = false;
            this.materialTextBox_area.UseSystemPasswordChar = false;
            this.materialTextBox_area.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox_area_KeyPress);
            // 
            // materialMaskedTextBox_liter
            // 
            this.materialMaskedTextBox_liter.AllowPromptAsInput = true;
            this.materialMaskedTextBox_liter.AnimateReadOnly = false;
            this.materialMaskedTextBox_liter.AsciiOnly = false;
            this.materialMaskedTextBox_liter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialMaskedTextBox_liter.BeepOnError = false;
            this.materialMaskedTextBox_liter.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox_liter.Depth = 0;
            this.materialMaskedTextBox_liter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMaskedTextBox_liter.HidePromptOnLeave = false;
            this.materialMaskedTextBox_liter.HideSelection = true;
            this.materialMaskedTextBox_liter.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.materialMaskedTextBox_liter.LeadingIcon = null;
            this.materialMaskedTextBox_liter.Location = new System.Drawing.Point(180, 115);
            this.materialMaskedTextBox_liter.Mask = "LL";
            this.materialMaskedTextBox_liter.MaxLength = 32767;
            this.materialMaskedTextBox_liter.MouseState = MaterialSkin.MouseState.OUT;
            this.materialMaskedTextBox_liter.Name = "materialMaskedTextBox_liter";
            this.materialMaskedTextBox_liter.PasswordChar = '\0';
            this.materialMaskedTextBox_liter.PrefixSuffixText = null;
            this.materialMaskedTextBox_liter.PromptChar = '_';
            this.materialMaskedTextBox_liter.ReadOnly = false;
            this.materialMaskedTextBox_liter.RejectInputOnFirstFailure = false;
            this.materialMaskedTextBox_liter.ResetOnPrompt = true;
            this.materialMaskedTextBox_liter.ResetOnSpace = true;
            this.materialMaskedTextBox_liter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialMaskedTextBox_liter.SelectedText = "";
            this.materialMaskedTextBox_liter.SelectionLength = 0;
            this.materialMaskedTextBox_liter.SelectionStart = 0;
            this.materialMaskedTextBox_liter.ShortcutsEnabled = true;
            this.materialMaskedTextBox_liter.Size = new System.Drawing.Size(407, 48);
            this.materialMaskedTextBox_liter.SkipLiterals = true;
            this.materialMaskedTextBox_liter.TabIndex = 51;
            this.materialMaskedTextBox_liter.TabStop = false;
            this.materialMaskedTextBox_liter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialMaskedTextBox_liter.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.materialMaskedTextBox_liter.TrailingIcon = null;
            this.materialMaskedTextBox_liter.UseSystemPasswordChar = false;
            this.materialMaskedTextBox_liter.ValidatingType = null;
            // 
            // FormAddOrChangeRoom
            // 
            this.AcceptButton = this.materialButton_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.materialButton_cancel;
            this.ClientSize = new System.Drawing.Size(651, 491);
            this.Controls.Add(this.materialMaskedTextBox_liter);
            this.Controls.Add(this.materialComboBox_type);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialTextBox_area);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialTextBox_number);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButton_cancel);
            this.Controls.Add(this.materialButton_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.MaximizeBox = false;
            this.Name = "FormAddOrChangeRoom";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового помещения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton_cancel;
        private MaterialSkin.Controls.MaterialButton materialButton_save;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_number;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox_type;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_area;
        private MaterialSkin.Controls.MaterialMaskedTextBox materialMaskedTextBox_liter;
    }
}