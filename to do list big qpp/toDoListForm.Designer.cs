namespace to_do_list_big_qpp
{
    partial class toDoListForm
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
            this.add = new System.Windows.Forms.Button();
            this.rmov = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.NameTask = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LightPink;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.ForeColor = System.Drawing.Color.DarkMagenta;
            this.add.Location = new System.Drawing.Point(227, 384);
            this.add.Margin = new System.Windows.Forms.Padding(1);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(116, 25);
            this.add.TabIndex = 1;
            this.add.Text = " Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // rmov
            // 
            this.rmov.BackColor = System.Drawing.Color.LightPink;
            this.rmov.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rmov.ForeColor = System.Drawing.Color.DarkMagenta;
            this.rmov.Location = new System.Drawing.Point(227, 355);
            this.rmov.Margin = new System.Windows.Forms.Padding(1);
            this.rmov.Name = "rmov";
            this.rmov.Size = new System.Drawing.Size(116, 27);
            this.rmov.TabIndex = 2;
            this.rmov.Text = "Remov";
            this.rmov.UseVisualStyleBackColor = false;
            this.rmov.Click += new System.EventHandler(this.rmov_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LightPink;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.ForeColor = System.Drawing.Color.DarkMagenta;
            this.save.Location = new System.Drawing.Point(227, 325);
            this.save.Margin = new System.Windows.Forms.Padding(1);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(116, 28);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // NameTask
            // 
            this.NameTask.BackColor = System.Drawing.Color.LightPink;
            this.NameTask.ForeColor = System.Drawing.Color.DarkMagenta;
            this.NameTask.Location = new System.Drawing.Point(227, 287);
            this.NameTask.Margin = new System.Windows.Forms.Padding(2);
            this.NameTask.Name = "NameTask";
            this.NameTask.Size = new System.Drawing.Size(116, 22);
            this.NameTask.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.LightPink;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 14);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(197, 391);
            this.checkedListBox1.TabIndex = 6;
            // 
            // toDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(354, 417);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.NameTask);
            this.Controls.Add(this.save);
            this.Controls.Add(this.rmov);
            this.Controls.Add(this.add);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightPink;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 456);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 456);
            this.Name = "toDoListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "toDoListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.toDoListForm_FormClosing);
            this.Load += new System.EventHandler(this.toDoListForm_Load);
            this.Shown += new System.EventHandler(this.toDoListForm_Shown);
            this.Leave += new System.EventHandler(this.toDoListForm_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button rmov;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox NameTask;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}