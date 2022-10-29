namespace WindowsFormsApp69
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
            this.label1 = new System.Windows.Forms.Label();
            this.Sum_Button = new System.Windows.Forms.Button();
            this.Sub_Button = new System.Windows.Forms.Button();
            this.Multi_Button = new System.Windows.Forms.Button();
            this.Div_Button = new System.Windows.Forms.Button();
            this.Incr_Button = new System.Windows.Forms.Button();
            this.Decr_Button = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(207, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Sum_Button
            // 
            this.Sum_Button.Location = new System.Drawing.Point(12, 166);
            this.Sum_Button.Name = "Sum_Button";
            this.Sum_Button.Size = new System.Drawing.Size(124, 57);
            this.Sum_Button.TabIndex = 1;
            this.Sum_Button.Text = "+";
            this.Sum_Button.UseVisualStyleBackColor = true;
            this.Sum_Button.Click += new System.EventHandler(this.Sum_Button_Click);
            // 
            // Sub_Button
            // 
            this.Sub_Button.Location = new System.Drawing.Point(142, 166);
            this.Sub_Button.Name = "Sub_Button";
            this.Sub_Button.Size = new System.Drawing.Size(124, 57);
            this.Sub_Button.TabIndex = 2;
            this.Sub_Button.Text = "-";
            this.Sub_Button.UseVisualStyleBackColor = true;
            this.Sub_Button.Click += new System.EventHandler(this.Sub_Button_Click);
            // 
            // Multi_Button
            // 
            this.Multi_Button.Location = new System.Drawing.Point(272, 166);
            this.Multi_Button.Name = "Multi_Button";
            this.Multi_Button.Size = new System.Drawing.Size(124, 57);
            this.Multi_Button.TabIndex = 3;
            this.Multi_Button.Text = "*";
            this.Multi_Button.UseVisualStyleBackColor = true;
            this.Multi_Button.Click += new System.EventHandler(this.Multi_Button_Click);
            // 
            // Div_Button
            // 
            this.Div_Button.Location = new System.Drawing.Point(402, 166);
            this.Div_Button.Name = "Div_Button";
            this.Div_Button.Size = new System.Drawing.Size(124, 57);
            this.Div_Button.TabIndex = 4;
            this.Div_Button.Text = "/";
            this.Div_Button.UseVisualStyleBackColor = true;
            this.Div_Button.Click += new System.EventHandler(this.Div_Button_Click);
            // 
            // Incr_Button
            // 
            this.Incr_Button.Location = new System.Drawing.Point(142, 265);
            this.Incr_Button.Name = "Incr_Button";
            this.Incr_Button.Size = new System.Drawing.Size(124, 57);
            this.Incr_Button.TabIndex = 5;
            this.Incr_Button.Text = "++";
            this.Incr_Button.UseVisualStyleBackColor = true;
            this.Incr_Button.Click += new System.EventHandler(this.Incr_Button_Click);
            // 
            // Decr_Button
            // 
            this.Decr_Button.Location = new System.Drawing.Point(272, 265);
            this.Decr_Button.Name = "Decr_Button";
            this.Decr_Button.Size = new System.Drawing.Size(124, 57);
            this.Decr_Button.TabIndex = 6;
            this.Decr_Button.Text = "--";
            this.Decr_Button.UseVisualStyleBackColor = true;
            this.Decr_Button.Click += new System.EventHandler(this.Decr_Button_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(207, 114);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(124, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 475);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Decr_Button);
            this.Controls.Add(this.Incr_Button);
            this.Controls.Add(this.Div_Button);
            this.Controls.Add(this.Multi_Button);
            this.Controls.Add(this.Sub_Button);
            this.Controls.Add(this.Sum_Button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sum_Button;
        private System.Windows.Forms.Button Sub_Button;
        private System.Windows.Forms.Button Multi_Button;
        private System.Windows.Forms.Button Div_Button;
        private System.Windows.Forms.Button Incr_Button;
        private System.Windows.Forms.Button Decr_Button;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

