namespace Dinamo
{
    partial class Form1
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
            this.buttonClientsOpen = new System.Windows.Forms.Button();
            this.buttonProductsOpen = new System.Windows.Forms.Button();
            this.buttonSuppliersOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClientsOpen
            // 
            this.buttonClientsOpen.Location = new System.Drawing.Point(12, 100);
            this.buttonClientsOpen.Name = "buttonClientsOpen";
            this.buttonClientsOpen.Size = new System.Drawing.Size(319, 55);
            this.buttonClientsOpen.TabIndex = 0;
            this.buttonClientsOpen.Text = "Клиенты";
            this.buttonClientsOpen.UseVisualStyleBackColor = true;
            // 
            // buttonProductsOpen
            // 
            this.buttonProductsOpen.Location = new System.Drawing.Point(12, 161);
            this.buttonProductsOpen.Name = "buttonProductsOpen";
            this.buttonProductsOpen.Size = new System.Drawing.Size(319, 55);
            this.buttonProductsOpen.TabIndex = 1;
            this.buttonProductsOpen.Text = "Товары";
            this.buttonProductsOpen.UseVisualStyleBackColor = true;
            // 
            // buttonSuppliersOpen
            // 
            this.buttonSuppliersOpen.Location = new System.Drawing.Point(12, 222);
            this.buttonSuppliersOpen.Name = "buttonSuppliersOpen";
            this.buttonSuppliersOpen.Size = new System.Drawing.Size(319, 55);
            this.buttonSuppliersOpen.TabIndex = 2;
            this.buttonSuppliersOpen.Text = "Поставщики";
            this.buttonSuppliersOpen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 289);
            this.Controls.Add(this.buttonSuppliersOpen);
            this.Controls.Add(this.buttonProductsOpen);
            this.Controls.Add(this.buttonClientsOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClientsOpen;
        private System.Windows.Forms.Button buttonProductsOpen;
        private System.Windows.Forms.Button buttonSuppliersOpen;
    }
}

