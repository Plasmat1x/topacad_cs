namespace WindowsFormsApp79
{
    partial class AddHumanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.Surname_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Cancel_linkLabel = new System.Windows.Forms.LinkLabel();
            this.PhoneNumber_MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.HumanPhoto_PictureBox = new System.Windows.Forms.PictureBox();
            this.AddHumanPhoto_Button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.HumanPhoto_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Location = new System.Drawing.Point(49, 61);
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(197, 22);
            this.FirstName_TextBox.TabIndex = 0;
            // 
            // Surname_TextBox
            // 
            this.Surname_TextBox.Location = new System.Drawing.Point(49, 144);
            this.Surname_TextBox.Name = "Surname_TextBox";
            this.Surname_TextBox.Size = new System.Drawing.Size(197, 22);
            this.Surname_TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер телефона";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(52, 288);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(194, 76);
            this.Add_Button.TabIndex = 6;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Cancel_linkLabel
            // 
            this.Cancel_linkLabel.AutoSize = true;
            this.Cancel_linkLabel.Location = new System.Drawing.Point(52, 382);
            this.Cancel_linkLabel.Name = "Cancel_linkLabel";
            this.Cancel_linkLabel.Size = new System.Drawing.Size(57, 16);
            this.Cancel_linkLabel.TabIndex = 7;
            this.Cancel_linkLabel.TabStop = true;
            this.Cancel_linkLabel.Text = "Отмена";
            this.Cancel_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cancel_linkLabel_LinkClicked);
            // 
            // PhoneNumber_MaskedTextBox
            // 
            this.PhoneNumber_MaskedTextBox.Location = new System.Drawing.Point(49, 241);
            this.PhoneNumber_MaskedTextBox.Mask = "0 (000) 000-00-00";
            this.PhoneNumber_MaskedTextBox.Name = "PhoneNumber_MaskedTextBox";
            this.PhoneNumber_MaskedTextBox.Size = new System.Drawing.Size(197, 22);
            this.PhoneNumber_MaskedTextBox.TabIndex = 8;
            // 
            // HumanPhoto_PictureBox
            // 
            this.HumanPhoto_PictureBox.Location = new System.Drawing.Point(308, 61);
            this.HumanPhoto_PictureBox.Name = "HumanPhoto_PictureBox";
            this.HumanPhoto_PictureBox.Size = new System.Drawing.Size(228, 202);
            this.HumanPhoto_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HumanPhoto_PictureBox.TabIndex = 9;
            this.HumanPhoto_PictureBox.TabStop = false;
            // 
            // AddHumanPhoto_Button
            // 
            this.AddHumanPhoto_Button.Location = new System.Drawing.Point(308, 288);
            this.AddHumanPhoto_Button.Name = "AddHumanPhoto_Button";
            this.AddHumanPhoto_Button.Size = new System.Drawing.Size(228, 31);
            this.AddHumanPhoto_Button.TabIndex = 10;
            this.AddHumanPhoto_Button.Text = "Добавить фото";
            this.AddHumanPhoto_Button.UseVisualStyleBackColor = true;
            this.AddHumanPhoto_Button.Click += new System.EventHandler(this.AddHumanPhoto_Button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddHumanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 472);
            this.Controls.Add(this.AddHumanPhoto_Button);
            this.Controls.Add(this.HumanPhoto_PictureBox);
            this.Controls.Add(this.PhoneNumber_MaskedTextBox);
            this.Controls.Add(this.Cancel_linkLabel);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Surname_TextBox);
            this.Controls.Add(this.FirstName_TextBox);
            this.Name = "AddHumanForm";
            this.Text = "AddHumanForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddHumanForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.HumanPhoto_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.TextBox Surname_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.LinkLabel Cancel_linkLabel;
        private System.Windows.Forms.MaskedTextBox PhoneNumber_MaskedTextBox;
        private System.Windows.Forms.PictureBox HumanPhoto_PictureBox;
        private System.Windows.Forms.Button AddHumanPhoto_Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}