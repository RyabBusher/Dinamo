namespace Dinamo
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonClientsOpen = new System.Windows.Forms.Button();
            this.buttonProductsOpen = new System.Windows.Forms.Button();
            this.buttonSuppliersOpen = new System.Windows.Forms.Button();
            this.buttonPersonalOpen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClientsOpen
            // 
            this.buttonClientsOpen.Location = new System.Drawing.Point(12, 126);
            this.buttonClientsOpen.Name = "buttonClientsOpen";
            this.buttonClientsOpen.Size = new System.Drawing.Size(319, 55);
            this.buttonClientsOpen.TabIndex = 0;
            this.buttonClientsOpen.Text = "Клиенты";
            this.buttonClientsOpen.UseVisualStyleBackColor = true;
            this.buttonClientsOpen.Click += new System.EventHandler(this.buttonClientsOpen_Click);
            // 
            // buttonProductsOpen
            // 
            this.buttonProductsOpen.Location = new System.Drawing.Point(12, 248);
            this.buttonProductsOpen.Name = "buttonProductsOpen";
            this.buttonProductsOpen.Size = new System.Drawing.Size(319, 55);
            this.buttonProductsOpen.TabIndex = 1;
            this.buttonProductsOpen.Text = "Товары";
            this.buttonProductsOpen.UseVisualStyleBackColor = true;
            this.buttonProductsOpen.Click += new System.EventHandler(this.buttonProductsOpen_Click);
            // 
            // buttonSuppliersOpen
            // 
            this.buttonSuppliersOpen.Location = new System.Drawing.Point(12, 187);
            this.buttonSuppliersOpen.Name = "buttonSuppliersOpen";
            this.buttonSuppliersOpen.Size = new System.Drawing.Size(319, 55);
            this.buttonSuppliersOpen.TabIndex = 2;
            this.buttonSuppliersOpen.Text = "Поставщики";
            this.buttonSuppliersOpen.UseVisualStyleBackColor = true;
            this.buttonSuppliersOpen.Click += new System.EventHandler(this.buttonSuppliersOpen_Click);
            // 
            // buttonPersonalOpen
            // 
            this.buttonPersonalOpen.Location = new System.Drawing.Point(12, 309);
            this.buttonPersonalOpen.Name = "buttonPersonalOpen";
            this.buttonPersonalOpen.Size = new System.Drawing.Size(319, 55);
            this.buttonPersonalOpen.TabIndex = 3;
            this.buttonPersonalOpen.Text = "Персонал";
            this.buttonPersonalOpen.UseVisualStyleBackColor = true;
            this.buttonPersonalOpen.Click += new System.EventHandler(this.buttonPersonalOpen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPersonalOpen);
            this.Controls.Add(this.buttonSuppliersOpen);
            this.Controls.Add(this.buttonProductsOpen);
            this.Controls.Add(this.buttonClientsOpen);
            this.Name = "FormMenu";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClientsOpen;
        private System.Windows.Forms.Button buttonProductsOpen;
        private System.Windows.Forms.Button buttonSuppliersOpen;
        private System.Windows.Forms.Button buttonPersonalOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

