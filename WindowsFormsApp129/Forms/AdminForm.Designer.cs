namespace WindowsFormsApp129
{
    partial class AdminForm
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
            this.dishes_ListBox = new System.Windows.Forms.ListBox();
            this.addDish_Button = new System.Windows.Forms.Button();
            this.removeDish_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dishes_ListBox
            // 
            this.dishes_ListBox.FormattingEnabled = true;
            this.dishes_ListBox.ItemHeight = 16;
            this.dishes_ListBox.Location = new System.Drawing.Point(13, 13);
            this.dishes_ListBox.Name = "dishes_ListBox";
            this.dishes_ListBox.Size = new System.Drawing.Size(496, 516);
            this.dishes_ListBox.TabIndex = 0;
            // 
            // addDish_Button
            // 
            this.addDish_Button.Location = new System.Drawing.Point(526, 13);
            this.addDish_Button.Name = "addDish_Button";
            this.addDish_Button.Size = new System.Drawing.Size(248, 79);
            this.addDish_Button.TabIndex = 1;
            this.addDish_Button.Text = "Добавить";
            this.addDish_Button.UseVisualStyleBackColor = true;
            this.addDish_Button.Click += new System.EventHandler(this.addDish_Button_Click);
            // 
            // removeDish_Button
            // 
            this.removeDish_Button.Location = new System.Drawing.Point(526, 117);
            this.removeDish_Button.Name = "removeDish_Button";
            this.removeDish_Button.Size = new System.Drawing.Size(248, 79);
            this.removeDish_Button.TabIndex = 2;
            this.removeDish_Button.Text = "Удалить блюдо";
            this.removeDish_Button.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 540);
            this.Controls.Add(this.removeDish_Button);
            this.Controls.Add(this.addDish_Button);
            this.Controls.Add(this.dishes_ListBox);
            this.Name = "AdminForm";
            this.Text = "Форма админа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox dishes_ListBox;
        private System.Windows.Forms.Button addDish_Button;
        private System.Windows.Forms.Button removeDish_Button;
    }
}