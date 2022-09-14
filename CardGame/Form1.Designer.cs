namespace CardGame
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
            this.image1 = new System.Windows.Forms.PictureBox();
            this.image2 = new System.Windows.Forms.PictureBox();
            this.play_bt = new System.Windows.Forms.Button();
            this.next_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2)).BeginInit();
            this.SuspendLayout();
            // 
            // image1
            // 
            this.image1.Location = new System.Drawing.Point(12, 12);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(230, 426);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image1.TabIndex = 0;
            this.image1.TabStop = false;
            // 
            // image2
            // 
            this.image2.Location = new System.Drawing.Point(256, 12);
            this.image2.Name = "image2";
            this.image2.Size = new System.Drawing.Size(230, 426);
            this.image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image2.TabIndex = 1;
            this.image2.TabStop = false;
            // 
            // play_bt
            // 
            this.play_bt.Location = new System.Drawing.Point(212, 465);
            this.play_bt.Name = "play_bt";
            this.play_bt.Size = new System.Drawing.Size(75, 23);
            this.play_bt.TabIndex = 2;
            this.play_bt.Text = "play";
            this.play_bt.UseVisualStyleBackColor = true;
            this.play_bt.Click += new System.EventHandler(this.play_bt_Click);
            // 
            // next_bt
            // 
            this.next_bt.Location = new System.Drawing.Point(411, 465);
            this.next_bt.Name = "next_bt";
            this.next_bt.Size = new System.Drawing.Size(75, 23);
            this.next_bt.TabIndex = 3;
            this.next_bt.Text = "next";
            this.next_bt.UseVisualStyleBackColor = true;
            this.next_bt.Click += new System.EventHandler(this.next_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.next_bt);
            this.Controls.Add(this.play_bt);
            this.Controls.Add(this.image2);
            this.Controls.Add(this.image1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.PictureBox image2;
        private System.Windows.Forms.Button play_bt;
        private System.Windows.Forms.Button next_bt;
        private System.Windows.Forms.Label label1;
    }
}

