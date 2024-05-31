namespace RentalOfPremises.WinForms.UI.Forms
{
    partial class FormAddOrChangeContract
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialButton_cancel = new MaterialSkin.Controls.MaterialButton();
            this.materialButton_save = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox_arendator = new MaterialSkin.Controls.MaterialComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker_dateStart = new System.Windows.Forms.DateTimePicker();
            this.materialTextBox_period = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.materialButton_cancel.Location = new System.Drawing.Point(369, 389);
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
            this.materialButton_save.Location = new System.Drawing.Point(41, 389);
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
            this.materialLabel1.Location = new System.Drawing.Point(38, 192);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(99, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Срок аренды";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(38, 267);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(165, 63);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Дата начала действия договора:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(38, 117);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(86, 19);
            this.materialLabel6.TabIndex = 20;
            this.materialLabel6.Text = "Арендатор:";
            // 
            // materialComboBox_arendator
            // 
            this.materialComboBox_arendator.AutoResize = false;
            this.materialComboBox_arendator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox_arendator.Depth = 0;
            this.materialComboBox_arendator.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox_arendator.DropDownHeight = 174;
            this.materialComboBox_arendator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox_arendator.DropDownWidth = 121;
            this.materialComboBox_arendator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox_arendator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox_arendator.FormattingEnabled = true;
            this.materialComboBox_arendator.IntegralHeight = false;
            this.materialComboBox_arendator.ItemHeight = 43;
            this.materialComboBox_arendator.Location = new System.Drawing.Point(209, 104);
            this.materialComboBox_arendator.MaxDropDownItems = 4;
            this.materialComboBox_arendator.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox_arendator.Name = "materialComboBox_arendator";
            this.materialComboBox_arendator.Size = new System.Drawing.Size(407, 49);
            this.materialComboBox_arendator.StartIndex = 0;
            this.materialComboBox_arendator.TabIndex = 21;
            this.materialComboBox_arendator.UseAccent = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(669, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 347);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "LiterNumber";
            this.Column1.HeaderText = "Литер-номер помещения";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Добавить к договору";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Цена аренды";
            this.Column3.Name = "Column3";
            // 
            // dateTimePicker_dateStart
            // 
            this.dateTimePicker_dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateStart.Location = new System.Drawing.Point(209, 267);
            this.dateTimePicker_dateStart.Name = "dateTimePicker_dateStart";
            this.dateTimePicker_dateStart.Size = new System.Drawing.Size(407, 40);
            this.dateTimePicker_dateStart.TabIndex = 53;
            // 
            // materialTextBox_period
            // 
            this.materialTextBox_period.AnimateReadOnly = false;
            this.materialTextBox_period.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_period.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_period.Depth = 0;
            this.materialTextBox_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_period.HelperText = "Срок аренды составляет от 1 до 11 месяцев.";
            this.materialTextBox_period.HideSelection = true;
            this.materialTextBox_period.Hint = "Введите целое число";
            this.materialTextBox_period.LeadingIcon = null;
            this.materialTextBox_period.Location = new System.Drawing.Point(209, 178);
            this.materialTextBox_period.MaxLength = 32767;
            this.materialTextBox_period.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_period.Name = "materialTextBox_period";
            this.materialTextBox_period.PasswordChar = '\0';
            this.materialTextBox_period.PrefixSuffixText = null;
            this.materialTextBox_period.ReadOnly = false;
            this.materialTextBox_period.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_period.SelectedText = "";
            this.materialTextBox_period.SelectionLength = 0;
            this.materialTextBox_period.SelectionStart = 0;
            this.materialTextBox_period.ShortcutsEnabled = true;
            this.materialTextBox_period.ShowAssistiveText = true;
            this.materialTextBox_period.Size = new System.Drawing.Size(407, 64);
            this.materialTextBox_period.TabIndex = 54;
            this.materialTextBox_period.TabStop = false;
            this.materialTextBox_period.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_period.TrailingIcon = null;
            this.materialTextBox_period.UseSystemPasswordChar = false;
            this.materialTextBox_period.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox21_KeyPress);
            // 
            // FormAddOrChangeContract
            // 
            this.AcceptButton = this.materialButton_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.materialButton_cancel;
            this.ClientSize = new System.Drawing.Size(1256, 447);
            this.Controls.Add(this.materialTextBox_period);
            this.Controls.Add(this.dateTimePicker_dateStart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialComboBox_arendator);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialButton_cancel);
            this.Controls.Add(this.materialButton_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.MaximizeBox = false;
            this.Name = "FormAddOrChangeContract";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового договора аренды";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton_cancel;
        private MaterialSkin.Controls.MaterialButton materialButton_save;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox_arendator;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateStart;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_period;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}