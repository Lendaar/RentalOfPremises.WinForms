namespace RentalOfPremises.WinForms.UserControls
{
    partial class UserControlContract
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
            this.materialLabel_count = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox_search = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton_delete = new MaterialSkin.Controls.MaterialButton();
            this.materialButton_add = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialListBox_roomInArend = new MaterialSkin.Controls.MaterialListBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialButton_exit = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialButton_toPDF = new MaterialSkin.Controls.MaterialButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            // materialTextBox_search
            // 
            this.materialTextBox_search.AnimateReadOnly = false;
            this.materialTextBox_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox_search.Depth = 0;
            this.materialTextBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox_search.HideSelection = true;
            this.materialTextBox_search.Hint = "Поиск по арендатору";
            this.materialTextBox_search.LeadingIcon = null;
            this.materialTextBox_search.Location = new System.Drawing.Point(332, 10);
            this.materialTextBox_search.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.materialTextBox_search.MaxLength = 32767;
            this.materialTextBox_search.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox_search.Name = "materialTextBox_search";
            this.materialTextBox_search.PasswordChar = '\0';
            this.materialTextBox_search.PrefixSuffixText = null;
            this.materialTextBox_search.ReadOnly = false;
            this.materialTextBox_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox_search.SelectedText = "";
            this.materialTextBox_search.SelectionLength = 0;
            this.materialTextBox_search.SelectionStart = 0;
            this.materialTextBox_search.ShortcutsEnabled = true;
            this.materialTextBox_search.Size = new System.Drawing.Size(270, 48);
            this.materialTextBox_search.TabIndex = 14;
            this.materialTextBox_search.TabStop = false;
            this.materialTextBox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox_search.TrailingIcon = null;
            this.materialTextBox_search.UseAccent = false;
            this.materialTextBox_search.UseSystemPasswordChar = false;
            this.materialTextBox_search.TextChanged += new System.EventHandler(this.materialTextBox_search_TextChanged);
            // 
            // materialButton_delete
            // 
            this.materialButton_delete.AutoSize = false;
            this.materialButton_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_delete.Depth = 0;
            this.materialButton_delete.Enabled = false;
            this.materialButton_delete.HighEmphasis = true;
            this.materialButton_delete.Icon = null;
            this.materialButton_delete.Location = new System.Drawing.Point(170, 6);
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
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialListBox_roomInArend);
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
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 47);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(218, 23);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Цена | Литер | Номер";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialListBox_roomInArend
            // 
            this.materialListBox_roomInArend.BackColor = System.Drawing.Color.White;
            this.materialListBox_roomInArend.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBox_roomInArend.Depth = 0;
            this.materialListBox_roomInArend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBox_roomInArend.Location = new System.Drawing.Point(17, 82);
            this.materialListBox_roomInArend.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBox_roomInArend.Name = "materialListBox_roomInArend";
            this.materialListBox_roomInArend.SelectedIndex = -1;
            this.materialListBox_roomInArend.SelectedItem = null;
            this.materialListBox_roomInArend.ShowBorder = false;
            this.materialListBox_roomInArend.ShowScrollBar = true;
            this.materialListBox_roomInArend.Size = new System.Drawing.Size(218, 197);
            this.materialListBox_roomInArend.TabIndex = 3;
            this.materialListBox_roomInArend.UseAccentColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(218, 23);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Арендованные помещения";
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
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(4, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1105, 558);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Number";
            this.Column1.HeaderText = "Номер договора";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenantTitle";
            this.Column3.HeaderText = "Наименование арендатора";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TenantInn";
            this.Column4.HeaderText = "ИНН арендатора";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DateStart";
            this.Column6.HeaderText = "Дата начала";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DateEnd";
            this.Column7.HeaderText = "Дата окончания";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Archive";
            this.Column2.HeaderText = "Архив";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1392, 657);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.materialButton_add);
            this.flowLayoutPanel1.Controls.Add(this.materialButton_delete);
            this.flowLayoutPanel1.Controls.Add(this.materialTextBox_search);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1106, 58);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.materialButton_exit);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1115, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(274, 58);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // materialButton_exit
            // 
            this.materialButton_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_exit.AutoSize = false;
            this.materialButton_exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton_exit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton_exit.Depth = 0;
            this.materialButton_exit.HighEmphasis = true;
            this.materialButton_exit.Icon = null;
            this.materialButton_exit.Location = new System.Drawing.Point(102, 6);
            this.materialButton_exit.Margin = new System.Windows.Forms.Padding(14, 6, 0, 6);
            this.materialButton_exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton_exit.Name = "materialButton_exit";
            this.materialButton_exit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton_exit.Size = new System.Drawing.Size(158, 45);
            this.materialButton_exit.TabIndex = 12;
            this.materialButton_exit.Text = "Выход";
            this.materialButton_exit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_exit.UseAccentColor = false;
            this.materialButton_exit.UseVisualStyleBackColor = true;
            this.materialButton_exit.Click += new System.EventHandler(this.materialButton_exit_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.materialCard1);
            this.flowLayoutPanel3.Controls.Add(this.materialButton_toPDF);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1115, 67);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(274, 558);
            this.flowLayoutPanel3.TabIndex = 18;
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
            this.materialButton_toPDF.Size = new System.Drawing.Size(252, 45);
            this.materialButton_toPDF.TabIndex = 15;
            this.materialButton_toPDF.Text = "Сохранить в PDF";
            this.materialButton_toPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton_toPDF.UseAccentColor = false;
            this.materialButton_toPDF.UseVisualStyleBackColor = true;
            this.materialButton_toPDF.Click += new System.EventHandler(this.materialButton_toPDF_Click);
            // 
            // UserControlContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "UserControlContract";
            this.Size = new System.Drawing.Size(1392, 657);
            this.Load += new System.EventHandler(this.UserControlContract_Load);
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
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox_search;
        private MaterialSkin.Controls.MaterialButton materialButton_delete;
        private MaterialSkin.Controls.MaterialButton materialButton_add;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton materialButton_exit;
        private MaterialSkin.Controls.MaterialButton materialButton_toPDF;
        private MaterialSkin.Controls.MaterialListBox materialListBox_roomInArend;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
