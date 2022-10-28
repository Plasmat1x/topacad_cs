namespace WindowsFormsApp44
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
            this.Description_TextBox = new System.Windows.Forms.TextBox();
            this.Results_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Directory_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Read_Button = new System.Windows.Forms.Button();
            this.Info_TextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.Location = new System.Drawing.Point(96, 32);
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.Size = new System.Drawing.Size(282, 22);
            this.Description_TextBox.TabIndex = 0;
            // 
            // Results_TextBox
            // 
            this.Results_TextBox.Location = new System.Drawing.Point(96, 87);
            this.Results_TextBox.Name = "Results_TextBox";
            this.Results_TextBox.Size = new System.Drawing.Size(282, 22);
            this.Results_TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Причина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Последнее использование";
            // 
            // Directory_Button
            // 
            this.Directory_Button.Location = new System.Drawing.Point(16, 176);
            this.Directory_Button.Name = "Directory_Button";
            this.Directory_Button.Size = new System.Drawing.Size(112, 64);
            this.Directory_Button.TabIndex = 6;
            this.Directory_Button.Text = "Папка";
            this.Directory_Button.UseVisualStyleBackColor = true;
            this.Directory_Button.Click += new System.EventHandler(this.Directory_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(134, 176);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(126, 64);
            this.Save_Button.TabIndex = 7;
            this.Save_Button.Text = "Сохранить";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Read_Button
            // 
            this.Read_Button.Location = new System.Drawing.Point(266, 176);
            this.Read_Button.Name = "Read_Button";
            this.Read_Button.Size = new System.Drawing.Size(112, 64);
            this.Read_Button.TabIndex = 8;
            this.Read_Button.Text = "Открыть";
            this.Read_Button.UseVisualStyleBackColor = true;
            this.Read_Button.Click += new System.EventHandler(this.Read_Button_Click);
            // 
            // Info_TextBox
            // 
            this.Info_TextBox.Location = new System.Drawing.Point(428, 35);
            this.Info_TextBox.Multiline = true;
            this.Info_TextBox.Name = "Info_TextBox";
            this.Info_TextBox.Size = new System.Drawing.Size(360, 205);
            this.Info_TextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 311);
            this.Controls.Add(this.Info_TextBox);
            this.Controls.Add(this.Read_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Directory_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Results_TextBox);
            this.Controls.Add(this.Description_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Description_TextBox;
        private System.Windows.Forms.TextBox Results_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Directory_Button;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Read_Button;
        private System.Windows.Forms.TextBox Info_TextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

