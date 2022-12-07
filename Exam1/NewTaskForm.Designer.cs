namespace Exam1
{
    partial class NewTaskForm
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
            this.date_select = new System.Windows.Forms.DateTimePicker();
            this.name_text = new System.Windows.Forms.TextBox();
            this.detail_text = new System.Windows.Forms.TextBox();
            this.prioirty_select = new System.Windows.Forms.ComboBox();
            this.createtask_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // date_select
            // 
            this.date_select.CustomFormat = "dd.MM.yyyy hh:mm";
            this.date_select.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_select.Location = new System.Drawing.Point(12, 12);
            this.date_select.Name = "date_select";
            this.date_select.Size = new System.Drawing.Size(209, 20);
            this.date_select.TabIndex = 0;
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(12, 38);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(94, 20);
            this.name_text.TabIndex = 1;
            this.name_text.Text = "Task";
            // 
            // detail_text
            // 
            this.detail_text.Location = new System.Drawing.Point(12, 64);
            this.detail_text.Multiline = true;
            this.detail_text.Name = "detail_text";
            this.detail_text.Size = new System.Drawing.Size(209, 202);
            this.detail_text.TabIndex = 3;
            this.detail_text.Text = "Detail";
            // 
            // prioirty_select
            // 
            this.prioirty_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prioirty_select.FormattingEnabled = true;
            this.prioirty_select.Items.AddRange(new object[] {
            "Low",
            "Mid",
            "High"});
            this.prioirty_select.Location = new System.Drawing.Point(112, 38);
            this.prioirty_select.Name = "prioirty_select";
            this.prioirty_select.Size = new System.Drawing.Size(109, 21);
            this.prioirty_select.TabIndex = 4;
            // 
            // createtask_bt
            // 
            this.createtask_bt.Location = new System.Drawing.Point(12, 272);
            this.createtask_bt.Name = "createtask_bt";
            this.createtask_bt.Size = new System.Drawing.Size(209, 23);
            this.createtask_bt.TabIndex = 5;
            this.createtask_bt.Text = "Create task";
            this.createtask_bt.UseVisualStyleBackColor = true;
            this.createtask_bt.Click += new System.EventHandler(this.createtask_bt_Click);
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 298);
            this.Controls.Add(this.createtask_bt);
            this.Controls.Add(this.prioirty_select);
            this.Controls.Add(this.detail_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.date_select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTaskForm";
            this.Text = "NewTaskForm";
            this.Load += new System.EventHandler(this.NewTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_select;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox detail_text;
        private System.Windows.Forms.ComboBox prioirty_select;
        private System.Windows.Forms.Button createtask_bt;
    }
}