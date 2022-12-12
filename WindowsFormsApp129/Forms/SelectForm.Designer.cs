namespace WindowsFormsApp129
{
    partial class SelectForm
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
            this.checkout_Button = new System.Windows.Forms.Button();
            this.admin_Button = new System.Windows.Forms.Button();
            this.manager_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkout_Button
            // 
            this.checkout_Button.Location = new System.Drawing.Point(12, 12);
            this.checkout_Button.Name = "checkout_Button";
            this.checkout_Button.Size = new System.Drawing.Size(355, 127);
            this.checkout_Button.TabIndex = 0;
            this.checkout_Button.Text = "Касса";
            this.checkout_Button.UseVisualStyleBackColor = true;
            this.checkout_Button.Click += new System.EventHandler(this.checkout_Button_Click);
            // 
            // admin_Button
            // 
            this.admin_Button.Location = new System.Drawing.Point(12, 145);
            this.admin_Button.Name = "admin_Button";
            this.admin_Button.Size = new System.Drawing.Size(355, 127);
            this.admin_Button.TabIndex = 1;
            this.admin_Button.Text = "Администратор";
            this.admin_Button.UseVisualStyleBackColor = true;
            this.admin_Button.Click += new System.EventHandler(this.admin_Button_Click);
            // 
            // manager_Button
            // 
            this.manager_Button.Location = new System.Drawing.Point(13, 278);
            this.manager_Button.Name = "manager_Button";
            this.manager_Button.Size = new System.Drawing.Size(355, 127);
            this.manager_Button.TabIndex = 2;
            this.manager_Button.Text = "Менеджер";
            this.manager_Button.UseVisualStyleBackColor = true;
            this.manager_Button.Click += new System.EventHandler(this.manager_Button_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 453);
            this.Controls.Add(this.manager_Button);
            this.Controls.Add(this.admin_Button);
            this.Controls.Add(this.checkout_Button);
            this.Name = "SelectForm";
            this.Text = "Выбрать форму";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkout_Button;
        private System.Windows.Forms.Button admin_Button;
        private System.Windows.Forms.Button manager_Button;
    }
}

