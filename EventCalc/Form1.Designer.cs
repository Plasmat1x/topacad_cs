namespace EventCalc
{
    partial class Form1
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
            this.special_cb = new System.Windows.Forms.CheckBox();
            this.health_cb = new System.Windows.Forms.CheckBox();
            this.guests_nud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.res_label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sum_label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cake_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bday_sum = new System.Windows.Forms.Label();
            this.bday_cb = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bday_nud = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guests_nud)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bday_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // special_cb
            // 
            this.special_cb.AutoSize = true;
            this.special_cb.Location = new System.Drawing.Point(6, 63);
            this.special_cb.Name = "special_cb";
            this.special_cb.Size = new System.Drawing.Size(95, 17);
            this.special_cb.TabIndex = 0;
            this.special_cb.Text = "Special design";
            this.special_cb.UseVisualStyleBackColor = true;
            this.special_cb.CheckedChanged += new System.EventHandler(this.special_cb_CheckedChanged);
            // 
            // health_cb
            // 
            this.health_cb.AutoSize = true;
            this.health_cb.Location = new System.Drawing.Point(6, 86);
            this.health_cb.Name = "health_cb";
            this.health_cb.Size = new System.Drawing.Size(86, 17);
            this.health_cb.TabIndex = 1;
            this.health_cb.Text = "Healthy food";
            this.health_cb.UseVisualStyleBackColor = true;
            this.health_cb.CheckedChanged += new System.EventHandler(this.health_cb_CheckedChanged);
            // 
            // guests_nud
            // 
            this.guests_nud.Location = new System.Drawing.Point(6, 28);
            this.guests_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guests_nud.Name = "guests_nud";
            this.guests_nud.Size = new System.Drawing.Size(120, 20);
            this.guests_nud.TabIndex = 2;
            this.guests_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guests_nud.ValueChanged += new System.EventHandler(this.guests_nud_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Guests number";
            // 
            // res_label
            // 
            this.res_label.AutoSize = true;
            this.res_label.Location = new System.Drawing.Point(6, 186);
            this.res_label.Name = "res_label";
            this.res_label.Size = new System.Drawing.Size(40, 13);
            this.res_label.TabIndex = 4;
            this.res_label.Text = "Result:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(243, 228);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.sum_label);
            this.tabPage1.Controls.Add(this.special_cb);
            this.tabPage1.Controls.Add(this.res_label);
            this.tabPage1.Controls.Add(this.health_cb);
            this.tabPage1.Controls.Add(this.guests_nud);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(235, 202);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sum_label
            // 
            this.sum_label.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sum_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum_label.Location = new System.Drawing.Point(52, 177);
            this.sum_label.Name = "sum_label";
            this.sum_label.Size = new System.Drawing.Size(100, 23);
            this.sum_label.TabIndex = 5;
            this.sum_label.Text = "$ 0";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cake_text);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.bday_sum);
            this.tabPage2.Controls.Add(this.bday_cb);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.bday_nud);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(235, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cake_text
            // 
            this.cake_text.Location = new System.Drawing.Point(6, 99);
            this.cake_text.Name = "cake_text";
            this.cake_text.Size = new System.Drawing.Size(223, 20);
            this.cake_text.TabIndex = 12;
            this.cake_text.TextChanged += new System.EventHandler(this.cake_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Guests number";
            // 
            // bday_sum
            // 
            this.bday_sum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bday_sum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bday_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bday_sum.Location = new System.Drawing.Point(52, 176);
            this.bday_sum.Name = "bday_sum";
            this.bday_sum.Size = new System.Drawing.Size(100, 23);
            this.bday_sum.TabIndex = 11;
            this.bday_sum.Text = "$ 0";
            // 
            // bday_cb
            // 
            this.bday_cb.AutoSize = true;
            this.bday_cb.Location = new System.Drawing.Point(6, 54);
            this.bday_cb.Name = "bday_cb";
            this.bday_cb.Size = new System.Drawing.Size(95, 17);
            this.bday_cb.TabIndex = 6;
            this.bday_cb.Text = "Special design";
            this.bday_cb.UseVisualStyleBackColor = true;
            this.bday_cb.CheckedChanged += new System.EventHandler(this.bday_cb_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Result:";
            // 
            // bday_nud
            // 
            this.bday_nud.Location = new System.Drawing.Point(6, 28);
            this.bday_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bday_nud.Name = "bday_nud";
            this.bday_nud.Size = new System.Drawing.Size(120, 20);
            this.bday_nud.TabIndex = 8;
            this.bday_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bday_nud.ValueChanged += new System.EventHandler(this.bday_nud_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Word on cake";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 251);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guests_nud)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bday_nud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox special_cb;
        private System.Windows.Forms.CheckBox health_cb;
        private System.Windows.Forms.NumericUpDown guests_nud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label res_label;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label sum_label;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bday_sum;
        private System.Windows.Forms.CheckBox bday_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown bday_nud;
        private System.Windows.Forms.TextBox cake_text;
        private System.Windows.Forms.Label label5;
    }
}

