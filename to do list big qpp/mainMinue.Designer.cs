namespace to_do_list_big_qpp
{
    partial class mainMinue
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.create = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.delate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Indigo;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.LightPink;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(100, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 319);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.LightPink;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.create.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.DarkMagenta;
            this.create.Location = new System.Drawing.Point(554, 8);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(101, 31);
            this.create.TabIndex = 1;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.LightPink;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.open.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open.ForeColor = System.Drawing.Color.DarkMagenta;
            this.open.Location = new System.Drawing.Point(554, 41);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(101, 31);
            this.open.TabIndex = 2;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // delate
            // 
            this.delate.BackColor = System.Drawing.Color.LightPink;
            this.delate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delate.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delate.ForeColor = System.Drawing.Color.DarkMagenta;
            this.delate.Location = new System.Drawing.Point(554, 74);
            this.delate.Name = "delate";
            this.delate.Size = new System.Drawing.Size(101, 31);
            this.delate.TabIndex = 3;
            this.delate.Text = "Delate";
            this.delate.UseVisualStyleBackColor = false;
            this.delate.Click += new System.EventHandler(this.delate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Project :";
            // 
            // mainMinue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(667, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delate);
            this.Controls.Add(this.open);
            this.Controls.Add(this.create);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightPink;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(683, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(683, 430);
            this.Name = "mainMinue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainMinue";
            this.Load += new System.EventHandler(this.mainMinue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button delate;
        private System.Windows.Forms.Label label1;
    }
}