namespace CustomProgressBar
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
            this.cstmProgBar1 = new CustomProgressBar.CstmProgBar();
            this.SuspendLayout();
            // 
            // cstmProgBar1
            // 
            this.cstmProgBar1.Location = new System.Drawing.Point(273, 101);
            this.cstmProgBar1.Name = "cstmProgBar1";
            this.cstmProgBar1.Size = new System.Drawing.Size(100, 23);
            this.cstmProgBar1.TabIndex = 0;
            this.cstmProgBar1.Click += new System.EventHandler(this.cstmProgBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cstmProgBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CstmProgBar cstmProgBar1;
    }
}

