namespace RentalOfPremises.WinForms.UserControls
{
    partial class UserControlPayment
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            MaterialSkin.MaterialListBoxItem materialListBoxItem4 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem5 = new MaterialSkin.MaterialListBoxItem();
            MaterialSkin.MaterialListBoxItem materialListBoxItem6 = new MaterialSkin.MaterialListBoxItem();
            this.materialLabel_count = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton_delete = new MaterialSkin.Controls.MaterialButton();
            this.materialButton_change = new MaterialSkin.Controls.MaterialButton();
            this.materialButton_add = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialButton_toPDF = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialButton_Exit = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel_count
            // 
            this.materialLabel_count.AutoSize = true;
            this.materialLabel_count.Depth = 0;
            this.materialLabel_count.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_count.Location = new System.Drawing.Point(5, 633);
            this.materialLabel_count.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel_count.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_count.Name = "materialLabel_count";
            this.materialLabel_count.Size = new System.Drawing.Size(157, 19);
            this.materialLabel_count.TabIndex = 16;
            this.materialLabel_count.Text = "Количество записей:";
            // 
            // materialTextBox21
            // 
            this.materialTextBox21.AnimateReadOnly = false;
            this.materialTextBox21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox21.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox21.Depth = 0;
            this.materialTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox21.HideSelection = true;
            this.materialTextBox21.Hint = "Поиск по наименованию арендатора";
            this.materialTextBox21.LeadingIcon = null;
            this.materialTextBox21.Location = new System.Drawing.Point(498, 10);
            this.materialTextBox21.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.materialTextBox21.MaxLength = 32767;
            this.materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox21.Name = "materialTextBox21";
            this.materialTextBox21.PasswordChar = '\0';
            this.materialTextBox21.PrefixSuffixText = null;
            this.materialTextBox21.ReadOnly = false;
            this.materialTextBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox21.SelectedText = "";
            this.materialTextBox21.SelectionLength = 0;
            this.materialTextBox21.SelectionStart = 0;
            this.materialTextBox21.ShortcutsEnabled = true;
            this.materialTextBox21.Size = new System.Drawing.Size(270, 48);
            this.materialTextBox21.TabIndex = 14;
            this.materialTextBox21.TabStop = false;
            this.materialTextBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox21.TrailingIcon = null;
            this.materialTextBox21.UseAccent = false;
            this.materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialButton_delete
            // 
            this.materialButton_delete.AutoSize = false;
            this.materialButton_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_delete.Depth = 0;
            this.materialButton_delete.HighEmphasis = true;
            this.materialButton_delete.Icon = null;
            this.materialButton_delete.Location = new System.Drawing.Point(336, 6);
            this.materialButton_delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_delete.Name = "materialButton_delete";
            this.materialButton_delete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_delete.Size = new System.Drawing.Size(158, 45);
            this.materialButton_delete.TabIndex = 13;
            this.materialButton_delete.Text = "Удалить";
            this.materialButton_delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_delete.UseAccentColor = false;
            this.materialButton_delete.UseVisualStyleBackColor = true;
            this.materialButton_delete.Click += new System.EventHandler(this.materialButton_delete_Click);
            // 
            // materialButton_change
            // 
            this.materialButton_change.AutoSize = false;
            this.materialButton_change.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_change.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_change.Depth = 0;
            this.materialButton_change.HighEmphasis = true;
            this.materialButton_change.Icon = null;
            this.materialButton_change.Location = new System.Drawing.Point(170, 6);
            this.materialButton_change.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_change.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_change.Name = "materialButton_change";
            this.materialButton_change.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_change.Size = new System.Drawing.Size(158, 45);
            this.materialButton_change.TabIndex = 12;
            this.materialButton_change.Text = "Изменить";
            this.materialButton_change.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_change.UseAccentColor = false;
            this.materialButton_change.UseVisualStyleBackColor = true;
            this.materialButton_change.Click += new System.EventHandler(this.materialButton_change_Click);
            // 
            // materialButton_add
            // 
            this.materialButton_add.AutoSize = false;
            this.materialButton_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_add.Depth = 0;
            this.materialButton_add.HighEmphasis = true;
            this.materialButton_add.Icon = null;
            this.materialButton_add.Location = new System.Drawing.Point(4, 6);
            this.materialButton_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_add.Name = "materialButton_add";
            this.materialButton_add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_add.Size = new System.Drawing.Size(158, 45);
            this.materialButton_add.TabIndex = 11;
            this.materialButton_add.Text = "Добавить";
            this.materialButton_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_add.UseAccentColor = false;
            this.materialButton_add.UseVisualStyleBackColor = true;
            this.materialButton_add.Click += new System.EventHandler(this.materialButton_add_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialListBox1);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 3);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14, 3, 14, 14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(252, 295);
            this.materialCard1.TabIndex = 10;
            // 
            // materialListBox1
            // 
            this.materialListBox1.BackColor = System.Drawing.Color.White;
            this.materialListBox1.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBox1.Depth = 0;
            this.materialListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialListBoxItem4.SecondaryText = "Все пользователи";
            materialListBoxItem4.Tag = null;
            materialListBoxItem4.Text = "По умолчанию";
            materialListBoxItem5.SecondaryText = "";
            materialListBoxItem5.Tag = null;
            materialListBoxItem5.Text = "Занято";
            materialListBoxItem6.SecondaryText = "";
            materialListBoxItem6.Tag = null;
            materialListBoxItem6.Text = "Свободно";
            this.materialListBox1.Items.Add(materialListBoxItem4);
            this.materialListBox1.Items.Add(materialListBoxItem5);
            this.materialListBox1.Items.Add(materialListBoxItem6);
            this.materialListBox1.Location = new System.Drawing.Point(17, 59);
            this.materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBox1.Name = "materialListBox1";
            this.materialListBox1.SelectedIndex = -1;
            this.materialListBox1.SelectedItem = null;
            this.materialListBox1.ShowBorder = false;
            this.materialListBox1.ShowScrollBar = true;
            this.materialListBox1.Size = new System.Drawing.Size(218, 219);
            this.materialListBox1.TabIndex = 1;
            this.materialListBox1.UseAccentColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(218, 42);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Фильтрация по занятости помещения";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column5,
            this.Column8});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(4, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 558);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер договора";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Период оплаты";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Электроэнергия";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Водопотребление";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Водоотведение";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Пропуска на человека";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Пропуска на легковое авто";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Пропуска на грузовое авто";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel_count, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1390, 657);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.materialButton_add);
            this.flowLayoutPanel1.Controls.Add(this.materialButton_change);
            this.flowLayoutPanel1.Controls.Add(this.materialButton_delete);
            this.flowLayoutPanel1.Controls.Add(this.materialTextBox21);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1104, 58);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // materialButton_toPDF
            // 
            this.materialButton_toPDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_toPDF.AutoSize = false;
            this.materialButton_toPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_toPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_toPDF.Depth = 0;
            this.materialButton_toPDF.HighEmphasis = true;
            this.materialButton_toPDF.Icon = null;
            this.materialButton_toPDF.Location = new System.Drawing.Point(14, 318);
            this.materialButton_toPDF.Margin = new System.Windows.Forms.Padding(14, 6, 4, 6);
            this.materialButton_toPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_toPDF.Name = "materialButton_toPDF";
            this.materialButton_toPDF.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_toPDF.Size = new System.Drawing.Size(246, 45);
            this.materialButton_toPDF.TabIndex = 15;
            this.materialButton_toPDF.Text = "Сохранить в PDF";
            this.materialButton_toPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_toPDF.UseAccentColor = false;
            this.materialButton_toPDF.UseVisualStyleBackColor = true;
            this.materialButton_toPDF.Click += new System.EventHandler(this.materialButton_toPDF_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.materialButton_Exit);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1113, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(274, 58);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // materialButton_Exit
            // 
            this.materialButton_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_Exit.AutoSize = false;
            this.materialButton_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_Exit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_Exit.Depth = 0;
            this.materialButton_Exit.HighEmphasis = true;
            this.materialButton_Exit.Icon = null;
            this.materialButton_Exit.Location = new System.Drawing.Point(102, 6);
            this.materialButton_Exit.Margin = new System.Windows.Forms.Padding(14, 6, 0, 6);
            this.materialButton_Exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_Exit.Name = "materialButton_Exit";
            this.materialButton_Exit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_Exit.Size = new System.Drawing.Size(158, 45);
            this.materialButton_Exit.TabIndex = 12;
            this.materialButton_Exit.Text = "Выход";
            this.materialButton_Exit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_Exit.UseAccentColor = false;
            this.materialButton_Exit.UseVisualStyleBackColor = true;
            this.materialButton_Exit.Click += new System.EventHandler(this.materialButton_Exit_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.materialCard1);
            this.flowLayoutPanel3.Controls.Add(this.materialButton_toPDF);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1113, 67);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(274, 558);
            this.flowLayoutPanel3.TabIndex = 18;
            // 
            // UserControlPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControlPayment";
            this.Size = new System.Drawing.Size(1390, 657);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel_count;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialButton materialButton_delete;
        private MaterialSkin.Controls.MaterialButton materialButton_change;
        private MaterialSkin.Controls.MaterialButton materialButton_add;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton materialButton_Exit;
        private MaterialSkin.Controls.MaterialButton materialButton_toPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}
