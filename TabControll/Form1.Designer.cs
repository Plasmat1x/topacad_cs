﻿namespace TabControll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.refresh_bt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sleep_bar = new System.Windows.Forms.ProgressBar();
            this.clear_bar = new System.Windows.Forms.ProgressBar();
            this.happy_bar = new System.Windows.Forms.ProgressBar();
            this.hungry_bar = new System.Windows.Forms.ProgressBar();
            this.health_bar = new System.Windows.Forms.ProgressBar();
            this.money_val = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.play_bt = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dish_bt = new System.Windows.Forms.Button();
            this.bath_bt = new System.Windows.Forms.Button();
            this.sleep_bt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.refresh_bt);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.sleep_bar);
            this.tabPage1.Controls.Add(this.clear_bar);
            this.tabPage1.Controls.Add(this.happy_bar);
            this.tabPage1.Controls.Add(this.hungry_bar);
            this.tabPage1.Controls.Add(this.health_bar);
            this.tabPage1.Controls.Add(this.money_val);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // refresh_bt
            // 
            this.refresh_bt.Location = new System.Drawing.Point(211, 8);
            this.refresh_bt.Name = "refresh_bt";
            this.refresh_bt.Size = new System.Drawing.Size(75, 23);
            this.refresh_bt.TabIndex = 13;
            this.refresh_bt.Text = "refresh";
            this.refresh_bt.UseVisualStyleBackColor = true;
            this.refresh_bt.Click += new System.EventHandler(this.refresh_bt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "action";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sleep_bar
            // 
            this.sleep_bar.Location = new System.Drawing.Point(83, 127);
            this.sleep_bar.Name = "sleep_bar";
            this.sleep_bar.Size = new System.Drawing.Size(100, 23);
            this.sleep_bar.TabIndex = 11;
            // 
            // clear_bar
            // 
            this.clear_bar.Location = new System.Drawing.Point(83, 98);
            this.clear_bar.Name = "clear_bar";
            this.clear_bar.Size = new System.Drawing.Size(100, 23);
            this.clear_bar.TabIndex = 10;
            // 
            // happy_bar
            // 
            this.happy_bar.Location = new System.Drawing.Point(83, 66);
            this.happy_bar.Name = "happy_bar";
            this.happy_bar.Size = new System.Drawing.Size(100, 23);
            this.happy_bar.TabIndex = 9;
            // 
            // hungry_bar
            // 
            this.hungry_bar.Location = new System.Drawing.Point(83, 37);
            this.hungry_bar.Name = "hungry_bar";
            this.hungry_bar.Size = new System.Drawing.Size(100, 23);
            this.hungry_bar.TabIndex = 8;
            // 
            // health_bar
            // 
            this.health_bar.Location = new System.Drawing.Point(83, 8);
            this.health_bar.Name = "health_bar";
            this.health_bar.Size = new System.Drawing.Size(100, 23);
            this.health_bar.TabIndex = 7;
            // 
            // money_val
            // 
            this.money_val.AutoSize = true;
            this.money_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money_val.Location = new System.Drawing.Point(79, 155);
            this.money_val.Name = "money_val";
            this.money_val.Size = new System.Drawing.Size(19, 20);
            this.money_val.TabIndex = 6;
            this.money_val.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Money";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sleep";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clear";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Happy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hungry";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.play_bt);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "play room";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // play_bt
            // 
            this.play_bt.Location = new System.Drawing.Point(6, 371);
            this.play_bt.Name = "play_bt";
            this.play_bt.Size = new System.Drawing.Size(75, 23);
            this.play_bt.TabIndex = 0;
            this.play_bt.Text = "Play";
            this.play_bt.UseVisualStyleBackColor = true;
            this.play_bt.Click += new System.EventHandler(this.play_bt_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dish_bt);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "dining room";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bath_bt);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "bathroom";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.sleep_bt);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(768, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "badroom";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dish_bt
            // 
            this.dish_bt.Location = new System.Drawing.Point(3, 374);
            this.dish_bt.Name = "dish_bt";
            this.dish_bt.Size = new System.Drawing.Size(75, 23);
            this.dish_bt.TabIndex = 1;
            this.dish_bt.Text = "dish";
            this.dish_bt.UseVisualStyleBackColor = true;
            this.dish_bt.Click += new System.EventHandler(this.dish_bt_Click);
            // 
            // bath_bt
            // 
            this.bath_bt.Location = new System.Drawing.Point(3, 374);
            this.bath_bt.Name = "bath_bt";
            this.bath_bt.Size = new System.Drawing.Size(75, 23);
            this.bath_bt.TabIndex = 1;
            this.bath_bt.Text = "bath";
            this.bath_bt.UseVisualStyleBackColor = true;
            this.bath_bt.Click += new System.EventHandler(this.bath_bt_Click);
            // 
            // sleep_bt
            // 
            this.sleep_bt.Location = new System.Drawing.Point(3, 374);
            this.sleep_bt.Name = "sleep_bt";
            this.sleep_bt.Size = new System.Drawing.Size(75, 23);
            this.sleep_bt.TabIndex = 1;
            this.sleep_bt.Text = "sleep";
            this.sleep_bt.UseVisualStyleBackColor = true;
            this.sleep_bt.Click += new System.EventHandler(this.sleep_bt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar sleep_bar;
        private System.Windows.Forms.ProgressBar clear_bar;
        private System.Windows.Forms.ProgressBar happy_bar;
        private System.Windows.Forms.ProgressBar hungry_bar;
        private System.Windows.Forms.ProgressBar health_bar;
        private System.Windows.Forms.Label money_val;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button refresh_bt;
        private System.Windows.Forms.Button play_bt;
        private System.Windows.Forms.Button dish_bt;
        private System.Windows.Forms.Button bath_bt;
        private System.Windows.Forms.Button sleep_bt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

