namespace WindowsFormsApp108
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
            this.biology_Button = new System.Windows.Forms.Button();
            this.math_Button = new System.Windows.Forms.Button();
            this.history_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // biology_Button
            // 
            this.biology_Button.Location = new System.Drawing.Point(44, 35);
            this.biology_Button.Name = "biology_Button";
            this.biology_Button.Size = new System.Drawing.Size(209, 112);
            this.biology_Button.TabIndex = 0;
            this.biology_Button.Text = "Биология";
            this.biology_Button.UseVisualStyleBackColor = true;
            this.biology_Button.Click += new System.EventHandler(this.biology_Button_Click);
            // 
            // math_Button
            // 
            this.math_Button.Location = new System.Drawing.Point(296, 35);
            this.math_Button.Name = "math_Button";
            this.math_Button.Size = new System.Drawing.Size(209, 112);
            this.math_Button.TabIndex = 1;
            this.math_Button.Text = "Math";
            this.math_Button.UseVisualStyleBackColor = true;
            this.math_Button.Click += new System.EventHandler(this.math_Button_Click);
            // 
            // history_Button
            // 
            this.history_Button.Location = new System.Drawing.Point(529, 35);
            this.history_Button.Name = "history_Button";
            this.history_Button.Size = new System.Drawing.Size(209, 112);
            this.history_Button.TabIndex = 2;
            this.history_Button.Text = "История";
            this.history_Button.UseVisualStyleBackColor = true;
            this.history_Button.Click += new System.EventHandler(this.history_Button_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(44, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 250);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(505, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 250);
            this.label2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.history_Button);
            this.Controls.Add(this.math_Button);
            this.Controls.Add(this.biology_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button biology_Button;
        private System.Windows.Forms.Button math_Button;
        private System.Windows.Forms.Button history_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

