namespace WindowsFormsApp129.Forms
{
    partial class CheckoutForm
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
            this.components = new System.ComponentModel.Container();
            this.customers_ListBox = new System.Windows.Forms.ListBox();
            this.detailOrder_Label = new System.Windows.Forms.Label();
            this.acceptOrder_Button = new System.Windows.Forms.Button();
            this.cookingDish_ListBox = new System.Windows.Forms.ListBox();
            this.waitCustomers_Label = new System.Windows.Forms.Label();
            this.customerQueue_Timer = new System.Windows.Forms.Timer(this.components);
            this.cookingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // customers_ListBox
            // 
            this.customers_ListBox.FormattingEnabled = true;
            this.customers_ListBox.ItemHeight = 16;
            this.customers_ListBox.Location = new System.Drawing.Point(697, 13);
            this.customers_ListBox.Name = "customers_ListBox";
            this.customers_ListBox.Size = new System.Drawing.Size(273, 644);
            this.customers_ListBox.TabIndex = 0;
            this.customers_ListBox.SelectedIndexChanged += new System.EventHandler(this.customers_ListBox_SelectedIndexChanged);
            // 
            // detailOrder_Label
            // 
            this.detailOrder_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailOrder_Label.Location = new System.Drawing.Point(493, 13);
            this.detailOrder_Label.Name = "detailOrder_Label";
            this.detailOrder_Label.Size = new System.Drawing.Size(198, 138);
            this.detailOrder_Label.TabIndex = 1;
            // 
            // acceptOrder_Button
            // 
            this.acceptOrder_Button.Location = new System.Drawing.Point(493, 176);
            this.acceptOrder_Button.Name = "acceptOrder_Button";
            this.acceptOrder_Button.Size = new System.Drawing.Size(198, 56);
            this.acceptOrder_Button.TabIndex = 2;
            this.acceptOrder_Button.Text = "Принять заказ";
            this.acceptOrder_Button.UseVisualStyleBackColor = true;
            this.acceptOrder_Button.Click += new System.EventHandler(this.acceptOrder_Button_Click);
            // 
            // cookingDish_ListBox
            // 
            this.cookingDish_ListBox.FormattingEnabled = true;
            this.cookingDish_ListBox.ItemHeight = 16;
            this.cookingDish_ListBox.Location = new System.Drawing.Point(13, 13);
            this.cookingDish_ListBox.Name = "cookingDish_ListBox";
            this.cookingDish_ListBox.Size = new System.Drawing.Size(474, 644);
            this.cookingDish_ListBox.TabIndex = 3;
            // 
            // waitCustomers_Label
            // 
            this.waitCustomers_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waitCustomers_Label.Location = new System.Drawing.Point(494, 446);
            this.waitCustomers_Label.Name = "waitCustomers_Label";
            this.waitCustomers_Label.Size = new System.Drawing.Size(197, 211);
            this.waitCustomers_Label.TabIndex = 4;
            // 
            // customerQueue_Timer
            // 
            this.customerQueue_Timer.Interval = 1000;
            this.customerQueue_Timer.Tick += new System.EventHandler(this.cutomerQueue_Timer_Tick);
            // 
            // cookingTimer
            // 
            this.cookingTimer.Interval = 1000;

            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 674);
            this.Controls.Add(this.waitCustomers_Label);
            this.Controls.Add(this.cookingDish_ListBox);
            this.Controls.Add(this.acceptOrder_Button);
            this.Controls.Add(this.detailOrder_Label);
            this.Controls.Add(this.customers_ListBox);
            this.Name = "CheckoutForm";
            this.Text = "CheckoutForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox customers_ListBox;
        private System.Windows.Forms.Label detailOrder_Label;
        private System.Windows.Forms.Button acceptOrder_Button;
        private System.Windows.Forms.ListBox cookingDish_ListBox;
        private System.Windows.Forms.Label waitCustomers_Label;
        private System.Windows.Forms.Timer customerQueue_Timer;
        private System.Windows.Forms.Timer cookingTimer;
    }
}