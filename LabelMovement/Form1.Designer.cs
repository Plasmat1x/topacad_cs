namespace LabelMovement
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
            this.center_cb = new System.Windows.Forms.CheckBox();
            this.bt_left = new System.Windows.Forms.Button();
            this.bt_right = new System.Windows.Forms.Button();
            this.bt_down = new System.Windows.Forms.Button();
            this.bt_up = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // center_cb
            // 
            this.center_cb.AutoSize = true;
            this.center_cb.Location = new System.Drawing.Point(353, 41);
            this.center_cb.Name = "center_cb";
            this.center_cb.Size = new System.Drawing.Size(57, 17);
            this.center_cb.TabIndex = 0;
            this.center_cb.Text = "Center";
            this.center_cb.UseVisualStyleBackColor = true;
            this.center_cb.CheckedChanged += new System.EventHandler(this.center_cb_CheckedChanged);
            // 
            // bt_left
            // 
            this.bt_left.Location = new System.Drawing.Point(268, 37);
            this.bt_left.Name = "bt_left";
            this.bt_left.Size = new System.Drawing.Size(75, 23);
            this.bt_left.TabIndex = 1;
            this.bt_left.Text = "Left";
            this.bt_left.UseVisualStyleBackColor = true;
            this.bt_left.Click += new System.EventHandler(this.bt_left_Click);
            // 
            // bt_right
            // 
            this.bt_right.Location = new System.Drawing.Point(416, 37);
            this.bt_right.Name = "bt_right";
            this.bt_right.Size = new System.Drawing.Size(75, 23);
            this.bt_right.TabIndex = 2;
            this.bt_right.Text = "Right";
            this.bt_right.UseVisualStyleBackColor = true;
            this.bt_right.Click += new System.EventHandler(this.bt_right_Click);
            // 
            // bt_down
            // 
            this.bt_down.Location = new System.Drawing.Point(341, 66);
            this.bt_down.Name = "bt_down";
            this.bt_down.Size = new System.Drawing.Size(75, 23);
            this.bt_down.TabIndex = 3;
            this.bt_down.Text = "Down";
            this.bt_down.UseVisualStyleBackColor = true;
            this.bt_down.Click += new System.EventHandler(this.bt_down_Click);
            // 
            // bt_up
            // 
            this.bt_up.Location = new System.Drawing.Point(341, 8);
            this.bt_up.Name = "bt_up";
            this.bt_up.Size = new System.Drawing.Size(75, 23);
            this.bt_up.TabIndex = 4;
            this.bt_up.Text = "Up";
            this.bt_up.UseVisualStyleBackColor = true;
            this.bt_up.Click += new System.EventHandler(this.bt_up_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 345);
            this.label1.TabIndex = 5;
            this.label1.Text = "Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_up);
            this.Controls.Add(this.bt_down);
            this.Controls.Add(this.bt_right);
            this.Controls.Add(this.bt_left);
            this.Controls.Add(this.center_cb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox center_cb;
        private System.Windows.Forms.Button bt_left;
        private System.Windows.Forms.Button bt_right;
        private System.Windows.Forms.Button bt_down;
        private System.Windows.Forms.Button bt_up;
        private System.Windows.Forms.Label label1;
    }
}

