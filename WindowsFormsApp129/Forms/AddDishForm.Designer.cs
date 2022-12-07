namespace WindowsFormsApp129
{
    partial class AddDishForm
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
            this.dishName_TextBox = new System.Windows.Forms.TextBox();
            this.cookingTime_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ingredients_ComboBox = new System.Windows.Forms.ComboBox();
            this.addIngredient_Button = new System.Windows.Forms.Button();
            this.ingredients_ListBox = new System.Windows.Forms.ListBox();
            this.addDish_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cookingTime_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dishName_TextBox
            // 
            this.dishName_TextBox.Location = new System.Drawing.Point(13, 51);
            this.dishName_TextBox.Name = "dishName_TextBox";
            this.dishName_TextBox.Size = new System.Drawing.Size(173, 22);
            this.dishName_TextBox.TabIndex = 0;
            // 
            // cookingTime_NumericUpDown
            // 
            this.cookingTime_NumericUpDown.Location = new System.Drawing.Point(13, 117);
            this.cookingTime_NumericUpDown.Name = "cookingTime_NumericUpDown";
            this.cookingTime_NumericUpDown.Size = new System.Drawing.Size(173, 22);
            this.cookingTime_NumericUpDown.TabIndex = 1;
            // 
            // ingredients_ComboBox
            // 
            this.ingredients_ComboBox.FormattingEnabled = true;
            this.ingredients_ComboBox.Location = new System.Drawing.Point(329, 48);
            this.ingredients_ComboBox.Name = "ingredients_ComboBox";
            this.ingredients_ComboBox.Size = new System.Drawing.Size(193, 24);
            this.ingredients_ComboBox.TabIndex = 2;
            // 
            // addIngredient_Button
            // 
            this.addIngredient_Button.Location = new System.Drawing.Point(544, 48);
            this.addIngredient_Button.Name = "addIngredient_Button";
            this.addIngredient_Button.Size = new System.Drawing.Size(112, 25);
            this.addIngredient_Button.TabIndex = 3;
            this.addIngredient_Button.Text = "Добавить";
            this.addIngredient_Button.UseVisualStyleBackColor = true;
            this.addIngredient_Button.Click += new System.EventHandler(this.addIngredient_Button_Click);
            // 
            // ingredients_ListBox
            // 
            this.ingredients_ListBox.FormattingEnabled = true;
            this.ingredients_ListBox.ItemHeight = 16;
            this.ingredients_ListBox.Location = new System.Drawing.Point(329, 117);
            this.ingredients_ListBox.Name = "ingredients_ListBox";
            this.ingredients_ListBox.Size = new System.Drawing.Size(193, 180);
            this.ingredients_ListBox.TabIndex = 4;
            // 
            // addDish_Button
            // 
            this.addDish_Button.Location = new System.Drawing.Point(12, 163);
            this.addDish_Button.Name = "addDish_Button";
            this.addDish_Button.Size = new System.Drawing.Size(208, 134);
            this.addDish_Button.TabIndex = 5;
            this.addDish_Button.Text = "Добавить блюдо";
            this.addDish_Button.UseVisualStyleBackColor = true;
            this.addDish_Button.Click += new System.EventHandler(this.addDish_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Время приготовления:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ингридиенты:";
            // 
            // AddDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addDish_Button);
            this.Controls.Add(this.ingredients_ListBox);
            this.Controls.Add(this.addIngredient_Button);
            this.Controls.Add(this.ingredients_ComboBox);
            this.Controls.Add(this.cookingTime_NumericUpDown);
            this.Controls.Add(this.dishName_TextBox);
            this.Name = "AddDishForm";
            this.Text = "Добавление блюда";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDishForm_FormClosing);
            this.Load += new System.EventHandler(this.AddDishForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cookingTime_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dishName_TextBox;
        private System.Windows.Forms.NumericUpDown cookingTime_NumericUpDown;
        private System.Windows.Forms.ComboBox ingredients_ComboBox;
        private System.Windows.Forms.Button addIngredient_Button;
        private System.Windows.Forms.ListBox ingredients_ListBox;
        private System.Windows.Forms.Button addDish_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}