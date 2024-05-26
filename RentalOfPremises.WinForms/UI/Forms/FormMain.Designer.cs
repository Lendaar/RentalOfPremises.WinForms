using RentalOfPremises.WinForms.UserControls;

namespace RentalOfPremises.WinForms.Forms
{
    partial class FormMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userControlContract1 = new RentalOfPremises.WinForms.UserControls.UserControlContract();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.userControlPayment1 = new RentalOfPremises.WinForms.UserControls.UserControlPayment();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.userControlRoom1 = new RentalOfPremises.WinForms.UserControls.UserControlRoom();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.userControlTenant1 = new RentalOfPremises.WinForms.UserControls.UserControlTenant();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.userControlPrice1 = new RentalOfPremises.WinForms.UserControls.UserControlPrice();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.userControlUser3 = new RentalOfPremises.WinForms.UserControls.UserControlUser();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.HotTrack = true;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 72);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.ShowToolTips = true;
            this.materialTabControl1.Size = new System.Drawing.Size(1754, 725);
            this.materialTabControl1.TabIndex = 18;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.userControlContract1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.ImageKey = "dogovor1.jpg";
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1746, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "Договоры для аренды";
            this.tabPage1.Text = "Договоры";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userControlContract1
            // 
            this.userControlContract1.Cursor = System.Windows.Forms.Cursors.Default;
            this.userControlContract1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlContract1.Location = new System.Drawing.Point(3, 3);
            this.userControlContract1.Name = "userControlContract1";
            this.userControlContract1.Size = new System.Drawing.Size(1740, 673);
            this.userControlContract1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.userControlPayment1);
            this.tabPage2.ImageKey = "payment.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1746, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "Счета для оплаты";
            this.tabPage2.Text = "Счета";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // userControlPayment1
            // 
            this.userControlPayment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPayment1.Location = new System.Drawing.Point(3, 3);
            this.userControlPayment1.Name = "userControlPayment1";
            this.userControlPayment1.Size = new System.Drawing.Size(1740, 673);
            this.userControlPayment1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.userControlRoom1);
            this.tabPage3.ImageKey = "room.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1746, 679);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = "Помещения для аренды";
            this.tabPage3.Text = "Помещения";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // userControlRoom1
            // 
            this.userControlRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRoom1.Location = new System.Drawing.Point(0, 0);
            this.userControlRoom1.Name = "userControlRoom1";
            this.userControlRoom1.Size = new System.Drawing.Size(1746, 679);
            this.userControlRoom1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.userControlTenant1);
            this.tabPage4.ImageKey = "arendator.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 42);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1746, 679);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Tag = "Арендаторы";
            this.tabPage4.Text = "Арендаторы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // userControlTenant1
            // 
            this.userControlTenant1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlTenant1.Location = new System.Drawing.Point(0, 0);
            this.userControlTenant1.Name = "userControlTenant1";
            this.userControlTenant1.Size = new System.Drawing.Size(1746, 679);
            this.userControlTenant1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.userControlPrice1);
            this.tabPage5.ImageKey = "price.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 42);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1746, 679);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Tag = "Прейскурант";
            this.tabPage5.Text = "Прейскурант";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // userControlPrice1
            // 
            this.userControlPrice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPrice1.Location = new System.Drawing.Point(0, 0);
            this.userControlPrice1.Name = "userControlPrice1";
            this.userControlPrice1.Size = new System.Drawing.Size(1746, 679);
            this.userControlPrice1.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.userControlUser3);
            this.tabPage6.ImageKey = "user.png";
            this.tabPage6.Location = new System.Drawing.Point(4, 42);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1746, 679);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Tag = "Пользователи";
            this.tabPage6.Text = "Пользователи";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // userControlUser3
            // 
            this.userControlUser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlUser3.Location = new System.Drawing.Point(0, 0);
            this.userControlUser3.Name = "userControlUser3";
            this.userControlUser3.Size = new System.Drawing.Size(1746, 679);
            this.userControlUser3.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "arendator.png");
            this.imageList1.Images.SetKeyName(1, "payment.png");
            this.imageList1.Images.SetKeyName(2, "price.png");
            this.imageList1.Images.SetKeyName(3, "room.png");
            this.imageList1.Images.SetKeyName(4, "user.png");
            this.imageList1.Images.SetKeyName(5, "dogovor1.jpg");
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1760, 800);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerIndicatorWidth = 10;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.ForeColor = System.Drawing.Color.White;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договоры для аренды";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private UserControls.UserControlUser userControlUser1;
        private UserControls.UserControlUser userControlUser2;
        private UserControlUser userControlUser3;
        private UserControlRoom userControlRoom1;
        private UserControlTenant userControlTenant1;
        private UserControlContract userControlContract1;
        private UserControlPrice userControlPrice1;
        private UserControlPayment userControlPayment1;
    }
}

