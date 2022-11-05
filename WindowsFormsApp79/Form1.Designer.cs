namespace WindowsFormsApp79
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
            this.AddHumanInPhoneBook_Button = new System.Windows.Forms.Button();
            this.HumanInfo_ListBox = new System.Windows.Forms.ListBox();
            this.SearchQuestions_TextBox = new System.Windows.Forms.TextBox();
            this.SearchType_ComboBox = new System.Windows.Forms.ComboBox();
            this.Sort_GroupBox = new System.Windows.Forms.GroupBox();
            this.SortSurname_RadioButton = new System.Windows.Forms.RadioButton();
            this.SortFirstName_RadioButton = new System.Windows.Forms.RadioButton();
            this.Search_Button = new System.Windows.Forms.Button();
            this.DeleteHuman_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sort_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddHumanInPhoneBook_Button
            // 
            this.AddHumanInPhoneBook_Button.Location = new System.Drawing.Point(12, 61);
            this.AddHumanInPhoneBook_Button.Name = "AddHumanInPhoneBook_Button";
            this.AddHumanInPhoneBook_Button.Size = new System.Drawing.Size(178, 158);
            this.AddHumanInPhoneBook_Button.TabIndex = 0;
            this.AddHumanInPhoneBook_Button.Text = "Добавить человека в справочник";
            this.AddHumanInPhoneBook_Button.UseVisualStyleBackColor = true;
            this.AddHumanInPhoneBook_Button.Click += new System.EventHandler(this.AddHumanInPhoneBook_Button_Click);
            // 
            // HumanInfo_ListBox
            // 
            this.HumanInfo_ListBox.FormattingEnabled = true;
            this.HumanInfo_ListBox.ItemHeight = 16;
            this.HumanInfo_ListBox.Location = new System.Drawing.Point(341, 61);
            this.HumanInfo_ListBox.Name = "HumanInfo_ListBox";
            this.HumanInfo_ListBox.Size = new System.Drawing.Size(645, 436);
            this.HumanInfo_ListBox.TabIndex = 1;
            this.HumanInfo_ListBox.SelectedIndexChanged += new System.EventHandler(this.HumanInfo_ListBox_SelectedIndexChanged);
            this.HumanInfo_ListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.HumanInfo_ListBox_MouseDoubleClick);
            // 
            // SearchQuestions_TextBox
            // 
            this.SearchQuestions_TextBox.Location = new System.Drawing.Point(584, 33);
            this.SearchQuestions_TextBox.Name = "SearchQuestions_TextBox";
            this.SearchQuestions_TextBox.Size = new System.Drawing.Size(402, 22);
            this.SearchQuestions_TextBox.TabIndex = 2;
            // 
            // SearchType_ComboBox
            // 
            this.SearchType_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchType_ComboBox.FormattingEnabled = true;
            this.SearchType_ComboBox.Items.AddRange(new object[] {
            "",
            "По имени",
            "По фамилии",
            "По телефону"});
            this.SearchType_ComboBox.Location = new System.Drawing.Point(421, 33);
            this.SearchType_ComboBox.Name = "SearchType_ComboBox";
            this.SearchType_ComboBox.Size = new System.Drawing.Size(157, 24);
            this.SearchType_ComboBox.TabIndex = 3;
            // 
            // Sort_GroupBox
            // 
            this.Sort_GroupBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Sort_GroupBox.Controls.Add(this.SortSurname_RadioButton);
            this.Sort_GroupBox.Controls.Add(this.SortFirstName_RadioButton);
            this.Sort_GroupBox.Location = new System.Drawing.Point(196, 61);
            this.Sort_GroupBox.Name = "Sort_GroupBox";
            this.Sort_GroupBox.Size = new System.Drawing.Size(139, 158);
            this.Sort_GroupBox.TabIndex = 4;
            this.Sort_GroupBox.TabStop = false;
            this.Sort_GroupBox.Text = "Сортировать";
            // 
            // SortSurname_RadioButton
            // 
            this.SortSurname_RadioButton.AutoSize = true;
            this.SortSurname_RadioButton.Location = new System.Drawing.Point(7, 63);
            this.SortSurname_RadioButton.Name = "SortSurname_RadioButton";
            this.SortSurname_RadioButton.Size = new System.Drawing.Size(109, 20);
            this.SortSurname_RadioButton.TabIndex = 1;
            this.SortSurname_RadioButton.TabStop = true;
            this.SortSurname_RadioButton.Text = "По фамилии";
            this.SortSurname_RadioButton.UseVisualStyleBackColor = true;
            this.SortSurname_RadioButton.CheckedChanged += new System.EventHandler(this.SortSurname_RadioButton_CheckedChanged);
            // 
            // SortFirstName_RadioButton
            // 
            this.SortFirstName_RadioButton.AutoSize = true;
            this.SortFirstName_RadioButton.Location = new System.Drawing.Point(7, 37);
            this.SortFirstName_RadioButton.Name = "SortFirstName_RadioButton";
            this.SortFirstName_RadioButton.Size = new System.Drawing.Size(90, 20);
            this.SortFirstName_RadioButton.TabIndex = 0;
            this.SortFirstName_RadioButton.TabStop = true;
            this.SortFirstName_RadioButton.Text = "По имени";
            this.SortFirstName_RadioButton.UseVisualStyleBackColor = true;
            this.SortFirstName_RadioButton.CheckedChanged += new System.EventHandler(this.SortFirstName_RadioButton_CheckedChanged);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(341, 33);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(75, 23);
            this.Search_Button.TabIndex = 6;
            this.Search_Button.Text = "Найти";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // DeleteHuman_Button
            // 
            this.DeleteHuman_Button.Location = new System.Drawing.Point(196, 226);
            this.DeleteHuman_Button.Name = "DeleteHuman_Button";
            this.DeleteHuman_Button.Size = new System.Drawing.Size(139, 52);
            this.DeleteHuman_Button.TabIndex = 7;
            this.DeleteHuman_Button.Text = "Удалить человека из справочника";
            this.DeleteHuman_Button.UseVisualStyleBackColor = true;
            this.DeleteHuman_Button.Click += new System.EventHandler(this.DeleteHuman_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 176);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DeleteHuman_Button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Sort_GroupBox);
            this.Controls.Add(this.SearchType_ComboBox);
            this.Controls.Add(this.SearchQuestions_TextBox);
            this.Controls.Add(this.HumanInfo_ListBox);
            this.Controls.Add(this.AddHumanInPhoneBook_Button);
            this.Name = "Form1";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Sort_GroupBox.ResumeLayout(false);
            this.Sort_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddHumanInPhoneBook_Button;
        private System.Windows.Forms.ListBox HumanInfo_ListBox;
        private System.Windows.Forms.TextBox SearchQuestions_TextBox;
        private System.Windows.Forms.ComboBox SearchType_ComboBox;
        private System.Windows.Forms.GroupBox Sort_GroupBox;
        private System.Windows.Forms.RadioButton SortSurname_RadioButton;
        private System.Windows.Forms.RadioButton SortFirstName_RadioButton;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button DeleteHuman_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

