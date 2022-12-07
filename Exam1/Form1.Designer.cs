namespace Exam1
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
            this.tasklist = new System.Windows.Forms.ListBox();
            this.newtask_bt = new System.Windows.Forms.Button();
            this.search_text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datesearch_picker = new System.Windows.Forms.DateTimePicker();
            this.search_bt = new System.Windows.Forms.Button();
            this.search_select = new System.Windows.Forms.ComboBox();
            this.prog_comment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tasklist
            // 
            this.tasklist.FormattingEnabled = true;
            this.tasklist.Location = new System.Drawing.Point(12, 38);
            this.tasklist.Name = "tasklist";
            this.tasklist.Size = new System.Drawing.Size(260, 394);
            this.tasklist.TabIndex = 0;
            this.tasklist.DoubleClick += new System.EventHandler(this.tasklist_DoubleClick);
            // 
            // newtask_bt
            // 
            this.newtask_bt.Location = new System.Drawing.Point(12, 9);
            this.newtask_bt.Name = "newtask_bt";
            this.newtask_bt.Size = new System.Drawing.Size(75, 23);
            this.newtask_bt.TabIndex = 1;
            this.newtask_bt.Text = "New task";
            this.newtask_bt.UseVisualStyleBackColor = true;
            this.newtask_bt.Click += new System.EventHandler(this.newtask_bt_Click);
            // 
            // search_text
            // 
            this.search_text.Location = new System.Drawing.Point(6, 19);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(248, 20);
            this.search_text.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datesearch_picker);
            this.groupBox1.Controls.Add(this.search_bt);
            this.groupBox1.Controls.Add(this.search_select);
            this.groupBox1.Controls.Add(this.search_text);
            this.groupBox1.Location = new System.Drawing.Point(278, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // datesearch_picker
            // 
            this.datesearch_picker.Location = new System.Drawing.Point(87, 72);
            this.datesearch_picker.Name = "datesearch_picker";
            this.datesearch_picker.Size = new System.Drawing.Size(167, 20);
            this.datesearch_picker.TabIndex = 5;
            this.datesearch_picker.Visible = false;
            // 
            // search_bt
            // 
            this.search_bt.Location = new System.Drawing.Point(6, 72);
            this.search_bt.Name = "search_bt";
            this.search_bt.Size = new System.Drawing.Size(75, 20);
            this.search_bt.TabIndex = 4;
            this.search_bt.Text = "Search";
            this.search_bt.UseVisualStyleBackColor = true;
            this.search_bt.Click += new System.EventHandler(this.search_bt_Click);
            // 
            // search_select
            // 
            this.search_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.search_select.FormattingEnabled = true;
            this.search_select.Items.AddRange(new object[] {
            "All",
            "Name",
            "Date",
            "Priority"});
            this.search_select.Location = new System.Drawing.Point(6, 45);
            this.search_select.Name = "search_select";
            this.search_select.Size = new System.Drawing.Size(248, 21);
            this.search_select.TabIndex = 3;
            this.search_select.SelectedIndexChanged += new System.EventHandler(this.search_select_SelectedIndexChanged);
            // 
            // prog_comment
            // 
            this.prog_comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prog_comment.Location = new System.Drawing.Point(278, 138);
            this.prog_comment.Name = "prog_comment";
            this.prog_comment.Size = new System.Drawing.Size(260, 294);
            this.prog_comment.TabIndex = 4;
            this.prog_comment.Text = "Program comment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "username";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prog_comment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.newtask_bt);
            this.Controls.Add(this.tasklist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ToDo List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tasklist;
        private System.Windows.Forms.Button newtask_bt;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button search_bt;
        private System.Windows.Forms.ComboBox search_select;
        private System.Windows.Forms.Label prog_comment;
        private System.Windows.Forms.DateTimePicker datesearch_picker;
        private System.Windows.Forms.Label label1;
    }
}

